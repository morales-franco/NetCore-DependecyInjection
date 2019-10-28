namespace NetCoreEssential.DependencyInjection.Api.Infraestructure.Configuration.ComplexIronPublicKey
{
    public class BodySection
    {
        public string PartOne { get; set; }
        public string Separator { get; set; }
        public BodyPartTwoSection PartTwo { get; set; }
        public BodySection()
        {
            PartTwo = new BodyPartTwoSection();
        }
    }
}
