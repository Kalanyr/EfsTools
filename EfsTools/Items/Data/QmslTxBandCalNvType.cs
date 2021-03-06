using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Data
{
    [Serializable]
    public class QmslTxBandCalNvType
    {
        [ElementsCount(8)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Reserved { get; set; }
        
        [ElementsCount(16)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] TxCalChan { get; set; }
        
        [ElementsCount(4)]
        [ElementType("QMSL_Tx_PA_State_Cal_Data_NV_Type")]
        [Description("")]
        public QmslTxPaStateCalDataNvType[] TxPaStateCalData { get; set; }
        
    }
}
