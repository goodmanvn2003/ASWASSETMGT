using Spire;
using Spire.Doc;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ASWERP.Models
{
    public class DocumentParser
    {
        private string oTemplatePath = null;
        public const string PLACEHOLDER_EMPLOYEENAME = "{{EMPNAME}}";

        public DocumentParser(string path)
        {
            oTemplatePath = path;
        }

        public void DoParse(string outputPath)
        {
            Document _doc = new Document();
            _doc.LoadFromFile(oTemplatePath);
            _doc.Replace(PLACEHOLDER_EMPLOYEENAME, "Nguyen Quoc An", true, true);
            _doc.SaveToFile(outputPath);
        }
    }
}
