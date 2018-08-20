using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
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
