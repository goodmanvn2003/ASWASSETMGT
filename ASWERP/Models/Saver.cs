using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

using ASWERPModels;

namespace ASWERP.Models
{
    public class Saver
    {
        private JsonSerializer serializer = null;

        public const string TYPE_ASSETSHANDOVER = "TAH";
        public const string TYPE_ASSETS = "AST";

        public Saver()
        {
            serializer = new JsonSerializer();
        }

        public void Invoke<T>(string Type, T vm, List<T> list = null)
        {
            switch (Type)
            {
                case TYPE_ASSETS:
                    StoreAssets(list);
                    break;
                case TYPE_ASSETSHANDOVER:
                    StoreAssetsHandover(vm);
                    break;
                default:
                    break;
            }
        }

        private void StoreAssets<T>(List<T> list)
        {
            try
            {
                var _list = list as List<AssetVM>;

                var path = Path.Combine(Loader.appPath, "Database", String.Format("{0}.json", "db"));

                serializer.NullValueHandling = NullValueHandling.Ignore;
                serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                serializer.DateFormatString = "MM/dd/yyyy";

                using (StreamWriter sw = new StreamWriter(path))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, _list);
                }
            } catch (Exception ex)
            {
                var test = ex;
            }
        }

        private void StoreAssetsHandover<T>(T vm)
        {
            try
            {
                var _vm = vm as AssetsHandoverVM;

                var emPath = Path.Combine(Loader.appPath, "Database", "em");

                var emFileName = Path.Combine(emPath, String.Format("{0}.json", _vm.AccessId.ToString()));

                serializer.NullValueHandling = NullValueHandling.Ignore;
                serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
                serializer.DateFormatString = "MM/dd/yyyy";

                using (StreamWriter sw = new StreamWriter(emFileName))
                using (JsonWriter writer = new JsonTextWriter(sw))
                {
                    serializer.Serialize(writer, vm);
                }
            } catch (Exception ex)
            {
                var test = ex;
            } 
        }
    }
}
