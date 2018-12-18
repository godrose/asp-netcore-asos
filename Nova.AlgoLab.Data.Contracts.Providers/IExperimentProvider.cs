using Nova.AlgoLab.Data.Contracts.Dto;

namespace Nova.AlgoLab.Data.Contracts.Providers
{
    public interface IExperimentProvider
    {
        ExperimentDto[] GetExperimentsByAlgorithm(string algorithmId);
        ExperimentDto GetById(string id);
        void Update(ExperimentDto experimentDto);
        ExperimentDto Create(string algorithmId, string id, ExperimentDto experimentDto);
        void Delete(string id);
        string GetRawData(string id);
    }
}
