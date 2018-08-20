using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// 解析されたユーザーの発話情報を持っているオブジェクト。リクエストタイプによって、構成されるフィールドが異なります。
    /// </summary>
    public class Request
    {
        /// <summary>
        /// リクエストメッセージは、次の4つのタイプがあります。リクエストのタイプによって、リクエストメッセージのrequestオブジェクトのフィールドの構成が異なります。
        /// </summary>
        [JsonProperty("type")]
        public RequestType Type { get; set; }
        /// <summary>
        /// ユーザーのリクエストを解析した情報が保存されたオブジェクトインテント
        /// </summary>
        [JsonProperty("intent")]
        public Intent Intent { get; set; }
        /// <summary>
        /// クライアントがClovaに渡した情報が保存されているオブジェクト
        /// </summary>
        [JsonProperty("event")]
        public Event Event { get; set; }
        /// <summary>
        /// クライアントがClovaに情報を渡した日時(タイムスタンプ、ISO 8601)
        /// CEKはEventRequestタイプのリクエストの順序を保証しません。クライアントからのリクエストの順序は、このフィールドの値から把握することができます。
        /// </summary>
        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
        /// <summary>
        /// クライアントがClovaに情報を渡すときに作成されたダイアログID(event.header.dialogRequestId)
        /// </summary>
        [JsonProperty("requestId")]
        public string RequestId { get; set; }
    } 
}
