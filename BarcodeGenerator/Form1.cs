using System;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;

namespace BarcodeGenerator
{
    public partial class Form1 : Form
    {
        SqlConnection connection;
        string connectionString;

        public Form1()
        {
            InitializeComponent();

            connectionString = ConfigurationManager.ConnectionStrings["BarcodeGenerator.Properties.Settings.LastInfoCacheConnectionString"].ConnectionString;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            PopulateCachedInfo();
        }

        private void PopulateCachedInfo()
        {
            string query = "SELECT * FROM LastInfoCache";

            using (connection = new SqlConnection(connectionString))
            using (SqlDataAdapter adapter = new SqlDataAdapter(query, connection))
            {
                DataTable cachedInfoTable = new DataTable();
                adapter.Fill(cachedInfoTable);

                lastSubmitDate.Text = $"{cachedInfoTable.Container}";
                lastRange1.Text = $"{cachedInfoTable.Container}";
                lastRange2.Text = $"{cachedInfoTable.Container}";
            }
        }

        private void CacheCurrentInfo()
        {
            string query = "UPDATE LastInfoCache " +
                        "SET LastDate = @LastDate, LastRange1 = @LastRange1, LastRange2 = @LastRange2 " +
                        "WHERE Id = 1";

            using (connection = new SqlConnection(connectionString))
            using (SqlCommand command = new SqlCommand(query, connection))
            {
                connection.Open();

                command.Parameters.AddWithValue("@LastDate", $"{DateTime.Now}");
                command.Parameters.AddWithValue("@LastRange1", $"{Convert.ToInt32(barcodeRange1.SelectedItem)}");
                command.Parameters.AddWithValue("@LastRange2", $"{Convert.ToInt32(barcodeRange2.SelectedItem)}");

                command.ExecuteScalar();
            }
        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            if (barcodeRange1.SelectedItem != null && barcodeRange2.SelectedItem != null)
            {
                object barcodeData = $"{Convert.ToInt64(barcodeRange1.SelectedItem) + Convert.ToInt64(50000000000)}";
                var barcodeUrl = $"barcode.tec-it.com/barcode.ashx?translate-esc=off&data={barcodeData}&code=UPCA&authentication=None&ssid=Networkname&password=&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=000000&bgcolor=FFFFFF&qunit=Mm&quiet=0&eclevel=L";
                
                lastSubmitDate.Text = $"{DateTime.Now}";
                lastRange1.Text = $"{Convert.ToInt32(barcodeRange1.SelectedItem)}";
                lastRange2.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem)}";


                try
                {
                    try
                    {
                        Avery5161pdf.PdfGen(rangeCount.Text, Convert.ToInt32(barcodeRange1.SelectedItem));
                    }
                    catch (Exception exp)
                    {
                        MessageBox.Show(exp.Message);
                    }
                }
                
                catch
                {
                    MessageBox.Show("Range cannot be negative", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                try
                {
                    //CacheCurrentInfo();
                }
                catch (Exception exp)
                {
                    MessageBox.Show(exp.Message);
                }
            }
        }

        private void BarcodeRange1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange2.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem) - Convert.ToInt32(barcodeRange1.SelectedItem) + 1}";
            }
        }

        private void BarcodeRange2_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (barcodeRange1.SelectedItem != null)
            {
                rangeCount.Text = $"{Convert.ToInt32(barcodeRange2.SelectedItem) - Convert.ToInt32(barcodeRange1.SelectedItem) + 1}";
            }
        }
    }
}
