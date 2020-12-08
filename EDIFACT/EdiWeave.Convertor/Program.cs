using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using EdiWeave.Framework.Readers;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;

namespace EdiWeave.Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            //Edifact_INVOIC_D00A    Edifact_IFTMBC_D98B  Invoices_INVOIC
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\Edifact_IFTMBC_D98B.txt";

            var sample = File.ReadAllText(path);

            List<EdiItem> ediItems;

            var ediStream = CommonHelper.GenerateStreamFromString(sample);

            var assembley = Assembly.Load(new AssemblyName("EdiWeave.Edifact.UN.D99B"));


            // ACT Rules.Edifact   EdiFabric.Templates.Edifact
            using (var ediReader = new EdifactReader(ediStream, "EdiWeave.Edifact.UN.D99B"))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }


            var tSIFTMBC = ediItems.OfType<EdiWeave.Edifact.UN.D99B.TSIFTMBC>().SingleOrDefault();

            MessageErrorContext result;
            var validationResult = tSIFTMBC.IsValid(out result);


            var model = JsonConvert.SerializeObject(tSIFTMBC, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

        }
    }
}
