using MongoDB.Driver;
using Neo4j.Driver;


public sealed class DbConnector : IDisposable
{
    private static readonly Lazy<DbConnector> LazyInstance =
        new(() => new DbConnector(GetConfiguration()));

    private readonly IDriver _neo4jDriver;
    private readonly MongoClient _mongoClient;

    public DbConnector(IConfiguration configuration)
    {
        var neo4jConnectionString = configuration["DatabaseSettings:Neo4jConnectionString"];
        var neo4jUsername = configuration["DatabaseSettings:Neo4jUsername"];
        var neo4jPassword = configuration["DatabaseSettings:Neo4jPassword"];
        var mongoConnectionString = configuration["DatabaseSettings:MongoConnectionString"];

        _neo4jDriver = GraphDatabase.Driver(neo4jConnectionString, AuthTokens.Basic(neo4jUsername, neo4jPassword));
        _mongoClient = new MongoClient(mongoConnectionString);
    }

    public static DbConnector Instance => LazyInstance.Value;

    #region Neo4j Methods
    public async Task<IResultCursor> RunNeo4jQueryAsync(string cypherQuery, object parameters = null)
    {
        IAsyncSession? session = null;

        try
        {
            session = _neo4jDriver.AsyncSession();
            var resultCursor = await session.RunAsync(cypherQuery, parameters).ConfigureAwait(false);
            return resultCursor;
        }
        finally
        {
            if (session != null)
            {
                await session.CloseAsync().ConfigureAwait(false);
            }
        }
    }



    #endregion

    #region MongoDB Methods

    public IMongoDatabase GetMongoDatabase(string databaseName)
    {
        return _mongoClient.GetDatabase(databaseName);
    }

    #endregion

    public void Dispose()
    {
        _neo4jDriver?.Dispose();

    }

    private static IConfiguration GetConfiguration()
    {
        return new ConfigurationBuilder().Build();
    }
}
