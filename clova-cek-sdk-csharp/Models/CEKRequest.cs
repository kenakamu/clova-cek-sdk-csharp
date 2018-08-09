using Newtonsoft.Json;

namespace ClovaCEKCsharp.Models
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
    }
}
