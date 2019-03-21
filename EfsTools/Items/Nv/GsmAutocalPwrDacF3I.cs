using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(3146)]
    [Attributes(9)]
    public class GsmAutocalPwrDacF3I
    {
        [ElementsCount(1)]
        [ElementType("int16")]
        [Description("")]
        public short Value1 { get; set; }
        
        [ElementsCount(1)]
        [ElementType("uint16")]
        [Description("")]
        public ushort Value2 { get; set; }
        
    }
}