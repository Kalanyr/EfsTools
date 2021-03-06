using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00022956", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc15TxMultiLinData
    {
        [ElementsCount(1)]
        [ElementType("QMSL_Tx_Cal_Complete_NV_Type")]
        [Description("")]
        public QmslTxCalCompleteNvType Value { get; set; }
        
    }
}
