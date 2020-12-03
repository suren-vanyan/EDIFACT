using EdiFabric.Core.Model.Edi;
using EdiFabric.Framework.Readers;
using EdiFabric.Templates.EdifactD96A;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace EdiFabric.Translate.EDIFACT.Net45
{
    class Program
    {
        static void Main(string[] args)
        {
            //  Demo for EDIFACT D.96A
            //  Download additional EDIFACT versions from https://support.edifabric.com/hc/en-us/categories/360001758952
            List<IEdiItem> ediItems;
            using (var reader = new EdifactReader(File.OpenRead(Directory.GetCurrentDirectory() + @"\..\..\Edi.BookingConfirmation.3627746.txt"), "EdiFabric.Templates.Edifact", new EdifactReaderSettings { ContinueOnError = true }))
                ediItems = reader.ReadToEnd().ToList();

            var purchaseOrders = ediItems.OfType<TSIFTMCS>();

            foreach (var order in purchaseOrders)
            {
                var model = JsonConvert.SerializeObject(order);
            }
        }
    }
}