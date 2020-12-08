﻿//---------------------------------------------------------------------
// This file is part of ediFabric
//
// Copyright (c) ediFabric. All rights reserved.
//
// THIS CODE AND INFORMATION ARE PROVIDED "AS IS" WITHOUT WARRANTY OF ANY
// KIND, WHETHER EXPRESSED OR IMPLIED, INCLUDING BUT NOT LIMITED TO THE
// IMPLIED WARRANTIES OF MERCHANTABILITY AND/OR FITNESS FOR A PARTICULAR
// PURPOSE.
//---------------------------------------------------------------------

using EdiWeave.Core.Annotations.Edi;
using System;
using System.Runtime.Serialization;

namespace EdiWeave.Core.Model.Edi.Edifact
{
    [Serializable()]
    public class EDIFACT_N
    {
    }

    [Serializable()]
    public class EDIFACT_A
    {
    }

    [Serializable()]
    public class EDIFACT_AN
    {
    }

    [Serializable()]
    public class EDIFACT_DT
    {
    }

    [Serializable()]
    public class EDIFACT_TM
    {
    }

    [Serializable()]
    [EdiCodes(",UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOX,UNOY,KECA,")]
    public class EDIFACT_ID_0001
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZZ,")]
    public class EDIFACT_ID_0133
    {
    }

    [Serializable()]
    [EdiCodes(",AA,BB,")]
    public class EDIFACT_ID_0025
    {
    }

    [Serializable()]
    [EdiCodes(",A,")]
    public class EDIFACT_ID_0029
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_0035
    {
    }

    [Serializable()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
        ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,5,6,7,8,9,")]
    public class EDIFACT_ID_0085
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_0083
    {
    }

    [Serializable()]
    [EdiCodes(",UCD,UCF,UCI,UCM,UCS,UGH,UGT,UIB,UIH,UIR,UIT,UIZ,UNB,UNE,UNG,UNH,UNO,UNP,UNS,UNT," +
        "UNZ,USA,USB,USC,USD,USE,USF,USH,USL,USR,UST,USU,USX,USY,")]
    public class EDIFACT_ID_0135
    {
    }

    [Serializable()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_0813
    {
    }


    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,CC,CE,EC,ED,EE,EN,ER,EU,EW,EX,IA,KE,LI,OD,RI,RT,UN,")]
    public class EDIFACT_ID_0051
    {
    }

    [Serializable()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,SECACK,SECAUT,")]
    public class EDIFACT_ID_0113
    {
    }

    [Serializable()]
    [EdiCodes(
        ",1,4,5,8,9,14,18,22,30,31,33,34,51,52,53,54,55,57,58,59,61,63,65,80,82,84,85,86,87,88,89,90,91,92,103,128,129,144,145,146,147,148,Z01,ZZZ,"
        )]
    public class EDIFACT_ID_0007
    {
    }

    [Serializable()]
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

    [Serializable()]
    [DataContract()]
    [EdiCodes(@",1,10,100,101,102,103,104,105,106,107,108,109,11,110,112,113,114,115,116,117,118,119,12,120,121,122,123,125,126,127,128,129,13,130,131,132,133,134,135,136,137,139,14,140,141,142,143,144,145,146,147,148,149,15,150,151,152,153,154,155,156,157,158,16,160,161,162,163,164,165,166,167,168,169,17,170,172,173,174,175,176,177,178,179,18,180,181,182,183,184,185,186,187,188,189,19,190,191,192,193,194,195,196,197,198,199,2,20,200,201,202,203,204,205,206,207,208,209,21,210,211,212,213,214,215,216,217,218,219,220,221,222,223,224,225,226,227,228,229,23,230,231,232,233,234,235,236,237,238,239,240,241,242,243,244,245,246,247,248,249,25,250,251,252,253,254,255,256,257,258,259,260,261,262,263,264,265,266,267,268,269,270,271,272,273,3,33,34,35,36,37,38,39,4,40,42,43,44,45,46,47,48,49,5,52,53,54,55,56,57,58,59,6,60,61,62,63,64,65,67,68,69,7,70,71,72,73,74,75,76,77,78,79,8,80,81,82,83,84,85,86,9,ZZZ,")]
    public class EDIFACT_ID_1131
    {
    }

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
    [EdiCodes(@",2,3,4,5,101,102,103,105,106,107,108,109,110,201,202,203,204,
                301,302,303,304,305,306,401,402,404,405,501,502,503,600,601,
                602,603,604,608,609,610,613,614,615,616,701,702,703,704,705,706,
                707,708,709,710,711,713,715,716,717,718,719,720,801,802,803,
                804,805,806,807,808,809,810,811,812,813,814,")]
    public class EDIFACT_ID_2379
    {
    }

}
