using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Configuration;
using System.Data;

namespace classbooking
{
    public class Ricerca
    {
        DateTime date = new DateTime();
        public Boolean[] programmi = new Boolean[12];
        public Boolean[] aule = new Boolean[10];
        public void setdate(DateTime d) { date = d; }

        public void cerca()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            conn.Open();

            bool flag = false;
            string queryStringNomeProgramma = "SELECT nome FROM [Software] WHERE Id = ";
            string queryStringListaProgrammi = "";
            for (int i = 0; i < programmi.Length; i++)
            {
                if(programmi[i] == true)
                {

                    queryStringNomeProgramma = string.Concat(queryStringNomeProgramma, i);
                    cmd.CommandText = queryStringNomeProgramma;
                    reader = cmd.ExecuteReader();

                    if (!flag)
                    {
                        queryStringListaProgrammi = string.Concat(queryStringListaProgrammi, reader.ToString());
                        flag = true;
                    }
                    else
                    {
                        queryStringListaProgrammi = string.Concat(queryStringListaProgrammi, string.Concat("AND", reader.ToString()));
                    }
                    
                    queryStringNomeProgramma.Remove(queryStringNomeProgramma.IndexOf(i.ToString()));
                }
            }

            



            for (int i = 0; i < programmi.Length; i++)
            {
                if (programmi[i] == true)
                {
                    cmd.CommandText = "select * from [Software] where Id='1'";

                    //cmd.CommandType = CommandType.Text;
                    //cmd.Connection = conn;
                    
                    /*try
                    {
                        reader = cmd.ExecuteReader();
                        
                    }
                    catch (Exception)
                    {
                        throw;
                    }*/
                }
                foreach (Boolean programmi in aule)
                {

                }
            }
            conn.Close();
        }
    }
}
