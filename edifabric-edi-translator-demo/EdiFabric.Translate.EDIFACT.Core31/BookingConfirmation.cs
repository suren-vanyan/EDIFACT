using System;
using System.Collections.Generic;
using System.Text;

namespace EdiFabric.Translate.EDIFACT.Core31
{

    public class Carrierbookingconfirmation
    {
        public Generalinformation[] GeneralInformation { get; set; }
        public Messagecontact[] MessageContact { get; set; }
        public Transport[] Transports { get; set; }
        public Bookingheader[] BookingHeader { get; set; }
        public Reference[] References { get; set; }
        public Remark[] Remarks { get; set; }
        public Messageinfo[] Messageinfos { get; set; }
        public Container[] Containers { get; set; }
        public Address2[] Addresses { get; set; }
    }

    public class Generalinformation
    {
        public string TransportMove { get; set; }
    }

    public class Messagecontact
    {
        public string ContactEmail { get; set; }
        public string ContactName { get; set; }
    }

    public class Transport
    {
        public Transport1[] Transport1 { get; set; }
    }

    public class Transport1
    {
        public string TransportStage { get; set; }
        public string ETS { get; set; }
        public string LoadingCode { get; set; }
        public string VesselNationality { get; set; }
        public string DestinationName { get; set; }
        public string ETA { get; set; }
        public string ModeOfTransport { get; set; }
        public string CarrierCode { get; set; }
        public string CYClosingFormat { get; set; }
        public string CYClosing { get; set; }
        public string LoadingName { get; set; }
        public string DestinationCode { get; set; }
        public string VoyageNo { get; set; }
        public string ETAFormat { get; set; }
        public string Vessel { get; set; }
        public string ImoNumber { get; set; }
        public string ETSFormat { get; set; }
    }

    public class Bookingheader
    {
        public string BookingStatus { get; set; }
        public string SCAC { get; set; }
        public string CarrierResponseType { get; set; }
    }

    public class Reference
    {
        public Reference1[] Reference1 { get; set; }
    }

    public class Reference1
    {
        public string ReferenceValue { get; set; }
        public string ReferenceCode { get; set; }
    }

    public class Remark
    {
        public Remark1[] Remark1 { get; set; }
    }

    public class Remark1
    {
        public string Code { get; set; }
        public string Text { get; set; }
    }

    public class Messageinfo
    {
        public string Sender { get; set; }
        public string Receiver { get; set; }
        public string IntegrationId { get; set; }
        public string MessageDate { get; set; }
        public string MessageId { get; set; }
    }

    public class Container
    {
        public Container1[] Container1 { get; set; }
    }

    public class Container1
    {
        public string Count { get; set; }
        public Address[] Addresses { get; set; }
        public string ContainerUnitDescription { get; set; }
        public string ContainerLoadIndicator { get; set; }
        public Reference2[] References { get; set; }
        public string ContainerOwner { get; set; }
        public string ContainerUnit { get; set; }
        public string ContainerNumber { get; set; }
    }

    public class Address
    {
        public Address1[] Address1 { get; set; }
    }

    public class Address1
    {
        public string AddressLine4 { get; set; }
        public string NameLine1 { get; set; }
        public string AddressFunction { get; set; }
        public string AddressLine1 { get; set; }
        public Datetime[] DateTimes { get; set; }
    }

    public class Datetime
    {
        public Datetime1[] DateTime { get; set; }
    }

    public class Datetime1
    {
        public string DateCode { get; set; }
        public string DateValue { get; set; }
    }

    public class Reference2
    {
        public Reference3[] Reference { get; set; }
    }

    public class Reference3
    {
        public string ReferenceValue { get; set; }
        public string ReferenceCode { get; set; }
    }

    public class Address2
    {
        public Address3[] Address { get; set; }
    }

    public class Address3
    {
        public string AddressFunction { get; set; }
        public string NameLine1 { get; set; }
    }

}
