using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// ディレクティブのヘッダー
    /// </summary>
    public class DirectiveHeader
    {
        /// <summary>
        /// メッセージID(UUID)。メッセージを区別するための識別子です。
        /// </summary>
        [JsonProperty("messageId")]
        public string MessageId { get; set; }
        /// <summary>
        /// ディレクティブのAPI名
        /// </summary>
        [JsonProperty("name")]
        public DirectiveHeaderName Name { get; set; }
        /// <summary>
        /// ディレクティブのAPI名前空間
        /// </summary>
        [JsonProperty("namespace")]
        public DirectiveHeaderNamespace Namespace { get; set; }       
    }
}
