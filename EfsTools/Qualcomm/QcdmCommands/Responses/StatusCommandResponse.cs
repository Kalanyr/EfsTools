using EfsTools.Qualcomm.QcdmCommands.Attributes;

namespace EfsTools.Qualcomm.QcdmCommands.Responses
{
    [QcdmCommand(QcdmCommand.Status)]
    [QcdmMinResponseLength(0)]
    internal class StatusCommandResponse : BaseCommandResponse
    {
        private StatusCommandResponse()
        {
        }

        public bool IsError { get; private set; }

        public static StatusCommandResponse Parse(byte[] data)
        {
            var result = new StatusCommandResponse();
            result.IsError = false;
            return result;
        }
    }
}