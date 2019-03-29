using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025073", true, 0xE1FF)]
    [Attributes(9)]
    public class GsmC2Gsm900PolarPathDelay
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short PolarPathDelay { get; set; }
        
    }
}
