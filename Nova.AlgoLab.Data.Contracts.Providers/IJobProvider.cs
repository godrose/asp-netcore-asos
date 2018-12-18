using System.Collections.Generic;
using Nova.AlgoLab.Data.Contracts.Dto;

namespace Nova.AlgoLab.Data.Contracts.Providers
{
    public interface IJobProvider
    {
        string Start(string algorithmId, IEnumerable<ParameterDto> parameters);
        void Stop(string id);
        JobDto GetJob(string id);
    }
}
