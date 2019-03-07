using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// 再生中のオーディオの詳細情報を保存したオブジェクト
    /// </summary>
    public class AudioStreamInfoObject
    {
        /// <summary>
        /// 再生を開始するオフセット。
        /// ミリ秒単位で、この値が指定されている場合、クライアントは、そのオーディオストリームを指定されたオフセットから再生する必要があります。
        /// この値が0に設定されている場合、ストリームを最初から再生します。
        /// </summary>
        [JsonProperty("beginAtInMilliseconds")]
        public int BeginAtInMilliseconds { get; set; }
        /// <summary>
        /// 現在のストリームに関連して、任意の形式を持つメタデータ情報。
        /// 特定のカテゴリに分類されたり、定義されないストリーミング情報は、このフィールドに含まれるか、または入力される必要があります。
        /// オーディオストリーム再生のコンテキストに必要な追加の値を、サービスプロバイダーがカスタムで追加できます。
        /// </summary>
        [JsonProperty("customData")]
        public string CustomData { get; set; }
        /// <summary>
        /// オーディオストリームの再生時間。クライアントは、beginAtInMillisecondsフィールドに指定されている再生のオフセットから、このフィールドに指定されている再生時間だけ、そのオーディオストリームをシークおよび再生できます。
        /// 例えば、beginAtInMillisecondsフィールドの値が10000で、このフィールドの値が60000の場合、そのオーディオストリームの10秒から70秒までの区間を再生およびシークすることができます。ミリ秒単位です。
        /// </summary>
        [JsonProperty("durationInMilliseconds")]
        public int DurationInMilliseconds { get; set; }
        /// <summary>
        /// メディアのフォーマット（MIMEタイプ）。このフィールドを使用してHLS（HTTP Live Streaming）方式のコンテンツであることを区別することができます。次のような値を持つことができます。デフォルトは"audio/mpeg"です。
        /// "audio/mpeg"
        /// "audio/mpegurl"
        /// "audio/aac"
        /// "application/vnd.apple.mpegurl"
        /// </summary>
        [JsonProperty("format")]
        public string Format { get; set; }
        /// <summary>
        /// 再生が開始してから、再生状態をレポートするタイミングを指定するオブジェクト
        /// </summary>
        [JsonProperty("progressReport")]
        public ProgressReport ProgressReport { get; set; }
        /// <summary>
        /// オーディオストリームのトークン
        /// </summary>
        [JsonProperty("token")]
        public string Token { get; set; }
        /// <summary>
        /// オーディオストリームのURL
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }
        /// <summary>
        /// urlフィールドのオーディオストリームのURLがすぐに再生できるかを示す値。
        /// true：すぐに再生できるURL
        /// false：すぐに再生できないURL。AudioPlayer.StreamRequestedイベントでオーディオストリームの情報を追加でリクエストする必要があります。
        /// </summary>
        [JsonProperty("urlPlayable")]
        public bool UrlPlayable { get; set; }
    }
}
