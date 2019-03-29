using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [EfsFile("/nv/item_files/rfnv/00021007", true, 0xE1FF)]
    [Attributes(9)]
    public class Bc1PaSmpsPdmLevelTemp
    {
        [ElementsCount(8)]
        [ElementType("uint16")]
        [Description("")]
        public ushort[] Value { get; set; }
        
    }
}
