using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// ディスプレイ装置の向き。context.System.device.display.sizeの値が"none"の場合、このフィールドは省略されます。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
    public enum Orientation
    {
        /// <summary>
        /// 横方向
        /// </summary>
        Landscape,
        /// <summary>
        /// 縦方向
        /// </summary>
        Portait
    }
}
