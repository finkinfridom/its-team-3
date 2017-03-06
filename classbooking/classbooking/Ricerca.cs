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
        public void setdate(DateTime d) { date = d;}

        public void cerca()
        {

            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
           /* try
            {
                conn.Open();
            }
            catch (Exception)
            {
                throw;
            }*/

            SqlCommand cmd = new SqlCommand();
            SqlDataReader reader;
            conn.Open();

            for(int i=0; i<programmi.Length; i++)
            {
                if(programmi[i]==true)
                {
                    cmd.CommandText = "select * from [Software] where Id='" + i + "'";
                    cmd.CommandType = CommandType.Text;
                    cmd.Connection = conn;
                    try
                    {
                        reader = cmd.ExecuteReader();
                    }
                    catch(Exception)
                    {
                     
                            
                            

                        
                    }
                }
                foreach( Boolean programmi in aule)
                {
                    
                }
                
            }
            conn.Close();
        }

    }
}
