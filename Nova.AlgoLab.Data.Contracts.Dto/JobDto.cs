using System.Collections.Generic;

namespace Nova.AlgoLab.Data.Contracts.Dto
{
    //TODO: Consider using enum/string instead of endless bool
    public class JobDto
    {
        public string Id { get; set; }
        public bool IsCompleted { get; set; }
        public bool IsStarting { get; set; }
        public bool IsRunning { get; set; }
        public bool IsCancelled { get; set; }
        public bool IsCancelling { get; set; }
        public bool IsError { get; set; }
        public string ErrorMessage { get; set; }
        public List<string> Messages { get; set; } = new List<string>();
        public List<ParameterDto> Results { get; set; } = new List<ParameterDto>();
    }
}
