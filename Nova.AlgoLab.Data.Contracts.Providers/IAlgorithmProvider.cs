using Nova.AlgoLab.Data.Contracts.Dto;

namespace Nova.AlgoLab.Data.Contracts.Providers
{
    public interface IAlgorithmProvider
    {
        FullAlgorithmInfoDto[] GetAlgorithms();
        FullAlgorithmInfoDto GetAlgorithm(string algorithmId);
        void Synchronize();
    }
}
