using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1780)]
    [Attributes(9)]
    public class C1Bc0Lna1Fall
    {
        [ElementsCount(1)]
        [ElementType("int8")]
        [Description("")]
        public sbyte Value { get; set; }
        
    }
}
