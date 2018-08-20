using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// 音声を合成する際に使用する言語のコード。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), new object[] { true })]  
    public enum Lang
    {
        /// <summary>
        /// 英語
        /// </summary>
        En,
        /// <summary>
        /// 日本語
        /// </summary>
        Ja,
        /// <summary>
        /// 韓国語
        /// </summary>
        Ko
    }
}
