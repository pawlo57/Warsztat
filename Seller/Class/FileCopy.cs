using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Seller.Class
{
    public static class FileCopy
    {
        
       


        public static bool CopyFile(string source, string dest, ref ProgressBar progressBar1)
        {
            FileStream fs = null;

            FileStream fw = null;

            bool Result = false;



            try
            {
                fs = new FileStream(source, FileMode.Open);

                fw = new FileStream(dest, FileMode.Create);

                if (progressBar1 != null)
                {
                    progressBar1.Minimum = 0;
                    progressBar1.Maximum = Convert.ToInt32(fs.Length);
                    progressBar1.Value = 0;
                }

                while (!(fs.Position == fs.Length))
                {
                    byte[] bufor;

                    if ((fs.Length - fs.Position) >= 1024) bufor = new byte[1024];
                    else bufor = new byte[fs.Length - fs.Position];

                    //long pos = fs.Position;


                    fs.Read(bufor, 0, bufor.Length);

                    fw.Write(bufor, 0, bufor.Length);

                    if (progressBar1 != null) progressBar1.Value = (int)fs.Position;
                }
            }

            catch (System.IO.FileNotFoundException ex)
            { Message.ErrorMessage("Nie znaleziono pliku: " + ex.FileName); return Result; }

            finally
            {
                if (fs != null) { fs.Close(); fs.Dispose(); }
                if (fw != null) { fw.Close(); fw.Dispose(); } 
            }

            Result = true;

            return Result;
        }
    }
}
