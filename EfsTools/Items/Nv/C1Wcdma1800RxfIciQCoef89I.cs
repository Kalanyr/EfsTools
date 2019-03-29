using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(6423)]
    [Attributes(9)]
    public class C1Wcdma1800RxfIciQCoef89
    {
        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint Value { get; set; }
        
    }
}
