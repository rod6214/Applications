using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Util.Enums;

namespace Util.Configuration
{
    public static class ConfigurationManager
    {
        #region JsonSerializer
        public static void ObjectSerializer(object model, ConfigurationRoot root, object locker)
        {
            lock (locker)
            {
                switch (root)
                {
                    case ConfigurationRoot.DEFAULTROOT:
                        WriteDataDefault(model);
                        break;
                }
            }
        }

        public static object ObjectDeserializer(Type type, ConfigurationRoot root, object locker)
        {
            lock (locker)
            {
                switch (root)
                {
                    case ConfigurationRoot.DEFAULTROOT:
                        return ReadDataDefault(type);
                    default:
                        return null;
                }
            }
        }

        private static void WriteDataDefault(object model)
        {
            string rootDir = Path.Combine(Directory.GetCurrentDirectory(), "configuration");
            if (!Directory.Exists(rootDir))
                Directory.CreateDirectory(rootDir);
            string filePath = Path.Combine(rootDir, "mainconfig.json");
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(filePath, json);
        }

        private static object ReadDataDefault(Type type)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "configuration", "mainconfig.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject(json, type);
            }
            else
                return null;
        }
        #endregion
    }
}
