
using Domen;
using Microsoft.Data.SqlClient;

using SqlConnection connection = new SqlConnection(@"Data Source=(localdb)\mssqllocaldb;Initial Catalog=vezbe06;Integrated Security=True;");
try
{
	connection.Open();
	SqlCommand command = connection.CreateCommand();
	command.CommandText = "select * from grad";
	using SqlDataReader reader = command.ExecuteReader();
	List<Grad> result = new List<Grad>();
	while (reader.Read())
	{
		Grad grad = new Grad();
		grad.Ptt = (long)reader["ptt"];
		grad.Naziv = (string)reader["naziv"];
		result.Add(grad);
	}

	Console.WriteLine("Ucitana je lista gradova:");
	foreach (Grad grad in result)
	{
		Console.WriteLine($"Id:{grad.Ptt}, Naziv:{grad.Naziv}");
	}

}
catch (SqlException ex)
{
    Console.WriteLine($"Greska: {ex.Message}");
}