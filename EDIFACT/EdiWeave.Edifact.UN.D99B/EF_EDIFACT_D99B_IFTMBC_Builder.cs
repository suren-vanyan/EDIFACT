using EdiWeave.Core.Model.Edi.Edifact;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text;

namespace EdiWeave.Edifact.UN.D99B
{
    public class EF_EDIFACT_D99B_IFTMBC_Builder
    {
        public static UNB BuildUNB()
        {
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
                    InterchangeSenderIdentification_1 = "CMACGM",
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZZ",
                },
                INTERCHANGERECIPIENT_3 = new S003
                {
                    // Interchange recipient identification
                    InterchangeRecipientIdentification_1 = "COMSUP",
                    // Identification code qualifier
                    IdentificationCodeQualifier_2 = "ZZZ",
                },
                DATEANDTIMEOFPREPARATION_4 = new S004
                {
                    // Date
                    Date_1 = "200807",
                    // Time
                    Time_2 = "0849"
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

            ////Message header
            result.UNH = new UNH();
            result.UNH.MessageReferenceNumber_01 = controlNumber.PadLeft(14, '0');
            result.UNH.MessageIdentifier_02 = new S009();
            result.UNH.MessageIdentifier_02.MessageType_01 = "IFTMBC";
            result.UNH.MessageIdentifier_02.MessageVersionNumber_02 = "D";
            result.UNH.MessageIdentifier_02.MessageReleaseNumber_03 = "99B";
            result.UNH.MessageIdentifier_02.ControllingAgencyCoded_04 = "UN";


            ////Beginning of a message
            var bookingHeader = carrierBookingConfirmation.SelectToken("BookingHeader").First;

            result.BGM = new BGM();
            result.BGM.DOCUMENTMESSAGENAME_01 = new C002();
            result.BGM.DOCUMENTMESSAGENAME_01.Documentnamecode_01 = "770";
            result.BGM.MessageFunctionCode_03 = bookingHeader.SelectToken("BookingStatus").ToString();
            result.BGM.ResponseTypeCode_04 = bookingHeader.SelectToken("CarrierResponseType").ToString();

            ////Contact information
            var messageContact = carrierBookingConfirmation.SelectToken("MessageContact").First;

            result.CTA = new CTA();
            //Confirmed with https://www.truugo.com/edifact/d99b/cl3139/
            result.CTA.ContactFunctionCode_01 = "CW";
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02 = new C056();
            result.CTA.DEPARTMENTOREMPLOYEEDETAILS_02.Departmentoremployee_02 = messageContact.SelectToken("ContactName").ToString();


            ////COMMUNICATION CONTACT
            result.COM = new List<COM>();

            var com1 = new COM();
            com1.COMMUNICATIONCONTACT_01 = new C076();
            com1.COMMUNICATIONCONTACT_01.CommunicationNumber_01 = messageContact.SelectToken("ContactEmail").ToString();
            //Electronic mail
            com1.COMMUNICATIONCONTACT_01.CommunicationChannelQualifier_02 = "EM";
            result.COM.Add(com1);


            ////DATE/TIME/PERIOD
            result.DTM = new List<DTM>();

            var dtm1 = new DTM();


            return result;
        }
    }
}
