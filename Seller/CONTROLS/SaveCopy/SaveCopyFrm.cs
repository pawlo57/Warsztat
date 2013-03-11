using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using Seller.Class;

namespace Seller.CONTROLS.SaveCopy
{
    public partial class SaveCopyFrm : Form
    {
        public enum TYPE
        {
            DEFAULT,
            DIR,
            DEFAULT_RESTORE,
            DIR_RESTORE,
            LOGO_FILE
        }

        public bool RESULT = true;

        public string LOGO_FILE = "";

        private TYPE TrybPracy = TYPE.DEFAULT;

       

        public SaveCopyFrm(TYPE tryb)
        {
            InitializeComponent();

            this.TrybPracy = tryb;
        }

        

        public bool MakeSaveCopyDatabase()
        {
             string DatabaseFile = Settings.AppDirectory +
                "\\Database.sdf";

            string DatabaseCopyFile =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Warsztat samochodowy";

            if (!Directory.Exists(DatabaseCopyFile))
                Directory.CreateDirectory(DatabaseCopyFile);

            DatabaseCopyFile += "\\DatabaseCopy.sdf";

            return FileCopy.CopyFile(DatabaseFile, DatabaseCopyFile, ref progressBar1);
        }

        public bool RestoreSaveCopyDatabase()
        {
            string DatabaseFile = Directory.GetCurrentDirectory() +
                "\\Database.sdf";

            string DatabaseCopyFile =
            Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) +
            "\\Warsztat samochodowy";

            if (!Directory.Exists(DatabaseCopyFile))
            { Message.ErrorMessage("Katalog domyślny z kopią bazy danych nie istnieje!"); return false; }

            DatabaseCopyFile += "\\DatabaseCopy.sdf";

            return FileCopy.CopyFile(DatabaseCopyFile, DatabaseFile, ref progressBar1);
        }

        public bool MakeCopyOfDatabase()
        {
            string DatabaseFile = Directory.GetCurrentDirectory() +
               "\\Database.sdf";


            SaveFileDialog saveDlg = new SaveFileDialog();

            saveDlg.DefaultExt = "sdf";

            saveDlg.AddExtension = false;

            saveDlg.RestoreDirectory = true;

            saveDlg.FileName = "Database";

            saveDlg.Title = "Proszę wybrać lokalizację do zarchiwizowania bazy danych";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string path = saveDlg.FileName;

                return FileCopy.CopyFile(DatabaseFile, path, ref progressBar1);
            }

            return false;
        }

        public bool RestoreDatabase()
        {
            string DatabaseFile = Directory.GetCurrentDirectory() +
              "\\Database.sdf";


            OpenFileDialog saveDlg = new OpenFileDialog();

            saveDlg.DefaultExt = "sdf";

            saveDlg.AddExtension = false;

            saveDlg.RestoreDirectory = true;

            saveDlg.FileName = "Database";

            saveDlg.Title = "Proszę wybrać lokalizację bazy danych";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string path = saveDlg.FileName;

                if (!Connect.CheckDatabase(path))
                { Message.ErrorMessage("Wybrany plik nie jest bazą danych tego programu"); return false; }

                return FileCopy.CopyFile(path, DatabaseFile, ref progressBar1);
            }

            return false;
        }

        public bool CopyLogoFile()
        {
            //string DatabaseFile = Directory.GetCurrentDirectory() +
            //  "\\Database.sdf";


            OpenFileDialog saveDlg = new OpenFileDialog();

            saveDlg.Title = "Proszę wybrać logo firmy";

            if (saveDlg.ShowDialog() == DialogResult.OK)
            {
                string path = saveDlg.FileName;
    
                LOGO_FILE = saveDlg.SafeFileName;

                string dest = Settings.AppDirectory + "\\Logo\\" + saveDlg.SafeFileName;

                return FileCopy.CopyFile(path, dest, ref progressBar1);
            }

            return false;
        }

        private void SaveCopyFrm_Load(object sender, EventArgs e)
        {
            switch (TrybPracy)
            {
                case TYPE.DEFAULT:
                    RESULT = MakeSaveCopyDatabase();
                    Close();
                    break;

                case TYPE.DIR:
                    RESULT = MakeCopyOfDatabase();
                    Close();
                    break;

                case TYPE.DEFAULT_RESTORE:
                    RESULT = RestoreSaveCopyDatabase();
                    Close();
                    break;

                case TYPE.DIR_RESTORE:
                    RESULT = RestoreDatabase();
                    Close();
                    break;

                case TYPE.LOGO_FILE:
                    RESULT = CopyLogoFile();
                    Close();
                    break;
            }
        
        }
    }
}
