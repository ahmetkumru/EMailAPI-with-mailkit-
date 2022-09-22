using EMailAPI.Dtos;

namespace EMailAPI.Interfaces
{
    public interface IEMailService
    {
        void SendEmail(EMailDto request);
    }
}
