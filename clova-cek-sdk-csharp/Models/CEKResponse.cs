using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClovaCEKCsharp.Models
{
    /// <summary>
    /// CEK esponse Message
    /// https://clova-developers.line.me/guide/#/CEK/References/CEK_API.md#CustomExtResponseMessage
    /// </summary>
    public class CEKResponse
    {
        /// <summary>
        /// Extensionのレスポンス情報を含むオブジェクト
        /// </summary>
        [JsonProperty("response")]
        public Response Response { get; set; }
        /// <summary>
        /// ユーザーとのマルチターン対話に必要な情報を保存するために使用されるオブジェクト。Custom Extensionは、sessionAttributesフィールドを使用して途中までの情報をCEKに渡します。ユーザーの追加のリクエストを受け付けると、その情報は再びリクエストメッセージのsession.sessionAttributesフィールドで渡されます。sessionAttributesオブジェクトは、キー(key)と値(value)のペアで構成され、Custom Extensionを実装する際に任意で定義できます。保存する値がない場合、空のオブジェクトを入力します。
        /// </summary>
        [JsonProperty("sessionAttributes")]
        public Dictionary<string, object> SessionAttributes { get; set; }
        /// <summary>
        /// メッセージフォーマットのバージョン(CEKのバージョン)
        /// </summary>
        [JsonProperty("version")]
        public string Version { get; set; }

        public CEKResponse()
        {
            Response = new Response()
            {
                Directives = new List<Directive>(),
                OutputSpeech = new OutputSpeech() { Type = OutputSpeechType.SimpleSpeech, Values = new List<SpeechInfoObject>() },
                ShouldEndSession = true,
                Card = new object()
            };
            Version = "1.0";
            SessionAttributes = new Dictionary<string, object>();
        }
        public void AddText(string text, Lang lang = Lang.Ja)
        {

            if (Response.OutputSpeech.Values.Count > 0)
                Response.OutputSpeech.Type = OutputSpeechType.SpeechList;

            Response.OutputSpeech.Values.Add(new SpeechInfoObject()
            {
                Type = SpeechInfoType.PlainText,
                Lang = lang,
                Value = text
            });
        }

        public void AddUrl(string url, Lang lang = Lang.Ja)
        {
            if (Response.OutputSpeech.Values.Count > 0)
                Response.OutputSpeech.Type = OutputSpeechType.SpeechList;
            Response.OutputSpeech.Values.Add(new SpeechInfoObject()
            {
                Type = SpeechInfoType.URL,
                Lang = lang,
                Value = url
            });
        }
    }
}
