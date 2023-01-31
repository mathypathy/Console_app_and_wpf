using _02_WPF.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_WPF.Services
{
    public class FileService

    {
        private string filePath = $@"{Environment.GetFolderPath(Environment.SpecialFolder.Desktop)}\activitys.json";
        private List<Activity_todo> activities = new List<Activity_todo>();

        public FileService()
        {
            ReadFromFile();
        }
        private void ReadFromFile()
        {
            try
            {
                using var sr = new StreamReader(filePath);
                activities = JsonConvert.DeserializeObject<List<Activity_todo>>(sr.ReadToEnd())!;
            }
            catch { activities = new List<Activity_todo>(); }
        }
        private void SaveToFile()
        {
         
            using var sw = new StreamWriter(filePath);
            sw.WriteLine(JsonConvert.SerializeObject(activities));
        }
        public void AddToList(Activity_todo actitivity)
        {
            activities.Add(actitivity);
            SaveToFile();
          
        }

        public ObservableCollection<Activity_todo> Activity()
        {
            var items = new ObservableCollection<Activity_todo>();
            foreach (var actitivity in activities)
                items.Add(actitivity);
            return items;
        }

    }
}
