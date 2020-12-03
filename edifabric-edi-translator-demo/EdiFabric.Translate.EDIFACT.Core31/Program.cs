using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using EdiFabric.Translate.EDIFACT.Core31;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.EDIFACT.Core20
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for EDIFACT D.96A
            //  Download additional EDIFACT versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\..\Edi.BookingConfirmation.3627746.txt"), "EdiFabric.Templates.Edifact", new EdifactReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            var invoices = ediItems.OfType<TSIFTMBC>().ToList();

            var model = JsonConvert.SerializeObject(invoices[0], new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });

            Carrierbookingconfirmation bookingconfirmation = new Carrierbookingconfirmation();
            
            JObject jObject = JObject.Parse(model);
            dynamic newJObject = new JObject();
            JObject newJObject1 = new JObject();

            foreach (var chield in jObject.Children())
            {
                var path = chield.Path;

                switch (path)
                {
                    case "BGM":
                        {
                            var obj = ((JProperty)chield).Value;
                            newJObject1.Add("BookingHeader", new JObject());
                            var sss = newJObject1["Bookingheader"];

                            newJObject.BookingHeader = new JObject();
                            

                            var property = new JProperty("BookingStatus", obj.SelectToken("Messagefunctioncoded_03"));
                            newJObject.BookingHeader.Add(property);
                            //newJObject.BookingHeader.Add("BookingStatus", chield.Children["Messagefunctioncoded_03"]);
                            newJObject.BookingHeader.BookingStatus = obj.SelectToken("Messagefunctioncoded_03");
                            newJObject.BookingHeader.CarrierResponseType = obj.SelectToken("Responsetypecoded_04");

                            break;
                        }
                    
                    default:
                        break;
                }

            }
            

        }
    }
}