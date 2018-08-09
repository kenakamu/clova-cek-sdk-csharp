using Newtonsoft.Json;

namespace ClovaCEKCsharp.Models
{
    /// <summary>
    /// ユーザーの追加の発話を促す音声情報を含んでいるオブジェクト。response.repromptフィールドを使用すると、ユーザーにマルチターン対話を続けるか尋ねたり、または必須情報を話すように促すことができます。通常、マルチターン対話を行う際、ユーザーが追加の発話をしないと、入力待ち時間が過ぎ、マルチターン対話が自動的に終了します。
    /// response.repromptフィールドは、response.shouldEndSessionフィールド値をfalseに入力した場合、有効です。主に単文タイプの音声情報("SimpleSpeech")を渡すことをお勧めします。response.repromptフィールドを使用すると、入力待ち時間を最大1回延長できます。
    /// </summary>
    public class Reprompt
    {
        /// <summary>
        /// 音声に合成する情報を含んでいるオブジェクト。合成された音声はCICを介してクライアントに渡されます。
        /// </summary>
        [JsonProperty("outputSpeech")]
        public OutputSpeech OutputSpeech { get; set; }
    }
}
