using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Seller
{
    public static class RSA
    {
        public struct PUBLIC
        {
            public void ghj() { }

            public int E;
            public int N;
        }

        static RSA()
        {
            
        }

        public static void Test()
        {
            PUBLIC PublicKey = new PUBLIC();

            PublicKey.E = 3;
            PublicKey.N = 11;

            PublicKey.ghj();

            string text = "Hello world!";

            char[] chars = text.ToCharArray();

            byte[] btxt = ASCIIEncoding.ASCII.GetBytes(text);

            //byte[] btxt = new byte[] { 1, 2, 3, 4, 5, 6, 7, 1, 2 };

            byte[] bctext = new byte[btxt.Length];

            for (int i = 0; i < btxt.Length; i++)
            {
                double potega = Math.Pow(btxt[i],PublicKey.E);

                bctext[i] = (byte)(potega % PublicKey.N); 
            }

            //string ctext = ASCIIEncoding.ASCII.GetString(bctext);

            //byte[] bdtext = ASCIIEncoding.ASCII.GetBytes(ctext);

            byte[] dtxt = new byte[bctext.Length];

            PUBLIC PrivateKey = new PUBLIC();

            PrivateKey.N = 11;
            PrivateKey.E = 7;

            for (int i = 0; i < bctext.Length; i++)
            {
                double potega = Math.Pow(bctext[i], PrivateKey.E);

                dtxt[i] = (byte)(potega % PrivateKey.N);
            }

            //string dtext = ASCIIEncoding.ASCII.GetString(dtxt);

        }

        public static string Encode(string text)
        {
            return null;
        }
    }
}
