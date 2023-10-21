using PhotoRevive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhotoRevive.Abstraction
{
    public interface IImageService
    {
        void AddImage(string name, byte[] data);
        Image GetImageByName(string name);
        void AddEffect(ImageEffect effect);
        void ApplyEffect(string imageName, ImageEffect effect);
        List<string> ListImages();
        List<string> ListEffects();
    }
}
