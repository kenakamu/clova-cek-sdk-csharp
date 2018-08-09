using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClovaCEKCsharp.Models
{
    /// <summary>
    /// ユーザーのリクエストを解析した情報が保存されたオブジェクトインテント
    /// </summary>
    public class Intent
    {
        /// <summary>
        /// インテント名対話モデルに定義したインテントをこのフィールドで識別できます。
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Extensionがインテントを処理する際に要求される情報(スロット)が保存されたオブジェクト。このフィールドは、intent.nameフィールドに入力されたインテントによって構成が異なることがあります。
        /// </summary>
        [JsonProperty("slots")]
        public Dictionary<string, Slot> Slots { get; set; }       
    }
}
