using Newtonsoft.Json;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// Extensionがインテントを処理する際に要求される情報(スロット)が保存されたオブジェクト。このフィールドは、intent.nameフィールドに入力されたインテントによって構成が異なることがあります。
    /// </summary>
    public class Slot
    {
        /// <summary>
        /// Intent の名称
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
        /// <summary>
        /// Intent の値
        /// </summary>
        [JsonProperty("value")]
        public string Value { get; set; }
    }
}
