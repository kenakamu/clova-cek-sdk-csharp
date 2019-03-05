using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// オーディオストリーミングサービスの提供元
    /// </summary>
    public class Source
    {
        /// <summary>
        /// オーディオストリーミングサービスのロゴ画像のURL。このフィールドがなかったり、またはフィールド値が空の場合や、ロゴ画像を表示できない場合、source.nameフィールド内のオーディオストリーミングサービスの名前を表示する必要があります。
        /// </summary>
        [JsonProperty("logoUrl")]
        public string LogoUrl { get; set; }
        /// <summary>
        /// オーディオストリーミングサービスの名前
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
