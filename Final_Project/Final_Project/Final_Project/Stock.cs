using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace Final_Project
{
    public partial class Stock : Form
    {
        class DBConnection
        {
            public static SqlConnection GetConnection()
            {
                return new SqlConnection(
                @"Data Source=LAPTOP-TA0T06IO\SQLEXPRESS;Integrated Security=True;Persist Security Info=False;Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;Application Name=""SQL Server Management Studio"";Command Timeout=0");
            }
        }

        private void DisplayProduct()
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                string query = "SELECT * FROM Productss";
                SqlDataAdapter da = new SqlDataAdapter(query, con);

                DataTable dt = new DataTable();
                da.Fill(dt);


                dataGridView1.Columns.Clear();


                dataGridView1.DataSource = dt;
            }
        }


        public Stock()
        {
            InitializeComponent();
        }

        private void Stock_Load(object sender, EventArgs e)
        {
            DisplayProduct();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (prosku.Text == "" || proname.Text == "" || prodesc.Text == "" ||
                    procat.Text == "" || proquan.Text == "" || prounit.Text == "" || proprice.Text == "")
                {
                    MessageBox.Show("Missing INFORMATION");
                    return;
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"INSERT INTO Productss 
        (sku, product_name, product_description, prod_category, quantity, unit, price)
        VALUES 
        (@sk, @pn, @pdes, @pcat, @pquan, @punit, @pprice)", con);

                    cmd.Parameters.AddWithValue("@sk", prosku.Text);
                    cmd.Parameters.AddWithValue("@pn", proname.Text);
                    cmd.Parameters.AddWithValue("@pdes", prodesc.Text);
                    cmd.Parameters.AddWithValue("@pcat", procat.Text);
                    cmd.Parameters.AddWithValue("@pquan", proquan.Text);
                    cmd.Parameters.AddWithValue("@punit", prounit.Text);
                    cmd.Parameters.AddWithValue("@pprice", proprice.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product inserted successfully.");
                }

                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void proquan_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtclear_Click(object sender, EventArgs e)
        {
            proid.Clear();
            proname.Clear();
            prosku.Clear();
            prodesc.Clear();
            procat.SelectedIndex = -1;
            proquan.Clear();
            prounit.Clear();
            proprice.Clear();
        }

        private void Updatebtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (prosku.Text == "" || proname.Text == "" || prodesc.Text == "" ||
                    procat.Text == "" || proquan.Text == "" || prounit.Text == "" || proprice.Text == "")
                {
                    MessageBox.Show("Missing INFORMATION");
                    return;
                }

                using (SqlConnection con = DBConnection.GetConnection())
                {
                    con.Open();

                    SqlCommand cmd = new SqlCommand(
                        @"UPDATE Productss SET 
        sku = @sk, product_name = @pn, product_description = @pdes, prod_category = @pcat, quantity = @pquan, unit = @punit, price = @pprice
        WHERE sku = @sk", con);

                    cmd.Parameters.AddWithValue("@sk", prosku.Text);
                    cmd.Parameters.AddWithValue("@pn", proname.Text);
                    cmd.Parameters.AddWithValue("@pdes", prodesc.Text);
                    cmd.Parameters.AddWithValue("@pcat", procat.Text);
                    cmd.Parameters.AddWithValue("@pquan", proquan.Text);
                    cmd.Parameters.AddWithValue("@punit", prounit.Text);
                    cmd.Parameters.AddWithValue("@pprice", proprice.Text);

                    cmd.ExecuteNonQuery();

                    MessageBox.Show("Product updated successfully.");
                }

                DisplayProduct();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void dataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

                prosku.Text = row.Cells["sku"].Value.ToString();
                proname.Text = row.Cells["product_name"].Value.ToString();
                prodesc.Text = row.Cells["product_description"].Value.ToString();
                procat.Text = row.Cells["prod_category"].Value.ToString();
                proquan.Text = row.Cells["quantity"].Value.ToString();
                prounit.Text = row.Cells["unit"].Value.ToString();
                proprice.Text = row.Cells["price"].Value.ToString();
            }
        }

        private void btndelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrEmpty(prosku.Text))
                {
                    MessageBox.Show("Please select a product to delete.");
                    return;
                }

                DialogResult result = MessageBox.Show(
                    "Are you sure you want to delete this product?",
                    "Confirm Delete",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    using (SqlConnection con = DBConnection.GetConnection())
                    {
                        con.Open();

                        SqlCommand cmd = new SqlCommand(
                            "DELETE FROM Productss WHERE sku = @sk", con);

                        cmd.Parameters.AddWithValue("@sk", prosku.Text);

                        cmd.ExecuteNonQuery();
                    }

                    MessageBox.Show("Product deleted successfully!");

                    DisplayProduct(); // refresh grid
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void proid_TextChanged(object sender, EventArgs e)
        {

        }
    }


}
