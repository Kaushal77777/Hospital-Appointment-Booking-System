using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace WCFservice
{
    public class HospitalService : IHospitalService
    {
        string connStr;
        SqlConnection conn;

        public User GetUser(string phone, string password)
        {
            connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connStr);
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            //cmd.CommandText = "SELECT Id,name,password,email,phone FROM users WHERE phone=@phone and password=@password";
            cmd.CommandText = "SELECT * FROM users WHERE phone=@phone and password=@password";
            cmd.Parameters.AddWithValue("@phone", phone);
            cmd.Parameters.AddWithValue("@password", password);

            SqlDataReader reader = cmd.ExecuteReader();
            User user = new User();
            if (reader.HasRows)
            {
                reader.Read();
                user.UserId = reader.GetInt32(0);
                user.Name = reader.GetString(1);
                user.Password = reader.GetString(2);
                user.Email = reader.GetString(3);
                user.Phone = reader.GetString(4);
            }
            else
            {
                return null;
            }
            return user;
        }

        public void SetUser(User user)
        {
            connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                var sql = "INSERT INTO users(name,password,email,phone) VALUES(@uname,@upassword,@uemail,@uphone)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uname", user.Name);
                    cmd.Parameters.AddWithValue("@upassword", user.Password);
                    cmd.Parameters.AddWithValue("@uemail", user.Email);
                    cmd.Parameters.AddWithValue("@uphone", user.Phone);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                conn.Close();
            }
        }

        public Slot GetSlot(string phone)
        {
            connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connStr);
            conn.Open();


            SqlCommand cmd = new SqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = "SELECT Id,userphone,time,city,status FROM slots WHERE userphone=@phone";
            cmd.Parameters.AddWithValue("@phone", phone);

            SqlDataReader reader = cmd.ExecuteReader();
            Slot slot = new Slot();
            if (reader.HasRows)
            {
                reader.Read();
                slot.SlotID = reader.GetInt32(0);
                slot.Userphone = reader.GetString(1);
                slot.Time = reader.GetString(2);
                slot.City = reader.GetString(3);
                slot.Status = reader.GetString(4);
            }
            else
            {
                return null;
            }
            return slot;
        }

        public void SetSlot(Slot slot)
        {
            connStr = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=HospitalDb;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            conn = new SqlConnection(connStr);
            conn.Open();
            try
            {
                var sql = "INSERT INTO slots(userphone,time,city,status) VALUES(@uphone,@utime,@ucity,@ustatus)";
                using (var cmd = new SqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@uphone", slot.Userphone);
                    cmd.Parameters.AddWithValue("@utime", slot.Time);
                    cmd.Parameters.AddWithValue("@ucity", slot.City);
                    cmd.Parameters.AddWithValue("@ustatus", slot.Status);
                    cmd.ExecuteNonQuery();
                }
            }
            catch (Exception e)
            {
                conn.Close();
            }
        }

        
    }
}
