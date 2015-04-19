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

using ASWERPModels;
using ASWERPModels.Extensions;
using ASWERPModels.ViewModels;

namespace ASWERP.Models
{
    public class Loader
    {
        public static string appPath = Path.GetDirectoryName(Application.ExecutablePath);
        public static string dbPath = Path.Combine(appPath, "Database");
        public static string documentsPath = Path.Combine(appPath, "Documents");
        public static string templatePath = Path.Combine(appPath, "Templates");
        public static string dbFilePath = Path.Combine(dbPath, "db.json");
        public static string usersFilePath = Path.Combine(dbPath, "users.json");
        public static string emPath = Path.Combine(appPath, "Database", "em");
        public static string assetsPath = Path.Combine(dbPath, "assets.json");

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

        public static DataTable ReadAssets()
        {
            try
            {
                var json = File.ReadAllText(assetsPath);

                return JsonConvert.DeserializeObject<List<AssetSpecifierVM>>(json).ToDataTable<AssetSpecifierVM>();
            } catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static string GetUserName(int _id)
        {
            try
            {
                var json = File.ReadAllText(usersFilePath);

                var _item = JsonConvert.DeserializeObject<List<MicroUserVM>>(json).FirstOrDefault(x => x.Id == _id);
                if (_item != null)
                    return !String.IsNullOrEmpty(_item.EmployeeName) ? _item.EmployeeName.Trim() : null;
                else
                    return null;
            }
            catch (Exception ex)
            {
                return null;
            }
        }

        public static List<MicroUserVM> UsersSelectList()
        {
            try
            {
                var json = File.ReadAllText(usersFilePath);

                return JsonConvert.DeserializeObject<List<MicroUserVM>>(json).OrderBy(x => x.EmployeeName).ToList();
            }
            catch (Exception ex)
            {
                return new List<MicroUserVM>();
            }
        }

        public static DataTable ReadUsers()
        {
            try
            {
                var json = File.ReadAllText(usersFilePath);

                return JsonConvert.DeserializeObject<List<UserVM>>(json).ToDataTable<UserVM>();
            } catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static DataTable ReadUsersWithSearch(string key)
        {
            try
            {
                var _data = new List<UserVM>();
                if (!String.IsNullOrEmpty(key))
                {
                    var json = File.ReadAllText(usersFilePath);

                    var _list = JsonConvert.DeserializeObject<List<UserVM>>(json);

                    foreach (var _item in _list)
                    {
                        if (_item.Id.ToString() == key.Trim())
                            _data.Add(_item);
                        if (!String.IsNullOrEmpty(_item.EmployeeName))
                            if (_item.EmployeeName.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);
                        if (!String.IsNullOrEmpty(_item.Email))
                            if (_item.Email.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);
                        if (!String.IsNullOrEmpty(_item.Office))
                            if (_item.Office.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);
                        if (!String.IsNullOrEmpty(_item.Department))
                            if (_item.Department.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);

                    }

                    return _data.ToDataTable<UserVM>();
                }
                else
                    return _data.ToDataTable<UserVM>();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
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
                var _data = new List<AssetVM>();
                if (!String.IsNullOrEmpty(key))
                {
                    var json = File.ReadAllText(dbFilePath);

                    var _list = JsonConvert.DeserializeObject<List<AssetVM>>(json);

                    foreach (var _item in _list)
                    {
                        if (_item.AccessId.ToString() == key.Trim())
                            _data.Add(_item);
                        /*if (!String.IsNullOrEmpty(_item.EmployeeName))
                            if (_item.EmployeeName.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);*/
                        if (!String.IsNullOrEmpty(_item.EmailAddress))
                            if (_item.EmailAddress.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);
                        if (!String.IsNullOrEmpty(_item.ComputerName))
                            if (_item.ComputerName.Trim().ToLower().Contains(key.ToLower()))
                                _data.Add(_item);

                    }

                    return _data.ToDataTable<AssetVM>();
                }
                else
                    return _data.ToDataTable<AssetVM>();
            }
            catch (Exception ex)
            {
                return new DataTable();
            }
        }

        public static AssetsHandoverVM ReadAssetHandover(int id)
        {
            try
            {
                var json = File.ReadAllText(Path.Combine(emPath, String.Format("{0}.json", id.ToString().Trim())));

                return JsonConvert.DeserializeObject<AssetsHandoverVM>(json);
            } catch (Exception ex)
            {
                return new AssetsHandoverVM();
            }
        }

        
    }
}
