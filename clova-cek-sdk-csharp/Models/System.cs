using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// クライアントシステムのコンテキスト情報を持っているオブジェクト
    /// </summary>
    public class System
    {
        /// <summary>
        /// ユーザーの意図によって実行されるExtensionの情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("application")]
        public Application Application { get; set; }
        /// <summary>
        /// クライアントデバイスの情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("device")]
        public Device Device { get; set; }
        /// <summary>
        /// クライアントデバイスに認証されたのデフォルトユーザーの情報を持っているオブジェクト
        /// </summary>
        [JsonProperty("user")]
        public User User { get; set; }
    }
}
