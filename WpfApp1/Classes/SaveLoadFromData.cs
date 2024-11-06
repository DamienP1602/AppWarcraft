using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows;
using Newtonsoft.Json;

namespace WpfApp1
{
    public static class SaveLoadFromData
    {
        const string SAVE_FILE = "Data";
        const string FILE_NAME = "Logins.json";

        public static void Save(DataLogin _data)
        {
            string _path = Path.Combine(SAVE_FILE, FILE_NAME);
            if (!Exist(_path)) return;

            string _jsonContent = JsonConvert.SerializeObject(_data,Formatting.Indented);

            File.WriteAllText(_path, _jsonContent);
        }

        public static void Load(out DataLogin _data)
        {
            string _path = Path.Combine(SAVE_FILE, FILE_NAME);
            if (!Exist(_path))
            {
                _data = null;
                return;
            }

            string _jsonContent = File.ReadAllText(_path);

            _data = JsonConvert.DeserializeObject<DataLogin>(_jsonContent);
        }

        static bool Exist(string _path)
        {
            if (!File.Exists(_path))
            {
                File.WriteAllText(_path,"");
                return false;
            }
            return true;
        }
    }
}
