using IronBarCode;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mthods
{
    public class Qrcode
    {
        public static string convertTobase64(string info)
        {
            string base64 = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(info));
            return base64;
        }
        public static Bitmap createQrCode(string info)
        {
            try
            {
                Bitmap qrcode = QRCodeWriter.CreateQrCode(info, 200, QRCodeWriter.QrErrorCorrectionLevel.Medium).Render();
                return qrcode;
            }
            catch
            {
                return null;
            }
        }
        public static void setLice()
        {
            IronBarCode.License.LicenseKey = Constants.Information.LICENSE;
        }
    }
}
