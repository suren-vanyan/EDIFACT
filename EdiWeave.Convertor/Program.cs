using EDIFACT.TEMPLATES.D99B;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;
using EdiWeave.Core.Model.Edi.ErrorContexts;
using EdiWeave.Framework.Readers;
using EdiWeave.Framework.Writers;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
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
            //ReadAperak();
            RmSpecChar("Fürther Straße 30", 70);
        }


        public static void BuildBookingRequest()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingRequest\BookingRequest.xml";

            var model = File.ReadAllText(path);

            using var writer = new EdifactWriter(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingRequest\EDIWriter-BookingRequest.txt", false, Encoding.UTF8, "\n");

            XmlDocument doc = new XmlDocument();
            doc.LoadXml(model);
            var jsonModel = JToken.Parse(JsonConvert.SerializeXmlNode(doc)).SelectToken("CarrierBookingRequest");

            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildUNA(jsonModel));
            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildUNB(jsonModel));
            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildIFTMBC("1", jsonModel));
            writer.Write(EF_EDIFACT_D99B_IFTMBF_Builder.BuildUNZ(jsonModel));


        }


        private static string RmSpecChar(string currentText, int maxLength)
        {
            if (string.IsNullOrWhiteSpace(currentText)) return currentText;

            currentText = currentText.Replace("\n", " ");


            currentText = Encoding.ASCII.GetString(Encoding.Convert(
            Encoding.ASCII,
            Encoding.GetEncoding(
              Encoding.ASCII.EncodingName,
              new EncoderReplacementFallback(string.Empty),
              new DecoderExceptionFallback()
              ), Encoding.ASCII.GetBytes(currentText)));

            if (maxLength > 0 && currentText.Length > maxLength)
            {
                currentText = currentText.Substring(0, maxLength);
            }
            return currentText;
        }

        public static void ReadAperak()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\APERAK\aperak.txt";

            var sample = File.ReadAllText(path);

            List<EdiItem> ediItems;

            var ediStream = CommonHelper.GenerateStreamFromString(sample);

            using (var ediReader = new EdifactReader(ediStream, "EDIFACT.TEMPLATES.D99B", Encoding.UTF8, true))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }

            var jObject = new JObject();

            var unb = ediItems.OfType<UNB>().SingleOrDefault();
            var TSAPERAK = ediItems.OfType<TSAPERAK>().SingleOrDefault();
            var unz = ediItems.OfType<UNZ>().SingleOrDefault();

            jObject.Add("UNB", JToken.FromObject(unb, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("APERAK", JToken.FromObject(TSAPERAK, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("UNZ", JToken.FromObject(unz, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));


            if (!TSAPERAK.IsValid(out MessageErrorContext error))
            {
                jObject.Add("Error", JToken.FromObject(error));
            }

            //ToDO Right Click in the File,then select Copy Full Path and paste here
            File.WriteAllText(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\APERAK\EdifactReader_APERAK.json", jObject.ToString());

            var unberrors = unb.Validate();
            var unzerrors = unb.Validate();


        }

        public static void ReadBookingConfirmation()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\BookingRequest\80795149.txt";

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
            File.WriteAllText(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\BookingRequest\EdifactReader_IFTMBC.json", jObject.ToString());

            var unberrors = unb.Validate();
            var unzerrors = unb.Validate();


            var model = JsonConvert.SerializeObject(tSIFTMBC, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }


        private static void ReadBookingRequest()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\BookingRequest\81310593.txt";

            var sample = File.ReadAllText(path);

            List<EdiItem> ediItems;

            var ediStream = CommonHelper.GenerateStreamFromString(sample);

            using (var ediReader = new EdifactReader(ediStream, "EDIFACT.TEMPLATES.D99B", Encoding.UTF8, true))
            {
                ediItems = ediReader.ReadToEnd().ToList();
            }


            var jObject = new JObject();

            var unb = ediItems.OfType<UNB>().SingleOrDefault();
            var tSiftmbf = ediItems.OfType<TSIFTMBF>().SingleOrDefault();
            var unz = ediItems.OfType<UNZ>().SingleOrDefault();

            jObject.Add("UNB", JToken.FromObject(unb, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("IFTMBF", JToken.FromObject(tSiftmbf, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));
            jObject.Add("UNZ", JToken.FromObject(unz, new JsonSerializer { NullValueHandling = NullValueHandling.Ignore }));


            if (!tSiftmbf.IsValid(out MessageErrorContext error))
            {
                jObject.Add("Error", JToken.FromObject(error));
            }

            //ToDO Right Click in the File,then select Copy Full Path and paste here
            File.WriteAllText(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EdiWeave.Convertor\BookingRequest\EdifactReader_IFTMBF.json", jObject.ToString());

            var unberrors = unb.Validate();
            var unzerrors = unb.Validate();


            var model = JsonConvert.SerializeObject(tSiftmbf, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
