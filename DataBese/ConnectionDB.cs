namespace rent3s.DataBase;
using rent3s.Domain.Interfaces;
using System.Data;

public class ConnectionDB : IConnectionDB
{
    private readonly string strConn;
    public ConnectionDB(IConfiguration configuration
    )
    {
        strConn = configuration["database"];
    }
    public DataView GetDataView(string sql)
    {
        var ds = new DataSet();
        try
        {
            //Fuciona com um dispose, retira da memoria.
            using(var _conn = new Npgsql.NpgsqlConnection(strConn))
            {
                _conn.Open();

                using(var _adapter = new Npgsql.NpgsqlDataAdapter(sql, _conn)){
                    _adapter.Fill(ds);
                }

            }            
        }
        catch (System.Exception ex)
        {
            Console.WriteLine(ex.Message);

            throw new ArgumentException("Não foi possivel concluir sua operação.");
        }

        return ds.Tables[0].DefaultView;
    }

}