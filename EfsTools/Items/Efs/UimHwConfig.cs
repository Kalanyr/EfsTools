using System;
using EfsTools.Attributes;

namespace EfsTools.Items.Efs
{
    [Ignore]
    [Serializable]
    [EfsFile("/nv/item_files/modem/uim/uimdrv/uim_hw_config", false, 0x81FF)]
    [Attributes(9)]
    public class UimHwConfig
    {
    }
}