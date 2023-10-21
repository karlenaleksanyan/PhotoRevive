using System;
using System.Collections.Generic;

namespace PhotoRevive.Models
{
    // Define a class to represent an effect
    public class ImageEffect
    {
        public string Name { get; set; }
        public Dictionary<string, object> Parameters { get; }

        public ImageEffect(string name)
        {
            Name = name;
            Parameters = new Dictionary<string, object>();
        }
    }
}
