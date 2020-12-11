//---------------------------------------------------------------------
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
    [DataContract()]
    public class EDIFACT_N
    {
    }

    [Serializable()]
    [DataContract()]
    public class EDIFACT_A
    {
    }

    [Serializable()]
    [DataContract()]
    public class EDIFACT_AN
    {
    }

    [Serializable()]
    [DataContract()]
    public class EDIFACT_DT
    {
    }

    [Serializable()]
    [DataContract()]
    public class EDIFACT_TM
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",UNOA,UNOB,UNOC,UNOD,UNOE,UNOF,UNOG,UNOH,UNOI,UNOJ,UNOX,UNOY,KECA,")]
    public class EDIFACT_ID_0001
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,ZZZ,")]
    public class EDIFACT_ID_0133
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,BB,")]
    public class EDIFACT_ID_0025
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",A,")]
    public class EDIFACT_ID_0029
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,")]
    public class EDIFACT_ID_0035
    {
    }

    /// <summary>
    /// Message version number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,4,88,89,90,D,S,")]
    public class EDIFACT_ID_0052
    {
    }

    /// <summary>
    /// Message release number
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,902,911,912,921,932,93A,94A,94B,95A,95B,96A,96B,97A,97B,98A,98B,99A,99B,")]
    public class EDIFACT_ID_0054
    {
    }

    /// <summary>
    /// Message type
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(@",APERAK,AUTACK,AUTHOR,AVLREQ,AVLRSP,BALANC,BANSTA,
                BAPLIE,BAPLTE,BMISRM,BOPBNK,BOPCUS,BOPDIR,BOPINF,
                BUSCRD,CALINF,CASINT,CASRES,CHACCO,CLASET,CNTCND,
                COACSU,COARRI,CODECO,CODENO,COEDOR,COHAOR,COLREQ,
                COMDIS,CONAPW,CONDPV,CONDRA,CONDRO,CONEST,CONITT,
                CONPVA,CONQVA,CONRPW,CONTEN,CONTRL,CONWQD,COPARN,
                COPAYM,COPINO,COPRAR,COREOR,COSTCO,COSTOR,CREADV,
                CREEXT,CREMUL,CUSCAR,CUSDEC,CUSEXP,CUSPED,CUSREP,
                CUSRES,DEBADV,DEBMUL,DEBREC,DELFOR,DELJIT,DESADV,
                DESTIM,DGRECA,DIRDEB,DIRDEF,DMRDEF,DMSTAT,DOCADV,
                DOCAMA,DOCAMI,DOCAMR,DOCAPP,DOCARE,DOCINF,ENTREC,
                FINCAN,FINPAY,FINSTA,GENRAL,GESMES,HANMOV,IFCSUM,
                IFTCCA,IFTDGN,IFTFCC,IFTIAG,IFTMAN,IFTMBC,IFTMBF,
                IFTMBP,IFTMCA,IFTMCS,IFTMIN,IFTRIN,IFTSAI,IFTSTA,
                IFTSTQ,IHCLME,IMPDEF,INFENT,INSDES,INSPRE,INSREQ,
                INSRPT,INVOIC,INVRPT,IPPOMO,ITRRPT,JAPRES,JINFDE,
                JOBAPP,JOBCON,JOBMOD,JOBOFF,JUPREQ,KEYMAN,LEDGER,
                LREACT,LRECLM,MEDPID,MEDPRE,MEDREQ,MEDRPT,MEDRUC,
                MEQPOS,MOVINS,MSCONS,ORDCHG,ORDERS,ORDRSP,OSTENQ,
                OSTRPT,PARTIN,PASREQ,PASRSP,PAXLST,PAYDUC,PAYEXT,
                PAYMUL,PAYORD,PRICAT,PRIHIS,PROCST,PRODAT,PRODEX,
                PROINQ,PROTAP,PRPAID,QALITY,QUOTES,RDRMES,REBORD,
                RECADV,RECALC,RECECO,RECLAM,REGENT,REMADV,REPREM,
                REQDOC,REQOTE,RESETT,RESMSG,RESREQ,RESRSP,RETACC,
                RETANN,RETINS,SAFHAZ,SANCRT,SLSFCT,SLSRPT,SOCADE,
                SSIMOD,SSRECH,SSREGW,STATAC,STLRPT,SUPCOT,SUPMAN,
                SUPRES,TANSTA,TAXCON,TIQREQ,TIQRSP,VATDEC,VESDEP,
                WASDIS,WKGRDC,WKGRRE,,")]
    public class EDIFACT_ID_0065
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,10,11,12,13,14,15,16,17,18,19,2,20,21,22,23,24,25,26,27,28,29,3,30,31,32,33,34" +
    ",35,36,37,38,39,4,40,41,42,43,44,45,46,47,48,5,6,7,8,9,")]
    public class EDIFACT_ID_0085
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,3,4,5,6,7,8,")]
    public class EDIFACT_ID_0083
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",UCD,UCF,UCI,UCM,UCS,UGH,UGT,UIB,UIH,UIR,UIT,UIZ,UNB,UNE,UNG,UNH,UNO,UNP,UNS,UNT," +
    "UNZ,USA,USB,USC,USD,USE,USF,USH,USL,USR,UST,USU,USX,USY,")]
    public class EDIFACT_ID_0135
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",1,2,")]
    public class EDIFACT_ID_0813
    {
    }

    /// <summary>
    /// Controlling agency, coded
    /// </summary>
    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,CC,CE,EC,ED,EE,EN,ER,EU,EW,EX,IA,KE,LI,OD,RI,RT,UN,")]
    public class EDIFACT_ID_0051
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(",AA,AB,AC,AD,AE,AF,AG,AH,AI,AJ,AK,AL,AM,AN,AO,AP,AQ,AR,AS,SECACK,SECAUT,")]
    public class EDIFACT_ID_0113
    {
    }

    [Serializable()]
    [DataContract()]
    [EdiCodes(
        ",1,4,5,8,9,14,18,22,30,31,33,34,51,52,53,54,55,57,58,59,61,63,65,80,82,84,85,86,87,88,89,90,91,92,103,128,129,144,145,146,147,148,Z01,ZZZ,"
        )]
    public class EDIFACT_ID_0007
    {
    }

}
