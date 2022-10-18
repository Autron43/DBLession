using System;
using System.Collections.Generic;

namespace DBFirst.Models
{
    public partial class ElectronicStethoscopeRecord
    {
        public int Id { get; set; }
        public string? ElectronicStethoscopeKey { get; set; }
        public int Organ { get; set; }
        public int Position { get; set; }
        public int Mode { get; set; }
        public string? AudioRecordFile { get; set; }
        public string? AudioRecordFileName { get; set; }
        public int ContentLength { get; set; }
        public DateTime UserMeasureTime { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}
