using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/mcfg/mcfg_autoselect_by_uim", false, 0x81FF)]
    [Attributes(9)]
    [Subscription]
    public class McfgAutoselectByUim
    {
        [ElementsCount(1)]
        [ElementType("uint8")]
        [Description("")]
        public uint Value { get; set; }
    }
}