using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// ディスプレイ装置の解像度を示す値。あらかじめ指定された値または任意の解像度のサイズを表す値("custom")が入力されています。しかし、ディスプレイ装置がないことを表す値("none")が入力されていることもあります。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter), new object[] { true })]
    public enum Size
    {
        /// <summary>
        /// クライアントデバイスにディスプレイ装置がない
        /// </summary>
        None,
        /// <summary>
        /// 低解像度(160px X 107px)
        /// </summary>
        S100,
        /// <summary>
        /// 中解像度(427px X 240px)
        /// </summary>
        M100,
        /// <summary>
        /// 高解像度(640px X 360px)
        /// </summary>
        L100,
        /// <summary>
        /// 超高解像度(xlarge type、899px X 506px)
        /// </summary>
        Xl100,
        /// <summary>
        /// あらかじめ定義された規格ではない解像度。
        /// </summary>
        Cusom
    }
}
