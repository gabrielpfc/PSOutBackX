using System;
using OutBackX.Layers.Data.Config;
using Xamarin.Forms;

[assembly: Dependency(typeof(OutBackX.iOS.Layers.Data.Config.DBConfig))]
namespace OutBackX.iOS.Layers.Data.Config
{
    public class DBConfig : IDBConfig
    {
        private String _path;
        public String Path
        {
            get
            {
                if (String.IsNullOrEmpty(_path))
                {
                    _path = System.Environment.GetFolderPath(Environment.SpecialFolder.Personal);
                    _path = System.IO.Path.Combine(_path, "..", "Library");
                }
                return _path;
            }
        }
    }
}
