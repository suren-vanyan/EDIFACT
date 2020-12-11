using EdiWeave.Core.Model.Edi.Edifact;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace EDIFACT.TEMPLATES.D99B
{
    public class EF_EDIFACT_D99B_IFTMBC_Builder
    {
        public static UNB BuildUNB(JToken model)
        {
            var carrierBookingConfirmation = model.SelectToken("CarrierBookingConfirmation");
            var messageinfos = carrierBookingConfirmation.SelectToken("Messageinfos").First;
            var res = messageinfos.SelectToken("MessageDate").ToString();

            DateTime.TryParseExact(s: res, format: "yyyyMMddHHmm", provider: CultureInfo.InvariantCulture, style: 0, out var dt);

            return new UNB
            {
                SYNTAXIDENTIFIER_1 = new S001
                {
                    // Syntax Identifier
                    SyntaxIdentifier_1 = "UNOC",
                    // Syntax Version Number
                    SyntaxVersionNumber_2 = "1"
                },
                INTERCHANGESENDER_2 = new S002
                {
                    // Interchange sender identification
                    InterchangeSenderIdentification_1 = messageinfos.SelectToken("Sender").ToString(),
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZZ",
                },
                INTERCHANGERECIPIENT_3 = new S003
                {
                    // Interchange recipient identification
                    InterchangeRecipientIdentification_1 = messageinfos.SelectToken("Receiver").ToString(),
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZZ",
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    // Date
                    Date_1 = dt.ToString("yyMMdd"),//"200807",
                    // Time
                    Time_2 = dt.ToString("HHmm")//"0849"
                },
                // Interchange control reference
                // Must be incremented with every interchange
                InterchangeControlReference_5 = "17386636",
            };
        }


        /// <summary>
        /// Booking confirmation
        /// </summary>
        public static TSIFTMBC BuildIFTMBC(string controlNumber, JToken model)
        {
            var result = new TSIFTMBC();

            var carrierBookingConfirmation = model.SelectToken("CarrierBookingConfirmation");

            #region UNH
            ////Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(1, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "IFTMBC";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "99B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";
            result.UNH.MessageIdentifier_02.AssociationAssignedCode_05 = "2.0";
            #endregion UNH

            var bookingHeader = carrierBookingConfirmation.SelectToken("BookingHeader")?.First;

            #region BGM 
            //Beginning of a message
            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "770";
            result.BGM.MessageFunctionCode_03 = bookingHeader.SelectToken("BookingStatus")?.ToString();
            result.BGM.ResponseTypeCode_04 = bookingHeader.SelectToken("CarrierResponseType")?.ToString();
            #endregion BGM

            var messageContact = carrierBookingConfirmation.SelectToken("MessageContact")?.First;

            #region CTA
            //Contact information            
            result.CTA = new CTA();
            //Confirmed with https://www.truugo.com/edifact/d99b/cl3139/
            result.CTA.ContactFunctionCode_01 = "CW";
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02 = new C056();
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02.Departmentoremployee_02 = messageContact.SelectToken("ContactName")?.ToString();
            #endregion CTA

            #region COM
            //COM-COMMUNICATION CONTACT
            result.COM = new List<COM>();

            var com1 = new COM();
            com1.COMMUNICATIONCONTACT_01 = new C076();
            com1.COMMUNICATIONCONTACT_01.CommunicationNumber_01 = messageContact.SelectToken("ContactEmail")?.ToString();
            //Electronic mail
            com1.COMMUNICATIONCONTACT_01.CommunicationChannelQualifier_02 = "EM";
            result.COM.Add(com1);
            #endregion COM


            var messageinfos = carrierBookingConfirmation.SelectToken("Messageinfos")?.First;

            #region DTM
            result.DTM = new List<DTM>();
            var dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "137";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = messageinfos.SelectToken("MessageDate")?.ToString();
            // TODO
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            result.DTM.Add(dtm1);

            //var dtm2 = new DTM();
            //dtm1.DATETIMEPERIOD_01 = new C507();
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "137";
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = messageinfos.SelectToken("MessageDate").ToString();
            //// TODO
            //dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "203";
            //result.DTM.Add(dtm2);
            #endregion DTM

            var generalInformation = carrierBookingConfirmation.SelectToken("GeneralInformation")?.First;

            #region TSR

            ////Transport service requirements
            ////A segment to provide confirmation details of the required transport services.
            ///
            result.TSR = new List<TSR>();
            var tsr = new TSR();
            tsr.CONTRACTANDCARRIAGECONDITION_01 = new C536();
            tsr.CONTRACTANDCARRIAGECONDITION_01.Contractandcarriageconditioncode_01 = generalInformation.SelectToken("TransportMove")?.ToString();
            result.TSR.Add(tsr);

            #endregion TSR

            var remarks = carrierBookingConfirmation.SelectToken("Remarks"); ;

            #region FTX

            result.FTX = new List<FTX>();

            foreach (var item in remarks)
            {
                var remark = item.SelectToken("Remark");

                foreach (var chield in remark.Children())
                {
                    //FTX, Free text                        
                    var ftx = new FTX();
                    //AAI General information - Self explanatory.           
                    ftx.Textsubjectcodequalifier_01 = remark.SelectToken("Code")?.ToString();
                    ftx.TEXTLITERAL_04 = new C108();
                    ftx.TEXTLITERAL_04.Freetext_01 = remark.SelectToken("Text")?.ToString();
                    result.FTX.Add(ftx);
                }
            }
            

            #endregion FTX

            #region LOCLoop Segment Group 1: LOC-DTM

            //TODO Foreach
            var transport = carrierBookingConfirmation.SelectToken("Transports")?.First.SelectToken("Transport")?.First;

            result.LOCLoop = new List<Loop_LOC_IFTMBC>();

            var lOCLoop1 = new Loop_LOC_IFTMBC();

            // LOC, Place/location identification      
            lOCLoop1.LOC = new LOC();

            //TODO
            //87 Place / port of conveyance initial arrival
            lOCLoop1.LOC.Locationfunctioncodequalifier_01 = "87";

            lOCLoop1.LOC.LOCATIONIDENTIFICATION_02 = new C517();

            lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = transport.SelectToken("DestinationCode")?.ToString();

            //181  Activity Code identifying activities.
            lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "181";

            //6  UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop1.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";

            lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03 = new C519();

            //Specification of the first related place/location by code.
            lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Relatedplacelocationoneidentification_01 = "US";

            //162  Country Identification of a country.
            lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistidentificationcode_02 = "162";

            //5  ISO (International Organization for Standardization)
            lOCLoop1.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistresponsibleagencycode_03 = "5";

            lOCLoop1.DTM = new List<DTM>();
            dtm1 = new DTM();
            dtm1.DATETIMEPERIOD_01 = new C507();
            //132  Arrival date/ time, estimated
            //ToDO
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "132";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = "20200825";
            dtm1.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";

            lOCLoop1.DTM.Add(dtm1);
            result.LOCLoop.Add(lOCLoop1);


            var lOCLoop2 = new Loop_LOC_IFTMBC();
            lOCLoop2.LOC = new LOC();
            //TODO
            //87 Place / port of conveyance initial arrival
            lOCLoop2.LOC.Locationfunctioncodequalifier_01 = "125";

            lOCLoop2.LOC.LOCATIONIDENTIFICATION_02 = new C517();

            lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "FRLEH";

            //181  Activity Code identifying activities.
            lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "181";

            //6  UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop2.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";

            lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03 = new C519();

            //Specification of the first related place/location by code.
            lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Relatedplacelocationoneidentification_01 = "FR";

            //162  Country Identification of a country.
            lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistidentificationcode_02 = "162";

            //5  ISO (International Organization for Standardization)
            lOCLoop2.LOC.RELATEDLOCATIONONEIDENTIFICATION_03.Codelistresponsibleagencycode_03 = "5";

            result.LOCLoop.Add(lOCLoop2);
            #endregion LOCLoop


            #region RFFLoop Segment Group 2: RFF-DTM

            var references = carrierBookingConfirmation.SelectToken("References") as JArray;

            result.RFFLoop = new List<Loop_RFF_IFTMBC>();

            foreach (var reference in references)
            {
                var chieldRef = reference.SelectToken("Reference");
                foreach (var item in chieldRef.Children())
                {
                    var rFFLoop = new Loop_RFF_IFTMBC();
                    rFFLoop.RFF = new RFF();
                    rFFLoop.RFF.REFERENCE_01 = new C506();
                    rFFLoop.RFF.REFERENCE_01.Referencefunctioncodequalifier_01 = item.SelectToken("ReferenceCode")?.ToString();
                    rFFLoop.RFF.REFERENCE_01.Referenceidentifier_02 = item.SelectToken("ReferenceValue")?.ToString();
                    result.RFFLoop.Add(rFFLoop);
                }
            }

            #endregion RFFLoop Segment Group 2: RFF-DTM


            #region TDTLoop Segment Group 3: TDT-DTM-TSR-SG4-SG5

            result.TDTLoop = new List<Loop_TDT_IFTMBC>();

            var tDTLoop1 = new Loop_TDT_IFTMBC();
            tDTLoop1.TDT = new TDT();

            tDTLoop1.TDT.Transportstagecodequalifier_01 = transport.SelectToken("TransportStage")?.ToString();
            tDTLoop1.TDT.Conveyancereferencenumber_02 = transport.SelectToken("VoyageNo")?.ToString();
            tDTLoop1.TDT.MODEOFTRANSPORT_03 = new C220();
            tDTLoop1.TDT.MODEOFTRANSPORT_03.Transportmodenamecode_01 = transport.SelectToken("ModeOfTransport")?.ToString();

            //CARRIER
            tDTLoop1.TDT.CARRIER_05 = new C040();
            tDTLoop1.TDT.CARRIER_05.Carrieridentification_01 = transport.SelectToken("CarrierCode")?.ToString();

            //172 Code list identifying carriers.
            tDTLoop1.TDT.CARRIER_05.Codelistidentificationcode_02 = "172";

            //182 US, Standard Carrier Alpha Code(Motor) 
            //Organisation maintaining the SCAC lists and transportation operating in North America.
            tDTLoop1.TDT.CARRIER_05.Codelistresponsibleagencycode_03 = "182";

            tDTLoop1.TDT.TRANSPORTIDENTIFICATION_08 = new C222();
            tDTLoop1.TDT.TRANSPORTIDENTIFICATION_08.Transportmeansidentificationnameidentifier_01 = transport.SelectToken("ImoNumber")?.ToString();
            tDTLoop1.TDT.TRANSPORTIDENTIFICATION_08.Codelistresponsibleagencycode_03 = "11";
            tDTLoop1.TDT.TRANSPORTIDENTIFICATION_08.Transportmeansidentificationname_04 = transport.SelectToken("Vessel")?.ToString();
            tDTLoop1.TDT.TRANSPORTIDENTIFICATION_08.Nationalityofmeansoftransportcoded_05 = transport.SelectToken("VesselNationality")?.ToString();


            #region SG4-LOCLoop LOC-DTM

            tDTLoop1.LOCLoop = new List<Loop_LOC_IFTMBC_2>();


            //+++++++++++++++++++
            var lOCLoop3 = new Loop_LOC_IFTMBC_2();

            lOCLoop3.LOC = new LOC();
            //Place / port of loading
            lOCLoop3.LOC.Locationfunctioncodequalifier_01 = "9";
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = transport.SelectToken("LoadingCode")?.ToString();
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop3.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = transport.SelectToken("LoadingName")?.ToString();


            lOCLoop3.DTM = new List<DTM>();
            var dtm2 = new DTM();
            dtm2.DATETIMEPERIOD_01 = new C507();
            //Departure date/time, estimated
            //when carrier estimates that a means of transport should depart at the place of departure.
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "133";
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = transport.SelectToken("ETS")?.ToString();
            //203 CCYYMMDDHHMM Calendar date including time with minutes: C=Century; Y=Year; M=Month; D=Day; H=Hour; M=Minutes.
            dtm2.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = transport.SelectToken("ETSFormat")?.ToString();
            lOCLoop3.DTM.Add(dtm2);

            var dtm3 = new DTM();
            dtm3.DATETIMEPERIOD_01 = new C507();
            //180 (Closing date/time) - Final date for delivering cargo to a liner ship.
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "180";
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = transport.SelectToken("CYClosing")?.ToString();
            //203 CCYYMMDDHHMM Calendar date including time with minutes: C=Century; Y=Year; M=Month; D=Day; H=Hour; M=Minutes.
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = transport.SelectToken("CYClosingFormat")?.ToString();
            lOCLoop3.DTM.Add(dtm3);

            tDTLoop1.LOCLoop.Add(lOCLoop3);
            //+++++++++++++++++++

            //+++++++++++++++++++
            var lOCLoop4 = new Loop_LOC_IFTMBC_2();

            lOCLoop4.LOC = new LOC();
            //11- Place / port of discharge
            lOCLoop4.LOC.Locationfunctioncodequalifier_01 = "11";
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = transport.SelectToken("DestinationCode")?.ToString();
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop4.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = transport.SelectToken("DestinationName")?.ToString();

            lOCLoop4.DTM = new List<DTM>();
            var dtm4 = new DTM();
            dtm4.DATETIMEPERIOD_01 = new C507();
            //132 Arrival date/time, estimated
            //when carrier estimates that a means of transport should arrive at the port of discharge or place of destination.
            dtm4.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "132";
            dtm4.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = transport.SelectToken("ETA")?.ToString();
            //203 CCYYMMDDHHMM Calendar date including time with minutes: C=Century; Y=Year; M=Month; D=Day; H=Hour; M=Minutes.
            dtm4.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = transport.SelectToken("ETAFormat")?.ToString();
            lOCLoop4.DTM.Add(dtm4);

            tDTLoop1.LOCLoop.Add(lOCLoop4);
            //+++++++++++++++++++

            #endregion SG4-LOCLoop LOC-DTM

            result.TDTLoop.Add(tDTLoop1);

            #endregion TDTLoop Segment Group 3: TDT-DTM-TSR-SG4-SG5


            #region NADLoop Segment Group 6: NAD-LOC-SG7-SG8

            result.NADLoop = new List<Loop_NAD_IFTMBC>();

            var addresses = carrierBookingConfirmation.SelectToken("Addresses") as JArray;

            var nADLoop1 = new Loop_NAD_IFTMBC();


            foreach (var address in addresses)
            {
                var chieldRef = address.SelectToken("Address");
                foreach (var item in chieldRef.Children())
                {
                    nADLoop1.NAD = new NAD();
                    nADLoop1.NAD.Partyqualifier_01 = item.SelectToken("AddressFunction")?.ToString();
                    nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
                    nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = transport.SelectToken("CarrierCode")?.ToString();
                    nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
                    nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "87";
                    nADLoop1.NAD.NAMEANDADDRESS_03 = new C058();
                    nADLoop1.NAD.NAMEANDADDRESS_03.Nameandaddressline_01 = item.SelectToken("NameLine1")?.ToString();
                }
            }


            #region SG7: CTA-COM

            #endregion SG7: CTA-COM

            #region SG8: TSR-RFF-LOC-TPL-FTX

            #endregion SG8: TSR-RFF-LOC-TPL-FTX

            result.NADLoop.Add(nADLoop1);
            #endregion NADLoop Segment Group 6: NAD-LOC-SG7-SG8

            #region GIDLoop Segment Group 9: GID-HAN-TMP-RNG-TMD-LOC-FTX-PCD-SG10-GDS-SG11-SG12-SG13-SG14-SG15

            result.GIDLoop = new List<Loop_GID_IFTMBC>();
            var gIDLoop1 = new Loop_GID_IFTMBC();

            gIDLoop1.GID = new GID();


            #endregion GIDLoop Segment Group 9: GID-HAN-TMP-RNG-TMD-LOC-FTX-PCD-SG10-GDS-SG11-SG12-SG13-SG14-SG15
            return result;

        }
    }
}
