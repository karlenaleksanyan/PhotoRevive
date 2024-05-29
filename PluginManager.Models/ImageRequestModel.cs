using System.Collections.Generic;

namespace PluginManager.Models
{
    public class ImageRequestModel
    {
        public string ImageName { get; set; }
        public List<string> PluginNames { get; set; }
    }
}
