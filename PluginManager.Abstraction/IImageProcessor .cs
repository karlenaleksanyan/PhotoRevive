using PluginManager.PluginManager;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManager.Abstraction
{
    public interface IImageProcessor
    {
        void ProcessImage(Image image, List<string> pluginNames);
    }
}
