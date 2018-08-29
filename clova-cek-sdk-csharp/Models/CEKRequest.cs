using Newtonsoft.Json;
using System.Collections.Generic;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// CEK Request Message
    /// https://clova-developers.line.me/guide/#/CEK/References/CEK_API.md#CustomExtRequestMessage
    /// </summary>
    public class CEKRequest
    {
        /// <summary>
        /// メッセージフォーマットのバージョン(CEKのバージョン)
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }
        /// <summary>
        /// クライアントのコンテキスト情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("context")]
        public Context Context { get; set; }
        /// <summary>
        /// 解析されたユーザーの発話情報を持っているオブジェクト。リクエストタイプによって、構成されるフィールドが異なります。
        /// </summary>
        [JsonProperty("request")]
        public Request Request { get; set; }
        /// <summary>
        /// セッション情報を持っているオブジェクト。ここでいうセッションとは、ユーザーのリクエストを区分する単位です。
        /// </summary>
        [JsonProperty("session")]
        public Session Session { get; set; }

        /// <summary>
        /// セッション情報から特定の値を取得する
        /// </summary>
        /// <param name="key">セッション情報のキー</param>
        /// <param name="defaultValue">セッション情報の既定値</param>
        /// <returns>セッション情報の値</returns>
        public object GetSessionAttribute(string key, object defaultValue = null)
        {
            if (Session.SessionAttributes.ContainsKey(key))
                return Session.SessionAttributes[key];
            else
                return defaultValue;
        }

        /// <summary>
        /// セッション情報をタイプセーフに取得する。
        /// </summary>
        /// <typeparam name="T">セッション情報を格納する型</typeparam>
        /// <returns>セッション情報</returns>
        public T GetSessionAttributeAs<T>()
            where T : class
        {
            if (Session == null || Session.SessionAttributes == null)
            {
                return null;
            }

            return JsonConvert.DeserializeObject<T>(JsonConvert.SerializeObject(Session.SessionAttributes));
        }

        /// <summary>
        /// セッション情報をタイプセーフな型で設定する。
        /// </summary>
        /// <typeparam name="T">セッション情報の型</typeparam>
        /// <param name="sessionValue">セッション情報</param>
        public void SetSessionAttributeFrom<T>(T sessionValue)
            where T : class
        {
            if (Session == null)
            {
                Session = new Session();
            }

            if (sessionValue == null)
            {
                Session.SessionAttributes = null;
            }
            else
            {
                Session.SessionAttributes = JsonConvert.DeserializeObject<Dictionary<string, object>>(JsonConvert.SerializeObject(sessionValue));
            }
        }
    }
}
