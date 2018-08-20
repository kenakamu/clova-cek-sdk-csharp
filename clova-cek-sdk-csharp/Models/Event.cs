using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// クライアントがClovaに渡した情報が保存されているオブジェクト
    /// </summary>
    public class Event
    {
        /// <summary>
        /// クライアントがClovaに送信したイベントの名前です。例えばスキルが有効、もしくは無効への切り替えを示すイベントの名前は、SkillEnabledやSkillDisabledになります。スキルの有効/無効の切り替えを示すリクエストを受け取った際には、リクエストメッセージのcontext.System.application.applicationIdフィールドとcontext.System.user.userIdフィールドを利用してユーザー情報を初期登録したり、利用終了したユーザーのデータを廃棄する実装をしてください。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// クライアントがClovaに送信したイベントの名前空間、または、スキルが有効か無効かを示す名前空間。スキルが有効か無効かを示す名前空間は、ClovaSkillに固定されます。
        /// </summary>
        [JsonProperty("namespace")]
        public string Namespace { get; set; }
        /// <summary>
        /// クライアントがClovaに送信したpayloadまたはpayloadの一部の情報。一部のイベント、または、スキルが有効か無効かを示すためのEventRequestリクエストは、payloadが空のオブジェクトの場合があります。
        /// </summary>
        [JsonProperty("payload")]
        public object Payload { get; set; }
    }
}
