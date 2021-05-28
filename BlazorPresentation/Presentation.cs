using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace BlazorPresentation
{
    public class Presentation
    {
        public List<SlideData> Slides { get; set; } = new List<SlideData>();
        public string FourCharCode { get; set; }
        public string PresenterPassCode { get; set; }
        public string Watermark { get; set; }
        public string Title { get; set; }
        public event EventHandler SlideChanged;

        private int sharedSlide = 0;
        [JsonIgnore]
        public int SharedSlide
        {
            get => sharedSlide;
            set
            {
                if (sharedSlide != value)
                {
                    sharedSlide = value;
                    SlideChanged?.Invoke(null, new EventArgs());
                }
            }
        }
    }
}
