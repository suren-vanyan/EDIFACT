using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi.Edifact;
using System;
using System.Runtime.Serialization;

namespace EDIFACT.TEMPLATES.D99B
{
    /// <summary>
    /// DOCUMENT/MESSAGE NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C002")]
    public class C002 : I_C002
    {
        /// <summary>
        /// Document name code
        /// </summary>
        [DataMember]
        [DataElement("1001", typeof(EDIFACT_ID_1001))]
        [Pos(1)]
        public string Documentnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Document name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Documentname_04 { get; set; }
    }

    /// <summary>
    /// CARRIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C040")]
    public class C040 : I_C040
    {
        /// <summary>
        /// Carrier identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3127", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Carrieridentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Carrier name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3128", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Carriername_04 { get; set; }
    }

    /// <summary>
    /// DEPARTMENT OR EMPLOYEE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C056")]
    public class C056 : I_C056
    {
        /// <summary>
        /// Department or employee identification
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("3413", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Departmentoremployeeidentification_01 { get; set; }
        /// <summary>
        /// Department or employee
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3412", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Departmentoremployee_02 { get; set; }
    }

    /// <summary>
    /// NAME AND ADDRESS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C058")]
    public class C058 : I_C058
    {
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1,35)]
        [DataElement("3124",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Nameandaddressline_01 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Nameandaddressline_02 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Nameandaddressline_03 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nameandaddressline_04 { get; set; }
        /// <summary>
        /// Name and address line
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3124", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nameandaddressline_05 { get; set; }
    }

    /// <summary>
    /// STREET
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C059")]
    public class C059 : I_C059
    {

        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1,35)]
        [DataElement("3042",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Streetandnumberpobox_01 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Streetandnumberpobox_02 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Streetandnumberpobox_03 { get; set; }
        /// <summary>
        /// Street and number/p.o. box
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3042", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Streetandnumberpobox_04 { get; set; }
    }

    [Serializable()]
    [Composite("C819")]
    public class C819:I_C819
    {
        /// <summary>
        /// Country sub-entity name code
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("3229", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Countrysubentitynamecode_01 { get; set; }

        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }

        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }

        /// <summary>
        /// Country sub-entity name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("3228", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Countrysubentityname_04 { get; set; }
    }

    /// <summary>
    /// COMMUNICATION CONTACT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C076")]
    public class C076 : I_C076
    {

        /// <summary>
        /// Communication number
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("3148", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string CommunicationNumber_01 { get; set; }
        /// <summary>
        /// Communication channel qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3155", typeof(EDIFACT_ID_3155))]
        [Pos(2)]
        public string CommunicationChannelQualifier_02 { get; set; }
    }

    /// <summary>
    /// ACCOUNT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C078")]
    public class C078 : I_C078
    {

        /// <summary>
        /// Account holder number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Accountholdernumber_01 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Accountholdername_02 { get; set; }
        /// <summary>
        /// Account holder name
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Accountholdername_03 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Currencycoded_04 { get; set; }
    }

    /// <summary>
    /// PARTY NAME
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C080")]
    public class C080 : I_C080
    {
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(1)]
        public string Partyname_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(2)]
        public string Partyname_02 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(3)]
        public string Partyname_03 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(4)]
        public string Partyname_04 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [DataElement("3036", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(5)]
        public string Partyname_05 { get; set; }
        /// <summary>
        /// Party name format, coded
        /// </summary>
        [DataMember]
        [DataElement("3045", typeof(EDIFACT_ID_3045))]
        [Pos(6)]
        public string Partynameformatcoded_06 { get; set; }
    }

    /// <summary>
    /// PARTY IDENTIFICATION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C082")]
    public class C082 : I_C082
    {
        /// <summary>
        /// Party identifier
        /// </summary>
        [DataMember]
        [StringLength(1,35)]
        [DataElement("3039",typeof(EDIFACT_AN))]
        [Required]
        [Pos(1)]
        public string Partyidentifier_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131",typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// INSTITUTION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C088")]
    public class C088 : I_C088
    {

        /// <summary>
        /// Institution name identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Institutionnameidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Institution branch number
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Institutionbranchnumber_04 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistqualifier_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistresponsibleagencycoded_06 { get; set; }
        /// <summary>
        /// Institution name
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Institutionname_07 { get; set; }
        /// <summary>
        /// Institution branch place
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Institutionbranchplace_08 { get; set; }
    }

    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C100")]
    public class C100 : I_C100
    {
        /// <summary>
        /// Delivery or transport terms description code
        /// </summary>
        [DataMember]
        [DataElement("4053",typeof(EDIFACT_ID_4053))]
        [Pos(1)]
        public string Deliveryortransporttermsdescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Delivery or transport terms description
        /// </summary>
        [DataMember]
        [StringLength(1,70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Deliveryortransporttermsdescription_04 { get; set; }
        /// <summary>
        ///Delivery or transport terms description
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("4052", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Deliveryortransporttermsdescription_05 { get; set; }
    }


    /// <summary>
    /// TEXT REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C107")]
    public class C107 : I_C107
    {
        /// <summary>
        /// Free text value code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4441", typeof(EDIFACT_AN))]
        [StringLength(1, 17)]
        [Pos(1)]
        public string Freetextvaluecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// DOCUMENT/MESSAGE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C106")]
    public class C106 : I_C106
    {
        /// <summary>
        /// Document identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1004", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Version identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("1056", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Version_02 { get; set; }
        /// <summary>
        /// Revision identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Revisionnumber_03 { get; set; }
    }

    /// <summary>
    /// TEXT LITERAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C108")]
    public class C108 : I_C108
    {
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freetext_01 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Freetext_02 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Freetext_03 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freetext_04 { get; set; }
        /// <summary>
        /// Free text
        /// </summary>
        [DataMember]
        [StringLength(1, 512)]
        [DataElement("4440", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Freetext_05 { get; set; }
    }

    /// <summary>
    /// PAYMENT TERMS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C110")]
    public class C110 : I_C110
    {

        /// <summary>
        /// Terms of payment identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Termsofpaymentidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Termsofpayment_04 { get; set; }
        /// <summary>
        /// Terms of payment
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Termsofpayment_05 { get; set; }
    }

    /// <summary>
    /// TERMS/TIME INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C112")]
    public class C112 : I_C112
    {

        /// <summary>
        /// Payment time reference, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Paymenttimereferencecoded_01 { get; set; }
        /// <summary>
        /// Time relation, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Timerelationcoded_02 { get; set; }
        /// <summary>
        /// Type of period, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Typeofperiodcoded_03 { get; set; }
        /// <summary>
        /// Number of periods
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Numberofperiods_04 { get; set; }
    }

    /// <summary>
    /// RATE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C128")]
    public class C128 : I_C128
    {

        /// <summary>
        /// Rate type qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Ratetypequalifier_01 { get; set; }
        /// <summary>
        /// Rate per unit
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Rateperunit_02 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Unitpricebasis_03 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Measureunitqualifier_04 { get; set; }
    }

    /// <summary>
    /// PRICE MULTIPLIER INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C138")]
    public class C138 : I_C138
    {

        /// <summary>
        /// Price multiplier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Pricemultiplier_01 { get; set; }
        /// <summary>
        /// Price multiplier qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Pricemultiplierqualifier_02 { get; set; }
    }

    /// <summary>
    /// VALUE/RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C174")]
    public class C174 : I_C174
    {
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [StringLength(1,3)]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Measurement value
        /// </summary>
        [DataMember]
        [DataElement("6314", typeof(EDIFACT_AN))]
        [StringLength(1, 18)]
        [Pos(2)]
        public string Measurementvalue_02 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [DataElement("6162", typeof(EDIFACT_N))]
        [StringLength(1, 18)]
        [Pos(3)]
        public string Rangeminimum_03 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [DataElement("6152", typeof(EDIFACT_N))]
        [StringLength(1, 18)]
        [Pos(4)]
        public string Rangemaximum_04 { get; set; }
        /// <summary>
        /// Significant digits
        /// </summary>
        [DataMember]
        [DataElement("6432", typeof(EDIFACT_N))]
        [StringLength(1, 2)]
        [Pos(5)]
        public string Significantdigits_05 { get; set; }
    }

    /// <summary>
    /// QUANTITY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C186")]
    public class C186 : I_C186
    {

        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantityqualifier_01 { get; set; }
        /// <summary>
        /// Quantity
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantity_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Measureunitqualifier_03 { get; set; }
    }

    /// <summary>
    /// CHARGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C200")]
    public class C200 : I_C200
    {

        /// <summary>
        /// Freight and charges identification
        /// </summary>
        [DataMember]
        [StringLength(1,17)]
        [DataElement("8023",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Freightandchargesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Freight and charges
        /// </summary>
        [DataMember]
        [StringLength(1, 26)]
        [DataElement("8022", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Freightandcharges_04 { get; set; }
        /// <summary>
        /// Prepaid/collect indicator, coded
        /// </summary>
        [DataMember]
        [DataElement("4237", typeof(EDIFACT_ID_4237))]
        [Pos(5)]
        public string Prepaidcollectindicatorcoded_05 { get; set; }
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Itemnumber_06 { get; set; }
    }

    /// <summary>
    /// PACKAGE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C202")]
    public class C202 : I_C202
    {

        /// <summary>
        /// Type of packages identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Typeofpackagesidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
    }

    /// <summary>
    /// RATE/TARIFF CLASS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C203")]
    public class C203 : I_C203
    {
        /// <summary>
        /// Rate/tariff class identification
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Rate/tariff class
        /// </summary>
        [DataMember]
        [DataElement("5242", typeof(EDIFACT_AN))]
        [StringLength(1,35)]
        [Pos(4)]
        public string Ratetariffclass_04 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Supplementaryratetariffbasisidentification_05 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(6)]
        public string Codelistidentificationcode_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(7)]
        public string Codelistresponsibleagencycode_07 { get; set; }
        /// <summary>
        /// Supplementary rate/tariff basis identification
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("5275", typeof(EDIFACT_AN))]
        [Pos(8)]
        public string Supplementaryratetariffbasisidentification_08 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(9)]
        public string Codelistidentificationcode_09 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(10)]
        public string Codelistresponsibleagencycode_10 { get; set; }
    }

    /// <summary>
    /// HAZARD CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C205")]
    public class C205 : I_C205
    {

        /// <summary>
        /// Hazard code identification
        /// </summary>
        [DataMember]
        [DataElement("8351", typeof(EDIFACT_AN))]
        [StringLength(1,7)]
        [Required]
        [Pos(1)]
        public string Hazardcodeidentification_01 { get; set; }
        /// <summary>
        /// Hazard substance/item/page number
        /// </summary>
        [DataMember]
        [DataElement("8078", typeof(EDIFACT_AN))]
        [StringLength(1, 7)]
        [Pos(2)]
        public string Hazardsubstanceitempagenumber_02 { get; set; }
        /// <summary>
        /// Hazard code version number
        /// </summary>
        [DataMember]
        [DataElement("8092", typeof(EDIFACT_AN))]
        [StringLength(1, 10)]
        [Pos(3)]
        public string Hazardcodeversionnumber_03 { get; set; }
    }

    /// <summary>
    /// IDENTIFICATION NUMBER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C206")]
    public class C206 : I_C206
    {

        /// <summary>
        /// Identity number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Identitynumber_01 { get; set; }
        /// <summary>
        /// Identity number qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Identitynumberqualifier_02 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Statuscoded_03 { get; set; }
    }

    /// <summary>
    /// IDENTITY NUMBER RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C208")]
    public class C208 : I_C208
    {
        /// <summary>
        /// Object identifier
        /// </summary>
        [DataMember]
        [StringLength(1,35)]
        [DataElement("7402",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Objectidentifier_01 { get; set; }
        /// <summary>
        /// Object identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("7402", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Objectidentifier_02 { get; set; }
    }

    /// <summary>
    /// MARKS & LABELS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C210")]
    public class C210 : I_C210
    {

        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Shippingmarks_01 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Shippingmarks_02 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Shippingmarks_03 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Shippingmarks_04 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Shippingmarks_05 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Shippingmarks_06 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Shippingmarks_07 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(8)]
        public string Shippingmarks_08 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(9)]
        public string Shippingmarks_09 { get; set; }
        /// <summary>
        /// Shipping marks
        /// </summary>
        [DataMember]
        [Pos(10)]
        public string Shippingmarks_10 { get; set; }
    }

    /// <summary>
    /// DIMENSIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C211")]
    public class C211 : I_C211
    {
        /// <summary>
        /// Measure unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(1)]
        public string Measureunitcode_01 { get; set; }
        /// <summary>
        /// Length dimension
        /// </summary>
        [DataMember]
        [DataElement("6168", typeof(EDIFACT_N))]
        [StringLength(1, 15)]
        [Pos(2)]
        public string Lengthdimension_02 { get; set; }
        /// <summary>
        /// Width dimension
        /// </summary>
        [DataMember]
        [DataElement("6140", typeof(EDIFACT_N))]
        [StringLength(1, 15)]
        [Pos(3)]
        public string Widthdimension_03 { get; set; }
        /// <summary>
        /// Height dimension
        /// </summary>
        [DataMember]
        [DataElement("6008", typeof(EDIFACT_N))]
        [StringLength(1, 15)]
        [Pos(4)]
        public string Heightdimension_04 { get; set; }
    }

    /// <summary>
    /// ITEM NUMBER IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C212")]
    public class C212 : I_C212
    {
        /// <summary>
        /// Item number
        /// </summary>
        [DataMember]
        [StringLength(1,35)]
        [DataElement("7140", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Itemnumber_01 { get; set; }
        /// <summary>
        /// Item type identification code
        /// </summary>
        [DataMember]
        [DataElement("7143", typeof(EDIFACT_ID_7143))]
        [Pos(2)]
        public string Itemtypeidentificationcoded_02 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }

        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }
    }

    /// <summary>
    /// NUMBER AND TYPE OF PACKAGES
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C213")]
    public class C213 : I_C213
    {

        /// <summary>
        /// Number of packages
        /// </summary>
        [DataMember]
        [DataElement("7224", typeof(EDIFACT_AN))]
        [StringLength(1, 8)]
        [Pos(1)]
        public string Numberofpackages_01 { get; set; }

        /// <summary>
        /// Package type description code
        /// </summary>
        [DataMember]
        [DataElement("7065", typeof(EDIFACT_AN))]
        [StringLength(1, 17)]
        [Pos(2)]
        public string Packagetypedescriptioncode_02 { get; set; }

        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(3)]
        public string Codelistidentificationcode_03 { get; set; }

        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(4)]
        public string Codelistresponsibleagencycode_04 { get; set; }

        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [DataElement("7064", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(5)]
        public string Typeofpackages_05 { get; set; }

        /// <summary>
        /// Packaging related description code
        /// </summary>
        [DataMember]
        [DataElement("7233", typeof(EDIFACT_ID_7233))]
        [Pos(6)]
        public string Packagingrelateddescriptioncode_05 { get; set; }
    }

    /// <summary>
    /// SPECIAL SERVICES IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C214")]
    public class C214 : I_C214
    {

        /// <summary>
        /// Special services, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Specialservicescoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Specialservice_04 { get; set; }
        /// <summary>
        /// Special service
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Specialservice_05 { get; set; }
    }

    /// <summary>
    /// SEAL ISSUER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C215")]
    public class C215 : I_C215
    {

        /// <summary>
        /// Sealing party, coded
        /// </summary>
        [DataMember]
        [DataElement("9303", typeof(EDIFACT_ID_9303))]
        [Pos(1)]
        public string Sealingpartycoded_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }

        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Sealing party
        /// </summary>
        [DataMember]
        [StringLength(1,35)]
        [DataElement("9302", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Sealingparty_04 { get; set; }
    }

    /// <summary>
    /// HAZARDOUS MATERIAL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C218")]
    public class C218 : I_C218
    {
        /// <summary>
        /// Hazardous material class code, identification
        /// </summary>
        [DataMember]
        [DataElement("7419", typeof(EDIFACT_AN))]
        [StringLength(1, 4)]
        [Pos(1)]
        public string Hazardousmaterialclasscodeidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Hazardous material class
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_AN))]
        [StringLength(1,35)]
        [Pos(4)]
        public string Hazardousmaterialclass_04 { get; set; }

    }

    /// <summary>
    /// MOVEMENT TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C219")]
    public class C219 : I_C219
    {
        /// <summary>
        /// Movement type description code
        /// </summary>
        [DataMember]
        [DataElement("8335", typeof(EDIFACT_ID_8335))]
        [Pos(1)]
        public string Movementtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Movement type description
        /// </summary>
        [DataMember]
        [DataElement("8334", typeof(EDIFACT_AN))]
        [StringLength(1, 35)]
        [Pos(2)]
        public string Movementtypedescription_02 { get; set; }
    }

    /// <summary>
    /// MODE OF TRANSPORT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C220")]
    public class C220 : I_C220
    {
        /// <summary>
        /// Transport mode name code
        /// </summary>
        [DataMember]
        [StringLength(1,3)]
        [DataElement("8067",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmodenamecode_01 { get; set; }
        /// <summary>
        /// Transport mode name
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8066", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmodename_02 { get; set; }
    }

    /// <summary>
    /// TRANSPORT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C222")]
    public class C222 : I_C222
    {
        /// <summary>
        /// Transport means identification name identifier
        /// </summary>
        [DataMember]
        [StringLength(1, 9)]
        [DataElement("8213", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Transportmeansidentificationnameidentifier_01 { get; set; }

        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }

        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }

        /// <summary>
        /// Transport means identification name
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("8212", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Transportmeansidentificationname_04 { get; set; }

        /// <summary>
        /// Nationality of means of transport, coded
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("8453", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Nationalityofmeansoftransportcoded_05 { get; set; }
    }

    /// <summary>
    /// DANGEROUS GOODS SHIPMENT FLASHPOINT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C223")]
    public class C223 : I_C223
    {

        /// <summary>
        /// Shipment flashpoint
        /// </summary>
        [DataMember]
        [DataElement("7106", typeof(EDIFACT_N))]
        [StringLength(3, 3)]
        [Pos(1)]
        public string Shipmentflashpoint_01 { get; set; }
        /// <summary>
        /// Measurement unit code
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(2)]
        public string Measurementunitcode_02 { get; set; }
    }

    /// <summary>
    /// EQUIPMENT SIZE AND TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C224")]
    public class C224 : I_C224
    {
        /// <summary>
        /// Equipment size and type description code
        /// </summary>
        [DataMember]
        [DataElement("8155", typeof(EDIFACT_ID_8155))]
        [Pos(1)]
        public string Equipmentsizeandtypedescriptioncode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Equipment size and type
        /// </summary>
        [DataMember]
        [DataElement("8154", typeof(EDIFACT_AN))]
        [StringLength(1,35)]
        [Pos(4)]
        public string Equipmentsizeandtypedescription_04 { get; set; }
    }

    /// <summary>
    /// TRANSPORT MEANS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C228")]
    public class C228 : I_C228
    {
        /// <summary>
        /// Transport means description code
        /// </summary>
        [DataMember]
        [DataElement("8179", typeof(EDIFACT_ID_8179))]
        [Pos(1)]
        public string Transportmeansdescriptioncode_01 { get; set; }
        /// <summary>
        /// Transport means description
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("8178", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Transportmeansdescription_02 { get; set; }
    }

    /// <summary>
    /// CHARGE CATEGORY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C229")]
    public class C229 : I_C229
    {

        /// <summary>
        /// Charge category, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5237",typeof(EDIFACT_ID_5237))]
        [Pos(1)]
        public string Chargecategorycoded_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// METHOD OF PAYMENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C231")]
    public class C231 : I_C231
    {

        /// <summary>
        /// Transport charges payment method code
        /// </summary>
        [DataMember]
        [DataElement("4215", typeof(EDIFACT_ID_4215))]
        [Pos(1)]
        public string Transportchargespaymentmethodcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// GOVERNMENT ACTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C232")]
    public class C232 : I_C232
    {
        /// <summary>
        /// Government agency, coded
        /// </summary>
        [DataMember]
        [DataElement("9415",typeof(EDIFACT_ID_9415))]
        [Pos(1)]
        public string Governmentagencycoded_01 { get; set; }
        /// <summary>
        /// Government involvement, coded
        /// </summary>
        [DataMember]
        [DataElement("9411", typeof(EDIFACT_ID_9411))]
        [Pos(2)]
        public string Governmentinvolvementcoded_02 { get; set; }
        /// <summary>
        /// Government action, coded
        /// </summary>
        [DataMember]
        [DataElement("9417", typeof(EDIFACT_ID_9417))]
        [Pos(3)]
        public string Governmentactioncoded_03 { get; set; }
        /// <summary>
        /// Government procedure, coded
        /// </summary>
        [DataMember]
        [DataElement("9353", typeof(EDIFACT_ID_9353))]
        [Pos(4)]
        public string Governmentprocedurecoded_04 { get; set; }
    }

    /// <summary>
    /// SERVICE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C233")]
    public class C233 : I_C233
    {
        /// <summary>
        /// Service requirement, code
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(1)]
        public string Servicerequirementcode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Service requirement, code
        /// </summary>
        [DataMember]
        [DataElement("7273", typeof(EDIFACT_ID_7273))]
        [Pos(4)]
        public string Servicerequirementcode_04 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(5)]
        public string Codelistidentificationcode_05 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(6)]
        public string Codelistresponsibleagencycode_06 { get; set; }
    }

    /// <summary>
    /// UNDG INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C234")]
    public class C234 : I_C234
    {
        /// <summary>
        /// UNDG number
        /// </summary>
        [DataMember]
        [DataElement("7124", typeof(EDIFACT_N))]
        [StringLength(4, 4)]
        [Pos(1)]
        public string UNDGnumber_01 { get; set; }
        /// <summary>
        /// Dangerous goods flashpoint
        /// </summary>
        [DataMember]
        [DataElement("7088", typeof(EDIFACT_AN))]
        [StringLength(1, 8)]
        [Pos(2)]
        public string Dangerousgoodsflashpoint_02 { get; set; }
    }

    /// <summary>
    /// HAZARD IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C235")]
    public class C235 : I_C235
    {
        /// <summary>
        /// Hazard identification number, upper part
        /// </summary>
        [DataMember]
        [DataElement("8158", typeof(EDIFACT_AN))]
        [StringLength(1,4)]
        [Pos(1)]
        public string Hazardidentificationnumberupperpart_01 { get; set; }
        /// <summary>
        /// Substance identification number, lower part
        /// </summary>
        [DataMember]
        [DataElement("8186", typeof(EDIFACT_AN))]
        [StringLength(4, 4)]
        [Pos(2)]
        public string Substanceidentificationnumberlowerpart_02 { get; set; }
    }

    /// <summary>
    /// DANGEROUS GOODS LABEL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C236")]
    public class C236 : I_C236
    {
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [StringLength(1,4)]
        [Pos(1)]
        public string Dangerousgoodslabelmarking_01 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [StringLength(1, 4)]
        [Pos(2)]
        public string Dangerousgoodslabelmarking_02 { get; set; }
        /// <summary>
        /// Dangerous goods label marking
        /// </summary>
        [DataMember]
        [DataElement("8246", typeof(EDIFACT_AN))]
        [StringLength(1, 4)]
        [Pos(3)]
        public string Dangerousgoodslabelmarking_03 { get; set; }
    }

    /// <summary>
    /// EQUIPMENT IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C237")]
    public class C237 : I_C237
    {
        /// <summary>
        /// Equipment identification number
        /// </summary>
        [DataMember]
        [DataElement("8260", typeof(EDIFACT_AN))]
        [StringLength(1,17)]
        [Pos(1)]
        public string Equipmentidentificationnumber_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Country,name code
        /// </summary>
        [DataMember]
        [DataElement("3207", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(4)]
        public string Countrynamecode_04 { get; set; }
    }

    /// <summary>
    /// TEMPERATURE SETTING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C239")]
    public class C239 : I_C239
    {

        /// <summary>
        /// Temperature setting
        /// </summary>
        [DataMember]
        [DataElement("6246", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(1)]
        public string Temperaturesetting_01 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(2)]
        public string Measureunitqualifier_02 { get; set; }
    }

    /// <summary>
    /// PRODUCT CHARACTERISTIC
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C240")]
    public class C240 : I_C240
    {

        /// <summary>
        /// Characteristic identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Characteristicidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Characteristic_04 { get; set; }
        /// <summary>
        /// Characteristic
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Characteristic_05 { get; set; }
    }

    /// <summary>
    /// DUTY/TAX/FEE TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C241")]
    public class C241 : I_C241
    {

        /// <summary>
        /// Duty/tax/fee type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeetypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee type
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Dutytaxfeetype_04 { get; set; }
    }

    /// <summary>
    /// DUTY/TAX/FEE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C243")]
    public class C243 : I_C243
    {

        /// <summary>
        /// Duty/tax/fee rate identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeerateidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Dutytaxfeerate_04 { get; set; }
        /// <summary>
        /// Duty/tax/fee rate basis identification
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Dutytaxfeeratebasisidentification_05 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Codelistqualifier_06 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(7)]
        public string Codelistresponsibleagencycoded_07 { get; set; }
    }

    /// <summary>
    /// CONTROL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C270")]
    public class C270 : I_C270
    {
        /// <summary>
        /// Control qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6069", typeof(EDIFACT_ID_6069))]
        [Pos(1)]
        public string Controltotaltypecodequalifier_01 { get; set; }
        /// <summary>
        /// Control value
        /// </summary>
        [DataMember]
        [Required]
        [StringLength(1, 18)]
        [DataElement("6066", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Controlvalue_02 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1, 3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Measurementunitcode_03 { get; set; }
    }

    /// <summary>
    /// ITEM DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C273")]
    public class C273 : I_C273
    {

        /// <summary>
        /// Item description identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Itemdescriptionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Itemdescription_04 { get; set; }
        /// <summary>
        /// Item description
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Itemdescription_05 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Languagecoded_06 { get; set; }
    }

    /// <summary>
    /// QUANTITY DIFFERENCE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C279")]
    public class C279 : I_C279
    {

        /// <summary>
        /// Quantity difference
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Quantitydifference_01 { get; set; }
        /// <summary>
        /// Quantity qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Quantityqualifier_02 { get; set; }
    }

    /// <summary>
    /// RANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C280")]
    public class C280 : I_C280
    {
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(1)]
        public string Measurementunitcode_01 { get; set; }
        /// <summary>
        /// Range minimum
        /// </summary>
        [DataMember]
        [DataElement("6162", typeof(EDIFACT_N))]
        [StringLength(1, 18)]
        [Pos(2)]
        public string Rangeminimum_02 { get; set; }
        /// <summary>
        /// Range maximum
        /// </summary>
        [DataMember]
        [DataElement("6152", typeof(EDIFACT_N))]
        [StringLength(1, 18)]
        [Pos(3)]
        public string Rangemaximum_03 { get; set; }
    }

    /// <summary>
    /// PRODUCT GROUP
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C288")]
    public class C288 : I_C288
    {

        /// <summary>
        /// Product group, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Productgroupcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Product group
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Productgroup_04 { get; set; }
    }

    /// <summary>
    /// PATTERN DESCRIPTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C329")]
    public class C329 : I_C329
    {

        /// <summary>
        /// Frequency, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Frequencycoded_01 { get; set; }
        /// <summary>
        /// Despatch pattern, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Despatchpatterncoded_02 { get; set; }
        /// <summary>
        /// Despatch pattern timing, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Despatchpatterntimingcoded_03 { get; set; }
    }

    /// <summary>
    /// EXCESS TRANSPORTATION INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C401")]
    public class C401 : I_C401
    {
        /// <summary>
        /// Excess transportation reason, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8457", typeof(EDIFACT_ID_8457))]
        [Pos(1)]
        public string Excesstransportationreasoncoded_01 { get; set; }
        /// <summary>
        /// Excess transportation responsibility, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("8459", typeof(EDIFACT_ID_8459))]
        [Pos(2)]
        public string Excesstransportationresponsibilitycoded_02 { get; set; }
        /// <summary>
        /// Customer authorization number
        /// </summary>
        [DataMember]
        [StringLength(1, 17)]
        [DataElement("7130", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Customerauthorizationnumber_03 { get; set; }
    }

    /// <summary>
    /// PACKAGE TYPE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C402")]
    public class C402 : I_C402
    {

        /// <summary>
        /// Item description type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Itemdescriptiontypecoded_01 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Typeofpackages_02 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Itemnumbertypecoded_03 { get; set; }
        /// <summary>
        /// Type of packages
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Typeofpackages_04 { get; set; }
        /// <summary>
        /// Item number type, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Itemnumbertypecoded_05 { get; set; }
    }

    /// <summary>
    /// PERCENTAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C501")]
    public class C501 : I_C501
    {
        /// <summary>
        /// Percentage type code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5245", typeof(EDIFACT_ID_5245))]
        [Pos(1)]
        public string Percentagetypecodequalifier_01 { get; set; }
        /// <summary>
        /// Percentage
        /// </summary>
        [DataMember]
        [DataElement("5482", typeof(EDIFACT_N))]
        [StringLength(1,10)]
        [Pos(2)]
        public string Percentage_02 { get; set; }
        /// <summary>
        /// Percentage basis identification code
        /// </summary>
        [DataMember]
        [DataElement("5249", typeof(EDIFACT_ID_5249))]
        [Pos(3)]
        public string Percentagebasisidentificationcode_03 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(4)]
        public string Codelistidentificationcode_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(5)]
        public string Codelistresponsibleagencycode_05 { get; set; }
    }

    /// <summary>
    /// MEASUREMENT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C502")]
    public class C502 : I_C502
    {
        /// <summary>
        /// Measured attribute code
        /// </summary>
        [DataMember]
        [DataElement("6313", typeof(EDIFACT_ID_6313))]
        [Pos(1)]
        public string Measuredattributecode_01 { get; set; }
        /// <summary>
        /// Measurement significance, coded
        /// </summary>
        [DataMember]
        [DataElement("6321", typeof(EDIFACT_ID_6321))]
        [Pos(2)]
        public string Measurementsignificancecoded_02 { get; set; }
        /// <summary>
        /// Non-discrete measurement name code
        /// </summary>
        [DataMember]
        [DataElement("6155", typeof(EDIFACT_ID_6155))]
        [Pos(3)]
        public string Nondiscretemeasurementnamecode_03 { get; set; }
        /// <summary>
        /// Non-discrete measurement name
        /// </summary>
        [DataMember]
        [DataElement("6154", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Nondiscretemeasurementname_04 { get; set; }
    }

    /// <summary>
    /// DOCUMENT/MESSAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C503")]
    public class C503 : I_C503
    {
        /// <summary>
        /// Document/message number
        /// </summary>
        [DataMember]
        [DataElement("1004",typeof(EDIFACT_AN))]
        [StringLength(1,35)]
        [Pos(1)]
        public string Documentmessagenumber_01 { get; set; }
        /// <summary>
        /// Document/message status, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Documentmessagestatuscoded_02 { get; set; }
        /// <summary>
        /// Document/message source
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Documentmessagesource_03 { get; set; }
        /// <summary>
        /// Language, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Languagecoded_04 { get; set; }
    }

    /// <summary>
    /// CURRENCY DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C504")]
    public class C504 : I_C504
    {
        /// <summary>
        /// Currency details qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("6347",typeof(EDIFACT_ID_6347))]
        [Pos(1)]
        public string Currencydetailsqualifier_01 { get; set; }
        /// <summary>
        /// Currency identification code
        /// </summary>
        [DataMember]
        [StringLength(1,3)]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Currencyidentificationcode_02 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(3)]
        public string Currencyqualifier_03 { get; set; }
        /// <summary>
        /// Currency rate base
        /// </summary>
        [DataMember]
        [StringLength(1,4)]
        [DataElement("6348", typeof(EDIFACT_N))]
        [Pos(4)]
        public string Currencyratebase_04 { get; set; }
    }

    /// <summary>
    /// REFERENCE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C506")]
    public class C506 : I_C506
    {
        /// <summary>
        /// Reference function code qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("1153", typeof(EDIFACT_ID_1153))]
        [Pos(1)]
        public string Referencefunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Reference number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("1154", typeof(EDIFACT_AN))]
        [Pos(2)]
        public string Referenceidentifier_02 { get; set; }
        /// <summary>
        /// Line number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1156", typeof(EDIFACT_AN))]
        [Pos(3)]
        public string Linenumber_03 { get; set; }
        /// <summary>
        /// Reference version number
        /// </summary>
        [DataMember]
        [StringLength(1, 35)]
        [DataElement("4000", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Referenceversionnumber_04 { get; set; }
        /// <summary>
        /// Revision number
        /// </summary>
        [DataMember]
        [StringLength(1, 6)]
        [DataElement("1060", typeof(EDIFACT_AN))]
        [Pos(5)]
        public string Revisionnumber_05 { get; set; }
    }

    /// <summary>
    /// DATE/TIME/PERIOD
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C507")]
    public class C507 : I_C507
    {
        /// <summary>
        /// Date/time/period function code qualifier
        /// </summary>
        [DataMember]
        [DataElement("2005", typeof(EDIFACT_ID_2005))]
        [Required]
        [Pos(1)]
        public string Dateortimeorperiodfunctioncodequalifier_01 { get; set; }
        /// <summary>
        /// Date/time/period value
        /// </summary>
        [DataMember]
        [DataElement("2380", typeof(EDIFACT_AN))]
        [StringLength(1,35)]
        [Pos(2)]
        public string Dateortimeorperiodvalue_02 { get; set; }
        /// <summary>
        /// Date/time/period format code
        /// </summary>
        [DataMember]
        [DataElement("2379", typeof(EDIFACT_ID_2379))]
        [Pos(3)]
        public string Dateortimeorperiodformatcode_03 { get; set; }
    }

    /// <summary>
    /// PRICE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C509")]
    public class C509 : I_C509
    {
        /// <summary>
        /// Price qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5125", typeof(EDIFACT_ID_5125))]
        [Pos(1)]
        public string Pricequalifier_01 { get; set; }
        /// <summary>
        /// Price
        /// </summary>
        [DataMember]
        [StringLength(1,15)]
        [DataElement("5118", typeof(EDIFACT_N))]
        [Pos(2)]
        public string Price_02 { get; set; }
        /// <summary>
        /// Price type, coded
        /// </summary>
        [DataMember]
        [DataElement("5375", typeof(EDIFACT_ID_5375))]
        [Pos(3)]
        public string Pricetypecoded_03 { get; set; }
        /// <summary>
        /// Price type qualifier
        /// </summary>
        [DataMember]
        [DataElement("5387", typeof(EDIFACT_ID_5387))]
        [Pos(4)]
        public string Pricespecificationcode_04 { get; set; }
        /// <summary>
        /// Unit price basis
        /// </summary>
        [DataMember]
        [StringLength(1,9)]
        [DataElement("5284", typeof(EDIFACT_N))]
        [Pos(5)]
        public string Unitpricebasis_05 { get; set; }
        /// <summary>
        /// Measure unit qualifier
        /// </summary>
        [DataMember]
        [StringLength(1,3)]
        [DataElement("6411", typeof(EDIFACT_AN))]
        [Pos(6)]
        public string Measureunitcode_06 { get; set; }
    }

    /// <summary>
    /// MONETARY AMOUNT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C516")]
    public class C516 : I_C516
    {
        /// <summary>
        /// Monetary amount type qualifier
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("5025", typeof(EDIFACT_ID_5025))]
        [Pos(1)]
        public string Monetaryamounttypecodequalifier_01 { get; set; }
        /// <summary>
        /// Monetary amount
        /// </summary>
        [DataMember]
        [DataElement("5004", typeof(EDIFACT_N))]
        [StringLength(1,35)]
        [Pos(2)]
        public string Monetaryamountvalue_02 { get; set; }
        /// <summary>
        /// Currency, coded
        /// </summary>
        [DataMember]
        [DataElement("6345", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(3)]
        public string Currencyidentificationcode_03 { get; set; }
        /// <summary>
        /// Currency qualifier
        /// </summary>
        [DataMember]
        [DataElement("6343", typeof(EDIFACT_ID_6343))]
        [Pos(4)]
        public string Currencyqualifier_04 { get; set; }
        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [DataElement("4405", typeof(EDIFACT_ID_4405))]
        [Pos(5)]
        public string Statusdescriptioncoded_05 { get; set; }
    }

    /// <summary>
    /// LOCATION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C517")]
    public class C517 : I_C517
    {
        /// <summary>
        /// Location name code
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3225", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Locationnamecode_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Location name code
        /// </summary>
        [DataMember]
        [StringLength(1, 256)]
        [DataElement("3224", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Locationname_04 { get; set; }
    }

    /// <summary>
    /// RELATED LOCATION ONE IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C519")]
    public class C519 : I_C519
    {
        /// <summary>
        /// Related place/location one identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3223", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationoneidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Related place/location one
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3222", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationone_04 { get; set; }
    }

    /// <summary>
    /// INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C522")]
    public class C522 : I_C522
    {

        /// <summary>
        /// Instruction qualifier
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Instructionqualifier_01 { get; set; }
        /// <summary>
        /// Instruction, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Instructioncoded_02 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistqualifier_03 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistresponsibleagencycoded_04 { get; set; }
        /// <summary>
        /// Instruction
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Instruction_05 { get; set; }
    }

    /// <summary>
    /// NUMBER OF UNIT DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C523")]
    public class C523 : I_C523
    {
        /// <summary>
        /// Number of units
        /// </summary>
        [DataMember]
        [DataElement("6350", typeof(EDIFACT_N))]
        [StringLength(1,15)]
        [Pos(1)]
        public string Numberofunits_01 { get; set; }
        /// <summary>
        /// Unit type code qualifier
        /// </summary>
        [DataMember]
        [DataElement("6353", typeof(EDIFACT_ID_6353))]
        [Pos(2)]
        public string Unittypecodequalifier_02 { get; set; }
    }

    /// <summary>
    /// HANDLING INSTRUCTIONS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C524")]
    public class C524 : I_C524
    {
        /// <summary>
        /// Handling instructions, coded
        /// </summary>
        [DataMember]
        [DataElement("4079", typeof(EDIFACT_AN))]
        [StringLength(1, 3)]
        [Pos(1)]
        public string Handlinginstructionscoded_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Handling instructions
        /// </summary>
        [DataMember]
        [DataElement("4078", typeof(EDIFACT_AN))]
        [StringLength(1, 70)]
        [Pos(4)]
        public string Handlinginstructions_04 { get; set; }
    }

    /// <summary>
    /// COMMODITY/RATE DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C528")]
    public class C528 : I_C528
    {

        /// <summary>
        /// Commodity/rate identification
        /// </summary>
        [DataMember]
        [StringLength(1,18)]
        [DataElement("7357",typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Commodityrateidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// PACKAGING DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C531")]
    public class C531 : I_C531
    {

        /// <summary>
        /// Packaging level, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Packaginglevelcoded_01 { get; set; }
        /// <summary>
        /// Packaging related information, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Packagingrelatedinformationcoded_02 { get; set; }
        /// <summary>
        /// Packaging terms and conditions, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Packagingtermsandconditionscoded_03 { get; set; }
    }

    /// <summary>
    /// RETURNABLE PACKAGE DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C532")]
    public class C532 : I_C532
    {

        /// <summary>
        /// Returnable package freight payment responsibility, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Returnablepackagefreightpaymentresponsibilitycoded_01 { get; set; }
        /// <summary>
        /// Returnable package load contents, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Returnablepackageloadcontentscoded_02 { get; set; }
    }

    /// <summary>
    /// DUTY/TAX/FEE ACCOUNT DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C533")]
    public class C533 : I_C533
    {

        /// <summary>
        /// Duty/tax/fee account identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Dutytaxfeeaccountidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }

    /// <summary>
    /// PAYMENT INSTRUCTION DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C534")]
    public class C534 : I_C534
    {

        /// <summary>
        /// Payment conditions, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Paymentconditionscoded_01 { get; set; }
        /// <summary>
        /// Payment guarantee, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Paymentguaranteecoded_02 { get; set; }
        /// <summary>
        /// Payment means, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Paymentmeanscoded_03 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Codelistqualifier_04 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Codelistresponsibleagencycoded_05 { get; set; }
        /// <summary>
        /// Payment channel, coded
        /// </summary>
        [DataMember]
        [Pos(6)]
        public string Paymentchannelcoded_06 { get; set; }
    }

    /// <summary>
    /// CONTRACT AND CARRIAGE CONDITION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C536")]
    public class C536 : I_C536
    {

        /// <summary>
        /// Contract and carriage condition, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4065", typeof(EDIFACT_ID_4065))]
        [Pos(1)]
        public string Contractandcarriageconditioncode_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// TRANSPORT PRIORITY
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C537")]
    public class C537 : I_C537
    {
        /// <summary>
        /// Transport priority, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("4219", typeof(EDIFACT_ID_4219))]
        [Pos(1)]
        public string Transportprioritycoded_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// REQUIREMENT/CONDITION IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C550")]
    public class C550 : I_C550
    {

        /// <summary>
        /// Requirement/condition identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Requirementconditionidentification_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Requirement or condition
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Requirementorcondition_04 { get; set; }
    }

    /// <summary>
    /// ALLOWANCE/CHARGE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C552")]
    public class C552 : I_C552
    {

        /// <summary>
        /// Allowance or charge number
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Allowanceorchargenumber_01 { get; set; }
        /// <summary>
        /// Charge/allowance description, coded
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Chargeallowancedescriptioncoded_02 { get; set; }
    }

    /// <summary>
    /// RELATED LOCATION TWO IDENTIFICATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C553")]
    public class C553 : I_C553
    {

        /// <summary>
        /// Related place/location two identification
        /// </summary>
        [DataMember]
        [StringLength(1, 25)]
        [DataElement("3233", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Relatedplacelocationtwoidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
        /// <summary>
        /// Related place/location two
        /// </summary>
        [DataMember]
        [StringLength(1, 70)]
        [DataElement("3232", typeof(EDIFACT_AN))]
        [Pos(4)]
        public string Relatedplacelocationtwo_04 { get; set; }
    }

    /// <summary>
    /// RATE/TARIFF CLASS DETAIL
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C554")]
    public class C554 : I_C554
    {
        /// <summary>
        /// Rate/tariff class identification
        /// </summary>
        [DataMember]
        [DataElement("5243", typeof(EDIFACT_ID_5243))]
        [Pos(1)]
        public string Ratetariffclassidentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// STATUS EVENT
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C555")]
    public class C555 : I_C555
    {

        /// <summary>
        /// Status event, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statuseventcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status event
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Statusevent_04 { get; set; }
    }

    /// <summary>
    /// STATUS REASON
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C556")]
    public class C556 : I_C556
    {

        /// <summary>
        /// Status reason, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statusreasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Status reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Statusreason_04 { get; set; }
    }

    /// <summary>
    /// STATUS TYPE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C601")]
    public class C601 : I_C601
    {

        /// <summary>
        /// Status type, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statustypecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }

    /// <summary>
    /// NATURE OF CARGO
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C703")]
    public class C703 : I_C703
    {
        /// <summary>
        /// Nature of cargo, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("7085", typeof(EDIFACT_ID_7085))]
        [Pos(1)]
        public string Natureofcargocoded_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }

    /// <summary>
    /// TYPE OF MARKING
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C827")]
    public class C827 : I_C827
    {

        /// <summary>
        /// Type of marking, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Typeofmarkingcoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
    }

    /// <summary>
    /// SUB-LINE INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C829")]
    public class C829 : I_C829
    {

        /// <summary>
        /// Sub-line indicator, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Sublineindicatorcoded_01 { get; set; }
        /// <summary>
        /// Line item number
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Lineitemnumber_02 { get; set; }
    }

    /// <summary>
    /// PARTIES TO INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C849")]
    public class C849 : I_C849
    {

        /// <summary>
        /// Party enacting instruction identification
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Partyenactinginstructionidentification_01 { get; set; }
        /// <summary>
        /// Recipient of the instruction identification
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Recipientoftheinstructionidentification_02 { get; set; }
    }

    /// <summary>
    /// STATUS OF INSTRUCTION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C850")]
    public class C850 : I_C850
    {

        /// <summary>
        /// Status, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Statuscoded_01 { get; set; }
        /// <summary>
        /// Party name
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Partyname_02 { get; set; }
    }

    /// <summary>
    /// CHARACTERISTIC VALUE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C889")]
    public class C889 : I_C889
    {

        /// <summary>
        /// Characteristic value, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Characteristicvaluecoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Characteristicvalue_04 { get; set; }
        /// <summary>
        /// Characteristic value
        /// </summary>
        [DataMember]
        [Pos(5)]
        public string Characteristicvalue_05 { get; set; }
    }

    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C960")]
    public class C960 : I_C960
    {

        /// <summary>
        /// Change reason, coded
        /// </summary>
        [DataMember]
        [Pos(1)]
        public string Changereasoncoded_01 { get; set; }
        /// <summary>
        /// Code list qualifier
        /// </summary>
        [DataMember]
        [Pos(2)]
        public string Codelistqualifier_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, coded
        /// </summary>
        [DataMember]
        [Pos(3)]
        public string Codelistresponsibleagencycoded_03 { get; set; }
        /// <summary>
        /// Change reason
        /// </summary>
        [DataMember]
        [Pos(4)]
        public string Changereason_04 { get; set; }
    }

    /// <summary>
    /// REASON FOR CHANGE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Composite("C901")]
    public class C901 : I_C901
    {

        /// <summary>
        /// Change reason, coded
        /// </summary>
        [DataMember]
        [Required]
        [DataElement("9321", typeof(EDIFACT_AN))]
        [Pos(1)]
        public string Applicationerroridentification_01 { get; set; }
        /// <summary>
        /// Code list identification code
        /// </summary>
        [DataMember]
        [DataElement("1131", typeof(EDIFACT_ID_1131))]
        [Pos(2)]
        public string Codelistidentificationcode_02 { get; set; }
        /// <summary>
        /// Code list responsible agency, code
        /// </summary>
        [DataMember]
        [DataElement("3055", typeof(EDIFACT_ID_3055))]
        [Pos(3)]
        public string Codelistresponsibleagencycode_03 { get; set; }
    }
}
