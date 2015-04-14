using Mono.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ASWERPUtilities
{
    class Program
    {
        static void Main(string[] args)
        {
            string type = null;
            string sourceFile = null;

            if (args.Length == 2)
            {
                type = args[0];
                sourceFile = args[1];

                switch (type)
                {
                    case Importer.TYPE_IMPORTER_USERS_TO_ASSET:
                        Importer.UsersToAssetsToJson(sourceFile.Trim());
                        break;
                    default:
                        Console.WriteLine("Invalid operation");
                        break;
                }
            }
            else
            {
                Console.WriteLine("Invalid number of arguments");
            }
        }
    }
}
