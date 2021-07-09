using System.Collections.Generic;
using System.Text.Json;
using System.IO;

namespace Project21040062.Function
{
    
    // Class for Saving and Retrieving Data
    // Currently, it use JSON for the system
    // It also use the class name to determine the filename
    class Data
    {
        // Save Single Object
        public static void SaveData<T>(T obj)
        {
            string fileName = typeof(T).Name + ".json";
            string jsonString = JsonSerializer.Serialize(obj);
            File.WriteAllText(fileName, jsonString);
        }

        // Load Single Object
        public static T LoadData<T>()
        {
            string fileName = typeof(T).Name + ".json";

            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                T obj = JsonSerializer.Deserialize<T>(jsonString);
                return obj;
            }
            else
            {
                return default(T);
            }

        }

        // Save List of Objects
        public static void SaveList<T>(List<T> list)
        {
            string fileName = typeof(T).Name + ".json";
            string jsonString = JsonSerializer.Serialize(list);
            File.WriteAllText(fileName, jsonString);
        }

        // Load List of Objects
        public static List<T> LoadList<T>()
        {
            string fileName = typeof(T).Name + ".json";

            if (File.Exists(fileName))
            {
                string jsonString = File.ReadAllText(fileName);
                List<T> list = JsonSerializer.Deserialize<List<T>>(jsonString);
                return list;
            }
            else
            {
                return new List<T>();
            }

        }

    }
}
