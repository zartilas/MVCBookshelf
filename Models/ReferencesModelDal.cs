using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MVCBookshelf.Models
{
    public class ReferencesModelDal
    {
       /* SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["constr"].ToString());
        public int InsertAuthor(authors authorsModel)
        {
            SqlCommand cmd = new SqlCommand("INSERT INTO Customers VALUES(@Name,@Country)", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@Name", authorsModel.au_id);
            cmd.Parameters.AddWithValue("@Country", authorsModel.au_fname);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int UpdateCustomer(authors authorsModel)
        {
            SqlCommand cmd = new SqlCommand("UPDATE Customers SET Name = @Name, Country = @Country WHERE CustomerId = @CustomerId", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@au_id", authorsModel.au_id);
            cmd.Parameters.AddWithValue("@Name", authorsModel.);
            cmd.Parameters.AddWithValue("@Country", authorsModel.Country);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public int DeleteCustomer(int authorId)
        {
            SqlCommand cmd = new SqlCommand("DELETE FROM authors WHERE au_id = @au_id", con);
            cmd.CommandType = CommandType.Text;
            cmd.Parameters.AddWithValue("@CustomerId", authorId);
            con.Open();
            int i = cmd.ExecuteNonQuery();
            con.Close();
            return i;
        }

        public List<CustomerModel> GetCustomers()
        {
            List<CustomerModel> customers = new List<CustomerModel>();
            SqlCommand cmd = new SqlCommand("SELECT * FROM Customers", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter sd = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            con.Open();
            sd.Fill(dt);
            con.Close();
            foreach (DataRow dr in dt.Rows)
            {
                customers.Add(
                    new CustomerModel
                    {
                        CustomerId = Convert.ToInt32(dr["CustomerId"]),
                        Name = Convert.ToString(dr["Name"]),
                        Country = Convert.ToString(dr["Country"])
                    });
            }
            return customers;
        }*/
    }
}
