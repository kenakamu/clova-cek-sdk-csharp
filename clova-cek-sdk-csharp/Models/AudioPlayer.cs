using Newtonsoft.Json;
using System.IO;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// クライアントが現在再生しているか、最後に再生したメディアの情報を持っているオブジェクト
    /// </summary>
    public class AudioPlayer
    {
        /// <summary>
        /// 最近再生したメディアの最後の再生ポイント(offset)。単位はミリ秒であり、playerActivityの値が"IDLE"の場合、このフィールドは空の場合があります。
        /// </summary>
        [JsonProperty("offsetInMilliseconds")]
        public int OffsetInMilliseconds { get; set; }
        /// <summary>
        /// プレイヤーの状態を示す値です。
        /// </summary>
        [JsonProperty("playerActivity")]
        public PlayerActivity PlayerActivity { get; set; }
        /// <summary>
        /// 再生中のオーディオの詳細情報を保存したオブジェクトplayerActivityの値が"IDLE"の場合、このフィールドが空であることがあります。
        /// </summary>
        [JsonProperty("stream")]
        public Stream Stream { get; set; }
        /// <summary>
        /// 最近再生したオーディオの全体の長さ。単位はミリ秒で、playerActivityの値が"IDLE"の場合、このフィールドが空であることがあります。
        /// </summary>
        [JsonProperty("totalInMilliseconds")]
        public int TotalInMilliseconds { get; set; }
    }
}
