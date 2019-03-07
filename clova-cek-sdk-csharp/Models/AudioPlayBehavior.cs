using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// ディレクティブに含まれたオーディオストリームをクライアントでいつ再生するかの指定
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum AudioPlayBehavior
    {
        /// <summary>
        /// 再生キューをすべてクリアして、送信されたオーディオストリームをすぐに再生します。
        /// </summary>
        REPLACE_ALL,
        /// <summary>
        /// 再生キューに、送信されたオーディオストリームを追加します。
        /// </summary>
        ENQUEUE
    }
}
