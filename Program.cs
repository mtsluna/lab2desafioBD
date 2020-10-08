using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace db
{
    class Program
    {
        static void Main(string[] args)
        {

            MySqlConnection mySql = new MySqlConnection("Server=localhost; Database=ejemplo; Uid=root; Pwd=");

            try
            {
                mySql.Open();
                Console.WriteLine("Se abrio correctamete");

                MySqlCommand mySqlCommand = new MySqlCommand("SELECT * FROM personas", mySql);
                MySqlDataAdapter mySqlDataAdapter = new MySqlDataAdapter();
                mySqlDataAdapter.SelectCommand = mySqlCommand;
                DataTable dataTable = new DataTable();
                mySqlDataAdapter.Fill(dataTable);
                foreach(DataRow dataRow in dataTable.Rows)
                {
                    Console.WriteLine(dataRow["dni"]+" - "+ dataRow["nombre"]+" - "+ dataRow["apellido"]);
                }

            } catch(Exception e)
            {
                Console.WriteLine("No se abrio correctamete");
            }

            Console.WriteLine("Para salir presione cualquier tecla...");
            Console.ReadKey();

        }
    }
}
