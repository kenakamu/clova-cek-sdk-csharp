using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// ディスプレイでコンテンツが表示される領域の解像度情報を持つオブジェクト。context.System.device.display.sizeの値が"none"の場合、このフィールドは省略されます。
    /// </summary>
    public class ContentLayer
    {
        /// <summary>
        /// ディスプレイでコンテンツが表示される領域の幅。ピクセル(px)単位です。
        /// </summary>
        [JsonProperty("width")]
        public int Width { get; set; }
        /// <summary>
        /// ディスプレイでコンテンツが表示される領域の高さ。ピクセル(px)単位です。
        /// </summary>
        [JsonProperty("height")]
        public int Height { get; set; }
    }
}
