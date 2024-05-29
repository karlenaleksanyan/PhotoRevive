using PluginManager.Abstraction;
using PluginManager.BusinessLogic;
using PluginManager.PluginManager;
using System.Web.Http;
using PluginManager.Models;

namespace PluginManager.Controllers
{
    public class ImageController : ApiController
    {
        private readonly IPluginManagerService _pluginManager;
        private readonly IImageProcessor _imageProcessor;

        public ImageController(IPluginManagerService pluginManager, IImageProcessor imageProcessor)
        {
            _pluginManager = pluginManager;
            _pluginManager.LoadPlugin(new ResizePlugin(100));
            _pluginManager.LoadPlugin(new BlurPlugin(5));
            _imageProcessor = imageProcessor;
        }

        #region Post requests
        [HttpPost]
        [Route("api/processImage")]
        public IHttpActionResult ProcessImage([FromBody]ImageRequestModel request)
        {
            var image = new Image(request.ImageName);
            _imageProcessor.ProcessImage(image, request.PluginNames);
            return Ok("Image processed successfully");
        }
        #endregion Post requests

        #region Get requests
        #endregion Get requests 

    }
}