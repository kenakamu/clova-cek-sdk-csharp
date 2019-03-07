using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// AudioPlayer.StreamRequestedイベントに対する応答です。実際に再生できるオーディオストリームの情報を受信するために使用します。
    /// クライアントがコンテンツを再生できるように、オーディオストリームの情報にストリーミングURLが必ず含まれます。
    /// </summary>
    public class AudioStreamDeliverPayload
    {
        /// <summary>
        /// オーディオストリームの情報を区別するための値。クライアントはこの値に基づいて、重複するPlayディレクティブを削除できます。
        /// </summary>
        [JsonProperty("audioItemId")]
        public string AudioItemId { get; set; }
        /// <summary>
        /// 再生に必要なオーディオストリームの情報を持つオブジェクト
        /// </summary>
        [JsonProperty("audioStream")]
        public AudioStreamInfoObject AudioStream { get; set; }
    }
}
