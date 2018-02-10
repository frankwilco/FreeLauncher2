﻿using Newtonsoft.Json;

namespace dotMCLauncher.Core
{
    public class DownloadEntry
    {
        [JsonProperty("path")]
        public string Path { get; set; }

        [JsonProperty("url")]
        public string Url { get; set; }

        [JsonIgnore]
        public bool IsNative { get; set; }
    }
}
