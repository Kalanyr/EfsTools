using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6062)]
    [Attributes(9)]
    public class BcxBlock1TxComp1
    {
        [ElementsCount(32)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Value { get; set; }
        
    }
}
