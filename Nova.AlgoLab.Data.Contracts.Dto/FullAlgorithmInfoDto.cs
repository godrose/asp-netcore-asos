using System.Collections.Generic;

namespace Nova.AlgoLab.Data.Contracts.Dto
{
    public class FullAlgorithmInfoDto
    {
        public string Name { get; set; }
        public string Id { get; set; }
        public List<ExperimentDto> Experiments { get; set; } = new List<ExperimentDto>();   
        public List<ParameterDefinitionDto> Parameters { get; set; } = new List<ParameterDefinitionDto>();
        public List<ParameterDefinitionDto> OutputParameters { get; set; } = new List<ParameterDefinitionDto>();
    }
}
