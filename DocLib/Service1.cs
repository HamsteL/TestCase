using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Data.SqlClient;
using System.Data.OleDb;
using System.Data;

namespace DocLib
{
    [ServiceBehavior(IncludeExceptionDetailInFaults = true)]
    public class DocService : IService1
    {
        //Путь к базе данных
        private string connString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=C:\\Users\\hamst\\Desktop\\TestCase\\DocLib\\DocLib\\DocBase.mdf;Integrated Security=True";
        //Добавление нового документа
        public bool AddNewDoc(Document doc)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("AddNewDoc", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@numberd", doc.NumberDoc));
                    command.Parameters.Add(new SqlParameter("@dated", doc.DateDoc));
                    command.Parameters.Add(new SqlParameter("@descd", doc.DescDoc));
                    command.Parameters.Add(new SqlParameter("@statusd", doc.StatusDoc));
                    int test = command.ExecuteNonQuery();
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }

        //Получить все документы из бд
        public DataSet GetAllData()
        {
            DataSet data = new DataSet("Docs");

            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("getDataToGrid", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Connection = conn;
                    SqlDataAdapter dataAdapter = new SqlDataAdapter();
                    dataAdapter.SelectCommand = command;
                    dataAdapter.Fill(data, "Docs");

                    for (int i = 0; i < data.Tables["Docs"].Rows.Count; i++)
                    {
                        data.Tables["Docs"].Rows[i][2] = data.Tables["Docs"].Rows[i][2].ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            return data;
        }

        //Изменение статуса документа
        public bool ChangeStatus(int docNumber, string newStatus)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("changeStatus", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@numberd", docNumber));
                    command.Parameters.Add(new SqlParameter("@newStatus", newStatus));
                    int test = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }
        //Получение одного документа из бд
        public Document getDocument(int numDoc)
        {
            DataSet data = new DataSet("Doc");
            Document doc = new Document();
            using (var conn = new SqlConnection(connString))
            {
                conn.Open();
                SqlCommand command = new SqlCommand("getDocument", conn);
                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Add(new SqlParameter("@numDoc", numDoc));
                command.Connection = conn;
                SqlDataAdapter dataAdapter = new SqlDataAdapter();
                dataAdapter.SelectCommand = command;
                dataAdapter.Fill(data, "Doc");

                doc.NumberDoc = Int32.Parse(data.Tables["Doc"].Rows[0].ItemArray[1].ToString());
                doc.DateDoc = data.Tables["Doc"].Rows[0].ItemArray[2].ToString();
                doc.DescDoc = data.Tables["Doc"].Rows[0].ItemArray[3].ToString();
                doc.StatusDoc = data.Tables["Doc"].Rows[0].ItemArray[4].ToString();
                doc.SignDoc = bool.Parse(data.Tables["Doc"].Rows[0].ItemArray[5].ToString());
            }

            return doc;
        }

        //Подпись документа
        public bool makeSign(int numDoc)
        {
            try
            {
                using (var conn = new SqlConnection(connString))
                {
                    conn.Open();
                    SqlCommand command = new SqlCommand("makeSign", conn);
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@numDoc", numDoc));
                    int test = command.ExecuteNonQuery();
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                return false;
            }

            return true;
        }
    }
}
