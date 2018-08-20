using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// クライアントデバイスの情報を持っているオブジェクト
    /// </summary>
    public class Device
    {
        /// <summary>
        /// クライアントデバイスのID。モデル名とデバイスのシリアル番号を組み合わせた情報など、ユーザーのデバイスを識別できる情報が渡されます。
        /// </summary>
        [JsonProperty("deviceId")]
        public string DeviceId { get; set; }
        /// <summary>
        /// クライアントデバイスのディスプレイ情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("display")]
        public Display Display { get; set; }
    }
}
