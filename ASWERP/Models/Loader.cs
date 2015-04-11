using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;
using System.Data;
using System.ComponentModel;

namespace ASWERP.Models
{
    public class Loader
    {
        public static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static string dbPath = Path.Combine(appPath, "Database");
        public static string documentsPath = Path.Combine(appPath, "Documents");
        public static string templatePath = Path.Combine(appPath, "Templates");
        public static string dbFilePath = Path.Combine(dbPath, "db.json");
        public static string emPath = Path.Combine(appPath, "Database", "em");

        public static void Initilize()
        {
            if (!Directory.Exists(dbPath))
                Directory.CreateDirectory(dbPath);
            if (!Directory.Exists(emPath))
                Directory.CreateDirectory(emPath);
            if (!File.Exists(dbFilePath))
                File.Create(dbFilePath);
            if (!Directory.Exists(templatePath))
                Directory.CreateDirectory(templatePath);
            if (!Directory.Exists(documentsPath))
                Directory.CreateDirectory(documentsPath);
        }

        public static DataTable ReadDatabase()
        {
            try
            {
                var json = File.ReadAllText(dbFilePath); 
            
                return JsonConvert.DeserializeObject<List<AssetVM>>(json).ToDataTable<AssetVM>();
            } catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static DataTable ReadDatabaseWithSearch(string key)
        {
            try
            {
                var json = File.ReadAllText(dbFilePath);

                var _list = JsonConvert.DeserializeObject<List<AssetVM>>(json);

                return _list.Where(x => x.Id.ToLower() == key.ToLower() || x.EmployeeName.ToLower().Contains(key.ToLower()) || x.EmailAddress.ToLower().Contains(key.ToLower()) || x.ComputerName.ToLower().Contains(key.ToLower())).ToList().ToDataTable<AssetVM>();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static AssetsHandoverVM ReadAssetHandover(string id)
        {
            try
            {
                var json = File.ReadAllText(Path.Combine(emPath, String.Format("{0}.json", id.Trim())));

                return JsonConvert.DeserializeObject<AssetsHandoverVM>(json);
            } catch (Exception ex)
            {
                return new AssetsHandoverVM();
            }
        }

        
    }
}
