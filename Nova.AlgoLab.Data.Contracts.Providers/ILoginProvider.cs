using Nova.AlgoLab.Data.Contracts.Dto;

namespace Nova.AlgoLab.Data.Contracts.Providers
{
    public interface ILoginProvider
    {
        UserDto GetUser(string username, string password);
    }
}