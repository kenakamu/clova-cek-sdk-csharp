using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// 再生後に再生状態情報のレポートを受けるための情報を持ったオブジェクト
    /// </summary>
    public class ProgressReport
    {
        /// <summary>
        /// 再生が開始してから、指定された時間が経過した後に、再生状態をレポートするように指定する値です。ミリ秒単位で、このフィールドの値はnullの場合があります。
        /// </summary>
        [JsonProperty("progressReportDelayInMilliseconds")]
        public object ProgressReportDelayInMilliseconds { get; set; }
        /// <summary>
        /// 再生中に、指定された間隔ごとに再生状態をレポートするように指定する値です。ミリ秒単位で、このフィールドの値はnullの場合があります。
        /// </summary>
        [JsonProperty("progressReportIntervalInMilliseconds")]
        public object ProgressReportIntervalInMilliseconds { get; set; }
        /// <summary>
        /// 再生中に、指定された再生位置を経過する度に、再生状態をレポートするように指定する値です。ミリ秒単位で、このフィールドの値はnullの場合があります。
        /// </summary>
        [JsonProperty("progressReportPositionInMilliseconds")]
        public object ProgressReportPositionInMilliseconds { get; set; }
    }
}
