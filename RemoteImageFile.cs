﻿using System;

namespace GlobalCalc.Shared
{
    public class RemoteImageFile
    {
        public string Name { get; set; }
        public DateTime LastWriteTime { get; set; }

        public RemoteImageFile(string name, DateTime lastWriteTime)
        {
            Name = name;
            LastWriteTime = lastWriteTime;
        }
    }
}
