using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// ディレクティブのAPI名前空間
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectiveHeaderNamespace
    {
        AudioPlayer,
        PlaybackController
    }
}
