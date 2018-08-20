using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// クライアントデバイスのディスプレイ情報を持っているオブジェクト
    /// </summary>
    public class Display
    {
        /// <summary>
        /// ディスプレイでコンテンツが表示される領域の解像度情報を持つオブジェクト。context.System.device.display.sizeの値が"none"の場合、このフィールドは省略されます。
        /// </summary>
        [JsonProperty("contentLayer")]
        public ContentLayer ContentLayer { get; set; }
        /// <summary>
        /// ディスプレイ装置のDPI。context.System.device.display.sizeの値が"none"の場合、このフィールドは省略されます。
        /// </summary>
        [JsonProperty("dpi")]
        public int Dpi { get; set; }
        /// <summary>
        /// ディスプレイ装置の向き。context.System.device.display.sizeの値が"none"の場合、このフィールドは省略されます。
        /// </summary>
        [JsonProperty("orientation")]
        public Orientation Orientation { get; set; }
        /// <summary>
        /// ディスプレイ装置の解像度を示す値。あらかじめ指定された値または任意の解像度のサイズを表す値("custom")が入力されています。しかし、ディスプレイ装置がないことを表す値("none")が入力されていることもあります。
        /// </summary>
        [JsonProperty("size")]
        public Size Size { get; set; }
    }
}
