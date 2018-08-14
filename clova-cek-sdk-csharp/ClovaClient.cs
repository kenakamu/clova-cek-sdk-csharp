using ClovaCEKCsharp.Models;
using Newtonsoft.Json;
using System;
using System.IO;
using System.Net.Http;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace ClovaCEKCsharp
{
    /// <summary>
    /// Client to handle followings
    /// - verify incoming request
    /// - convert request from Clova and return CEK Response
    /// </summary>
    public class ClovaClient
    {
        static private HttpClient _httpClient;
        static private string cert;
        private HttpClient httpClient
        {
            get
            {
                if (_httpClient == null)
                    _httpClient = new HttpClient();

                return _httpClient;
            }
        }
        public ClovaClient()
        {
        }

        /// <summary>
        /// Verify the signature
        /// https://clova-developers.line.me/guide/#/CEK/References/CEK_API.md#RequestMessageValidation
        /// </summary>
        /// <param name="signatureCEK">Signature Header value</param>
        /// <param name="body">Content Body (byte array)</param>
        /// <returns></returns>
        private async Task<bool> VerifySignature(string signatureCEK, byte[] body)
        {
            if (string.IsNullOrEmpty(signatureCEK))
                throw new Exception("Signature missing");

            if (string.IsNullOrEmpty(cert))
                cert = await httpClient.GetStringAsync("https://clova-cek-requests.line.me/.well-known/signature-public-key.pem");
            
            RSACryptoServiceProvider provider = PemKeyUtils.GetRSAProviderFromPemString(cert.Trim());
            if (!provider.VerifyData(body, Convert.FromBase64String(signatureCEK), HashAlgorithmName.SHA256, RSASignaturePadding.Pkcs1))
                throw new Exception("Invalid Signature");
            else
                return true;
        }

        private byte[] ConvertStreamToByteArray(Stream stream)
        {
            using (MemoryStream ms = new MemoryStream())
            {
                byte[] buffer = new byte[16 * 1024];
                int read;
                while ((read = stream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ms.Write(buffer, 0, read);
                }
                return ms.ToArray();
            }
        }

        /// <summary>
        /// Get CEK Request from HttpRequest Body (Stream)
        /// </summary>
        /// <param name="signatureCEK">Signature Header value</param>
        /// <param name="body">Content Body (Stream)</param>
        /// <returns>CEK Response</returns>
        public async Task<CEKRequest> GetRequest(string signatureCEK, Stream body)
        {
            byte[] bodyContent = ConvertStreamToByteArray(body);
            await VerifySignature(signatureCEK, bodyContent);
            return JsonConvert.DeserializeObject<CEKRequest>(Encoding.UTF8.GetString(bodyContent));
        }
    }
}
