using Newtonsoft.Json;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// 再生するオーディオストリームのメタデータと、再生に必要なオーディオストリームの情報を持つオブジェクト
    /// </summary>
    public class AudioItem
    {
        /// <summary>
        /// オーディオコンテンツに関連する画像(アルバムの画像)のURL
        /// </summary>
        [JsonProperty("artImageUrl")]
        public string ArtImageUrl { get; set; }
        /// <summary>
        /// オーディオストリームを区別するID。クライアントはこの値に基づいて、重複するPlayディレクティブを削除できます。
        /// </summary>
        [JsonProperty("audioItemId")]
        public string AudioItemId { get; set; }
        /// <summary>
        /// 主に、現在の再生リストのタイトルを表すテキストフィールド
        /// </summary>
        [JsonProperty("headerText")]
        public string HeaderText { get; set; }
        /// <summary>
        /// 再生に必要なオーディオストリームの情報を持つオブジェクト
        /// </summary>
        [JsonProperty("stream")]
        public AudioStreamInfoObject Stream { get; set; }
        /// <summary>
        /// 主にアーティスト名を表すテキストフィールド
        /// </summary>
        [JsonProperty("titleSubText1")]
        public string TitleSubText1 { get; set; }
        /// <summary>
        /// 主にアルバム名を表すサブテキストフィールド
        /// </summary>
        [JsonProperty("titleSubText2")]
        public string TitleSubText2 { get; set; }
        /// <summary>
        /// 現在のオーディオコンテンツのタイトルを表すテキストフィールド
        /// </summary>
        [JsonProperty("titleText")]
        public string TitleText { get; set; }
    }
}
