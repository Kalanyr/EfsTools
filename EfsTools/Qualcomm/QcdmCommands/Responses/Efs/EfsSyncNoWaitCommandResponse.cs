﻿using System;
using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses.Efs
{
    [QcdmCommand(QcdmCommand.SubsysCmd)]
    [QcdmSubSystemCommand(QcdmSubSystem.Efs, (ushort) QcdmEfsCommand.EfsSyncNoWait)]
    [QcdmMinResponseLength(14)]
    internal class EfsSyncNoWaitCommandResponse : BaseSubSystemCommandResponse
    {
        private EfsSyncNoWaitCommandResponse()
        {
        }

        public ushort Sequence { get; private set; }
        public uint Token { get; private set; }
        public QcdmEfsErrors Error { get; private set; }

        public static EfsSyncNoWaitCommandResponse Parse(byte[] data)
        {
            var result = new EfsSyncNoWaitCommandResponse();
            result.CheckResponse(data);

            result.Sequence = BitConverter.ToUInt16(data, 4);
            result.Token = BitConverter.ToUInt32(data, 6);
            var error = (QcdmEfsErrors) BitConverter.ToInt32(data, 10);
            result.Error = error;
            return result;
        }
    }
}