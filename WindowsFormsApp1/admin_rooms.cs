using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace WindowsFormsApp1
{
    public partial class admin_rooms : UserControl
    {
        private string conn = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\Joy07\Documents\hotel1.mdf;Integrated Security=True;Connect Timeout=30";

        public admin_rooms()
        {
            InitializeComponent();

            displayRoomsData();
        }

        public void refreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)refreshData);
                return;
            }
            displayRoomsData();
        }
        public void displayRoomsData()
        {
            roomsData rData = new roomsData();
            List<roomsData> listD = rData.roomsDataList();

            dataGridView1.DataSource = listD;
        }
        public bool isEmpty()
        {
            if(string.IsNullOrEmpty(rooms_roomID.Text) || string.IsNullOrEmpty(rooms_roomName.Text)
                || rooms_type.SelectedIndex == -1 || string.IsNullOrEmpty(rooms_price.Text)
                || rooms_status.SelectedIndex == -1 || rooms_picture.Image == null)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private void rooms_addBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please fill all blank fields", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(conn))
                    {
                        connect.Open();

                        string checkRoomRID = "SELECT room_id FROM rooms WHERE room_id = @roomID";
                        using (SqlCommand checkRID = new SqlCommand(checkRoomRID, connect))
                        {
                            checkRID.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());

                            SqlDataAdapter adapter = new SqlDataAdapter(checkRID);
                            DataTable table = new DataTable();

                            adapter.Fill(table);

                            if (table.Rows.Count > 0)
                            {
                                MessageBox.Show(rooms_roomID.Text.Trim() + "is existing already"
                                    , "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                string insertData = "INSERT INTO  rooms (room_id, type, room_name, price, image_path, status, date_register)" +
                                    "VALUES(@room_ID, @type, @name, @price, @path, @status, @date_reg)";


                                string path = Path.Combine(@"C:\Users\Joy07\source\repos\WindowsFormsApp1\WindowsFormsApp1\room_directory\" +
                                    rooms_roomID.Text.Trim() + ".jpg");

                                string directoryPath = Path.GetDirectoryName(path);

                                if (!Directory.Exists(directoryPath))
                                {
                                    Directory.CreateDirectory(directoryPath);
                                }

                                File.Copy(rooms_picture.ImageLocation, path, true);

                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@room_ID", rooms_roomID.Text.Trim());
                                    cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                    cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                    cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());

                                    cmd.Parameters.AddWithValue("@path", path); // FOR THE IMAGE

                                    cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                    DateTime today = DateTime.Today;
                                    cmd.Parameters.AddWithValue("@date_reg", today);

                                    cmd.ExecuteNonQuery();
                                    clearFields();
                                    displayRoomsData();


                                    MessageBox.Show("Added successfully!", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                }
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);

                }

            }

        }

        private void rooms_importBtn_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog file = new OpenFileDialog();
                string imagePath = "";

                file.Filter = "Image Files (*.jpg; *.png)|*.jpg;*.png";

                if (file.ShowDialog() == DialogResult.OK)
                {
                    imagePath = file.FileName;
                    rooms_picture.ImageLocation = imagePath;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error: {ex}", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void rooms_updateBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you want to UPDATE ID: " + id + "?", "Confirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET room_id = @roomID, type = @type, room_name = @name, price =@price" +
                                ", status = @status, date_update = @update WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {
                                cmd.Parameters.AddWithValue("@roomID", rooms_roomID.Text.Trim());
                                cmd.Parameters.AddWithValue("@type", rooms_type.SelectedItem.ToString());
                                cmd.Parameters.AddWithValue("@name", rooms_roomName.Text.Trim());
                                cmd.Parameters.AddWithValue("@price", rooms_price.Text.Trim());
                                cmd.Parameters.AddWithValue("@status", rooms_status.SelectedItem.ToString());

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@update", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Updated successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch(Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private int id;
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if(e.RowIndex != -1)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                id = (int)row.Cells[0].Value;
                rooms_roomID.Text = row.Cells[1].Value.ToString();
                rooms_type.Text = row.Cells[2].Value.ToString();
                rooms_roomName.Text = row.Cells[3].Value.ToString();
                rooms_price.Text = row.Cells[4].Value.ToString();

                rooms_picture.ImageLocation = row.Cells[5].Value.ToString();

                rooms_status.Text = row.Cells[6].Value.ToString();


            }
        }

        public void clearFields()
        {
            rooms_roomID.Text = "";
            rooms_type.SelectedIndex = -1;
            rooms_roomName.Text = "";
            rooms_price.Text = "";
            rooms_picture.Image = null;
            rooms_status.SelectedIndex = -1;
        }
        private void rooms_clearBtn_Click(object sender, EventArgs e)
        {
            clearFields();
        }


        private void rooms_deleteBtn_Click(object sender, EventArgs e)
        {
            if (isEmpty())
            {
                MessageBox.Show("Please select item first", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (MessageBox.Show("Are you want to DELETE ID: " + id + "?", "Confirmation Message"
                   , MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        using (SqlConnection connect = new SqlConnection(conn))
                        {
                            connect.Open();

                            string updateData = "UPDATE rooms SET date_delete = @delete WHERE id = @id";

                            using (SqlCommand cmd = new SqlCommand(updateData, connect))
                            {

                                DateTime today = DateTime.Today;
                                cmd.Parameters.AddWithValue("@delete", today);
                                cmd.Parameters.AddWithValue("@id", id);

                                cmd.ExecuteNonQuery();

                                clearFields();
                                displayRoomsData();

                                MessageBox.Show("Deleted successfully", "Information Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Something went wrong :3", "Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
