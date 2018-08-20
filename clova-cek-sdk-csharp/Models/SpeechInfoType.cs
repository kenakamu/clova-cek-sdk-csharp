using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// 再生する音声のタイプ。このフィールドの値によって、valueフィールドの値の形式が異なります。現在、次の値を持ちます。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum SpeechInfoType
    {
        /// <summary>
        /// テキスト
        /// </summary>
        PlainText,
        /// <summary>
        /// "URL"：音声および音楽を再生できるファイルのURI
        /// </summary>
        URL
    }
}
