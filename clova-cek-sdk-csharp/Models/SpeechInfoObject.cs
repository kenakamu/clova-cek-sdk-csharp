using Newtonsoft.Json;

namespace ClovaCEKCsharp.Models
{
    /// <summary>
    /// SpeechInfoObjectオブジェクトはレスポンスメッセージのresponse.outputSpeechで再使用されるオブジェクトです。ユーザーに出力する音声情報の最も小さな単位である単文レベルの発話情報です。このオブジェクトは、次のフィールドを持ちます。
    /// </summary>
    public class SpeechInfoObject
    {
        /// <summary>
        /// 音声を合成する際に使用する言語のコード。
        /// </summary>
        [JsonProperty("lang")]
        public Lang? Lang { get; set; }
        /// <summary>
        /// 再生する音声のタイプ。このフィールドの値によって、valueフィールドの値の形式が異なります。現在、次の値を持ちます。
        /// </summary>
        [JsonProperty("type")]
        public SpeechInfoType Type { get; set; }
        /// <summary>
        /// 音声を合成する内容または音声ファイルのURI
        /// 音声ファイル：ファイル形式については、プラットフォームでサポートされるオーディオ圧縮形式 https://clova-developers.line.me/guide/#/Design/Design_Guideline_For_Extension.md#SupportedAudioCompressionFormat を参照してください。
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
