using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Items.Data;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00024752", true, 0xE1FF)]
    [Attributes(9)]
    public class CdmaC2Bc10TxLimVsTempVsFreq
    {
        [ElementsCount(8)]
        [ElementType("QMSL_Tx_Cal_Freq_Num_Type")]
        [Description("")]
        public QmslTxCalFreqNumType[] Temp { get; set; }
        
    }
}
