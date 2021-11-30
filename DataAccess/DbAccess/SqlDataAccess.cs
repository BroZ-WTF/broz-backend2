using Dapper;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataAccess.DbAccess;

public class SqlDataAccess : ISqlDataAccess {
    private readonly IConfiguration config;

    public SqlDataAccess(IConfiguration config) {
        this.config = config;
    }

    public async Task<IEnumerable<T>> LoadDataAsync<T, U>(string storedProcedure, U parameters, string connectionId = "Default") {
        using IDbConnection con = new SqlConnection(config.GetConnectionString(connectionId));

        return await con.QueryAsync<T>(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }

    public async Task SaveDataAsync<T>(string storedProcedure, T parameters, string connectionId = "Default") {
        using IDbConnection con = new SqlConnection(config.GetConnectionString(connectionId));

        await con.ExecuteAsync(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
    }
}

