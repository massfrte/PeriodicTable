namespace PeriodicTable.Infrastructure.Options
{
    public class SqlServerOptions
    {
        public const string CONFIG_KEY = "SqlServerSettings";

        public string? ConnectionString { get; set; }
    }
}
