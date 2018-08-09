using Newtonsoft.Json;
using System.Collections.Generic;

namespace ClovaCEKCsharp.Models
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
        [JsonProperty("values")]
        public List<SpeechInfoObject> Values { get; set; }
    }
}
