using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebForm
{
    public partial class UserRegister : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void handleSubmit(object sender, EventArgs e)
        {
            //extract form fields
            String usernameValue = userName.Text;
            String passwordValue = password.Text;
            String confirmPasswordValue = confirmPassword.Text;
 

            // check if the password and confirm password are same
            if (passwordValue != confirmPasswordValue)
            {
                result.Text = "Passwords do not match";
                return;
            }

            string gender;

            if (genderMale.Checked)
            {
                gender = genderMale.Text;
            }
            else if (genderFemale.Checked)
            {
                gender = genderFemale.Text;
            }
            else{
                result.Text = "Please select a gender";
                return;
            }

            string course = "";
            if (c.Checked)
            {
                course += c.Text + ", ";
            }
            if (cpp.Checked)
            {
                course += cpp.Text + ", ";
            }
            if (java.Checked)
            {
                course += java.Text + ", ";
            }

            string countryValue = "";
            if (country.SelectedValue != "")
            {
                countryValue = country.SelectedValue;
            }
            else
            {
                result.Text = "Please select a country";
                return;
            }

            try
            {
                string connectionString = "Data Source=SHREEJALDHUNGAN;Initial Catalog=db_prime;Integrated Security=True";
                SqlConnection conn = new SqlConnection(connectionString);
                conn.Open();

                string query = "INSERT INTO tbl_register (username, password, gender, course, country) VALUES (" +
                    "@username, @password, @gender, @course, @country)";
                SqlCommand sc = new SqlCommand(query, conn);
                sc.Parameters.AddWithValue("@username", usernameValue);
                sc.Parameters.AddWithValue("@password", passwordValue);
                sc.Parameters.AddWithValue("@gender", gender);
                sc.Parameters.AddWithValue("@course", course);
                sc.Parameters.AddWithValue("@country", countryValue);

                int res = sc.ExecuteNonQuery();
                if (res > 0)
                {
                    result.Text = "User registered successfully";
                }
                else
                {
                    result.Text = "Failed to register user";
                }
            }
            catch (SqlException error)
            {
                result.Text = error.Message;
            }
        }
    }
}