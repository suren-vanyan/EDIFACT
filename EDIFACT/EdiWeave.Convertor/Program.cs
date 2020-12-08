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
            var str = @"2

3

4

5

101

102

103

105

106

107

108

109

110

201

202

203

204

301

302

303

304

305

306

401

402

404

405

501

502

503

600

601

602

603

604

608

609

610

613

614

615

616

701

702

703

704

705

706

707

708

709

710

711

713

715

716

717

718

719

720

801

802

803

804

805

806

807

808

809

810

811

812

813

814

";
            var ab = str.Replace("\r\n\r\n", ",");

            BuildBookingConfirmation();

            
        }


        

        public static void BuildBookingConfirmation()
        {
            const string path = @"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\BookingConfirmation.json";

            var jModel = File.ReadAllText(path);
            JToken jtoken = JToken.Parse(jModel);

            using var writer = new EdifactWriter(@"C:\Users\suren.vanyan\source\repos\EDIFACT\EDIFACT\EdiWeave.Convertor\EdifactWriter.IFTMBC.txt", false,Encoding.UTF8,"\n");
            writer.Write(EF_EDIFACT_D99B_IFTMBC_Builder.BuildUNB());
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


            var model = JsonConvert.SerializeObject(tSIFTMBC, new JsonSerializerSettings { NullValueHandling = NullValueHandling.Ignore });
        }
    }
}
