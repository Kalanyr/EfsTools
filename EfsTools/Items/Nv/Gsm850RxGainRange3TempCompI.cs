using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(4381)]
    [Attributes(9)]
    public class Gsm850RxGainRange3TempComp
    {
        [ElementsCount(3)]
        [ElementType("int16")]
        [Description("")]
        public short[] Value { get; set; }
        
    }
}
