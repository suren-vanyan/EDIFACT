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
    [Message("EDIFACT", "D99B", "APERAK")]
    public class TSAPERAK : EdiMessage
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
        [ListCount(9)]
        [Pos(3)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(4)]
        [ListCount(99)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(5)]
        [ListCount(9)]
        public virtual List<CNT> CNT { get; set; }
        /// <summary>
        ///GRP1 Segment Group 1: DOC-DTM
        /// </summary>
        [DataMember]
        [Pos(6)]
        [ListCount(99)]
        public virtual List<Loop_DOC_APERAK> LOCLoop { get; set; }

        [DataMember]
        [ListCount(9)]
        [Pos(7)]
        public virtual List<Loop_RFF_APERAK> RFFLoop { get; set; }

        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<Loop_NAD_APERAK> NADLoop { get; set; }

        [DataMember]
        [ListCount(9)]
        [Pos(8)]
        public virtual List<Loop_ERC_APERAK> ERCLoop { get; set; }
    }


    #region Loop_DOC_APERAK

    [DataContract]
    [Group(nameof(LOC))]
    public class Loop_DOC_APERAK
    {

        [DataMember]
        [Required]
        [Pos(1)]
        public virtual DOC LOC { get; set; }
        [DataMember]
        [ListCount(99)]
        [Pos(2)]
        public virtual List<DTM> DTM { get; set; }
    }

    #endregion Loop_DOC_APERAK

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_APERAK
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

    [DataContract]
    [Group(nameof(RFF))]
    public class Loop_RFF_APERAK_2
    {

        [DataMember]
        [Required]
        [Pos(1)]
        public virtual RFF RFF { get; set; }
        [DataMember]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<FTX> FTX { get; set; }
    }

    [DataContract]
    [Group(nameof(NAD))]
    public class Loop_NAD_APERAK
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual NAD NAD { get; set; }

        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(2)]
        public virtual List<CTA> CTA { get; set; }

        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<COM> COM { get; set; }
    }

    [DataContract]
    [Group(nameof(ERC))]
    public class Loop_ERC_APERAK
    {
        [DataMember]
        [Required]
        [Pos(1)]
        public virtual ERC ERC { get; set; }

        [DataMember]
        [Pos(2)]
        public virtual FTX FTX { get; set; }

        [DataMember]
        [Required]
        [ListCount(9)]
        [Pos(3)]
        public virtual List<Loop_RFF_APERAK_2> RFFLoop { get; set; }
    }
}