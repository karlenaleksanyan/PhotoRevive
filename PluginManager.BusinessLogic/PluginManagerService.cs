using PluginManager.Abstraction;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PluginManager.BusinessLogic
{
    public class PluginManagerService : IPluginManagerService
    {
        private readonly Dictionary<string, IImagePluginService> _plugins = new Dictionary<string, IImagePluginService>();

        public void LoadPlugin(IImagePluginService plugin)
        {
            if (!_plugins.ContainsKey(plugin.Name))
            {
                _plugins.Add(plugin.Name, plugin);
            }
        }

        public void RemovePlugin(string pluginName)
        {
            if (_plugins.ContainsKey(pluginName))
            {
                _plugins.Remove(pluginName);
            }
        }

        public IImagePluginService GetPlugin(string pluginName)
        {
            if (_plugins.ContainsKey(pluginName))
            {
                return _plugins[pluginName];
            }
            return null;
        }

        public IEnumerable<IImagePluginService> GetAllPlugins()
        {
            return _plugins.Values;
        }
    }
}
