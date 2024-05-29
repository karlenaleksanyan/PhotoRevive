using PluginManager.PluginManager;

namespace PluginManager.Abstraction
{
    public interface IImagePluginService
    {
        string Name { get; }
        void Apply(Image image);
    }
}
