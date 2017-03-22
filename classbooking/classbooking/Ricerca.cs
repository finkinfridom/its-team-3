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

        public List<int> cerca()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = ConfigurationManager.ConnectionStrings["MyDBConnectionString"].ConnectionString;
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            SqlDataReader reader;
            conn.Open();

            bool flag = true;
            //string queryStringSingolaAulaProgrammi = "SELECT IDA FROM [SelectSoftware] WHERE IDS = ";
            string queryString = "SELECT * FROM [SelectSoftware]";
            cmd.CommandText = queryString;

            //List<int> lP = new List<int>();
            List<int> lA = new List<int>();

            List<int>[] l = new List<int>[10];
            for (int i = 0; i < l.Length; i++)
            {
                l[i] = new List<int>();
            }

            reader = cmd.ExecuteReader();
            if (reader.HasRows)
            {
                while (reader.Read())
                {
                    int a = reader.GetInt32(0) - 1;
                    int b = reader.GetInt32(1);
                    l[a].Add(b);
                }
            }
            for (int i = 0; i < l.Length; i++)
            {
                for (int j = 0; j < programmi.Length; j++)
                {
                    if (programmi[j] && !l[i].Contains(j))
                    {
                        flag = false;
                        break;
                    }
                }

                if (flag)
                    lA.Add(i);

                flag = true;
            }
            for (int i = 0, j = 0; i < aule.Length; i++)
            {
                if (j < lA.Count)
                {
                    if (lA[j] == i && j < lA.Count)
                    {
                        aule[i] = true;
                        j++;
                    }
                    else
                        aule[i] = false;
                }
                else { aule[i] = false; }

            }

            queryString = "";



            conn.Close();
            return lA;


            /*for (int i = 0; i < programmi.Length; i++)
            {
                if (programmi[i] == true)
                {
                    lP.Add(i);
                }
            }

            if(lP.Count != 0)
            {
                queryStringSingolaAulaProgrammi = string.Concat(queryStringSingolaAulaProgrammi, lP[0]);
                cmd.CommandText = queryStringSingolaAulaProgrammi;
                reader.
                reader = cmd.ExecuteReader();
                queryStringSingolaAulaProgrammi=queryStringSingolaAulaProgrammi.Remove(queryStringSingolaAulaProgrammi.IndexOf(lP[0].ToString()));

                if (reader.HasRows)
                {
                    //lA.Add(reade)
                    //reader.Read();
                    //lA.Add(reader.GetInt32(0));
                    for (int i=0; reader.Read(); i++)
                    {
                        lA.Add(reader.GetInt32(0));
                    }

                    for (int i = 1; i < lP.Count; i++)
                    {
                        //reader = cmd.EndExecuteReader();
                        queryStringSingolaAulaProgrammi = string.Concat(queryStringSingolaAulaProgrammi, lP[i]);
                        cmd.CommandText = queryStringSingolaAulaProgrammi;
                        reader = cmd.ExecuteReader();
                        
                        if (reader.HasRows)
                        {
                            for(int j=0; j<lA.Count; j++)
                            {
                                for (int k=0; reader.Read(); k++)
                                {                                 
                                    if (lA[j].Equals(reader.GetInt32(0)))
                                    {
                                        flag = true;
                                        break;
                                    }
                                }

                                if (!flag)
                                {
                                    lA.RemoveAt(j);
                                    j--;
                                }

                                flag = false;
                            }
                        }

                        queryStringSingolaAulaProgrammi.Remove(queryStringSingolaAulaProgrammi.IndexOf(lP[i].ToString()));
                    }
                }
            }*/
       
            
        }
    }
}
