using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(660)]
    [Attributes(9)]
    public class PcsDaccIaccum4
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
        
    }
}
