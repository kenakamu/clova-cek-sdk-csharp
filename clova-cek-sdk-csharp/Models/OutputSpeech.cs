using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Linq;

namespace CEK.CSharp.Models
{
    /// <summary>
    /// 音声に合成する情報を含んでいるオブジェクト。合成された音声はCICを介してクライアントに渡されます。
    /// </summary>
    public class OutputSpeech
    {
        /// <summary>
        /// 出力する要約音声情報
        /// </summary>
        [JsonProperty("brief")]
        public SpeechInfoObject Brief { get; set; }
        /// <summary>
        /// 出力する音声情報のタイプ
        /// </summary>
        [JsonProperty("type")]
        public OutputSpeechType Type { get; set; }
        /// <summary>
        /// クライアントデバイスで出力する音声情報を持っているオブジェクトまたはオブジェクト配列
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

        /// <summary>
        /// 画面を持たないクライアントデバイスに渡す際に使用されます。詳細音声情報を含んでいます。
        /// </summary>
        [JsonProperty("verbose")]
        public Verbose Verbose { get; set; }
    }
}
