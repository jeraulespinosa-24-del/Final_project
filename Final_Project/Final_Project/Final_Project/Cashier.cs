using Microsoft.Data.SqlClient;

namespace Final_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessSKU(string sku)
        {
            using (SqlConnection con = DBConnection.GetConnection())
            {
                con.Open();

                SqlCommand cmd = new SqlCommand(
                    "SELECT product_name, price, unit FROM Productss WHERE sku = @sku", con);

                cmd.Parameters.AddWithValue("@sku", sku);

                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string name = reader["product_name"].ToString();
                        decimal price = Convert.ToDecimal(reader["price"]);
                        string unit = reader["unit"].ToString();

                        int qty = 1;
                        decimal amount = qty * price;

                        dataGridView1.Rows.Add(name, qty, unit, price, amount);

                        UpdateSubtotal(); // 🔥 CALL THIS
                    }
                    else
                    {
                        MessageBox.Show("Product not found!");
                    }
                }

                SqlCommand update = new SqlCommand(
                    "UPDATE Productss SET quantity = quantity - 1 WHERE sku = @sku AND quantity > 0", con);

                update.Parameters.AddWithValue("@sku", sku);
                update.ExecuteNonQuery();
            }
        }





        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button15_Click(object sender, EventArgs e)
        {
            Stock stock = new Stock();
            stock.ShowDialog();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ReadOnly = false;
            dataGridView1.Columns["qty"].ReadOnly = false;


            dataGridView1.Columns[0].ReadOnly = true;  // Name
            dataGridView1.Columns[1].ReadOnly = false; // Qty (EDITABLE)
            dataGridView1.Columns[2].ReadOnly = true;  // Unit
            dataGridView1.Columns[3].ReadOnly = true;  // Price
            dataGridView1.Columns[4].ReadOnly = true;  // Amount


            dataGridView1.Columns["qty"].ReadOnly = false;

        }


        private void btnNum0_Click(object sender, EventArgs e)
        {
            const int num = 0;
            txtSku.Text += num.ToString();
        }
        private void btnNum1_Click(object sender, EventArgs e)
        {
            const int num = 1;
            txtSku.Text += num.ToString();
        }
        private void btnNum2_Click(object sender, EventArgs e)
        {
            const int num = 2;
            txtSku.Text += num.ToString();
        }
        private void btnNum3_Click(object sender, EventArgs e)
        {
            const int num = 3;
            txtSku.Text += num.ToString();
        }
        private void btnNum4_Click(object sender, EventArgs e)
        {
            const int num = 4;
            txtSku.Text += num.ToString();
        }
        private void btnNum5_Click(object sender, EventArgs e)
        {
            const int num = 5;
            txtSku.Text += num.ToString();
        }
        private void btnNum6_Click(object sender, EventArgs e)
        {
            const int num = 6;
            txtSku.Text += num.ToString();
        }
        private void btnNum7_Click(object sender, EventArgs e)
        {
            const int num = 7;
            txtSku.Text += num.ToString();
        }
        private void btnNum8_Click(object sender, EventArgs e)
        {
            const int num = 8;
            txtSku.Text += num.ToString();
        }
        private void btnNum9_Click(object sender, EventArgs e)
        {
            const int num = 9;
            txtSku.Text += num.ToString();
        }
        private void btnClear_Click(object sender, EventArgs e)
        {
            const string clear = "";
            txtSku.Text = clear;
        }



        private void txt_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnPeriod_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Enter SKU first!");
                return;
            }

            ProcessSKU(txtSku.Text.Trim());
            txtSku.Clear();
        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }




        private void txtsku_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                ProcessSKU(txtSku.Text.Trim());
                txtSku.Clear();

                e.Handled = true;
                e.SuppressKeyPress = true;
            }
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSku.Text))
            {
                MessageBox.Show("Please enter SKU!");
                return;
            }

            ProcessSKU(txtSku.Text.Trim());
            txtSku.Clear();
            txtSku.Focus();
        }
        // 1. Detect change
        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            using var con = DBConnection.GetConnection();
            if (e.RowIndex < 0) return;


            if (e.ColumnIndex == 1)
            {
                RecalculateRow(e.RowIndex);
                UpdateSubtotal();
            }
            {
                con.Open();

              

                RecalculateRow(e.RowIndex);
                SqlCommand update = new SqlCommand(
                    "UPDATE Productss SET quantity = @quantity WHERE sku = @sku", con);

                update.Parameters.AddWithValue("@quantity", textBox1.ToString );
                update.ExecuteNonQuery();
            }
        }

        // 2. Force commit
        private void dataGridView1_CurrentCellDirtyStateChanged(object sender, EventArgs e)
        {
            if (dataGridView1.IsCurrentCellDirty)
            {
                dataGridView1.CommitEdit(DataGridViewDataErrorContexts.Commit);
            }
        }

        // 3. Live typing update
        private void dataGridView1_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
        {
            if (dataGridView1.CurrentCell.ColumnIndex == 1)
            {
                TextBox tb = e.Control as TextBox;
                if (tb != null)
                {
                    tb.TextChanged -= Qty_TextChanged;
                    tb.TextChanged += Qty_TextChanged;
                }
            }
        }

        // 4. While typing
        private void Qty_TextChanged(object sender, EventArgs e)
        {
            if (dataGridView1.CurrentCell == null) return;

            int rowIndex = dataGridView1.CurrentCell.RowIndex;

            RecalculateRow(rowIndex);
            UpdateSubtotal();
        }
        private void RecalculateRow(int rowIndex)
        {
            var row = dataGridView1.Rows[rowIndex];

            if (row.Cells[1].Value == null || row.Cells[3].Value == null)
                return;

            int qty;
            decimal price;

            if (int.TryParse(row.Cells[1].Value.ToString(), out qty) &&
                decimal.TryParse(row.Cells[3].Value.ToString(), out price))
            {
                row.Cells[4].Value = qty * price;
            }
        }

        private void UpdateSubtotal()
        {
            decimal subtotal = 0;

            foreach (DataGridViewRow row in dataGridView1.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    subtotal += Convert.ToDecimal(row.Cells[4].Value);
                }
            }

            txtSubTotal.Text = subtotal.ToString("0.00");
        }

        private void btnPay_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtSubTotal.Text) ||
        string.IsNullOrWhiteSpace(paym.Text))
            {
                MessageBox.Show("Missing subtotal or payment!");
                return;
            }

            decimal subtotal;
            decimal payment;

            if (!decimal.TryParse(txtSubTotal.Text, out subtotal) ||
                !decimal.TryParse(paym.Text, out payment))
            {
                MessageBox.Show("Invalid number format!");
                return;
            }

            if (payment < subtotal)
            {
                MessageBox.Show("Insufficient payment!");
                return;
            }

            decimal change = payment - subtotal;

            txtChange.Text = change.ToString("0.00");

            MessageBox.Show("Payment successful!");
        }



        private void btnVoid_Click_1(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Please select an item to void.");
                return;
            }

            foreach (DataGridViewRow row in dataGridView1.SelectedRows)
            {
                if (!row.IsNewRow)
                {
                    dataGridView1.Rows.Remove(row);
                }
                DialogResult result = MessageBox.Show(
    "Void selected item?",
    "Confirm",
    MessageBoxButtons.YesNo,
    MessageBoxIcon.Warning);

                if (result == DialogResult.No)
                    return;
            }

            UpdateSubtotal();
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
