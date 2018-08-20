using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// 画面を持たないクライアントデバイスに渡す際に使用されます。詳細音声情報を含んでいます。
    /// </summary>
    public class Verbose
    {
        /// <summary>
        /// 出力する音声情報のタイプ単文と複文タイプの音声情報のみ入力できます。
        /// </summary>
        [JsonProperty("type")]
        public OutputSpeechType Type { get; set; }
        /// <summary>
        /// クライアントデバイスで出力する詳細音声情報を持っているオブジェクトまたはオブジェクト配列
        /// </summary>
        [JsonIgnore]
        public List<SpeechInfoObject> Values { get; set; }
        [JsonProperty("values")]
        private object values
        {
            get
            {
                if (Values == null || Values.Count == 0)
                    return null;
                else if (Values.Count == 1)
                    return JObject.FromObject(Values.First());
                else
                    return JArray.FromObject(Values);
            }
        }
    }
}
