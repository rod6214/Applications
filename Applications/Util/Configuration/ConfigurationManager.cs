using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;
using Util.Enums;
using Util.ModelUtil;

namespace Util.Configuration
{
    public static class ConfigurationManager
    {
        #region JsonSerializer
        public static void ObjectSerializer(IModel model, ConfigurationRoot root, object locker)
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

        public static IModel ObjectDeserializer(Type type, ConfigurationRoot root, object locker)
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

        private static void WriteDataDefault(IModel model)
        {
            string rootDir = Path.Combine(Directory.GetCurrentDirectory(), "configuration");
            if (!Directory.Exists(rootDir))
                Directory.CreateDirectory(rootDir);
            string filePath = Path.Combine(rootDir, "mainconfig.json");
            string json = JsonConvert.SerializeObject(model);
            File.WriteAllText(filePath, json);
        }

        private static IModel ReadDataDefault(Type type)
        {
            string filePath = Path.Combine(Directory.GetCurrentDirectory(), "configuration", "mainconfig.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject(json, type) as IModel;
            }
            else
                return null;
        }
        #endregion
    }
}
