using System;
using System.ComponentModel;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/data/ds_dsd_attach_profile.txt", false, 0x81B6)]
    [Attributes(9)]
    public class DsDsdAttachProfileTxt
    {
        [ElementsCount(1)]
        [ElementType("string[]")]
        [LineEnding(LineEnding.Windows, true)]
        [Description("")]
        public string[] Values { get; set; }
    }
}