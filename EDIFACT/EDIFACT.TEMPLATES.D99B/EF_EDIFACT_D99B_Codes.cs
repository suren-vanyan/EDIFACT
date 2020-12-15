using EdiWeave.Core.Annotations.Edi;
using System;
using System.Runtime.Serialization;

namespace EDIFACT.TEMPLATES.D99B
{


    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117," +
    "118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,13" +
    "6,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154," +
    "155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,17" +
    "3,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191," +
    "192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21," +
    "210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,2" +
    "29,23,230,231,232,233,234,235,236,237,238,239,24,240,241,242,243,244,245,246,247" +
    ",248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,2" +
    "66,267,268,269,27,270,271,272,273,274,275,276,277,278,279,28,280,281,282,283,284" +
    ",285,286,287,288,289,29,290,291,292,293,294,295,296,297,298,299,3,30,300,301,302" +
    ",303,304,305,306,307,308,31,310,311,312,313,314,315,316,317,318,319,32,320,321,3" +
    "22,323,324,325,326,327,328,329,33,330,331,332,333,334,335,336,337,338,339,34,340" +
    ",341,342,343,344,345,346,347,348,349,35,350,351,352,353,354,355,356,357,36,37,37" +
    "0,38,380,381,382,383,384,385,386,387,388,389,39,390,393,394,395,396,397,398,399," +
    "4,40,400,401,402,403,404,405,409,41,412,42,425,426,427,428,429,43,430,431,435,44" +
    ",447,448,45,450,451,452,454,455,456,457,458,46,460,465,466,467,468,469,47,48,481" +
    ",485,49,490,491,492,493,5,50,51,52,520,53,530,54,55,550,56,57,575,58,580,59,6,60" +
    ",61,610,62,621,622,623,624,63,630,631,632,633,635,64,640,65,650,655,66,67,68,69," +
    "7,70,700,701,702,703,704,705,706,707,708,709,71,710,711,712,713,714,715,716,72,7" +
    "20,722,723,724,73,730,74,740,741,743,744,745,746,75,750,76,760,761,763,764,765,7" +
    "66,77,770,775,78,780,781,782,783,784,785,786,787,788,789,79,790,791,792,793,794," +
    "795,796,797,798,799,8,80,81,810,811,812,82,820,821,822,823,824,825,83,830,833,84" +
    ",840,841,85,850,851,852,853,855,856,86,860,861,862,863,864,865,87,870,88,89,890," +
    "895,896,9,90,901,91,910,911,913,914,915,916,917,92,925,926,927,929,93,930,931,93" +
    "2,933,934,935,936,937,938,94,940,941,95,950,951,952,953,954,955,96,960,961,962,9" +
    "63,964,965,966,97,98,99,990,991,995,996,998,")]
    public class EDIFACT_ID_1001
    {
    }

    /// <summary>
    /// Code list identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,112,113,114,115,116,117,118,119,12,120,121,122,123,125,126,127,128,129,13,130,131,132,133,134,135,136,137,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,16,160,161,162,163,164,165,166,167,168,169,17,170,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,220,221,222,223,224,225,226,227,228,229,23,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,271,272,273,3,33,34,35,36,37,38,39,4,40,42,43,44,45,46,47,48,49,5,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,9,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }

    /// <summary>
    /// Code list responsible agency code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,22,220,221,222,223,224,225,226,227,228,229,23,230,231,233,234,235,236,237,238,239,24,240,241,242,243,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,26,260,261,262,263,264,265,266,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3055
    {
    }

    /// <summary>
    /// Message function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,60,6,7,8,9,")]
    public class EDIFACT_ID_1225
    {
    }

    /// <summary>
    /// Response type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AP,AQ,AR,AS,CA,CO,NA,RE,UR,")]
    public class EDIFACT_ID_4343
    {
    }

    /// <summary>
    /// Contact function, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BU,CA,CB,CC,CD,CE,CF,CG,CN,CO,CP,CR,CW,DE,DI,DL,EB,EC,ED,EX,GR,HE,HG,HM,IC,IN,LB,LO,MC,MD,MH,MR,MS,NT,OC,PA,PD,PE,PM,QA,QC,RD,SA,SC,SD,SR,SU,TA,TD,TI,TR,WH,WI,WJ,ZZZ,")]
    public class EDIFACT_ID_3139
    {
    }

    /// <summary>
    /// Communication number code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,CA,EI,EM,EX,FT,FX,GM,IE,IM,MA,PB,PS,SW" +
    ",TE,TG,TL,TM,TT,TX,XF,")]
    public class EDIFACT_ID_3155
    {
    }

    /// <summary>
    /// Date/time/period function code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@"2,3,4,7,8,9,10,11,12,13,14,15,16,17,18,20,21,22,35,36,37,38,39,42,44,45,46,47,48,49,50,51,52,53,
              54,55,58,59,60,61,63,64,65,67,69,71,72,74,75,76,79,81,84,85,89,90,91,92,93,94,95,96,97,101,107,108,
              109,110,111,112,113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,128,129,130,131,132,133,
134,135,136,137,138,140,141,142,143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,158,159,160,161,162,163,
164,165,166,167,168,169,170,171,172,173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,188,189,190,191,192,
193,194,195,196,197,198,199,200,201,202,203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,218,219,221,222,
223,224,225,226,227,228,229,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,250,251,
252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,270,271,272,273,274,275,276,277,278,279,280,281,
282,283,284,285,286,287,288,289,290,291,292,293,294,295,296,297,298,299,300,301,302,303,304,305,306,307,308,309,310,
311,312,313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,328,329,330,331,332,333,334,335,336,337,338,339,
340,341,342,343,344,345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,361,362,363,364,365,366,367,368,
369,370,371,372,373,374,375,376,377,378,379,380,381,382,383,384,387,388,389,390,391,392,393,394,395,396,397,398,399,
400,401,402,403,404,405,406,407,408,409,410,411,412,413,414,415,416,417,418,419,420,421,422,423,424,425,426,427,428,
429,430,431,432,433,434,435,436,437,438,439,440,441,442,443,444,445,446,447,448,449,450,451,452,453,454,455,456,457,
458,459,460,461,462,463,464,465,466,467,468,469,470,471,472,473,474,475,476,477,478,479,480,481,482,483,484,485,486,
487,488,489,490,491,492,493,494,495,496,497,498,499,500,501,502,503,504,505,506,507,508,509,510,511,512,513,514,515,
516,517,518,519,520,521,522,523,524,525,526,527,528,529,530,531,532,533,534,535,536,537,538,539,540,541,542,543,544,
545,546,547,548,549,550,551,552,553,554,555,556,557,558,559,560,561,562,563,564,565,566,567,568,569,570,571,572,573,
574,575,576,577,578,579,580,581,582,583,584,585,586,587,588,589,590,591,592,593,594,596,597,598,599,600,601,602,603,
604,605,606,607,608,609,610,611,612,613,614,615,616,617,618,619,620,621,622,623,624,625,626,627,628,629,630,631,632,
633,634,635,636,637,638,639,640,641,642,643,644,645,646,647,648,649,650,651,652,653,654,655,656,657,658,659,660,661,
662,663,664,665,666,667,668,669,670,671,672,673,674,675,676,677,678,679,680,681,682,683,684,685,686,687,688,689,690,
691,692,693,694,695,696,697,698,699,700,701,702,703,704,705,706,707,708,709,710,711,712,713,714,715,716,717,718,719,
720,721,722,723,724,725,726,727,728,729,730,731,732,733,734,735,736,737,738,739,740,741,742,743,744,ZZZ,")]
    public class EDIFACT_ID_2005
    {
    }

    /// <summary>
    /// Date/time/period format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",2,3,4,5,101,102,103,105,106,107,108,109,110,201,202,203,204,
                301,302,303,304,305,306,401,402,404,405,501,502,503,600,601,
                602,603,604,608,609,610,613,614,615,616,701,702,703,704,705,706,
                707,708,709,710,711,713,715,716,717,718,719,720,801,802,803,
                804,805,806,807,808,809,810,811,812,813,814,")]
    public class EDIFACT_ID_2379
    {
    }

    /// <summary>
    /// Contract and carriage condition code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4065
    {
    }

    /// <summary>
    /// Service requirement code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,
                23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,
                37,38,39,4,40,41,42,43,44,6,7,8,9,")]
    public class EDIFACT_ID_7273
    {
    }

    /// <summary>
    /// Transport priority, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_4219
    {

    }

    /// <summary>
    /// Transport priority, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,28,29,30," +
        "31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,60," +
        "61,63,64,71,72,74,76,77,78,79,80,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100," +
        "101,102,103,104,105,")]
    public class EDIFACT_ID_4405
    {

    }

    /// <summary>
    /// PRODUCT ID. FUNCTION QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,12,")]
    public class EDIFACT_ID_4347
    {

    }


    /// <summary>
    /// OBJECT IDENTIFICATION CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV" +
        ",AW,AX,AY,AZ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT," +
        "BU,BV,BW,BX,BY,BZ,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CO,CP,CQ,CR," +
        "CS,CT,EE,EM,IL,ML,PN,SC,VV,")]
    public class EDIFACT_ID_7405
    {
    }

    /// <summary>
    /// Nature of cargo, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX," +
               "AY,AZ,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BR,BS,BT,BU,BV," +
               "BW,BX,BY,CC,CG,CL,CR,CV,DR,DW,EC,EF,EN,GB,GN,GS,HS,IB,IN,IS,IT,IZ,MA,MF," +
               "MN,MP,NB,ON,PD,PL,PO,PV,QS,RC,RN,RU,RY,SA,SG,SK,SN,SRS,SS,ST,TG,UA,UP,VN,VP," +
               "VS,VX,ZZZ,")]
    public class EDIFACT_ID_7143
    {
    }

    /// <summary>
    /// Nature of cargo, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_7085
    {
    }

    /// <summary>
    /// TEXT FORMATTING, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,2,3,4,5,6,7,8,9,")]
    public class EDIFACT_ID_4447
    {
    }


    /// <summary>
    /// TEXT SUBJECT CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,ACD,ACE,ACF,ACG,ACH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,ADB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AEN,AEO,AEP,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,AEZ,AFA,AFB,AFC,AFD,AFE,AFF,AFG,AFH,AFI,AFJ,AFK,AFL,AFM,AFN,AFO,AFP,AFQ,AFR,AFS,AFT,AFU,AFV,AFW,AFX,AFY,AFZ,AGA,AGB,AGC,AGD,AGE,AGF,AGG,AGH,AGI,AGJ,AGK,AGL,AGM,AGN,AGO,AGP,AGQ,AGR,AGS,AGT,AGU,AGV,AGW,AGX,AGY,AGZ,AHA,AHB,AHC,AHD,AHE,AHF,AHG,AHH,AHI,AHJ,AHK,AHL,AHM,AHN,AHO,AHP,AHQ,AHR,AHS,AHT,AHU,AHV,AHW,AHX,AHY,AHZ,AIA,AIB,AIC,AID,AIE,AIF,AIG,AIH,AII,AIJ,AIK,AIL,AIM,AIN,AIO,AIP,AIQ,AIR,AIS,AIT,AIU,AIV,AIW,AIX,AIY,AIZ,ALC,ALL,ARR,AUT,BLC,BLR,CCI,CEX,CHG,CIP,CLP,CLR,COI,CUR,CUS,DAR,DCL,DEL,DIN,DOC,DUT,EUR,FBC,GBL,GEN,GS7,HAN,HAZ,ICN,IIN,IMI,IND,INS,INV,IRP,ITR,ITS,LIN,LOI,MCO,MKS,ORI,OSI,PAC,PAI,PAY,PKG,PKT,PMD,PMT,PRD,PRF,PRI,PUR,QIN,QQD,QUT,RAH,REG,RET,REV,RQR,RQT,SAF,SIC,SIN,SLR,SPA,SPG,SPH,SPP,SPT,SRN,SSR,SUR,TCA,TDT,TRA,TRR,TXD,WHI,ZZZ,")]
    public class EDIFACT_ID_4451
    {
    }

    /// <summary>
    /// TEXT FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_4453
    {
    }

    /// <summary>
    /// Charge category code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,")]
    public class EDIFACT_ID_5237
    {
    }

    /// <summary>
    /// Control total type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,6,7,8,9,")]
    public class EDIFACT_ID_6069
    {
    }

    /// <summary>
    /// LOCATION FUNCTION CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,111,112,113,114,115,116,117,118,119,12,120,121,122,123,124,125,126,127,128,129,13,130,131,132,133,134,135,136,137,138,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,159,16,160,161,162,163,164,165,166,167,168,169,17,170,171,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,87,88,89,9,90,91,92,93,94,95,96,97,98,99,ZZZ,")]
    public class EDIFACT_ID_3227
    {
    }


    /// <summary>
    /// LOCATION FUNCTION CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT," +
    "AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,ABK,ABL,ABM,ABN," +
    "ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,AC,ACA,ACB,ACC,ACD,ACE,ACF,ACG,A" +
    "CH,ACI,ACJ,ACK,ACL,ACM,ACN,ACO,ACP,ACQ,ACR,ACS,ACT,ACU,ACV,ACW,ACX,ACY,ACZ,ADA,A" +
    "DB,ADC,ADD,ADE,ADF,ADG,ADH,ADI,ADJ,ADK,ADL,ADM,ADN,ADO,ADP,ADQ,ADR,ADS,ADT,ADU,A" +
    "DV,ADW,ADY,ADZ,AE,AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEL,AEM,AEN,AEO,AE" +
    "P,AEQ,AER,AES,AET,AEU,AEV,AEW,AEX,AEY,AEZ,AF,AFA,AFB,AFC,AFD,AFE,AFF,AFG,AFH,AFI" +
    ",AFJ,AFK,AFL,AFM,AFN,AFO,AFP,AFQ,AFR,AFS,AFT,AFU,AFV,AFW,AFX,AFY,AFZ,AGA,AGB,AGC" +
    ",AGD,AGE,AGF,AGG,AGH,AGI,AGJ,AGK,AGL,AGM,AGN,AGO,AGP,AGQ,AGR,AGS,AGT,AGU,AGV,AGW" +
    ",AGX,AGY,AGZ,AHA,AHB,AHC,AHD,AHE,AHF,AHG,AHH,AHI,AHJ,AHK,AHL,AHM,AHN,AHO,AHP,AHQ" +
    ",AHR,AHS,AHT,AHU,AHV,AHW,AHX,AHY,AHZ,AIA,AIB,AIC,AID,AIE,AIF,AIG,AIH,AII,AIJ,AIK" +
    ",AIL,AIM,AIN,AIO,AIP,AIQ,AIR,AIS,AIT,AIU,AIV,AIW,AIX,AIY,AIZ,AJA,AJB,AJC,AJD,AJE" +
    ",AJF,AJG,AJH,AJI,AJJ,AJK,AJL,AJM,AJN,AJO,AJP,AJQ,AJR,AJS,AJT,AJU,AJV,AJW,AJX,AJY" +
    ",AJZ,AKA,AKB,AKC,AKD,AKE,AKF,AKG,AKH,AKI,AKJ,AKK,AKL,AKM,AKN,AKO,AKP,AKQ,AKR,AKS" +
    ",AKT,AKU,AKV,AKW,AKX,AKY,AKZ,ALA,ALB,ALC,ALD,ALE,ALF,ALG,ALH,ALI,ALJ,ALK,ALL,ALM" +
    ",ALN,ALO,ALP,ALQ,ALR,ALS,ALT,ALU,ALV,ALW,ALX,ALY,ALZ,AMA,AMB,AMC,AMD,AME,AMF,AMG" +
    ",AMH,AMI,AMJ,AMK,AML,AMM,AMN,AMO,AMP,AMQ,AMR,AMS,AMT,AMU,AMV,AMW,AMX,AMY,AMZ,ANA" +
    ",ANB,ANC,AND,ANE,ANF,ANG,ANH,ANI,ANJ,ANK,ANL,ANM,ANN,ANO,ANP,ANQ,ANR,ANS,ANT,ANU" +
    ",ANV,ANW,ANX,ANY,ANZ,AOA,AOB,AOC,AOD,AOE,AOF,AOG,AOH,AOI,AOJ,AOK,AOL,AOM,AON,AOO" +
    ",AOP,AOQ,AOR,AOS,AOT,AOU,AOV,AOW,AOX,AOY,AOZ,AP,APA,APB,APC,APD,APE,APF,APG,APH," +
    "API,APJ,APK,APL,APM,APN,APO,APP,APQ,APR,APS,APT,APU,APV,APW,APX,APY,APZ,AQA,AQB," +
    "AQC,AQD,AQE,AQF,AQG,AQH,AQI,AQJ,AQK,AQL,AQM,AQN,AQO,AQP,AQQ,AQR,AQS,AQT,AQU,AQV," +
    "AQW,AQX,AQY,AQZ,ARA,ARB,ARC,ARD,ARE,ARF,ARG,ARH,ARI,ARJ,ARK,ARL,ARM,ARN,ARO,ARP," +
    "ARQ,ARR,ARS,ART,ARU,ARV,ARW,ARX,ARY,ARZ,ASA,ASB,ASC,ASD,ASE,ASF,ASG,ASH,ASI,ASJ," +
    "ASK,ASL,ASM,ASN,ASO,ASP,ASQ,ASR,ASS,AST,ASU,ASV,ASW,ASX,ASY,ASZ,ATA,ATB,ATC,ATD," +
    "ATE,ATF,ATG,ATH,ATI,ATJ,ATK,ATL,ATM,ATN,ATO,ATP,ATQ,ATR,ATS,ATT,ATU,ATV,ATW,ATX," +
    "ATY,ATZ,AU,AUA,AV,AWA,AWB,AWC,AWD,AWE,AWF,AWG,AWH,AWI,BA,BC,BD,BE,BH,BM,BN,BO,BR" +
    ",BT,BW,CAS,CD,CEC,CFE,CFO,CG,CH,CK,CKN,CM,CMR,CN,CNO,CO,COF,CP,CR,CRN,CS,CST,CT," +
    "CU,CV,CW,CZ,DA,DAN,DB,DI,DL,DM,DQ,DR,EA,EB,ED,EE,EI,EN,EP,EQ,ER,ERN,ET,EX,FC,FF," +
    "FI,FLW,FN,FO,FS,FT,FV,FX,GA,GC,GD,GDN,GN,HS,HWB,IA,IB,ICA,ICE,ICO,II,IL,INB,INN," +
    "INO,IP,IS,IT,IV,JB,JE,LA,LAN,LAR,LB,LC,LI,LO,LS,MA,MB,MF,MG,MH,MR,MRN,MS,MSS,MWB" +
    ",NA,OH,OI,ON,OP,OR,PB,PC,PD,PE,PF,PI,PK,PL,POR,PP,PQ,PR,PS,PW,PY,RA,RC,RCN,RE,RE" +
    "N,RF,RR,RT,SA,SB,SD,SE,SF,SH,SI,SM,SN,SP,SQ,SRN,SS,STA,SW,SZ,TB,TE,TF,TI,TL,TN,T" +
    "P,UAR,UC,UCN,UN,UO,VA,VC,VM,VN,VON,VP,VR,VS,VT,VV,WE,WM,WN,WR,WS,WY,XA,XC,XP,ZZZ" +
    ",")]
    public class EDIFACT_ID_1153
    {
    }


    /// <summary>
    /// Prepaid/collect indicator, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,B,C,P,")]
    public class EDIFACT_ID_4237
    {
    }

    /// <summary>
    /// Rate/tariff class identification
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,B,C,D,E,F,K,M,N,Q,R,S,")]
    public class EDIFACT_ID_5243
    {
    }

    /// <summary>
    /// TRANSPORT STAGE CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,30,31,32,33,")]
    public class EDIFACT_ID_8051
    {
    }


    /// <summary>
    /// Transport means description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34,35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,49,5,50,51,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,66,67,68,69,7,70,71,72,73,74,")]
    public class EDIFACT_ID_8179
    {
    }


    /// <summary>
    /// TRANSIT DIRECTION INDICATOR CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",BS,SB,SC,SD,SF,SS,ST,SU,ZZZ,")]
    public class EDIFACT_ID_8101
    {
    }

    /// <summary>
    /// Excess transportation reason, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,C,D,E,F,G,H,I,J,K,L,M,N,P,R,T,U,V,W,X,Y,ZZZ,")]
    public class EDIFACT_ID_8457
    {
    }

    /// <summary>
    /// Excess transportation responsibility, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,B,S,X,ZZZ,")]
    public class EDIFACT_ID_8459
    {
    }

    /// <summary>
    /// TRANSPORT OWNERSHIP, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,")]
    public class EDIFACT_ID_8281
    {
    }


    /// <summary>
    /// PARTY FUNCTION CODE QUALIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,AT,AU,AV,AW,AX,AY,
                AZ,B1,B2,BA,BB,BC,BD,BE,BF,BG,BH,BI,BJ,BK,BL,BM,BN,BO,BP,BQ,BS,BT,BU,
                BV,BW,BX,BY,BZ,C1,C2,CA,CB,CC,CD,CE,CF,CG,CH,CI,CJ,CK,CL,CM,CN,CNX,CNY,
                CNZ,CO,COA,COB,COC,COD,COE,COF,COG,COH,COI,COJ,COK,COL,COM,CON,COO,COP,
                COQ,COR,COS,COT,COU,COV,COW,COX,COY,COZ,CP,CPA,CPB,CPC,CPD,CPE,CPF,CPG,
                CQ,CR,CS,CT,CU,CV,CW,CX,CY,CZ,DA,DB,DC,DCP,DD,DE,DF,DG,DH,DI,DJ,DK,DL,DM,
                DN,DO,DP,DQ,DR,DS,DT,DU,DV,DW,DX,DY,DZ,EA,EB,EC,ED,EE,EF,EG,EH,EI,EJ,EK,
                EL,EM,EN,EO,EP,EQ,ER,ES,ET,EU,EV,EW,EX,EY,EZ,FA,FB,FC,FD,FE,FF,FG,FH,FI,
                FJ,FK,FL,FM,FN,FO,FP,FQ,FR,FS,FT,FU,FV,FW,FX,FY,FZ,GA,GB,GC,GD,GE,GF,GG,
                GH,GI,GJ,GK,GL,GM,GN,GO,GP,GQ,GR,GS,GT,GU,GV,GW,GX,GY,GZ,HA,HB,HC,HD,HE,
                HF,HG,HH,HI,HJ,HK,HL,HM,HN,HO,HP,HQ,HR,HS,HT,HU,HV,HW,HX,HY,HZ,I1,I2,IB,
                IC,ID,IE,IF,IG,IH,II,IJ,IL,IM,IN,IO,IP,IQ,IR,IS,IT,IU,IV,IW,IX,IY,IZ,LA,
                LB,LC,LD,LE,LF,LG,LH,LI,LJ,LK,LL,LM,LN,LO,LP,LQ,LR,LS,LT,LU,LV,MA,MF,MG,
                MI,MP,MR,MS,MT,N1,N2,NI,OA,OB,OC,OD,OE,OF,OG,OH,OI,OJ,OK,OL,OM,ON,OO,OP,
                OQ,OR,OS,OT,OU,OV,OW,OX,OY,OZ,P1,P2,P3,P4,PA,PB,PC,PD,PE,PF,PG,PH,PI,PJ,
                PK,PL,PM,PN,PO,PQ,PR,PS,PT,PW,PX,PY,PZ,RA,RB,RE,RF,RH,RI,RL,RM,RP,RS,RV,
                RW,SB,SE,SF,SG,SI,SK,SN,SO,SR,SS,ST,SU,SX,SY,SZ,TA,TB,TC,TCP,TD,TE,TF,TG,
                TH,TI,TJ,TK,TL,TM,TN,TO,TP,TQ,TR,TS,TT,TU,TV,TW,TX,TY,TZ,UA,UB,UC,UD,UE,
                UF,UG,UH,UHP,UI,UJ,UK,UL,UM,UN,UO,UP,UQ,UR,US,UT,UU,UV,UW,UX,UY,UZ,VA,VB,
                VC,VE,VF,VG,VH,VI,VJ,VK,VL,VM,VN,VO,VP,VQ,VR,VS,VT,VU,VV,VW,VX,VY,VZ,WA,
                WB,WC,WD,WE,WF,WG,WH,WI,WJ,WK,WL,WM,WN,WO,WP,WPA,WQ,WR,WS,WT,WU,WV,WW,XX,ZZZ,,")]
    public class EDIFACT_ID_3035
    {
    }


    /// <summary>
    /// Party name format code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_3045
    {
    }

    /// <summary>
    /// TRANSPORT CHARGES PAYMENT METHOD CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,AA,AB,AC,AD,CA,CC,CF,DF,FO,IC,MX,NC,NS,PA,PB,PC,PE,PO,PP,PU,RC,RF,RS,TP,WC,ZZZ,")]
    public class EDIFACT_ID_4215
    {
    }

    /// <summary>
    /// Delivery or transport terms description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_4053
    {
    }

    /// <summary>
    /// TERMS OF DELIVERY OR TRANSPORT FUNCTION, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,")]
    public class EDIFACT_ID_4055
    {
    }

    /// <summary>
    /// Packaging related description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,
               50,51,52,53,54,55,56,57,58,59,60,61,62,63,66,67,68,69,
               70,71,72,73,74,75,76,77,")]
    public class EDIFACT_ID_7233
    {
    }

    /// <summary>
    /// Movement type description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,
                19,20,21,22,23,31,32,33,41,42,43,44,45,46,47,")]
    public class EDIFACT_ID_8335
    {
    }

    /// <summary>
    /// Movement type description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,")]
    public class EDIFACT_ID_8341
    {
    }

    /// <summary>
    /// Percentage type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,
               28,29,30,31,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,49,50,51,52,
               53,54,55,56,57,58,59,60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,
               78,79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,98,99,100,101,
               102,103,104,105,106,107,108,109,110,111,112,113,114,115,116,117,118,119,120,
               121,122,123,124,125,126,127,128,129,130,131,132,133,134,135,136,137,138,139,
               140,141,142,143,144,145,")]
    public class EDIFACT_ID_5245
    {
    }


    /// <summary>
    /// Percentage basis identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,")]
    public class EDIFACT_ID_5249
    {
    }

    /// <summary>
    /// Monetary amount type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,
               22,23,24,25,26,27,28,29,30,31,32,33,34,35,36,37,38,39,40,
               41,42,43,44,45,46,47,48,49,50,51,52,53,54,55,56,57,58,59,
               60,61,62,63,64,65,66,67,68,69,70,71,72,73,74,75,76,77,78,
               79,80,81,82,83,84,85,86,87,88,89,90,91,92,93,94,95,96,97,
               98,99,100,101,102,103,104,105,106,107,108,109,110,111,112,
               113,114,115,116,117,118,119,120,121,122,123,124,125,126,127,
               128,129,130,131,132,133,134,135,136,137,138,139,140,141,142,
               143,144,145,146,147,148,149,150,151,152,153,154,155,156,157,
               158,159,160,161,162,163,164,165,166,167,168,169,170,171,172,
               173,174,175,176,177,178,179,180,181,182,183,184,185,186,187,
               188,189,190,191,192,193,194,195,196,197,198,199,200,201,202,
               203,204,205,206,207,208,209,210,211,212,213,214,215,216,217,
               218,219,220,221,222,223,224,225,226,227,228,229,230,231,232,
               233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,
               249,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,
               265,266,267,268,269,270,271,272,273,274,275,276,277,278,279,280,
               281,282,283,284,285,286,287,288,289,290,291,292,293,294,295,296,
               297,298,299,300,301,302,303,304,305,306,307,308,309,310,311,312,
               313,314,315,316,317,318,319,320,321,322,323,324,325,326,327,328,
               329,330,331,332,333,334,335,336,337,338,339,340,341,342,343,344,
               345,346,347,348,349,350,351,352,353,354,355,356,357,358,359,360,
               361,362,363,364,365,366,367,368,369,370,371,372,373,374,375,376,
               377,378,379,380,381,382,383,384,385,386,387,388,389,390,391,392,
               393,394,395,396,397,398,399,400,401,402,403,404,405,406,407,408,
               409,410,411,412,413,414,415,416,417,418,419,420,421,422,423,424,
               425,426,427,428,429,430,431,432,433,434,435,436,437,438,439,440,
               441,442,443,444,445,446,447,448,449,450,451,452,453,454,455,456,
               457,458,459,460,461,462,463,464,465,466,467,468,469,470,471,472,
               473,474,475,476,477,478,479,480,481,482,483,484,485,486,487,488,
               489,490,491,492,493,494,495,ZZZ,")]
    public class EDIFACT_ID_5025
    {
    }

    /// <summary>
    /// Price qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,CAL,INF,INV,")]
    public class EDIFACT_ID_5125
    {
    }

    /// <summary>
    /// Price type, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AA,AB,AC,AD,AE,AI,AQ,CA,CT,CU,DI,EC,NW,PC,PE,PK,PL,PT,PU,PV,PW,QT,SR,TB,TU,TW,WH,")]
    public class EDIFACT_ID_5375
    {
    }

    /// <summary>
    /// Percentage basis identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,I,S,")]
    public class EDIFACT_ID_5213
    {
    }

    /// <summary>
    /// Percentage basis identification code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,
                AAM,AAN,AAO,AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,
                AAY,AAZ,ABA,ABB,ABC,ABD,ABE,ABF,ABG,ABH,ABI,ABJ,
                ABK,ABL,ABM,ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,
                AI,ALT,AP,BR,CAT,CDV,CON,CP,CU,CUP,CUS,DAP,DIS,
                DPR,DR,DSC,EC,ES,EUP,FCR,GRP,INV,LBL,MAX,MIN,MNR,
                MSR,MXR,NE,NQT,NTP,NW,OCR,OFR,PAQ,PBQ,PPD,PPR,PRO,
                PRP,PW,QTE,RES,RTP,SHD,SRP,SW,TB,TRF,TU,TW,WH,")]
    public class EDIFACT_ID_5387
    {
    }

    /// <summary>
    /// MEASUREMENT ATTRIBUTE CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAC,AAD,AAE,AAF,AAG,AAH,AAI,AAJ,AAK,AAL,AAM,AAN,AAO,AAP,
               AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABI,ABJ,ABK,ABL,ABM,
               ABN,ABO,ABP,ABQ,ABR,ABS,ABT,ABU,ABV,ABW,ABX,ABY,ABZ,ACA,ACB,ACC,
               ACD,ACE,ACF,ACG,ACH,ASW,ASX,ASY,ASZ,ATA,ATB,ATC,ATD,ATE,CH,CHW,
               CN,CS,CT,DEN,DT,DV,DX,EN,FO,IV,LAO,LC,LGL,LL,LMT,PAL,PC,PD,PL,
               PLL,RL,SE,SH,SM,SO,SR,ST,SU,SV,TE,TL,TR,VOL,WT,WX,,")]
    public class EDIFACT_ID_6311
    {
    }

    /// <summary>
    /// Measured attribute code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",A,AAA,AAB,AAC,AAD,AAE,AAF,AAJ,AAK,AAL,AAM,AAN,AAO,
                AAP,AAQ,AAR,AAS,AAT,AAU,AAV,AAW,AAX,AAY,AAZ,ABA,ABB,
                ABC,ABD,ABE,ABJ,ABS,ABX,ABY,ABZ,ACA,ACE,ACG,ACN,ACP,
                ACS,ACV,ACW,ACX,ADR,ADS,ADT,ADU,ADV,ADW,ADX,ADY,ADZ,
                AEA,AEB,AEC,AED,AEE,AEF,AEG,AEH,AEI,AEJ,AEK,AEM,AEN,
                AEO,AEP,AEQ,AER,AET,AEU,AEV,AEW,AEX,AEY,AEZ,AF,AFA,
                AFB,AFC,AFD,AFE,AFF,B,BL,BMY,BMZ,BNA,BNB,BNC,BND,BNE,
                BNF,BNG,BNH,BNI,BNJ,BNK,BNL,BNM,BNN,BNO,BNP,BNQ,BNR,
                BNS,BNT,BR,BRA,BRE,BS,BSW,BW,CHN,CM,CT,CV,CZ,D,DI,DL,
                DN,DP,DR,DS,DW,E,EA,F,FI,FL,FN,FV,G,GG,GW,HF,HM,HT,
                IB,ID,L,LM,LN,LND,M,MO,MW,N,OD,PRS,PTN,RA,RF,RJ,RMW,
                RP,RUN,RY,SQ,T,TC,TH,TN,TT,U,VH,VW,WA,WD,WM,WT,WU,XH,
                XQ,XZ,YS,ZAL,ZAS,ZB,ZBI,ZC,ZCA,ZCB,ZCE,ZCL,ZCO,ZCR,
                ZCU,ZFE,ZFS,ZGE,ZH,ZK,ZMG,ZMN,ZMO,ZN,ZNA,ZNB,ZNI,ZO,
                ZP,ZPB,ZS,ZSB,ZSE,ZSI,ZSL,ZSN,ZTA,ZTE,ZTI,ZV,ZW,ZWA,
                ZZN,ZZR,ZZZ,")]
    public class EDIFACT_ID_6313
    {
    }

    /// <summary>
    /// Measurement significance, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",3,4,5,6,7,8,10,11,12,13,15,")]
    public class EDIFACT_ID_6321
    {
    }

    /// <summary>
    /// Unit type code qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_6353
    {
    }

    /// <summary>
    /// Non-discrete measurement name code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20,21,22,23,24,25,26,27,
               28,29,32,33,34,35,36,37,38,39,40,41,42,43,44,45,46,47,48,")]
    public class EDIFACT_ID_6155
    {
    }

    /// <summary>
    /// EXCHANGE RATE CURRENCY MARKET IDENTIFIER
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",AAA,AAB,AMS,ARG,AST,AUS,BEL,CAN,CAR,CIE,DEN,ECR,FIN,FRA,IMF,LNF,LNS,MIL,NOR,NYC,PHI,SRE,SWE,ZUR,")]
    public class EDIFACT_ID_6341
    {
    }

    /// <summary>
    /// Currency qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,")]
    public class EDIFACT_ID_6343
    {
    }

    /// <summary>
    /// Currency details qualifier
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_6347
    {
    }


    /// <summary>
    /// SURFACE/LAYER CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1S,2S,AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,
              BC,BS,BT,DF,FR,IN,LE,OA,OS,OT,RI,RR,ST,TB,TP,TS,UC,")]
    public class EDIFACT_ID_7383
    {
    }

    /// <summary>
    /// DANGEROUS GOODS REGULATIONS CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",ADR,ADS,ADT,ADU,AGS,ANR,ARD,CFR,COM,GVE,GVS,ICA,IMD,RGE,RID,TEC,UI,ZZZ,99A,99B,")]
    public class EDIFACT_ID_8273
    {
    }

    /// <summary>
    /// Equipment size and type description code
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,
                19,20,21,22,23,31,32,33,41,42,43,44,45,")]
    public class EDIFACT_ID_8155
    {
    }

    /// <summary>
    /// EQUIPMENT SUPPLIER, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,")]
    public class EDIFACT_ID_8077
    {
    }

    /// <summary>
    /// EQUIPMENT STATUS CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,14,")]
    public class EDIFACT_ID_8249
    {
    }

    /// <summary>
    /// FULL/EMPTY INDICATOR, CODED
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_8169
    {
    }

    /// <summary>
    /// TRANSPORT MOVEMENT CODE
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,")]
    public class EDIFACT_ID_8323
    {
    }

    /// <summary>
    /// Government agency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,")]
    public class EDIFACT_ID_9415
    {
    }

    /// <summary>
    /// Government involvement, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,")]
    public class EDIFACT_ID_9411
    {
    }

    /// <summary>
    /// Government action, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,")]
    public class EDIFACT_ID_9417
    {
    }

    /// <summary>
    /// Government procedure, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,2,3,4,5,6,7,8,9,10,11,12,13,")]
    public class EDIFACT_ID_9353
    {
    }
}
