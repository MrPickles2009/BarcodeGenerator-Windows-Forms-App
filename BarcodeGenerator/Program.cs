using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BarcodeGenerator
{
    public class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
        HttpClient client;
        ComboBox range1 = System.Windows.Forms.comboBox1;
        public async Task<T> GetAsync<T>(string url)
        {
            object barcodeData = 51000001687;
            var barcodeUrl = $"barcode.tec-it.com/barcode.ashx?translate-esc=off&data={barcodeData}&code=UPCA&authentication=None&ssid=Networkname&password=&unit=Fit&dpi=96&imagetype=Gif&rotation=0&color=000000&bgcolor=FFFFFF&qunit=Mm&quiet=0&eclevel=L";

            T result = default(T);

            HttpResponseMessage response = await client.GetAsync(barcodeUrl);
            return result;
        }
    }
}
