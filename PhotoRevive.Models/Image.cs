using System.Collections.Generic;

namespace PhotoRevive.Models
{
    // Define a class to represent an image
    public class Image:ImageModel
    {
        public List<ImageEffect> Effects { get; }

        public Image(string name, byte[] data)
        {
            Name = name;
            Data = data;
            Effects = new List<ImageEffect>();
        }
    }
}
