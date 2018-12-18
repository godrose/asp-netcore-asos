namespace Nova.AlgoLab.Data.Contracts.Dto
{
    public class ParameterDefinitionDto
    {
        public string Id { get; set; }
        public string Name { get; set; }
        public string Type { get; set; }
        public object DefaultValue { get; set; }
        public object[] Options { get; set; }
    }
}
