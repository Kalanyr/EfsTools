using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00025212", true, 0xE1FF)]
    [Attributes(9)]
    public class LteB5CaBcConfig : LteBandsConfigBase
    {
        
    }
}
