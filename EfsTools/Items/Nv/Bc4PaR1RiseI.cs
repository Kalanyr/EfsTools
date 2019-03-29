using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1479)]
    [Attributes(9)]
    public class Bc4PaR1Rise
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Value { get; set; }
        
    }
}
