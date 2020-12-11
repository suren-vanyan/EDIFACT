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
        [Pos(9)]
        [ListCount(99)]
        public virtual List<Loop_DOC_IFTMBC> LOCLoop { get; set; }

        //TODO
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
}
