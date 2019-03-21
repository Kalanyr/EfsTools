using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(1286)]
    [Attributes(9)]
    public class GsmPaTempCompIndex13I
    {
        [ElementsCount(16)]
        [ElementType("int8")]
        [Description("")]
        public sbyte[] Value { get; set; }
        
    }
}