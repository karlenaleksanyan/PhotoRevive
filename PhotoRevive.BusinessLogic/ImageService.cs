using PhotoRevive.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;
using PhotoRevive.Abstraction;

namespace PhotoRevive.BusinessLogic
{
    public class ImageService : IImageService
    {
        private List<Models.Image> images = new List<Models.Image>();
        private List<ImageEffect> effects = new List<ImageEffect>();

        
        /// <summary>
        /// Add an image to the collection
        /// </summary>
        /// <param name="name">Image Name</param>
        /// <param name="data">Image bytes</param>
        public void AddImage(string name, byte[] data)
        {
            images.Add(new Models.Image(name, data));
        }

        
        /// <summary>
        /// Get a specific image by name
        /// </summary>
        /// <param name="name">Image Name</param>
        /// <returns></returns>
        public Models.Image GetImageByName(string name)
        {
            return images.Find(img => img.Name == name);
        }

        /// <summary>
        /// Add Effect
        /// </summary>
        /// <param name="effect"></param>
        public void AddEffect(ImageEffect effect)
        {
            effects.Add(effect);
        }

       
        /// <summary>
        /// Apply an effect to a specific image
        /// </summary>
        /// <param name="imageName"></param>
        /// <param name="effect"></param>
        public void ApplyEffect(string imageName, ImageEffect effect)
        {
            Models.Image image = GetImageByName(imageName);
            if (image != null)
            {
                image.Effects.Add(effect);
            }
        }

        /// <summary>
        /// Get all iamges
        /// </summary>
        /// <returns></returns>
        public List<string> ListImages()
        {
            return images.Select(image => image.Name).ToList();
        }

        /// <summary>
        /// Get all Effects
        /// </summary>
        /// <returns></returns>
        public List<string> ListEffects()
        {
            return effects.Select(effect => effect.Name).ToList();
        }
    }
}
