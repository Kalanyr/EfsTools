using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025050", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm1800TempComp
    {
        [ElementsCount(1)]
        [ElementType("GSM_TX_TEMP_COMP_DATA_TYPE")]
        [Description("")]
        public GsmTxTempCompDataType TempCompData { get; set; }
        
    }
}
