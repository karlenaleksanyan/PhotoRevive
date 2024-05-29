using PluginManager.Abstraction;
using PluginManager.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManager.BusinessLogic
{
    public class ResizePlugin : IImagePluginService
    {
        public string Name => "Resize";

        private int _newWidth;

        public ResizePlugin(int newWidth)
        {
            _newWidth = newWidth;
        }

        public void Apply(Image image)
        {
            // Dummy implementation
            Console.WriteLine($"Resizing image to width {_newWidth}");
        }
    }
}
