using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using EdiWeave.Edifact.UN.D99B;
using EdiWeave.Framework.Readers;
using EdiWeave.Framework.Writers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;

namespace EdiWeave.Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var str = @"";
            var ab = str.Replace("\r\n\r\n", ",");

            //ReadBookingConfirmation();

            BuildBookingConfirmation();


        }


        

        public static void BuildBookingConfirmation()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingConfirmation.json";

            var jModel = File.ReadAllText(path);
            JToken jtoken = JToken.Parse(jModel);

            using var writer = new EdifactWriter(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\EdifactWriter.IFTMBC.txt", false,Encoding.UTF8,"\n");
            writer.Write(EF_EDIFACT_D99B_IFTMBC_Builder.BuildUNB(jtoken));
            writer.Write(EF_EDIFACT_D99B_IFTMBC_Builder.BuildIFTMBC("1",jtoken));


        }


        public static void ReadBookingConfirmation()
        {
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


            var tSIFTMBC = ediItems.OfType<TSIFTMBC>().SingleOrDefault();

            MessageErrorContext result;
            var validationResult = tSIFTMBC.IsValid(out result);

            var errorContext = JsonConvert.SerializeObject(result);

            var model = JsonConvert.SerializeObject(tSIFTMBC, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
