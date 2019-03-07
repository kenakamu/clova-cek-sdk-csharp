using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// クライアントに特定のオーディオストリームを再生したり、再生キューに追加するように指示します。
    /// </summary>
    public class AudioPlayPayload
    {
        /// <summary>
        /// 再生するオーディオストリームのメタ情報と再生に必要なオーディオストリームの情報を含んでいるオブジェクト
        /// </summary>
        [JsonProperty("audioItem")]
        public AudioItem AudioItem { get; set; }
        /// <summary>
        /// ディレクティブに含まれたオーディオストリームを、クライアントでいつ再生するかを指定するフィールド
        /// "REPLACE_ALL"：再生キューをすべてクリアして、送信されたオーディオストリームをすぐに再生します。
        /// "ENQUEUE"：再生キューに、送信されたオーディオストリームを追加します。
        /// </summary>
        [JsonProperty("playBehavior")]
        public AudioPlayBehavior PlayBehavior { get; set; }
        /// <summary>
        /// オーディオストリーミングサービスの提供元
        /// </summary>
        [JsonProperty("source")]
        public Source Source { get; set; }
    }
}
