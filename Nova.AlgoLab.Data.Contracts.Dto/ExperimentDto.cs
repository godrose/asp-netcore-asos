using System;
using System.Collections.Generic;

namespace Nova.AlgoLab.Data.Contracts.Dto
{
    public class ExperimentDto
    {
        public string Id { get; set; }
        public string AlgorithmId { get; set; }
        public string Name { get; set; }
        public List<ParameterDto> Parameters { get; set; } = new List<ParameterDto>();
        public string Status { get; set; }
        public List<LogItemDto> Messages { get; set; } = new List<LogItemDto>();
        public List<ParameterDto> Results { get; set; } = new List<ParameterDto>();
        public string JobId { get; set; }
        public DateTime CreationTime { get; set; }
        public DateTime LastUpdateTime { get; set; }
        //TODO: To be used
        public DateTime ExecutionTime { get; set; }
    }
}
