using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;

namespace EfsTools.Items.Efs
{
    [Serializable]
    [Subscription]
    [EfsFile("/nv/item_files/modem/mmode/lte_bandpref_extn_65_256", true, 0xE1FF)]
    [Attributes(9)]
    public class LteBandPreferenceExtn65
    {
        [ElementsCount(3)]
        [ElementType("uint32")]
        [Description("")]
        [JsonIgnore]
        public ulong[] Value { get; set; }

        public LteBandPreferenceExtn65()
        {
            Value = new ulong[3];
        }

        public bool B65
        {
            get => BitsUtils.GetBitAsBool(Value[0], 64);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 64, value);
        }

        public bool B66
        {
            get => BitsUtils.GetBitAsBool(Value[0], 65);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 65, value);
        }

        public bool B67
        {
            get => BitsUtils.GetBitAsBool(Value[0], 66);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 66, value);
        }

        public bool B68
        {
            get => BitsUtils.GetBitAsBool(Value[0], 67);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 67, value);
        }

        public bool B69
        {
            get => BitsUtils.GetBitAsBool(Value[0], 68);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 68, value);
        }

        public bool B70
        {
            get => BitsUtils.GetBitAsBool(Value[0], 69);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 69, value);
        }

        public bool B71
        {
            get => BitsUtils.GetBitAsBool(Value[0], 70);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 70, value);
        }

        public bool B72
        {
            get => BitsUtils.GetBitAsBool(Value[0], 71);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 71, value);
        }

        public bool B73
        {
            get => BitsUtils.GetBitAsBool(Value[0], 72);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 72, value);
        }

        public bool B74
        {
            get => BitsUtils.GetBitAsBool(Value[0], 73);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 73, value);
        }

        public bool B75
        {
            get => BitsUtils.GetBitAsBool(Value[0], 74);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 74, value);
        }

        public bool B76
        {
            get => BitsUtils.GetBitAsBool(Value[0], 75);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 75, value);
        }

        public bool B77
        {
            get => BitsUtils.GetBitAsBool(Value[0], 76);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 76, value);
        }

        public bool B78
        {
            get => BitsUtils.GetBitAsBool(Value[0], 77);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 77, value);
        }

        public bool B79
        {
            get => BitsUtils.GetBitAsBool(Value[0], 78);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 78, value);
        }

        public bool B80
        {
            get => BitsUtils.GetBitAsBool(Value[0], 79);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 79, value);
        }

        public bool B81
        {
            get => BitsUtils.GetBitAsBool(Value[0], 80);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 80, value);
        }

        public bool B82
        {
            get => BitsUtils.GetBitAsBool(Value[0], 81);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 81, value);
        }

        public bool B83
        {
            get => BitsUtils.GetBitAsBool(Value[0], 82);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 82, value);
        }

        public bool B84
        {
            get => BitsUtils.GetBitAsBool(Value[0], 83);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 83, value);
        }

        public bool B85
        {
            get => BitsUtils.GetBitAsBool(Value[0], 84);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 84, value);
        }

        public bool B86
        {
            get => BitsUtils.GetBitAsBool(Value[0], 85);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 85, value);
        }

        public bool B87
        {
            get => BitsUtils.GetBitAsBool(Value[0], 86);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 86, value);
        }

        public bool B88
        {
            get => BitsUtils.GetBitAsBool(Value[0], 87);
            set => Value[0] = BitsUtils.SetBitAsBool(Value[0], 87, value);
        }
    }
}