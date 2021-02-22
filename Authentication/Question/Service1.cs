using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Question
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public SqlConnection GetConnection()
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security=True");
            return con;
        }
        public bool AddQuestion(Que question)
        {
            SqlConnection con = GetConnection();
            string query1 = "select count (id) from [ques]";
            string query = "insert into [ques] values(@id,@Question, @op1, @op2, @op3, @op4, @ans)";
            SqlCommand cmd = new SqlCommand(query, con);
            SqlCommand cmd1 = new SqlCommand(query1, con);
            con.Open();
            int count = Convert.ToInt32(cmd1.ExecuteScalar());
            
            cmd.Parameters.AddWithValue("@Question", question.QuestionVal);
            cmd.Parameters.AddWithValue("@op1", question.Option1);
            cmd.Parameters.AddWithValue("@op2", question.Option2);
            cmd.Parameters.AddWithValue("@op3", question.Option3);
            cmd.Parameters.AddWithValue("@op4", question.Option4);
            cmd.Parameters.AddWithValue("@ans", question.Answer);
            cmd.Parameters.AddWithValue("@id", count+1);
            int result = cmd.ExecuteNonQuery();

            con.Close();
            if (result > 0) return true;
            else return false;
        }

        public bool DeleteQuestion(string question)
        {
            SqlConnection con = GetConnection();
            string query = "delete from [ques] where question=@q";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@q", question);
            con.Open();
            int result = cmd.ExecuteNonQuery();
            con.Close();
            if (result > 0) return true;
            else return false;
        }

        public Que FindQuestion(string question)
        {
            Que q = new Que();
            SqlConnection con = GetConnection();
            string query = "select * from [ques] where question=@q";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@q", question);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            if (reader.Read() == true)
            {
                q.QuestionVal = reader[0].ToString();
                q.Option1 = reader[1].ToString();
                q.Option2 = reader[2].ToString();
                q.Option3 = reader[3].ToString();
                q.Option4 = reader[4].ToString();
                q.Answer = reader[5].ToString();
            }
            con.Close();
            return q;
        }

        public List<Que> GetAllQuestions()
        {
            List<Que> questions = new List<Que>();
            SqlConnection con = GetConnection();
            string query = "select * from [ques]";
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                Que q = new Que
                {
                    QuestionVal = reader[0].ToString(),
                    Option1 = reader[1].ToString(),
                    Option2 = reader[2].ToString(),
                    Option3 = reader[3].ToString(),
                    Option4 = reader[4].ToString(),
                    Answer = reader[5].ToString(),
                };
                questions.Add(q);
            }
            return questions;
        }

        public bool IsCorrect(string question, string answer)
        {
            Que q = FindQuestion(question);
            if (answer == q.Answer) return true;
            else return false;
        }

        public bool UpdateQuestion(string question, Que updatedVal)
        {
            SqlConnection con = GetConnection();
            string query = "update [ques] set question=@q1, op1=@op1, op2=@op2, op3=@op3, op4=@op4, ans=@a where question=@q";
            SqlCommand cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@q1", updatedVal.QuestionVal);
            cmd.Parameters.AddWithValue("@op1", updatedVal.Option1);
            cmd.Parameters.AddWithValue("@op2", updatedVal.Option2);
            cmd.Parameters.AddWithValue("@op3", updatedVal.Option3);
            cmd.Parameters.AddWithValue("@op4", updatedVal.Option4);
            cmd.Parameters.AddWithValue("@a", updatedVal.Answer);
            cmd.Parameters.AddWithValue("@q", question);
            con.Open();

            int result = cmd.ExecuteNonQuery();
            if (result > 0) return true;
            else return false;
        }

       
    }
}
