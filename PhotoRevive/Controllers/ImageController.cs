using PhotoRevive.Abstraction;
using PhotoRevive.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace PhotoRevive.Controllers
{
    public class ImageController : ApiController
    {
        private IImageService imageService;

        public ImageController(IImageService imageProcessor)
        {
            this.imageService = imageProcessor;
        }

        #region Get requests
        [HttpGet]
        public List<string> ListImages()
        {
            return imageService.ListImages();
        }

        [HttpGet]
        public List<string> ListEffects()
        {
            return imageService.ListEffects();
        }

        [HttpGet]
        public void GetImageByName(string name)
        {
            imageService.GetImageByName(name);
        }
        #endregion Get requests 

        #region Post requests
        [HttpPost]
        public void AddImage(ImageModel model)
        {
            imageService.AddImage(model.Name, model.Data);
        }

        [HttpPost]
        public void AddEffect(string effectName)
        {
            ImageEffect effect = new ImageEffect(effectName);
            imageService.AddEffect(effect);
        }

        [HttpPost]
        public void ApplyEffect(EffectModel effectModel)
        {
            ImageEffect effect = new ImageEffect(effectModel.EffectName);
            imageService.ApplyEffect(effectModel.ImageName, effect);
        }
        #endregion Post requests
    }
}