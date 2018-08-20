using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace ClovaCEKCSharp.Models
{
    /// <summary>
    /// ディレクティブのAPI名
    /// </summary>
    [JsonConverter(typeof(StringEnumConverter))]
    public enum DirectiveHeaderName
    {
        Play,
        PlayFinished,
        PlayPaused,
        PlayResumed,
        PlayStarted,
        PlayStopped,
        ProgressReportDelayPassed,
        ProgressReportIntervalPassed,
        ProgressReportPositionPassed,
        StreamDeliver,
        StreamRequested,
        Pause,
        Resume,
        Stop
    }
}
