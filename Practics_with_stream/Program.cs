using MySql.Data.MySqlClient;
using Practics_with_stream;
using System.Data;

String Id = Console.ReadLine();
int Pass = int.Parse(Console.ReadLine());

DB dB = new DB();

var table = new DataTable();

MySqlDataAdapter adapter = new MySqlDataAdapter();

MySqlCommand command = new MySqlCommand("SELECT * FROM 'gr' WHERE 'member' = Id AND 'card' = Pass", dB.getConnection());

//command.Parameters.Add("@uI", MySqlDbType.VarChar).Value = Id;
//command.Parameters.Add("@uP", MySqlDbType.Int32).Value = Pass;

adapter.SelectCommand = command;
adapter.Fill(table);

if (table.Rows.Count > 0)
{
    Console.WriteLine(table);
}

else
{

    Console.WriteLine("No");
}