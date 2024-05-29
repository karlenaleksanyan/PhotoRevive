using PluginManager.Abstraction;
using PluginManager.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManager.BusinessLogic
{
    public class BlurPlugin : IImagePluginService
    {
        public string Name => "Blur";

        private int _blurSize;

        public BlurPlugin(int blurSize)
        {
            _blurSize = blurSize;
        }

        public void Apply(Image image)
        {
            // Dummy implementation
            Console.WriteLine($"Applying blur of size {_blurSize}");
        }
    }
}
