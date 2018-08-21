using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// ExtensionがCEKに渡すディレクティブです
    /// </summary>
    public class Directive
    {
        /// <summary>
        /// ディレクティブのヘッダー
        /// </summary>
        [JsonProperty("header")]
        public DirectiveHeader Header { get; set; }
        /// <summary>
        /// ディレクティブに関する情報を持つオブジェクト。ディレクティブに応じて、payloadオブジェクトの構成とフィールド値を変更できます。
        /// </summary>
        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}
