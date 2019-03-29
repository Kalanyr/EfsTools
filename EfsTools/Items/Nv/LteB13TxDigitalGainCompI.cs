using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6516)]
    [Attributes(9)]
    public class LteB13TxDigitalGainComp
    {
        [ElementsCount(16)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
