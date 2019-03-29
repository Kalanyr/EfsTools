using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(7183)]
    [Attributes(9)]
    public class WcdmaDc1LnaRangeRise3Car1
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value { get; set; }
        
    }
}
