using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClovaCEKCsharp.Models
{
    /// <summary>
    /// 音声に合成する情報を含んでいるオブジェクト。合成された音声はCICを介してクライアントに渡されます。
    /// </summary>
    [JsonConverter(typeof(OutputSpeechJsonConverter))]
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
        [JsonProperty("values")]
        public List<SpeechInfoObject> Values { get; set; }
       
        /// <summary>
        /// 画面を持たないクライアントデバイスに渡す際に使用されます。詳細音声情報を含んでいます。
        /// </summary>
        [JsonProperty("verbose")]
        public Verbose Verbose { get; set; }
    }
}
