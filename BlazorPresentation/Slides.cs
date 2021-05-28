using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorPresentation
{
    public static partial class Slides
    {
        public static Dictionary<string, Presentation> Presentations = new Dictionary<string, Presentation>();
        public static void AddPresentation(string fileName)
        {
            Presentation presentation = JsonConvert.DeserializeObject<Presentation>(File.ReadAllText(fileName));
            Presentations.Add(presentation.FourCharCode, presentation);
        }
    }
}
