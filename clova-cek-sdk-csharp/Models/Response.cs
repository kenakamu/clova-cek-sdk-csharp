using Newtonsoft.Json;
using System.Collections.Generic;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// Extensionのレスポンス情報を含むオブジェクト
    /// </summary>
    public class Response
    {
        /// <summary>
        /// コンテンツテンプレート形式のデータで、クライアントの画面に表示するコンテンツをこのフィールドで渡すことができます。
        /// 日本では現在、cardをサポートしておりません。
        /// </summary>
        [JsonProperty("card")]
        public object Card { get; set; }
        /// <summary>
        /// ExtensionがCEKに渡すディレクティブです。
        /// </summary>
        [JsonProperty("directives")]
        public List<Directive> Directives { get; set; }
        /// <summary>
        /// 音声に合成する情報を含んでいるオブジェクト。合成された音声はCICを介してクライアントに渡されます。
        /// </summary>
        [JsonProperty("outputSpeech")]
        public OutputSpeech OutputSpeech { get; set; }
        /// <summary>
        /// ユーザーの追加の発話を促す音声情報を含んでいるオブジェクト。response.repromptフィールドを使用すると、ユーザーにマルチターン対話を続けるか尋ねたり、または必須情報を話すように促すことができます。通常、マルチターン対話を行う際、ユーザーが追加の発話をしないと、入力待ち時間が過ぎ、マルチターン対話が自動的に終了します。
        /// response.repromptフィールドは、response.shouldEndSessionフィールド値をfalseに入力した場合、有効です。主に単文タイプの音声情報("SimpleSpeech")を渡すことをお勧めします。response.repromptフィールドを使用すると、入力待ち時間を最大1回延長できます。
        /// </summary>
        [JsonProperty("reprompt")]
        public Reprompt Reprompt { get; set; }
        /// <summary>
        /// セッション終了のフラグ。クライアントに特定のExtensionの使用が終了したことを示すフィールドです。SessionEndedRequestタイプのリクエストメッセージを受け取る前に、Extensionから先に使用終了を示す際に使用されます。
        /// true：使用を終了する
        /// false：引き続き使用する。ユーザーとマルチターン対話を行います。
        /// </summary>
        [JsonProperty("shouldEndSession")]
        public bool ShouldEndSession { get; set; }
    }
}
