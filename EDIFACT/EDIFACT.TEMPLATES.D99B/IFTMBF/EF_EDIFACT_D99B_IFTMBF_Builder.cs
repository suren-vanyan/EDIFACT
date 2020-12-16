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
                ComponentDataElement = ':',
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


            var lOCLoop5 = new Loop_LOC_IFTMBF();

            lOCLoop5.LOC = new LOC();
            //Place / port of loading
            lOCLoop5.LOC.Locationfunctioncodequalifier_01 = "9";
            lOCLoop5.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop5.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "MZBEW";
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop5.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop5.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop5.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = "Beira";

            lOCLoop5.DTM = new List<DTM>();
            var dtm3 = new DTM();
            dtm3.DATETIMEPERIOD_01 = new C507();
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodfunctioncodequalifier_01 = "133";
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodvalue_02 = "20201217";
            dtm3.DATETIMEPERIOD_01.Dateortimeorperiodformatcode_03 = "102";
            lOCLoop5.DTM.Add(dtm3);
            tDTLoop1.LOCLoop.Add(lOCLoop5);


            var lOCLoop6 = new Loop_LOC_IFTMBF();

            lOCLoop6.LOC = new LOC();
            //Place / port of loading
            lOCLoop6.LOC.Locationfunctioncodequalifier_01 = "11";
            lOCLoop6.LOC.LOCATIONIDENTIFICATION_02 = new C517();
            lOCLoop6.LOC.LOCATIONIDENTIFICATION_02.Locationnamecode_01 = "CNWHG";
            //139 (Port) -  A location having facilities for means of transport to load or discharge cargo.
            lOCLoop6.LOC.LOCATIONIDENTIFICATION_02.Codelistidentificationcode_02 = "139";
            //6 UN / ECE(United Nations - Economic Commission for Europe)
            lOCLoop6.LOC.LOCATIONIDENTIFICATION_02.Codelistresponsibleagencycode_03 = "6";
            lOCLoop6.LOC.LOCATIONIDENTIFICATION_02.Locationname_04 = "Wuhan Pt";
            tDTLoop1.LOCLoop.Add(lOCLoop6);

            result.TDTLoop.Add(tDTLoop1);

            #endregion TDTLoop 


            #region NADLoop 

            result.NADLoop = new List<Loop_NAD_IFTMBF>();



            var nADLoop1 = new Loop_NAD_IFTMBF();
            nADLoop1.NAD = new NAD();
            nADLoop1.NAD.Partyqualifier_01 = "CA";
            nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "OOLU";
            nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            nADLoop1.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "86";
            result.NADLoop.Add(nADLoop1);


            var nADLoop2 = new Loop_NAD_IFTMBF();
            nADLoop2.NAD = new NAD();
            nADLoop2.NAD.Partyqualifier_01 = "BK";
            nADLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nADLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "CACC000008";
            nADLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            nADLoop2.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "86";

            nADLoop2.NAD.PARTYNAME_04 = new C080();
            nADLoop2.NAD.PARTYNAME_04.Partyname_01 = "Access World (Mozambique)";
            nADLoop2.NAD.PARTYNAME_04.Partyname_02 = "Mahmoud Nada";

            nADLoop2.CTALoop = new List<Loop_CTA_IFTMBF>();
            var ctaLoop = new Loop_CTA_IFTMBF();
            ctaLoop.CTA = new CTA();
            ctaLoop.CTA.ContactFunctionCode_01 = "IC";
            ctaLoop.CTA.DEPARTMENTOREMPLOYEEDETAILS_02 = new C056();
            ctaLoop.CTA.DEPARTMENTOREMPLOYEEDETAILS_02.Departmentoremployee_02 = "Mahmoud Nada";            

            ctaLoop.COM = new List<COM>();
            var com = new COM();
            com.COMMUNICATIONCONTACT_01 = new C076();
            com.COMMUNICATIONCONTACT_01.CommunicationNumber_01 = "mahmoud.nada@commodity.ch";
            com.COMMUNICATIONCONTACT_01.CommunicationChannelQualifier_02 = "EM";
            ctaLoop.COM.Add(com);
            nADLoop2.CTALoop.Add(ctaLoop);

            result.NADLoop.Add(nADLoop2);

            var nADLoop3 = new Loop_NAD_IFTMBF();
            nADLoop3.NAD = new NAD();
            nADLoop3.NAD.Partyqualifier_01 = "FW";
            nADLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nADLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "CACC000008";
            nADLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            nADLoop3.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "86";

            nADLoop3.NAD.PARTYNAME_04 = new C080();
            nADLoop3.NAD.PARTYNAME_04.Partyname_01 = "Access World (Mozambique)";

            nADLoop3.NAD.STREET_05 = new C059();
            nADLoop3.NAD.STREET_05.Streetandnumberpobox_01 = "Cornelder de Mocambique";
            nADLoop3.NAD.STREET_05.Streetandnumberpobox_02 = "Lda Shed 16, Porto de Beira";

            nADLoop3.NAD.Cityname_06 = "Beira";
            nADLoop3.NAD.Countrynamecode_09 = "MZ";
            result.NADLoop.Add(nADLoop3);

            var nADLoop4 = new Loop_NAD_IFTMBF();
            nADLoop4.NAD = new NAD();
            nADLoop4.NAD.Partyqualifier_01 = "CZ";
            nADLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nADLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "CACC000008";
            nADLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            nADLoop4.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "86";
                   
            nADLoop4.NAD.PARTYNAME_04 = new C080();
            nADLoop4.NAD.PARTYNAME_04.Partyname_01 = "Access World (Mozambique)";
                   
            nADLoop4.NAD.STREET_05 = new C059();
            nADLoop4.NAD.STREET_05.Streetandnumberpobox_01 = "Cornelder de Mocambique";
            nADLoop4.NAD.STREET_05.Streetandnumberpobox_02 = "Lda Shed 16, Porto de Beira";
                   
            nADLoop4.NAD.Cityname_06 = "Beira";
            nADLoop4.NAD.Countrynamecode_09 = "MZ";
            result.NADLoop.Add(nADLoop4);

            var nADLoop5 = new Loop_NAD_IFTMBF();
            nADLoop5.NAD = new NAD();
            nADLoop5.NAD.Partyqualifier_01 = "CN";
            nADLoop5.NAD.PARTYIDENTIFICATIONDETAILS_02 = new C082();
            nADLoop5.NAD.PARTYIDENTIFICATIONDETAILS_02.Partyidentifier_01 = "CGLE000001";
            nADLoop5.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistidentificationcode_02 = "160";
            nADLoop5.NAD.PARTYIDENTIFICATIONDETAILS_02.Codelistresponsibleagencycode_03 = "86";

            nADLoop5.NAD.PARTYNAME_04 = new C080();
            nADLoop5.NAD.PARTYNAME_04.Partyname_01 = "Glencore International AG";

            nADLoop5.NAD.STREET_05 = new C059();
            nADLoop5.NAD.STREET_05.Streetandnumberpobox_01 = "Baarermattstrasse 3";
 
            nADLoop5.NAD.Cityname_06 = "Baar";
            nADLoop5.NAD.Postcodeidentification_08 = "6341";
            nADLoop5.NAD.Countrynamecode_09 = "CH";
            result.NADLoop.Add(nADLoop5);

            #endregion NADLoop 

            #region GIDLoop 

            result.GIDLoop = new List<Loop_GID_IFTMBF>();
            
            var gIDLoop1 = new Loop_GID_IFTMBF();
            gIDLoop1.GID = new GID();
            gIDLoop1.GID.Goodsitemnumber_01 = "1";
            gIDLoop1.GID.NUMBERANDTYPEOFPACKAGES_02 = new C213();
            gIDLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Numberofpackages_01 = "1";
            gIDLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Packagetypedescriptioncode_02 = "VR";
            gIDLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Codelistidentificationcode_03 = "67";
            gIDLoop1.GID.NUMBERANDTYPEOFPACKAGES_02.Codelistresponsibleagencycode_04 = "6";

            gIDLoop1.FTX = new List<FTX>();
            var ftx2 = new FTX();
            ftx2.Textsubjectcodequalifier_01 = "AAA";
            ftx2.TEXTLITERAL_04 = new C108();
            ftx2.TEXTLITERAL_04.Freetext_01 = "Copper";
            gIDLoop1.FTX.Add(ftx2);

            gIDLoop1.MEALoop = new List<Loop_MEA_IFTMBF>();

            var mEALoop1 = new Loop_MEA_IFTMBF();
            mEALoop1.MEA = new MEA();
            mEALoop1.MEA.Measurementattributecode_01 = "WT";
            mEALoop1.MEA.MEASUREMENTDETAILS_02 = new C502();
            mEALoop1.MEA.MEASUREMENTDETAILS_02.Measuredattributecode_01 = "G";

            mEALoop1.MEA.VALUERANGE_03 = new C174();
            mEALoop1.MEA.VALUERANGE_03.Measurementunitcode_01 = "KGM";
            mEALoop1.MEA.VALUERANGE_03.Measurementvalue_02 = "22000.00";
            gIDLoop1.MEALoop.Add(mEALoop1);

            var mEALoop2 = new Loop_MEA_IFTMBF();
            mEALoop2.MEA = new MEA();
            mEALoop2.MEA.Measurementattributecode_01 = "VOL";
            mEALoop2.MEA.MEASUREMENTDETAILS_02 = new C502();
            mEALoop2.MEA.MEASUREMENTDETAILS_02.Measuredattributecode_01 = "AAW";
                   
            mEALoop2.MEA.VALUERANGE_03 = new C174();
            mEALoop2.MEA.VALUERANGE_03.Measurementunitcode_01 = "MTQ";
            mEALoop2.MEA.VALUERANGE_03.Measurementvalue_02 = "0.000";
            gIDLoop1.MEALoop.Add(mEALoop2);

            var mEALoop3 = new Loop_MEA_IFTMBF();
            mEALoop3.MEA = new MEA();
            mEALoop3.MEA.Measurementattributecode_01 = "WT";
            mEALoop3.MEA.MEASUREMENTDETAILS_02 = new C502();
            mEALoop3.MEA.MEASUREMENTDETAILS_02.Measuredattributecode_01 = "N";
                   
            mEALoop3.MEA.VALUERANGE_03 = new C174();
            mEALoop3.MEA.VALUERANGE_03.Measurementunitcode_01 = "KGM";
            mEALoop3.MEA.VALUERANGE_03.Measurementvalue_02 = "0.00";
            gIDLoop1.MEALoop.Add(mEALoop3);

            result.GIDLoop.Add(gIDLoop1);

            #endregion GIDLoop 


            #region EQDLoop

            #endregion EQDLoop

            result.EQDLoop = new List<Loop_EQD_IFTMBF>();

            var eQDLoop = new Loop_EQD_IFTMBF();
            eQDLoop.EQD = new EQD();
            eQDLoop.EQD.Equipmenttypecodequalifier_01 = "CN";
            eQDLoop.EQD.EQUIPMENTSIZEANDTYPE_03 = new C224();
            eQDLoop.EQD.EQUIPMENTSIZEANDTYPE_03.Equipmentsizeandtypedescriptioncode_01 = "22G0";
            eQDLoop.EQD.EQUIPMENTSIZEANDTYPE_03.Codelistidentificationcode_02 = "102";
            eQDLoop.EQD.EQUIPMENTSIZEANDTYPE_03.Codelistresponsibleagencycode_03 = "5";

            eQDLoop.EQD.Equipmentsuppliercoded_04 = "2";

            eQDLoop.EQN = new EQN();
            eQDLoop.EQN.NUMBEROFUNITDETAILS_01 = new C523();
            eQDLoop.EQN.NUMBEROFUNITDETAILS_01.Numberofunits_01 = "1";
            eQDLoop.EQN.NUMBEROFUNITDETAILS_01.Unittypecodequalifier_02 = "2";

            eQDLoop.TMD = new TMD();
            eQDLoop.TMD.MOVEMENTTYPE_01 = new C219();
            eQDLoop.TMD.MOVEMENTTYPE_01.Movementtypedescriptioncode_01 = "3";
            eQDLoop.TMD.MOVEMENTTYPE_01.Movementtypedescription_02 = "FCL-FCL";

            eQDLoop.TMD.Haulagearrangementscoded_03 = "MM";
            result.EQDLoop.Add(eQDLoop);
            return result;

        }

        public static UNZ BuildUNZ(JToken input)
        {

            JToken carrierBookingRequest = input.SelectToken("CarrierBookingRequest");

            return new UNZ
            {
                InterchangeControlCount_1 = "1",
                InterchangeControlReference_2 = "2650"
            };
        }
    }
}
