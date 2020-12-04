using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace EdiWeave.Edifact.UN.D99B
{
    /// <summary>
    /// Invoice message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D99B", "IFTMBC")]
    public class TSIFTMBC : EdiMessage
    {
        [Required]
        [DataMember]
        [Pos(1)]
        public virtual UNH UNH { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual CTA CTA { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual List<TSR> TSR { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual List<CNT> CNT { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual List<GDS> GDS { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_LOC_IFTMBC> LOCLoop { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_RFF_IFTMBC> RFFLoop { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual List<TCC> TCC { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_TDT_IFTMBC> TDTLoop { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_NAD_IFTMBC> NADLoop { get; set; }
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_GID_IFTMBC> GIDLoop { get; set; }
        [DataMember]
        [Pos(15)]
        public virtual List<Loop_EQD_IFTMBC> EQDLoop { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual UNT UNT { get; set; }
    }

    #region Loop_GID_IFTMBC

    /// <summary>
    /// Loop for GOODS ITEM DETAILS
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(nameof(GID))]
    public class Loop_GID_IFTMBC
    {
        /// <summary>
        /// GOODS ITEM DETAILS
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual GID GID { get; set; }
        /// <summary>
        /// HANDLING INSTRUCTIONS
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual HAN HAN { get; set; }
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
        [Pos(6)]
        public virtual List<LOC> LOC { get; set; }
        /// <summary>
        /// FREE TEXT
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        /// <summary>
        /// PERCENTAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(7)]
        public virtual List<PCD> PCD { get; set; }
        /// <summary>
        /// Loop for NAME AND ADDRESS
        /// </summary>
        [DataMember]
        [Pos(8)]
        public virtual List<Loop_NAD_IFTMBC_2> NADLoop { get; set; }
        /// <summary>
        /// NATURE OF CARGO
        /// </summary>
        [DataMember]
        [Pos(9)]
        public virtual List<GDS> GDS { get; set; }
        /// <summary>
        /// Loop for MEASUREMENTS
        /// </summary>
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_MEA_IFTMBC> MEALoop { get; set; }
        /// <summary>
        /// Loop for DIMENSIONS
        /// </summary>
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_DIM_IFTMBC> DIMLoop { get; set; }
        /// <summary>
        /// Loop for REFERENCE
        /// </summary>
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_RFF_IFTMBC> RFFLoop { get; set; }
        /// <summary>
        /// Loop for DOCUMENT/MESSAGE DETAILS
        /// </summary>
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_DOC_IFTMBC> DOCLoop { get; set; }
        /// <summary>
        /// Loop for DANGEROUS GOODS
        /// </summary>
        [DataMember]
        [Pos(14)]
        public virtual List<Loop_DGS_IFTMBC> DGSLoop { get; set; }
    }

    [DataContract]
    [Group(nameof(DGS))]
    public class Loop_DGS_IFTMBC_2
    {
        [DataMember]
        [Pos(1)]
        public virtual DGS DGS { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMBC> CTALoop { get; set; }
    }

    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_IFTMBC_2
    {

        [DataMember]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }

    [DataContract]
    [Group(nameof(MEA))]
    public class Loop_MEA_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual MEA MEA { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }

    [DataContract]
    [Group(nameof(DIM))]
    public class Loop_DIM_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual DIM DIM { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
    }

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    [DataContract]
    [Group(nameof(DOC))]
    public class Loop_DOC_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual DOC DOC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    [DataContract]
    [Group(nameof(DGS))]
    public class Loop_DGS_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual DGS DGS { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual List<Loop_CTA_IFTMBC> CTALoop { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_MEA_IFTMBC> MEALoop { get; set; }
    }

    #endregion

    #region Loop_NAD_IFTMBC

    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_IFTMBC
    {
        [DataMember]
        [Pos(1)]
        public virtual NAD NAD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<LOC> LOC { get; set; }
        [DataMember]
        [Pos(3)]
        public List<Loop_CTA_IFTMBC> CTALoop { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_TSR_IFTMBC> TSRLoop { get; set; }
    }

    /// <summary>
    /// Loop for CONTACT INFORMATION
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Group(nameof(CTA))]
    public class Loop_CTA_IFTMBC
    {
        /// <summary>
        /// CONTACT INFORMATION
        /// </summary>
        [DataMember]
        [Pos(1)]
        public virtual CTA CTA { get; set; }
        /// <summary>
        /// COMMUNICATION CONTACT
        /// </summary>
        [DataMember]
        [Pos(2)]
        public virtual List<COM> COM { get; set; }
    }

    [DataContract]
    [Group(nameof(TSR))]
    public class Loop_TSR_IFTMBC
    {

        [DataMember]
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
        [Pos(5)]
        public virtual List<FTX> FTX { get; set; }
    }
    #endregion

    #region Loop_TDT_IFTMBC

    [DataContract]
    [Group(nameof(TDT))]
    public class Loop_TDT_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual TDT TDT { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual List<TSR> TSR { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<Loop_LOC_IFTMBC_2> LOCLoop { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual List<Loop_RFF_IFTMBC_2> RFFLoop { get; set; }
    }

    [DataContract]
    [Group(nameof(LOC))]
    public class Loop_LOC_IFTMBC_2
    {

        [DataMember]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_IFTMBC_2
    {

        [DataMember]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual DTM DTM { get; set; }
    }
    #endregion

    #region Loop_LOC_IFTMBC

    [DataContract]
    [Group(nameof(LOC))]
    public class Loop_LOC_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual LOC LOC { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    #endregion

    #region Loop_EQD_IFTMBC

    [DataContract]
    [Group(nameof(EQD))]
    public class Loop_EQD_IFTMBC
    {

        [DataMember]
        [Pos(1)]
        public virtual EQD EQD { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual EQN EQN { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual TMD TMD { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<MEA> MEA { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual List<DIM> DIM { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual HAN HAN { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual TMP TMP { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual List<RNG> RNG { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual List<RFF> RFF { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_NAD_IFTMBC_2> NADLoop { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual List<Loop_DGS_IFTMBC_2> DGSLoop { get; set; }
    }

    #endregion
}
