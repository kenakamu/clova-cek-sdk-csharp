using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// リクエストメッセージは、次の4つのタイプがあります。リクエストのタイプによって、リクエストメッセージのrequestオブジェクトのフィールドの構成が異なります。
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum RequestType
    {
        /// <summary>
        /// EventRequestタイプは、クライアントの状態の変化や、それに伴うリクエストをExtensionに渡すために使用されるリクエストタイプです。CEKは、EventRequestのリクエストタイプを使用して、ユーザーが特定のスキルを有効または無効にした結果を渡したり、クライアントのオーディオ再生状態をExtensionにレポートすることができます。Extensionの開発者は、スキルの有効化/無効化、オーディオ再生状態のレポートまたは付加情報のリクエストに適切な作業を処理する必要があります
        /// </summary>
        EventRequest,
        /// <summary>
        /// LaunchRequestは、ユーザーが特定のExtensionの使用を開始したことを示すリクエストタイプです。例えば、ユーザーが「サイコロ遊びを起動して」と言ったときのように、特定のスキルを使用すると宣言した状況です。ユーザーがスキルの使用をやめると宣言するまで、そのExtensionからIntentRequestタイプのメッセージを受信します。
        /// </summary>
        LaunchRequest,
        /// <summary>
        /// IntentRequestは、解析されたユーザーのリクエストを渡し、その内容を処理するように要求するリクエストタイプです。Extensionの開発者はサービスを開発する際、ユーザーのリクエストをどう受け付けるかについて対話モデルを定義する必要があります。対話モデルは、Clova Developer Centerで登録できます。その際、区別されるユーザーのリクエストをインテントという情報形式で定義します。解析されたユーザーの発話情報はインテントに変換され、intentフィールドでExtensionに渡されます。
        /// </summary>
        IntentRequest,
        /// <summary>
        /// SessionEndedRequestタイプは、ユーザーの特定のスキルの使用が終了したことを示すリクエストです。次の状況でこのメッセージを受信します。
        /// ユーザーがスキルの終了をリクエストした場合
        /// 特定の時間内にユーザーからの入力がない場合(Timeout)
        /// エラーが発生した場合
        /// </summary>
        SessionEndedRequest
    }
}
