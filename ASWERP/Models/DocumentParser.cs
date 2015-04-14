using Spire;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

using ASWERPModels.Extensions;

namespace ASWERP.Models
{
    public class DocumentParser
    {
        private string oTemplatePath = null;

        public const string PLACEHOLDER_ASSETHANDOVER_EMPLOYEENAME = "{{EMPNAME}}";
        public const string PLACEHOLDER_ASSETHANDOVER_DEV = "{{DEV}}";
        public const string PLACEHOLDER_ASSETHANDOVER_ACC = "{{ACC}}";
        public const string PLACEHOLDER_ASSETHANDOVER_QA = "{{QA}}";
        public const string PLACEHOLDER_HANDEDDATE = "{{HANDEDDATE}}";
        public const string PLACEHOLDER_RECEIVEDDATE = "{{RECEIVEDDATE}}";
        public const string PLACEHOLDER_RECORDEDBY = "{{RECORDEDBY}}";
        public const string PLACEHOLDER_ACKNOWLEDGEDBY = "{{ACKNOWLEDGEDBY}}";
        public const string PLACEHOLDER_GMNAME = "{{GMNAME}}";
        public const string PLACEHOLDER_AD1 = "{{AD1}}";
        public const string PLACEHOLDER_AN1 = "{{AN1}}";
        public const string PLACEHOLDER_QT1 = "{{QT1}}";
        public const string PLACEHOLDER_LOC1 = "{{LOC1}}";
        public const string PLACEHOLDER_REM1 = "{{REM1}}";
        public const string PLACEHOLDER_AD2 = "{{AD2}}";
        public const string PLACEHOLDER_AN2 = "{{AN2}}";
        public const string PLACEHOLDER_QT2 = "{{QT2}}";
        public const string PLACEHOLDER_LOC2 = "{{LOC2}}";
        public const string PLACEHOLDER_REM2 = "{{REM2}}";
        public const string PLACEHOLDER_AD3 = "{{AD3}}";
        public const string PLACEHOLDER_AN3 = "{{AN3}}";
        public const string PLACEHOLDER_QT3 = "{{QT3}}";
        public const string PLACEHOLDER_LOC3 = "{{LOC3}}";
        public const string PLACEHOLDER_REM3 = "{{REM3}}";
        public const string PLACEHOLDER_AD4 = "{{AD4}}";
        public const string PLACEHOLDER_AN4 = "{{AN4}}";
        public const string PLACEHOLDER_QT4 = "{{QT4}}";
        public const string PLACEHOLDER_LOC4 = "{{LOC4}}";
        public const string PLACEHOLDER_REM4 = "{{REM4}}";

        public const string DOCUMENTTYPE_ASSETHANDOVER = "DTAH";

        public DocumentParser(string path)
        {
            oTemplatePath = path;
        }

        public void DoParse<T>(string type, string outputPath, T vm)
        {
            bool isNothingToDo = true;

            Document _doc = new Document();
            _doc.LoadFromFile(oTemplatePath);

            switch (type)
            {
                case DOCUMENTTYPE_ASSETHANDOVER:
                    isNothingToDo = false;

                    AssetsHandoverVM _vm = vm as AssetsHandoverVM;

                    _doc.Replace(PLACEHOLDER_ASSETHANDOVER_EMPLOYEENAME, !String.IsNullOrEmpty(_vm.Name) ? _vm.Name.Trim() : String.Empty, true, true);

                    switch (_vm.Department)
                    {
                        case "Development":
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_DEV, "[X]", true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_ACC, String.Empty, true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_QA, String.Empty, true, true);
                            break;
                        case "QA":
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_DEV, String.Empty, true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_ACC, "[X]", true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_QA, String.Empty, true, true);
                            break;
                        case "Accounting":
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_DEV, String.Empty, true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_ACC, String.Empty, true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_QA, "[X]", true, true);
                            break;
                        default:
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_DEV, "[  "+ String.Empty + "  ]", true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_ACC, "[  " + String.Empty + "  ]", true, true);
                            _doc.Replace(PLACEHOLDER_ASSETHANDOVER_QA, "[  " + String.Empty + "  ]", true, true);
                            break;
                    }

                    _doc.Replace(PLACEHOLDER_HANDEDDATE, _vm.HandoverBy.DisplayDate("{0:dd/MM/yyyy}"), true, true);
                    _doc.Replace(PLACEHOLDER_GMNAME, !String.IsNullOrEmpty(_vm.GroupManagerName) ? _vm.GroupManagerName.Trim() : String.Empty, true, true);
                    _doc.Replace(PLACEHOLDER_RECEIVEDDATE, _vm.ReceivedBy.DisplayDate("{0:dd/MM/yyyy}"), true, true);
                    _doc.Replace(PLACEHOLDER_RECORDEDBY, _vm.RecordedBy.DisplayDate("{0:dd/MM/yyyy}"), true, true);
                    _doc.Replace(PLACEHOLDER_ACKNOWLEDGEDBY, _vm.AcknowledgedBy.DisplayDate("{0:dd/MM/yyyy}"), true, true);

                    var _exportedDetails = _vm.Details.OrderBy(x => x.No);

                    try
                    {
                        _doc.Replace(PLACEHOLDER_AD1, _exportedDetails.ElementAt(0).AssetDescription ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN1, _exportedDetails.ElementAt(0).AssetName ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT1, _exportedDetails.ElementAt(0).Quantity ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC1, _exportedDetails.ElementAt(0).Location ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM1, _exportedDetails.ElementAt(0).Remarks ?? String.Empty, true, true);
                    }
                    catch (Exception ex) 
                    {
                        _doc.Replace(PLACEHOLDER_AD1, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN1, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT1, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC1, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM1, String.Empty, true, true);
                    }

                    try
                    {
                        _doc.Replace(PLACEHOLDER_AD2, _exportedDetails.ElementAt(1).AssetDescription ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN2, _exportedDetails.ElementAt(1).AssetName ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT2, _exportedDetails.ElementAt(1).Quantity ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC2, _exportedDetails.ElementAt(1).Location ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM2, _exportedDetails.ElementAt(1).Remarks ?? String.Empty, true, true);
                    }
                    catch (Exception ex) 
                    {
                        _doc.Replace(PLACEHOLDER_AD2, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN2, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT2, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC2, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM2, String.Empty, true, true);
                    }

                    try
                    {
                        _doc.Replace(PLACEHOLDER_AD3, _exportedDetails.ElementAt(2).AssetDescription ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN3, _exportedDetails.ElementAt(2).AssetName ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT3, _exportedDetails.ElementAt(2).Quantity ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC3, _exportedDetails.ElementAt(2).Location ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM3, _exportedDetails.ElementAt(2).Remarks ?? String.Empty, true, true);
                    }
                    catch (Exception ex) 
                    {
                        _doc.Replace(PLACEHOLDER_AD3, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN3, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT3, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC3, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM3, String.Empty, true, true);                    
                    }

                    try
                    {
                        _doc.Replace(PLACEHOLDER_AD4, _exportedDetails.ElementAt(3).AssetDescription ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN4, _exportedDetails.ElementAt(3).AssetName ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT4, _exportedDetails.ElementAt(3).Quantity ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC4, _exportedDetails.ElementAt(3).Location ?? String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM4, _exportedDetails.ElementAt(3).Remarks ?? String.Empty, true, true);
                    }
                    catch (Exception ex) 
                    {
                        _doc.Replace(PLACEHOLDER_AD4, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_AN4, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_QT4, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_LOC4, String.Empty, true, true);
                        _doc.Replace(PLACEHOLDER_REM4, String.Empty, true, true);
                    }
                    
                    break;
                default:
                    break;
            }
            
            if (!isNothingToDo)
                _doc.SaveToFile(outputPath);
        }
    }
}
