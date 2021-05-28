using Microsoft.AspNetCore.Components;
using System.Collections.Generic;

namespace BlazorPresentation
{
    public class SlideData
    {
        public string MassiveTitle { get; set; }
        public string Title { get; set; }
        public MarkupString Body { get; set; }
        public List<string> Images { get; set; }
        public MarkupString Script { get; set; }
        
    }
}