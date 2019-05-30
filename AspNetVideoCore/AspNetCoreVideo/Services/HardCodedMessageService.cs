namespace AspNetCoreVideo.Services
{
    public class HardCodedMessageService : IMessageService
    {
        public string GetMessage()
        {
            return "Harcoded message from a service";
        }
    }
}
