using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Nv
{
    [Serializable]
    [NvItemId(494)]
    [Attributes(41)]
    public class DataServicesMobileIpMnHomeAgentTimebaseDifference
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public byte Index { get; set; }


        [ElementsCount(1)]
        [ElementType("uint32")]
        [Description("")]
        public uint TimeDelta { get; set; }
    }
}