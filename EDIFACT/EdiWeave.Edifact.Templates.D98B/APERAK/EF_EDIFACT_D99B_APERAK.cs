using EdiWeave.Core.Annotations.Edi;
using EdiWeave.Core.Annotations.Validation;
using EdiWeave.Core.Model.Edi;
using EdiWeave.Core.Model.Edi.Edifact;
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Xml.Serialization;

namespace EdiWeave.Edifact.Templates.D99B
{
    /// <summary>
    /// Application error and acknowledgement message
    /// </summary>
    [Serializable()]
    [DataContract()]
    [Message("EDIFACT", "D99B", "APERAK")]
    public class TSAPERAK : EdiMessage
    {

        [DataMember]
        [Pos(14)]
        public virtual List<Loop_GID_IFTMBC> GIDLoop { get; set; }
        [DataMember]
        [Pos(13)]
        public virtual List<Loop_NAD_IFTMBC> NADLoop { get; set; }
        [DataMember]
        [Pos(12)]
        public virtual List<Loop_TDT_IFTMBC> TDTLoop { get; set; }
        [DataMember]
        [Pos(11)]
        public virtual List<TCC> TCC { get; set; }
        [DataMember]
        [Pos(10)]
        public virtual List<Loop_RFF_IFTMBC> RFFLoop { get; set; }
        [DataMember]
        [Pos(9)]
        public virtual List<Loop_LOC_IFTMBC> LOCLoop { get; set; }
        [DataMember]
        [Pos(8)]
        public virtual List<CNT> CNT { get; set; }
        [DataMember]
        [Pos(7)]
        public virtual List<FTX> FTX { get; set; }
        [DataMember]
        [Pos(6)]
        public virtual List<TSR> TSR { get; set; }
        [DataMember]
        [Pos(5)]
        public virtual List<DTM> DTM { get; set; }
        [DataMember]
        [Pos(4)]
        public virtual List<COM> COM { get; set; }
        [DataMember]
        [Pos(3)]
        public virtual CTA CTA { get; set; }
        [DataMember]
        [Pos(2)]
        public virtual BGM BGM { get; set; }
        [DataMember]
        [Pos(1)]
        public virtual UNH UNH { get; set; }

        [DataMember]
        [Pos(15)]
        public virtual List<Loop_EQD_IFTMBC> EQDLoop { get; set; }
        [DataMember]
        [Pos(16)]
        public virtual UNT UNT { get; set; }
    }

}
