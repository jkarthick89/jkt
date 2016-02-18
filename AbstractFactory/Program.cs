using Sytem;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            DBProviderFactory oDBFactory = new SQLClient();
            
        }
    }

    class DBCommand
    {
    }
    class DBConnection
    {
    }
    abstract class DBProviderFactory
    {
        DBCommand CreateCommand();
        DBConnection CreateConnection();
    }

    class SQLClient : DBProviderFactory
    {
        DB
    }

    class OracleClient : DBProviderFactory
    {
    }

    class OLEDBClient : DBProviderFactory
    {
    }



    class SQLConnection : DBConnection
    {
    }

    class OLEDBConnection : DBConnection
    {
    }

    class OracleConnection : DBConnection
    {
    }



    class SQLCommand : DBCommand
    {
    }

    class OLEDBCommand : DBCommand
    {
    }

    class OracleCommand : DBCommand
    {
    }
}
