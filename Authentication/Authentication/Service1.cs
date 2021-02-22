using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Portal
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in both code and config file together.
    public class Service1 : IService1
    {
        public bool addUser(string email, string fname, string lname, string password, string role)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "INSERT INTO users(email,fname,lname,password,role)VALUES(@email,@fname,@lname,@password,@role)";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@fname", fname);
                    cmd.Parameters.AddWithValue("@lname", lname);
                    cmd.Parameters.AddWithValue("@password", password);
                    cmd.Parameters.AddWithValue("@role", role);

                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        public bool checkUser(string email, string password)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from users where email = '" + email + "' and password = '" + password + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        public List<User> getUsers()
        {
            List<User> users = new List<User>();
            User u;
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename =D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from users";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        u = new User();
                        u.email = rdr["email"].ToString();
                        u.fname = rdr["fname"].ToString();
                        u.lname = rdr["lname"].ToString();
                        users.Add(u);
                    }
                    rdr.Close();
                    return users;
                }
            }
            catch (Exception err)
            {
                return users;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        public User getSingleUser(string email)
        {
            User u = new User();
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from users where email = '" + email + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    while (rdr.Read())
                    {
                        u.email = rdr["email"].ToString();
                        u.fname = rdr["fname"].ToString();
                        u.lname = rdr["lname"].ToString();

                    }
                    rdr.Close();
                    return u;
                }
            }
            catch (Exception err)
            {
                return u;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        public bool delete(string email, string password)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";
                using (con)
                {
                    string command = "select * from users where email = '" + email + "' and password = '" + password + "'";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    SqlDataReader rdr = cmd.ExecuteReader();
                    if (rdr.Read())
                    {
                        command = "delete from users where email = '" + email + "' and password = '" + password + "'";
                        cmd = new SqlCommand(command, con);
                        cmd.ExecuteNonQuery();
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                    rdr.Close();
                }
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }

        public bool update(string email, string fname, string lname, string role)
        {
            SqlConnection con = null;
            SqlCommand cmd = null;
            try
            {
                con = new SqlConnection();
                con.ConnectionString = @"Data Source = (LocalDB)\MSSQLLocalDB;AttachDbFilename = D:\c#codes\Client\Client\App_Data\Database1.mdf;Integrated Security = True";

                using (con)
                {
                    string command = "UPDATE Place set fname = @fname, lanme = @lname, role=@role where id='" + email + "' ";
                    cmd = new SqlCommand(command, con);
                    con.Open();
                    cmd.Parameters.Add("@fname", fname);
                    cmd.Parameters.Add("@lname", lname);
                    cmd.Parameters.Add("@role", role);

                    int res = cmd.ExecuteNonQuery();
                    if (res == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }
            }
            catch (Exception err)
            {
                return false;
            }
            finally
            {
                if (con != null)
                {
                    con.Dispose();
                }
                if (cmd != null)
                {
                    cmd.Dispose();
                }
            }
        }
    }
}
