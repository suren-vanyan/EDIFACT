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
    [Message("EDIFACT", "D99B", "IFTMBF")]
    public class TSIFTMBF : EdiMessage
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
        [Pos(4)]
        [ListCount(9)]
        public virtual List<COM> COM { get; set; }
        [DataMember]
        [Pos(5)]
        [ListCount(9)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(6)]
        [ListCount(9)]
        public virtual List<TSR> TSR { get; set; }
        [DataMember]
        [Pos(7)]
        [ListCount(9)]
        public virtual List<MOA> MOA { get; set; }


        [DataMember]
        [Pos(7)]
        [ListCount(99)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(8)]
        [ListCount(9)]
        public virtual List<CNT> CNT { get; set; }
        [DataMember]
        [Pos(8)]
        [ListCount(9)]
        public virtual List<GDS> GDS { get; set; }
        /// <summary>
        ///GRP1 Segment Group 1: LOC-DTM
        /// </summary>
        [DataMember]
        [Pos(9)]
        [ListCount(99)]
        public virtual List<Loop_LOC_IFTMBC> LOCLoop { get; set; }
        /// <summary>
        ///GRP2 Segment Group 2: RFF-DTM
        /// </summary>
        [DataMember]
        [Pos(10)]
        [ListCount(99)]
        public virtual List<Loop_RFF_IFTMBC> RFFLoop { get; set; }
        [DataMember]
        [Pos(11)]
        [ListCount(9)]
        public virtual List<TCC> TCC { get; set; }
        /// <summary>
        ///  Segment Group 3: TDT-DTM-TSR-SG4-SG5
        /// </summary>
        [DataMember]
        [Pos(12)]
        [ListCount(99)]
        public virtual List<Loop_TDT_IFTMBC> TDTLoop { get; set; }
        /// <summary>
        /// GRP6 Segment Group 6: NAD-LOC-SG7-SG8
        /// </summary>
        [DataMember]
        [Pos(13)]
        [ListCount(99)]
        public virtual List<Loop_NAD_IFTMBC> NADLoop { get; set; }
        /// <summary>
        ///  Segment Group 9:  GID-HAN-TMP-RNG-TMD-LOC-FTX-PCD-SG10-GDS-
        /// </summary>
        [DataMember]
        [Pos(14)]
        [ListCount(999)]
        public virtual List<Loop_GID_IFTMBC> GIDLoop { get; set; }
        /// <summary>
        ///  Segment Group 18: EQD-EQN-TMD-MEA-DIM-HAN-TMP-RNG-FTX-RFF-SG19-
        /// </summary>
        [DataMember]
        [Pos(15)]
        [ListCount(999)]
        public virtual List<Loop_EQD_IFTMBC> EQDLoop { get; set; }
        [DataMember]
        [Pos(16)]
        [Required]
        public virtual UNT UNT { get; set; }
    }


}
