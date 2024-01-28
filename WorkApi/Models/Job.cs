using System;

namespace WorkApi.Models {
    public class Job
    {
        public int Id { get; set; }

        public string Name {get; set; } = "";

        public DateTime DateTimeOfNotification { get; set;}
    }
}