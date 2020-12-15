using EdiWeave.Core.Model.Edi.Edifact;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Xml;

namespace EDIFACT.TEMPLATES.D99B
{
    public class EF_EDIFACT_D99B_IFTMBF_Builder
    {
        public static UNA BuildUNA(JToken input)
        {

            JToken carrierBookingRequest = input.SelectToken("CarrierBookingRequest");

            return new UNA()
            {
                ComponentDataElement = ' ',
                DecimalNotation = '.',
                DataElement = '+',
                ReleaseIndicator = '?',
                Reserved = ' ',
                Segment = '\''

            };
        }

        public static UNB BuildUNB(JToken input)
        {

            JToken carrierBookingRequest = input.SelectToken("CarrierBookingRequest");

            return new UNB
            {
                SYNTAXIDENTIFIER_1 = new S001
                {
                    // Syntax Identifier
                    SyntaxIdentifier_1 = "UNOC",
                    // Syntax Version Number
                    SyntaxVersionNumber_2 = "3"
                },
                INTERCHANGESENDER_2 = new S002
                {
                    // Interchange sender identification
                    InterchangeSenderIdentification_1 = "COMSUP",
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZ",
                },
                INTERCHANGERECIPIENT_3 = new S003
                {
                    // Interchange recipient identification
                    InterchangeRecipientIdentification_1 = "CARGOSMART",
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "01",
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    // Date
                    Date_1 = "201130",
                    // Time
                    Time_2 = "0935"
                },
                // Interchange control reference
                // Must be incremented with every interchange
                InterchangeControlReference_5 = "2650",
            };
        }


        /// <summary>
        /// Booking confirmation
        /// </summary>
        public static TSIFTMBF BuildIFTMBC(string controlNumber, JToken model)
        {
            var result = new TSIFTMBF();

            var carrierBookingConfirmation = model.SelectToken("CarrierBookingConfirmation");

            #region UNH

            ////Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = "176911";
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "IFTMBF";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "99B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";

            #endregion UNH

            #region BGM 

            //Beginning of a message
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "335";
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02 = new C106();
            result.BGM.DOCUMENTMESSAGEIDENTIFICATION_02.Documentmessagenumber_01 = "C2020113038";
            result.BGM.MessageFunctionCode_03 = "9";

            #endregion BGM



            #region CTA
            //Contact information            
            result.CTA = new CTA();
            //Confirmed with https://www.truugo.com/edifact/d99b/cl3139/
            result.CTA.ContactFunctionCode_01 = "IC";
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02 = new C056();
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02.Departmentoremployee_02 = "Mahmoud Nada";
            #endregion CTA


            #region COM
            //COM-COMMUNICATION CONTACT
            result.COM = new List<COM>();

            var com1 = new COM();
            com1.COMMUNICATIONCONTACT_01 = new C076();
            com1.COMMUNICATIONCONTACT_01.CommunicationNumber_01 = "mahmoud.nada@commodity.ch";
            //Electronic mail
            com1.COMMUNICATIONCONTACT_01.CommunicationChannelQualifier_02 = "EM";
            result.COM.Add(com1);
            #endregion COM



            #region DTM

            result.DTM = new List<DTM>();
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "318";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = "20201130093511";
            // TODO
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "204";
            result.DTM.Add(dtm1);

            #endregion DTM

            #region TSR

            ////Transport service requirements
            ////A segment to provide confirmation details of the required transport services.
            result.TSR = new List<TSR>();
            var tsr = new TSR();
            tsr.CONTRACTANDCARRIAGECONDITION_01 = new C536();
            tsr.CONTRACTANDCARRIAGECONDITION_01.Contractandcarriageconditioncode_01 = "30";
            result.TSR.Add(tsr);

            #endregion TSR


            #region FTX

            result.FTX = new List<FTX>();


            //FTX, Free text                        
            var ftx = new FTX();
            //AAI General information - Self explanatory.           
            ftx.Textsubjectcodequalifier_01 = "AAA";
            ftx.TEXTLITERAL_04 = new C108();
            ftx.TEXTLITERAL_04.Freetext_01 = "Origin port charges Prepaid: payable by Access World (Mozambique), Bei";
            ftx.TEXTLITERAL_04.Freetext_02 = "ra, MZ";
            result.FTX.Add(ftx);


            //FTX, Free text                        
            ftx = new FTX();
            //AAI General information - Self explanatory.           
            ftx.Textsubjectcodequalifier_01 = "AAA";
            ftx.TEXTLITERAL_04 = new C108();
            ftx.TEXTLITERAL_04.Freetext_01 = "Basic freight Collect: payable by Commodity Supplies AG (Main), 8832 W";
            ftx.TEXTLITERAL_04.Freetext_02 = "ollerau, CH";
            result.FTX.Add(ftx);


            //FTX, Free text                        
            ftx = new FTX();
            //AAI General information - Self explanatory.           
            ftx.Textsubjectcodequalifier_01 = "AAA";
            ftx.TEXTLITERAL_04 = new C108();
            ftx.TEXTLITERAL_04.Freetext_01 = "Destination port charges Collect: payable by Glencore International AG";
            ftx.TEXTLITERAL_04.Freetext_02 = ", 6341 Baar, CH";
            result.FTX.Add(ftx);


            #endregion FTX

            //#region LOCLoop Segment Group 1: LOC-DTM

            ////TODO Foreach
            //var transport = carrierBookingConfirmation.SelectToken("Transports")?.First.SelectToken("Transport")?.First;

            //result.LOCLoop = new List<Loop_LOC_IFTMBC>();

            //var lOCLoop1 = new Loop_LOC_IFTMBC();

            //// LOC, Place/location identification      
            //lOCLoop1.LOC = new LOC();

            ////TODO
            ////87 Place / port of conveyance initial arrival
            //lOCLoop1.LOC.Locationfunctioncodequalifier_01 = "87";

            //lOCLoop1.LOC.LOCATIONIDENTIFICATION_02 = new C517();

            //lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = transport.SelectToken("DestinationCode")?.ToString();

            ////181  Activity Code identifying activities.
            //lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "181";

            ////6  UN / ECE(United Nations - Economic Commission for Europe)
            //lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";

            //lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03 = new C519();

            ////Specification of the first related place/location by code.
            //lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Relatedplacelocationoneidentification_01 = "US";

            ////162  Country Identification of a country.
            //lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistidentificationcode_02 = "162";

            ////5  ISO (International Organization for Standardization)
            //lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistresponsibleagencycode_03 = "5";

            //lOCLoop1.DTM = new List<DTM>();
            //dtm1 = new DTM();
            //dtm1.DATETIMEPERIOD_01 = new C507();
            ////132  Arrival date/ time, estimated
            ////ToDO
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "132";
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = "20200825";
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";

            //lOCLoop1.DTM.Add(dtm1);
            //result.LOCLoop.Add(lOCLoop1);


            //var lOCLoop2 = new Loop_LOC_IFTMBC();
            //lOCLoop2.LOC = new LOC();
            ////TODO
            ////87 Place / port of conveyance initial arrival
            //lOCLoop2.LOC.Locationfunctioncodequalifier_01 = "125";

            //lOCLoop2.LOC.LOCATIONIDENTIFICATION_02 = new C517();

            //lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "FRLEH";

            ////181  Activity Code identifying activities.
            //lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "181";

            ////6  UN / ECE(United Nations - Economic Commission for Europe)
            //lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";

            //lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03 = new C519();

            ////Specification of the first related place/location by code.
            //lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Relatedplacelocationoneidentification_01 = "FR";

            ////162  Country Identification of a country.
            //lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistidentificationcode_02 = "162";

            ////5  ISO (International Organization for Standardization)
            //lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistresponsibleagencycode_03 = "5";

            //result.LOCLoop.Add(lOCLoop2);
            //#endregion LOCLoop


            #region RFFLoop Segment Group 2: RFF-DTM

            result.RFFLoop = new List<Loop_RFF_IFTMBF>();


            var rFFLoop = new Loop_RFF_IFTMBF();
            rFFLoop.RFF = new RFF();
            rFFLoop.RFF.REFERENCE_01 = new C506();
            rFFLoop.RFF.REFERENCE_01.Referencefunctioncodequalifier_01 = "CT";
            rFFLoop.RFF.REFERENCE_01.Referenceidentifier_02 = "GC78032";
            result.RFFLoop.Add(rFFLoop);

             rFFLoop = new Loop_RFF_IFTMBF();
            rFFLoop.RFF = new RFF();
            rFFLoop.RFF.REFERENCE_01 = new C506();
            rFFLoop.RFF.REFERENCE_01.Referencefunctioncodequalifier_01 = "PO";
            rFFLoop.RFF.REFERENCE_01.Referenceidentifier_02 = "GC33044";
            result.RFFLoop.Add(rFFLoop);

            #endregion RFFLoop Segment Group 2: RFF-DTM


            #region TDTLoop Segment Group 3: TDT-DTM-TSR-SG4-SG5

            result.TDTLoop = new List<Loop_TDT_IFTMBF>();

            var tDTLoop1 = new Loop_TDT_IFTMBF();
            tDTLoop1.TDT = new TDT();

            tDTLoop1.TDT.Transportstagecodequalifier_01 = "20";
            tDTLoop1.TDT.MODEOFTRANSPORT_03 = new C220();
            tDTLoop1.TDT.MODEOFTRANSPORT_03.Transportmodenamecode_01 = "1";

            //CARRIER
            tDTLoop1.TDT.CARRIER_05 = new C040();
            tDTLoop1.TDT.CARRIER_05.Carrieridentification_01 = "OOLU";

            tDTLoop1.TDT.CARRIER_05.Codelistresponsibleagencycode_03 = "182";


            tDTLoop1.LOCLoop = new List<Loop_LOC_IFTMBF>();


            //+++++++++++++++++++
            var lOCLoop3 = new Loop_LOC_IFTMBF();

            lOCLoop3.LOC = new LOC();
            //Place / port of loading
            lOCLoop3.LOC.Locationfunctioncodequalifier_01 = "88";
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "MZBEW";
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = "Beira";

            lOCLoop3.DTM = new List<DTM>();
            var dtm2 = new DTM();
            dtm2.DATETIMEPERIOD_01 = new C507();
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "133";
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = "20201217";
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";
            lOCLoop3.DTM.Add(dtm2);

            tDTLoop1.LOCLoop.Add(lOCLoop3);


            var lOCLoop4 = new Loop_LOC_IFTMBF();

            lOCLoop4.LOC = new LOC();
            //11- Place / port of discharge
            lOCLoop4.LOC.Locationfunctioncodequalifier_01 = "7";
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "CNWHG";
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = "Wuhan Pt";

            tDTLoop1.LOCLoop.Add(lOCLoop4);


            result.TDTLoop.Add(tDTLoop1);

            #endregion TDTLoop 


            //#region NADLoop Segment Group 6: NAD-LOC-SG7-SG8

            //result.NADLoop = new List<Loop_NAD_IFTMBC>();

            //var addresses = carrierBookingConfirmation.SelectToken("Addresses") as JArray;

            //var nADLoop1 = new Loop_NAD_IFTMBC();


            //foreach (var address in addresses)
            //{
            //    var chieldRef = address.SelectToken("Address");
            //    foreach (var item in chieldRef.Children())
            //    {
            //        nADLoop1.NAD = new NAD();
            //        nADLoop1.NAD.Partyqualifier_01 = item.SelectToken("AddressFunction")?.ToString();
            //        nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            //        nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = transport.SelectToken("CarrierCode")?.ToString();
            //        nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            //        nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "87";
            //        nADLoop1.NAD.NAMEANDADDRESS_03 = new C058();
            //        nADLoop1.NAD.NAMEANDADDRESS_03.Nameandaddressline_01 = item.SelectToken("NameLine1")?.ToString();
            //    }
            //}


            //#region SG7: CTA-COM

            //#endregion SG7: CTA-COM

            //#region SG8: TSR-RFF-LOC-TPL-FTX

            //#endregion SG8: TSR-RFF-LOC-TPL-FTX

            //result.NADLoop.Add(nADLoop1);
            //#endregion NADLoop Segment Group 6: NAD-LOC-SG7-SG8

            //#region GIDLoop Segment Group 9: GID-HAN-TMP-RNG-TMD-LOC-FTX-PCD-SG10-GDS-SG11-SG12-SG13-SG14-SG15

            //result.GIDLoop = new List<Loop_GID_IFTMBC>();
            //var gIDLoop1 = new Loop_GID_IFTMBC();

            //gIDLoop1.GID = new GID();


            //#endregion GIDLoop Segment Group 9: GID-HAN-TMP-RNG-TMD-LOC-FTX-PCD-SG10-GDS-SG11-SG12-SG13-SG14-SG15

            return result;

        }
    }
}
