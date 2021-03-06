using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [NvItemId(69689)]
    [EfsFile("/nv/item_files/ims/ims_user_agent", true, 0xE1FF)]
    [Attributes(9)]
    public class ImsUserAgent
    {
        [JsonIgnore]
        [ElementsCount(1024)]
        [ElementType("uint8")]
        [Description("")]
        public byte[] Value { get; set; }

        public string ValueString
        {
            get => StringUtils.GetString(Value);
            set => Value = StringUtils.GetBytes(value, 1024);
        }
    }
}