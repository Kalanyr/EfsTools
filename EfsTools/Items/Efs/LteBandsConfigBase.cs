using System;
using System.ComponentModel;
using EfsTools.Attributes;
using EfsTools.Utils;
using Newtonsoft.Json;
using EfsTools.Items.Data;

namespace EfsTools.Items.Efs
{
    public class LteBandsConfigBase
    {
        [ElementsCount(1)]
        [ElementType("uint64")]
        [Description("")]
        [JsonIgnore]
        public ulong Value { get; set; }

        public bool B1
        {
            get => BitsUtils.GetBitAsBool(Value, 0);
            set => Value = BitsUtils.SetBitAsBool(Value, 0, value);
        }

        public bool B2
        {
            get => BitsUtils.GetBitAsBool(Value, 1);
            set => Value = BitsUtils.SetBitAsBool(Value, 1, value);
        }

        public bool B3
        {
            get => BitsUtils.GetBitAsBool(Value, 2);
            set => Value = BitsUtils.SetBitAsBool(Value, 2, value);
        }

        public bool B4
        {
            get => BitsUtils.GetBitAsBool(Value, 3);
            set => Value = BitsUtils.SetBitAsBool(Value, 3, value);
        }

        public bool B5
        {
            get => BitsUtils.GetBitAsBool(Value, 4);
            set => Value = BitsUtils.SetBitAsBool(Value, 4, value);
        }

        public bool B6
        {
            get => BitsUtils.GetBitAsBool(Value, 5);
            set => Value = BitsUtils.SetBitAsBool(Value, 5, value);
        }

        public bool B7
        {
            get => BitsUtils.GetBitAsBool(Value, 6);
            set => Value = BitsUtils.SetBitAsBool(Value, 6, value);
        }

        public bool B8
        {
            get => BitsUtils.GetBitAsBool(Value, 7);
            set => Value = BitsUtils.SetBitAsBool(Value, 7, value);
        }

        public bool B9
        {
            get => BitsUtils.GetBitAsBool(Value, 8);
            set => Value = BitsUtils.SetBitAsBool(Value, 8, value);
        }

        public bool B10
        {
            get => BitsUtils.GetBitAsBool(Value, 9);
            set => Value = BitsUtils.SetBitAsBool(Value, 9, value);
        }

        public bool B11
        {
            get => BitsUtils.GetBitAsBool(Value, 10);
            set => Value = BitsUtils.SetBitAsBool(Value, 10, value);
        }

        public bool B12
        {
            get => BitsUtils.GetBitAsBool(Value, 11);
            set => Value = BitsUtils.SetBitAsBool(Value, 11, value);
        }

        public bool B13
        {
            get => BitsUtils.GetBitAsBool(Value, 12);
            set => Value = BitsUtils.SetBitAsBool(Value, 12, value);
        }

        public bool B14
        {
            get => BitsUtils.GetBitAsBool(Value, 13);
            set => Value = BitsUtils.SetBitAsBool(Value, 13, value);
        }

        public bool B15
        {
            get => BitsUtils.GetBitAsBool(Value, 14);
            set => Value = BitsUtils.SetBitAsBool(Value, 14, value);
        }

        public bool B16
        {
            get => BitsUtils.GetBitAsBool(Value, 15);
            set => Value = BitsUtils.SetBitAsBool(Value, 15, value);
        }

        public bool B17
        {
            get => BitsUtils.GetBitAsBool(Value, 16);
            set => Value = BitsUtils.SetBitAsBool(Value, 16, value);
        }

        public bool B18
        {
            get => BitsUtils.GetBitAsBool(Value, 17);
            set => Value = BitsUtils.SetBitAsBool(Value, 17, value);
        }

        public bool B19
        {
            get => BitsUtils.GetBitAsBool(Value, 18);
            set => Value = BitsUtils.SetBitAsBool(Value, 18, value);
        }

        public bool B20
        {
            get => BitsUtils.GetBitAsBool(Value, 19);
            set => Value = BitsUtils.SetBitAsBool(Value, 19, value);
        }
        
        public bool B21
        {
            get => BitsUtils.GetBitAsBool(Value, 20);
            set => Value = BitsUtils.SetBitAsBool(Value, 20, value);
        }

        public bool B22
        {
            get => BitsUtils.GetBitAsBool(Value, 21);
            set => Value = BitsUtils.SetBitAsBool(Value, 21, value);
        }

        public bool B23
        {
            get => BitsUtils.GetBitAsBool(Value, 22);
            set => Value = BitsUtils.SetBitAsBool(Value, 22, value);
        }

        public bool B24
        {
            get => BitsUtils.GetBitAsBool(Value, 23);
            set => Value = BitsUtils.SetBitAsBool(Value, 23, value);
        }

        public bool B25
        {
            get => BitsUtils.GetBitAsBool(Value, 24);
            set => Value = BitsUtils.SetBitAsBool(Value, 24, value);
        }

        public bool B26
        {
            get => BitsUtils.GetBitAsBool(Value, 25);
            set => Value = BitsUtils.SetBitAsBool(Value, 25, value);
        }

        public bool B27
        {
            get => BitsUtils.GetBitAsBool(Value, 26);
            set => Value = BitsUtils.SetBitAsBool(Value, 26, value);
        }

        public bool B28
        {
            get => BitsUtils.GetBitAsBool(Value, 27);
            set => Value = BitsUtils.SetBitAsBool(Value, 27, value);
        }

        public bool B29
        {
            get => BitsUtils.GetBitAsBool(Value, 28);
            set => Value = BitsUtils.SetBitAsBool(Value, 28, value);
        }

        public bool B30
        {
            get => BitsUtils.GetBitAsBool(Value, 29);
            set => Value = BitsUtils.SetBitAsBool(Value, 29, value);
        }

        public bool B31
        {
            get => BitsUtils.GetBitAsBool(Value, 30);
            set => Value = BitsUtils.SetBitAsBool(Value, 30, value);
        }

        public bool B32
        {
            get => BitsUtils.GetBitAsBool(Value, 31);
            set => Value = BitsUtils.SetBitAsBool(Value, 31, value);
        }

        public bool B33
        {
            get => BitsUtils.GetBitAsBool(Value, 32);
            set => Value = BitsUtils.SetBitAsBool(Value, 32, value);
        }

        public bool B34
        {
            get => BitsUtils.GetBitAsBool(Value, 33);
            set => Value = BitsUtils.SetBitAsBool(Value, 33, value);
        }

        public bool B35
        {
            get => BitsUtils.GetBitAsBool(Value, 34);
            set => Value = BitsUtils.SetBitAsBool(Value, 34, value);
        }

        public bool B36
        {
            get => BitsUtils.GetBitAsBool(Value, 35);
            set => Value = BitsUtils.SetBitAsBool(Value, 35, value);
        }

        public bool B37
        {
            get => BitsUtils.GetBitAsBool(Value, 36);
            set => Value = BitsUtils.SetBitAsBool(Value, 36, value);
        }

        public bool B38
        {
            get => BitsUtils.GetBitAsBool(Value, 37);
            set => Value = BitsUtils.SetBitAsBool(Value, 37, value);
        }

        public bool B39
        {
            get => BitsUtils.GetBitAsBool(Value, 38);
            set => Value = BitsUtils.SetBitAsBool(Value, 38, value);
        }

        public bool B40
        {
            get => BitsUtils.GetBitAsBool(Value, 39);
            set => Value = BitsUtils.SetBitAsBool(Value, 39, value);
        }

        public bool B41
        {
            get => BitsUtils.GetBitAsBool(Value, 40);
            set => Value = BitsUtils.SetBitAsBool(Value, 40, value);
        }

        public bool B42
        {
            get => BitsUtils.GetBitAsBool(Value, 41);
            set => Value = BitsUtils.SetBitAsBool(Value, 41, value);
        }

        public bool B43
        {
            get => BitsUtils.GetBitAsBool(Value, 42);
            set => Value = BitsUtils.SetBitAsBool(Value, 42, value);
        }

        public bool B44
        {
            get => BitsUtils.GetBitAsBool(Value, 43);
            set => Value = BitsUtils.SetBitAsBool(Value, 43, value);
        }

        public bool B45
        {
            get => BitsUtils.GetBitAsBool(Value, 44);
            set => Value = BitsUtils.SetBitAsBool(Value, 44, value);
        }

        public bool B46
        {
            get => BitsUtils.GetBitAsBool(Value, 45);
            set => Value = BitsUtils.SetBitAsBool(Value, 45, value);
        }

        public bool B47
        {
            get => BitsUtils.GetBitAsBool(Value, 46);
            set => Value = BitsUtils.SetBitAsBool(Value, 46, value);
        }

        public bool B48
        {
            get => BitsUtils.GetBitAsBool(Value, 47);
            set => Value = BitsUtils.SetBitAsBool(Value, 47, value);
        }

        public bool B49
        {
            get => BitsUtils.GetBitAsBool(Value, 48);
            set => Value = BitsUtils.SetBitAsBool(Value, 48, value);
        }

        public bool B50
        {
            get => BitsUtils.GetBitAsBool(Value, 49);
            set => Value = BitsUtils.SetBitAsBool(Value, 49, value);
        }

        public bool B51
        {
            get => BitsUtils.GetBitAsBool(Value, 50);
            set => Value = BitsUtils.SetBitAsBool(Value, 50, value);
        }

        public bool B52
        {
            get => BitsUtils.GetBitAsBool(Value, 51);
            set => Value = BitsUtils.SetBitAsBool(Value, 51, value);
        }

        public bool B53
        {
            get => BitsUtils.GetBitAsBool(Value, 52);
            set => Value = BitsUtils.SetBitAsBool(Value, 52, value);
        }

        public bool B54
        {
            get => BitsUtils.GetBitAsBool(Value, 53);
            set => Value = BitsUtils.SetBitAsBool(Value, 53, value);
        }

        public bool B55
        {
            get => BitsUtils.GetBitAsBool(Value, 54);
            set => Value = BitsUtils.SetBitAsBool(Value, 54, value);
        }

        public bool B56
        {
            get => BitsUtils.GetBitAsBool(Value, 55);
            set => Value = BitsUtils.SetBitAsBool(Value, 55, value);
        }

        public bool B57
        {
            get => BitsUtils.GetBitAsBool(Value, 56);
            set => Value = BitsUtils.SetBitAsBool(Value, 56, value);
        }

        public bool B58
        {
            get => BitsUtils.GetBitAsBool(Value, 57);
            set => Value = BitsUtils.SetBitAsBool(Value, 57, value);
        }

        public bool B59
        {
            get => BitsUtils.GetBitAsBool(Value, 58);
            set => Value = BitsUtils.SetBitAsBool(Value, 58, value);
        }

        public bool B60
        {
            get => BitsUtils.GetBitAsBool(Value, 59);
            set => Value = BitsUtils.SetBitAsBool(Value, 59, value);
        }

        public bool B61
        {
            get => BitsUtils.GetBitAsBool(Value, 60);
            set => Value = BitsUtils.SetBitAsBool(Value, 60, value);
        }

        public bool B62
        {
            get => BitsUtils.GetBitAsBool(Value, 61);
            set => Value = BitsUtils.SetBitAsBool(Value, 61, value);
        }

        public bool B63
        {
            get => BitsUtils.GetBitAsBool(Value, 62);
            set => Value = BitsUtils.SetBitAsBool(Value, 62, value);
        }

        public bool B64
        {
            get => BitsUtils.GetBitAsBool(Value, 63);
            set => Value = BitsUtils.SetBitAsBool(Value, 63, value);
        }
    }
}
