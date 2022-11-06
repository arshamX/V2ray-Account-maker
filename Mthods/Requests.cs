using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using Constants;
using Leaf.xNet;
namespace Mthods
{
    public class Requests
    {
        private static Calculate cMethods = new Calculate();
        public static bool isServer(string ip)
        {
            HttpClient client = new HttpClient();
            try
            {
                string res = client.GetStringAsync(ip).Result.ToString();
                if (res.Contains("<h1>"))
                    return true;
                return false;
            }
            catch
            {
                return false;
            }
        }
        public static string createAccount(string name)
        {
            try
            {
                string port = (new Random()).Next(22,647738).ToString();
                string uuid = cMethods.idMaker().ToString();
                string sendData = "up=0&down=0&total=0&remark=" + DateTime.Now.Day.ToString()+name + "&enable=true&expiryTime=0&listen=&port=" + port + "&protocol=vmess&settings={\"clients\":[{\"id\":\"" + uuid + "\",\"alterId\":0}],\"disableInsecureEncryption\":false}&streamSettings={\"network\":\"ws\",\"security\":\"none\",\"wsSettings\":{\"path\":\"/\",\"headers\":{}}}&sniffing={\"enabled\":true,\"destOverride\":[\"http\",\"tls\"]}";
                CookieStorage cookie = new CookieStorage();
                cookie.Set(Constants.Information.COOKIE[0], Constants.Information.COOKIE[1], Constants.Information.IP[1],"/");
                HttpRequest req = new HttpRequest();
                req.IgnoreProtocolErrors = true;
                req.KeepAlive = true;
                req.Cookies = cookie;
                req.AddHeader(Leaf.xNet.HttpHeader.Accept, "application/json, text/plain, */*");
                req.AddHeader(Leaf.xNet.HttpHeader.AcceptLanguage, "en-IR,en-GB;q=0.9,en-US;q=0.8,en;q=0.7,fa;q=0.6,ar;q=0.5");
                req.AddHeader(Leaf.xNet.HttpHeader.Origin, Constants.Information.IP[0]);
                req.Referer = Constants.Information.IP[0] + "/xui/inbound/add";
                req.UserAgent = "User-Agent: Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/80.0.3987.149 Safari/537.36";
                req.SslCertificateValidatorCallback += (sender, certificate, chain, sslPolicyErrors) => true;
                req.AllowAutoRedirect = true;
                string res = req.Post(Constants.Information.IP[0] + "/xui/inbound/add",sendData, "application/x-www-form-urlencoded; charset=UTF-8").ToString();
                if(res.Contains("\"success\":true"))
                    return "{\"v\":\"2\",\"ps\":\"" + name + "\",\"add\":\"" + Constants.Information.DOMAIN + "\",\"port\":" + port.ToString() + ",\"id\":\"" + uuid + "\",\"aid\":0,\"net\":\"ws\",\"type\":\"none\",\"host\":\"\",\"path\":\"/\",\"tls\":\"none\"}";
                return string.Empty;
            }
            catch
            {
                return string.Empty;
            }
        }

    }
}
