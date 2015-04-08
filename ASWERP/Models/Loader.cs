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

        public static DataTable ReadDatabase()
        {
            try
            {
                var json = File.ReadAllText(Path.Combine(appPath, "Database", "db.json")); 
            
                return JsonConvert.DeserializeObject<List<AssetVM>>(json).ToDataTable<AssetVM>();
            } catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static AssetsHandoverVM ReadAssetHandover(string id)
        {
            try
            {
                var json = File.ReadAllText(Path.Combine(appPath, "Database", "em", String.Format("{0}.json", id.Trim())));

                return JsonConvert.DeserializeObject<AssetsHandoverVM>(json);
            } catch (Exception ex)
            {
                return new AssetsHandoverVM();
            }
        }

        
    }
}
