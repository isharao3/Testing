namespace EngineModule
{
    public enum EngineType
    {
        Electric,
        Petrol,
        Hybrid,
        Diesel
    }
    public interface IEngine
    {
        public bool Has8Pistons { get; set; }
        public int HorsePower {  get; set; }
        public string Manufacturer {  get; set; }
        public EngineType TypeOfEngine { get; set; }
        public string RegisterThroughApi();

    }
}
