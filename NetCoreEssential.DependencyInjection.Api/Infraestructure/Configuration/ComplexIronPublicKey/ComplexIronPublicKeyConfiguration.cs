namespace NetCoreEssential.DependencyInjection.Api.Infraestructure.Configuration.ComplexIronPublicKey
{
    public class ComplexIronPublicKeyConfiguration
    {
        public string Prefix { get; set; }
        public BodySection Body { get; set; }
        public string Sufix { get; set; }

        public ComplexIronPublicKeyConfiguration()
        {
            Body = new BodySection();
        }

        public string GetPublicKey()
        {
            var key = $"{Prefix}{Body.PartOne}{Body.Separator}{Body.PartTwo.ValueA}{Body.PartTwo.Separator}{Body.PartTwo.ValueB}{Sufix}";
            return key;
        }
    }

}
