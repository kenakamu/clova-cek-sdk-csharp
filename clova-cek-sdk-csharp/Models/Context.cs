using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// クライアントのコンテキスト情報を持っているオブジェクト
    /// </summary>
    public class Context
    {
        /// <summary>
        /// クライアントが現在再生しているか、最後に再生したメディアの情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("audioPlayer")]
        public AudioPlayer AudioPlayer { get; set; }
        /// <summary>
        /// クライアントシステムのコンテキスト情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("system")]
        public System System { get; set; }
    }
}
