using System.Security.Cryptography;
using System.Text;

namespace ConsoleApp1.Utility
{
    internal static class HashUtility
    {
        public static string MdFive(string str)
        { 
            MD5 md5 = MD5.Create();
            byte[] sonuc= md5.ComputeHash(Encoding.UTF8.GetBytes(str));

            string strHashedData = "";
            foreach(byte b in sonuc)
            {
                strHashedData += b.ToString("x2");
            }
            return strHashedData;
        }
    }
}
