﻿using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

using ASWERPModels;
using ASWERPModels.ViewModels;

namespace ASWERP.Models
{
    public class Saver
    {
        private JsonSerializer serializer = null;

        public const string TYPE_ASSETSHANDOVER = "TAH";
        public const string TYPE_ASSETS = "AST";
        public const string TYPE_USERS = "USR";
        public const string TYPE_ASSETSSPECIFIER = "ASP";

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
                case TYPE_USERS:
                    StoreUsers(list);
                    break;
                case TYPE_ASSETSSPECIFIER:
                    StoreAssetsSpecifiers(list);
                    break;
                default:
                    break;
            }
        }

        private void ExecuteSaveList<T>(string path, List<T> _list) {
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            serializer.DateFormatString = "MM/dd/yyyy";

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, _list);
            }
        }

        private void ExecuteSave<T>(string path, T vm)
        {
            serializer.NullValueHandling = NullValueHandling.Ignore;
            serializer.DateFormatHandling = DateFormatHandling.IsoDateFormat;
            serializer.DateFormatString = "MM/dd/yyyy";

            using (StreamWriter sw = new StreamWriter(path))
            using (JsonWriter writer = new JsonTextWriter(sw))
            {
                serializer.Serialize(writer, vm);
            }
        }

        private void StoreAssetsSpecifiers<T>(List<T> list)
        {
            try
            {
                var _list = list as List<AssetSpecifierVM>;

                ExecuteSaveList<AssetSpecifierVM>(Path.Combine(Loader.assetsPath), _list);
            } catch (Exception ex)
            {
                var test = ex;
            }
        }

        private void StoreUsers<T>(List<T> list)
        {
            try
            {
                var _list = list as List<UserVM>;

                ExecuteSaveList<UserVM>(Path.Combine(Loader.usersFilePath), _list);
            }
            catch (Exception ex)
            {
                var test = ex;
            }
        }

        private void StoreAssets<T>(List<T> list)
        {
            try
            {
                var _list = list as List<AssetVM>;

                ExecuteSaveList<AssetVM>(Path.Combine(Loader.dbFilePath), _list);
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

                var emPath = Path.Combine(Loader.emPath);

                var emFileName = Path.Combine(emPath, String.Format("{0}.json", _vm.AccessId.ToString()));

                ExecuteSave<AssetsHandoverVM>(emFileName, _vm);
            } catch (Exception ex)
            {
                var test = ex;
            } 
        }
    }
}
