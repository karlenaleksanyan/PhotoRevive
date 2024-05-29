using PluginManager.Abstraction;
using PluginManager.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManager.BusinessLogic
{
    public class ImageProcessor: IImageProcessor
    {
        private readonly PluginManagerService _pluginManager;

        public ImageProcessor(PluginManagerService pluginManager)
        {
            _pluginManager = pluginManager;
        }

        public void ProcessImage(Image image, List<string> pluginNames)
        {
            foreach (var pluginName in pluginNames)
            {
                var plugin = _pluginManager.GetPlugin(pluginName);
                plugin?.Apply(image);
            }
        }
    }
}
