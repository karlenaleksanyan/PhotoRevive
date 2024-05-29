using System.Collections.Generic;

namespace PluginManager.Abstraction
{
    public interface IPluginManagerService
    {
        void LoadPlugin(IImagePluginService plugin);

        void RemovePlugin(string pluginName);

        IImagePluginService GetPlugin(string pluginName);

        IEnumerable<IImagePluginService> GetAllPlugins();
    }
}
