using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EDIFACT.TEMPLATES.D99B
{
    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D99B", "IFTMIN")]
    public class TSIFTMIN : EdiMessage
    {
        [Required]
        [DataMember]
        [Pos(1)]
        public virtual UNH UNH { get; set; }
        [Required]
        [DataMember]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual CTA CTA { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(6)]
        [ListCount(9)]
        public virtual List<TSR> TSR { get; set; }
        [DataMember]
        [Pos(7)]
        [ListCount(9)]
        public virtual List<CUX> CUX { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(8)]
        public virtual List<MOA> MOA { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<CNT> CNT { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<DOC> DOC { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<GDS> GDS { get; set; }
        /// <summary>
        ///Segment Group 1: LOC-DTM
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<Loop_LOC_IFTMIN> LOCLoop { get; set; }
        /// <summary>
        ///Segment Group 2: TOD-LOC
        /// </summary>
        [DataMember]
        [ListCount(2)]
        [Pos(14)]
        public virtual List<Loop_TOD_IFTMIN> TODLoop { get; set; }
        /// <summary>
        ///Segment Group 3: RFF-DTM
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(15)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }
        /// <summary>
        ///  Segment Group 4: GOR-DTM-LOC-SEL-FTX-GRP5
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(16)]
        public virtual List<Loop_GOR_IFTMIN> GORLoop { get; set; }
        /// <summary>
        /// Segment Group 6
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(17)]
        public virtual List<Loop_CPI_IFTMIN> CPILoop { get; set; }
        /// <summary>
        /// Segment Group 7: TCC-LOC-FTX-CUX-PRI-EQN-PCD-MOA-QTY
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(18)]
        public virtual List<Loop_TCC_IFTMIN> TCCLoop { get; set; }
        /// <summary>
        /// Segment Group 8
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(19)]
        public virtual List<Loop_TDT_IFTMIN> TDTLoop { get; set; }
        /// <summary>
        /// Segment Group 11: NAD-LOC-SG11-SG12-SG13-SG14-SG15-SG16-SG17
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(20)]
        public virtual List<Loop_NAD_IFTMIN> NADLoop { get; set; }
        /// <summary>
        /// Segment Group 18
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(21)]
        public virtual List<Loop_GID_IFTMIN> GIDLoop { get; set; }
        /// <summary>
        /// Segment Group 32: EQD-EQN-TMD-MEA-DIM-TPL-HAN-TMP-FTX-RFF-SG33-SG35
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(22)]
        public virtual List<Loop_EQD_IFTMIN> EQDLoop { get; set; }
        [DataMember]
        [Pos(23)]
        [Required]
        public virtual UNT UNT { get; set; }
    }


    #region Loop_GOR_IFTMIN

    [DataContract]
    [Group(nameof(GOR))]
    public class Loop_GOR_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GOR GOR { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<SEL> SEL { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<Loop_DOC_IFTMIN> DOC { get; set; }
    }

    [DataContract]
    [Group(nameof(DOC))]
    public class Loop_DOC_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }

    #endregion Loop_GOR_IFTMIN

    #region Loop_LOC_IFTMIN

    [DataContract]
    [Group(nameof(LOC))]
    public class Loop_LOC_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    #endregion Loop_LOC_IFTMIN

    #region Loop_TOD_IFTMIN

    [DataContract]
    [Group(nameof(TOD))]
    public class Loop_TOD_IFTMIN
    {

        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TOD TOD { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<LOC> DTM { get; set; }
    }

    #endregion Loop_TOD_IFTMIN

    #region Loop_RFF_IFTMIN

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_IFTMIN
    {

        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    #endregion Loop_RFF_IFTMIN

    #region Loop_CPI_IFTMIN

    /// <summary>
    /// Loop for  identify the charge and its amount to be paid by the party.
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(nameof(CPI))]
    public class Loop_CPI_IFTMIN
    {
        /// <summary>
        /// Charge payment instructions
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CPI CPI { get; set; }
        /// <summary>
        /// REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// CURRENCIES
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual CUX CUX { get; set; }
        /// <summary>
        /// Place/location identification
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<MOA> MOA { get; set; }
    }

    #endregion Loop_CPI_IFTMIN

    #region Loop_TCC_IFTMIN

    [DataContract]
    [Group(nameof(TCC))]
    public class Loop_TCC_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual FTX FTX { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual CUX CUX { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual PRI PRI { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual EQN EQN { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual PCD PCD { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<MOA> MOA { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(9)]
        public virtual List<QTY> QTY { get; set; }
    }

    #endregion Loop_TCC_IFTMIN

    #region Loop_TDT_IFTMIN

    [DataContract]
    [Group(nameof(TDT))]
    public class Loop_TDT_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<TSR> TSR { get; set; }
        /// <summary>
        /// Segment Group 9: LOC-DTM
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(4)]
        public virtual List<Loop_LOC_IFTMIN> LOCLoop { get; set; }
        /// <summary>
        /// Segment Group 10: RFF-DTM
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<Loop_RFF_IFTMIN_2> RFFLoop { get; set; }
    }


    [DataContract]
    [Group(nameof(LOC))]
    public class Loop_LOC_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }

    #endregion Loop_TDT_IFTMIN

    #region Loop_NAD_IFTMIN

    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_IFTMIN
    {
        /// <summary>
        /// NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// Segment Group 12:  CTA-COM
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
        /// <summary>
        /// Segment Group 13:  DOC-DTM
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<Loop_DOC_IFTMIN> DOCLoop { get; set; }
        /// <summary>
        /// Segment Group 14  
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<Loop_TCC_IFTMIN_2> TCCLoop { get; set; }
        /// <summary>
        /// Segment Group 15:  RFF-DTM
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }

        /// <summary>
        /// Segment Group 16: CPI-RFF-CUX-LOC-MOA
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<Loop_CPI_IFTMIN> CPILoop { get; set; }

        /// <summary>
        /// Segment Group 17: TSR-RFF-LOC-TPL-FTX
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(7)]
        public virtual List<Loop_TSR_IFTMIN> TSRLoop { get; set; }
    }

    [DataContract]
    [Group(nameof(TCC))]
    public class Loop_TCC_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual CUX CUX { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual PRI PRI { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual EQN EQN { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual PCD PCD { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<MOA> MOA { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
    }

    [DataContract]
    [Group(nameof(TSR))]
    public class Loop_TSR_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TSR TSR { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual TPL TPL { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
    }

    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(nameof(CTA))]
    public class Loop_CTA_IFTMIN
    {
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }

    #endregion Loop_NAD_IFTMIN


    #region Loop_GID_IFTMIN

    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(nameof(GID))]
    public class Loop_GID_IFTMIN
    {
        /// <summary>
        /// GOODS ITEM DETAILS
        /// </summary>
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual GID GID { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<HAN> HAN { get; set; }
        /// <summary>
        /// TEMPERATURE
        /// </summary>
        [DataMember]
        [Pos(3)]
        public virtual TMP TMP { get; set; }
        /// <summary>
        /// RANGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(4)]
        public virtual RNG RNG { get; set; }
        /// <summary>
        /// TRANSPORT MOVEMENT DETAILS
        /// </summary>
        [DataMember]
        [Pos(5)]
        public virtual TMD TMD { get; set; }
        /// <summary>
        /// PLACE/LOCATION IDENTIFICATION
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// MONETARY AMOUNT
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<MOA> MOA { get; set; }
        /// <summary>
        /// ADDITIONAL PRODUCT ID
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<PIA> PIA { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<PCD> PCD { get; set; }
        /// <summary>
        /// identify different places of collection and/or delivery for the goods item.
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<Loop_NAD_IFTMIN_2> NADLoop { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(12)]
        public virtual List<GDS> GDS { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(13)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
        /// <summary>
        /// Loop for DIMENSIONS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(14)]
        public virtual List<Loop_DIM_IFTMIN> DIMLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(15)]
        public virtual List<Loop_RFF_IFTMIN> RFFLoop { get; set; }
        /// <summary>
        /// Loop for specify marks and numbers of a goods item.
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(16)]
        public virtual List<Loop_PCI_IFTMIN> PCILoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(17)]
        public virtual List<Loop_DOC_IFTMIN_2> DOCLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(17)]
        public virtual List<Loop_GOR_IFTMIN> GORLoop { get; set; }
        /// <summary>
        /// Loop for  transport details
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(18)]
        public virtual List<Loop_TPL_IFTMIN> TPLLoop { get; set; }
        /// <summary>
        /// Loop for specify the distribution of a goods item among the transport equipment.
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(19)]
        public virtual List<Loop_SGP_IFTMIN> SGPLoop { get; set; }
        /// <summary>
        /// A group of segments to specify charge associated with the goods item.
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(20)]
        public virtual List<Loop_TCC_IFTMIN_3> TCCLoop { get; set; }
        /// <summary>
        /// Loop for DANGEROUS GOODS
        /// </summary>
        [DataMember]
        [ListCount(99)]
        [Pos(20)]
        public virtual List<Loop_DGS_IFTMIN> DGSLoop { get; set; }
    }


    [DataContract]
    [Group(nameof(TCC))]
    public class Loop_TCC_IFTMIN_3
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual TCC TCC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual CUX CUX { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual PRI PRI { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual EQN EQN { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual PCD PCD { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(6)]
        public virtual List<MOA> MOA { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<QTY> QTY { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<LOC> LOC { get; set; }
    }

    [DataContract]
    [Group(nameof(DOC))]
    public class Loop_DOC_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }


    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<LOC> LOC { get; set; }
    }

    [DataContract]
    [Group(nameof(MEA))]
    public class Loop_MEA_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }


    [DataContract]
    [Group(nameof(DIM))]
    public class Loop_DIM_IFTMIN
    {

        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DIM DIM { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }



    [DataContract]
    [Group(nameof(DGS))]
    public class Loop_DGS_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DGS DGS { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// GRP28
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
        /// <summary>
        /// GRP29
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
        /// <summary>
        /// GRP30
        /// </summary>
        [DataMember]
        [ListCount(999)]
        [Pos(5)]
        public virtual List<Loop_SGP_IFTMIN> SGPLoop { get; set; }

    }

    [DataContract]
    [Group(nameof(PCI))]
    public class Loop_PCI_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual PCI PCI { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual DTM DTM { get; set; }
        [DataMember]
        [ListCount(10)]
        [Pos(4)]
        public virtual List<GIN> GIN { get; set; }
    }

    [DataContract]
    [Group(nameof(TPL))]
    public class Loop_TPL_IFTMIN
    {
        [DataMember]
        [Pos(1)]
        public virtual TPL TPL { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
    }

    [DataContract]
    [Group(nameof(SGP))]
    public class Loop_SGP_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual SGP SGP { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<Loop_MEA_IFTMIN> MEALoop { get; set; }
    }

    #endregion Loop_GID_IFTMIN

    #region Loop_EQD_IFTMIN

    [DataContract]
    [Group(nameof(EQD))]
    public class Loop_EQD_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EQD EQD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual TMD TMD { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(5)]
        public virtual List<DIM> DIM { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(6)]
        public virtual List<SEL> SEL { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<TPL> TPL { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual HAN HAN { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual TMP TMP { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(10)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(11)]
        public virtual List<RFF> RFF { get; set; }
        /// <summary>
        /// GRP 38
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_TCC_IFTMIN_2> TCCLoop { get; set; }
        /// <summary>
        /// GRP 39
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_NAD_IFTMIN_3> NADLoop { get; set; }
        /// <summary>
        /// GRP 41
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_EQA_IFTMIN> EQALoop { get; set; }
        /// <summary>
        /// GRP35
        /// </summary>
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_DGS_IFTMIN_2> DGSLoop { get; set; }
    }

    [DataContract]
    [Group(nameof(DGS))]
    public class Loop_DGS_IFTMIN_2
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DGS DGS { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
    }

    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_IFTMIN_3
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
        /// <summary>
        /// GRP34
        /// </summary>
        [DataMember]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMIN> CTALoop { get; set; }
    }

    [DataContract]
    [Group(nameof(EQA))]
    public class Loop_EQA_IFTMIN
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual EQA EQA { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }
    #endregion



}
