using EDIFACT.TEMPLATES.D99B;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using EdiWeave.Framework.Readers;
using EdiWeave.Framework.Writers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml;

namespace EdiWeave.Convertor
{
    class Program
    {
        static void Main(string[] args)
        {
            var str ="";
            var ab = str.Replace("\r\n\r\n", ",");

            //ReadBookingConfirmation();
            BuildBookingRequest();

        }

     
        public static void BuildBookingConfirmation()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingConfirmation.json";

            var jModel = File.ReadAllText(path);
            JToken jtoken = JToken.Parse(jModel);

            using var writer = new EdifactWriter(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\EdifactWriter_IFTMBC.txt", false,Encoding.UTF8,"\n");
            writer.Write(EF_EDIFACT_D99B_IFTMBC_Builder.BuildUNB(jtoken));
            writer.Write(EF_EDIFACT_D99B_IFTMBC_Builder.BuildIFTMBC("1",jtoken));


        }


        public static void BuildBookingRequest()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingRequest\BR_COMSUP_CARGOSMART.xml";

            var model = File.ReadAllText(path);

            using var writer = new EdifactWriter(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingRequest\EdifactWriter_BR_IFTMBF.txt", false, Encoding.UTF8, "\n");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(model);
            var jsonModel = JToken.Parse(JsonConvert.SerializeXmlNode(doc));

            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildUNA(jsonModel));
            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildUNB(jsonModel));
            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildIFTMBC("1", jsonModel));


        }


        public static void ReadBookingConfirmation()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingConfirmation\Edifact_IFTMBC_D98B.txt";

            var sample = File.ReadAllText(path);

            List<EdiItem> ediItems;

            var ediStream = CommonHelper.GenerateStreamFromString(sample);

            using (var ediReader = new EdifactReader(ediStream, "EDIFACT.TEMPLATES.D99B", Encoding.UTF8,true))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }


            var jObject = new JObject();

            var unb = ediItems.OfType<UNB>().SingleOrDefault();
            var tSIFTMBC = ediItems.OfType<TSIFTMBC>().SingleOrDefault();
            var unz = ediItems.OfType<UNZ>().SingleOrDefault();

            jObject.Add("UNB", JToken.FromObject(unb, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("IFTMBC", JToken.FromObject(tSIFTMBC, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("UNZ", JToken.FromObject(unz,new JsonSerializer {NullValueHandling=NullValueHandling.Ignore }));


            if(!tSIFTMBC.IsValid(out MessageErrorContext error))
            {
                jObject.Add("Error", JToken.FromObject(error));
            }
          
            //ToDO Right Click in the File,then select Copy Full Path and paste here
            File.WriteAllText(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingConfirmation\EdifactReader_IFTMBC.json", jObject.ToString());

            var unberrors = unb.Validate();
            var unzerrors = unb.Validate();


            var model = JsonConvert.SerializeObject(tSIFTMBC, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
