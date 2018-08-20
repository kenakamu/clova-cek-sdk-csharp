using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// プレイヤーの状態を示す値です。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum PlayerActivity
    {
        /// <summary>
        /// 非アクティブ状態
        /// </summary>
        IDLE,
        /// <summary>
        /// 再生中
        /// </summary>
        PLAYING,
        /// <summary>
        /// 一時停止状態
        /// </summary>
        PAUSED,
        /// <summary>
        /// 中止状態
        /// </summary>
        STOPPED
    }
}
