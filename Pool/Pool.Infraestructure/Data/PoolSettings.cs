namespace Pool.Infraestructure.Data
{
    public class PoolSettings : IPoolSettings
    {
        public string Server { get; set; }
        public string Database { get; set; }
    }

    public interface IPoolSettings
    {
        string Server { get; set; }
        string Database { get; set; }
    }
}