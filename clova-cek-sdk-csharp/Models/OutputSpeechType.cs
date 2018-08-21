using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// 出力する音声情報のタイプ
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum OutputSpeechType
    {
        /// <summary>
        /// 単文タイプの音声情報です。最も基本となるタイプで、この値を指定した場合、response.outputSpeech.valuesフィールドがSpeechInfoObjectオブジェクトを持っている必要があります。
        /// </summary>
        SimpleSpeech,
        /// <summary>
        /// 複文タイプの音声情報です。複数の文章を出力する際に使用されます。この値を指定した場合、response.outputSpeech.valuesフィールドがSpeechInfoObjectオブジェクト配列を持っている必要があります。
        /// </summary>
        SpeechList,
        /// <summary>
        /// 複合タイプの音声情報です。画面を持たないクライアントデバイスに、要約音声情報と詳細音声情報を渡す際に使用されます。この値を指定した場合、response.outputSpeech.valuesフィールドの代わりにresponse.outputSpeech.briefとresponse.outputSpeech.verboseフィールドを持つ必要があります。
        /// </summary>
        SpeechSet
    }
}
