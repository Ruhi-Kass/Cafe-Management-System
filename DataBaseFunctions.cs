using System.Data;
using System.Data.SqlClient;
using System.Security.Cryptography;
using System.Text;

namespace Cafe_Management_System
{
    internal partial class Functions
    {
        SqlConnection connection = new SqlConnection("Data Source=.;Initial Catalog=Cafe_management_system;Integrated Security=True;");
        SqlCommand cmd;
        string query = "";
        /*============================================================================================================================================================================*/
        /*============================================================================================================================================================================*/
        public bool Login(string username, string password)//function that handles logins.returns true or false
        {
            try
            {
                using (connection)
                {
                    connection.Open();

                    // Retrieve the stored hashed password from the database
                    query = "SELECT password FROM userLogin WHERE username = @Username";
                    cmd = new SqlCommand(query, connection);

                    cmd.Parameters.AddWithValue("@Username", username);

                    byte[] storedHashedPassword = (byte[])cmd.ExecuteScalar();

                    // Hash the user-provided password
                    byte[] userHashedPassword = HashString(password);

                    // Compare the hashed passwords
                    if (storedHashedPassword.SequenceEqual(userHashedPassword)) 
                    {
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Invalid username or password!");
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Incorrect user name or password!");
            }
            return false;
        }
        /*============================================================================================================================================================================*/
        /*============================================================================================================================================================================*/

        //function that hashes user input password.
        public byte[] HashString(string str)
        {

            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] inputBytes = Encoding.UTF8.GetBytes(str);
                byte[] hashedBytes = sha256.ComputeHash(inputBytes);
                return hashedBytes;
            }
        }
        /*============================================================================================================================================================================*/
        /*============================================================================================================================================================================*/
        public void Execute(string query)//function for executing queries with no result set return.
        {
            try
            {
                using (connection)
                {
                    connection.Open();
                    cmd = new SqlCommand(query, connection);
                    cmd.ExecuteNonQuery();
                }
             MessageBox.Show("succesfull!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /*============================================================================================================================================================================*/
        /*============================================================================================================================================================================*/
        public void SetImage(PictureBox pictureBox)//Function for setting images in a Picture Box.
        {
            //class for prompting the user to open file from a directory.
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // User selected image file
                string imagePath = openFileDialog.FileName;

                // Load the image into a Bitmap object
                Bitmap image = new Bitmap(imagePath);


                pictureBox.Image = image;

                pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;

            }
        }

        public void SetMenuImage(PictureBox pictureBox, Image image)//Function for setting images in a Picture Box.
        {
            pictureBox.Image = image;
            pictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
        }
 /*============================================================================================================================================================================*/
 /*============================================================================================================================================================================*/

        //Function that gets the image stored in the Data Base.
        public Image RetriveImage(int id)
        {
            connection.Open();
            cmd = new SqlCommand("SELECT IMG FROM menuitems where menuitem_id=@id", connection);
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value=id;
            byte[] imageData = (byte[])cmd.ExecuteScalar();
            Image image;
            using (MemoryStream ms = new MemoryStream(imageData))
            {
                image = Image.FromStream(ms);
            }
            return image;
        }
 /*============================================================================================================================================================================*/
 /*============================================================================================================================================================================*/
        public void viewTable(string name, DataGridView dgv)//function for displaying database tables in a data grid view.
        {
            try
            {
                connection = new SqlConnection("Data Source=.;Initial Catalog=Cafe_management_system;Integrated Security=True;");
                using (connection)
                {
                    connection.Open();
                    cmd = new SqlCommand($"select * from {name}", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
/*============================================================================================================================================================================*/
/*============================================================================================================================================================================*/
        public void viewOrdersTable(DataGridView dgv)//function for displaying database tables in a data grid view.
        {
            try
            {
                connection = new SqlConnection("Data Source=.;Initial Catalog=Cafe_management_system;Integrated Security=True;");
                using (connection)
                {
                    connection.Open();
                    cmd = new SqlCommand($"SELECT * FROM orders JOIN orderitem ON orders.Order_id = orderitem.orderid JOIN customer ON orders.Customer_id = customer.Customer_id", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 /*============================================================================================================================================================================*/
 /*============================================================================================================================================================================*/
        public void viewSuppleirsTable(DataGridView dgv)//function for displaying database tables in a data grid view.
        {
            try
            {
                connection = new SqlConnection("Data Source=.;Initial Catalog=Cafe_management_system;Integrated Security=True;");
                using (connection)
                {
                    connection.Open();
                    cmd = new SqlCommand($"SELECT * FROM suppliers JOIN supplier_phonenumbers ON suppliers.supplier_id = supplier_phonenumbers.sid JOIN supplier_address ON suppliers.supplier_id  = supplier_address.sid", connection);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 /*============================================================================================================================================================================*/
 /*============================================================================================================================================================================*/
        public void viewSearchedTable(string tablename, string value, string val, DataGridView dgv)//function for displaying database tables in a data grid view.
        {
            try
            {
                connection = new SqlConnection("Data Source=.;Initial Catalog=Cafe_management_system;Integrated Security=True;");
                using (connection)
                {
                    connection.Open();
                    cmd = new SqlCommand($"select * from {tablename} where {value}=@value", connection);
                    cmd.Parameters.AddWithValue("@value", val);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable table = new DataTable();

                    adapter.Fill(table);
                    dgv.DataSource = table;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
 /*============================================================================================================================================================================*/
 /*============================================================================================================================================================================*/
    }
}
