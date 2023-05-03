using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DbUp;
using System.Data.SQLite;

namespace DbUpSQLite_48
{
    public partial class FormMain : Form
    {
        string _migrationsPath { get; set; }
        string _databasePath { get; set; }
        public string MigrationsPath { get 
            {
                return _migrationsPath;
            } 
            set {
                textBox2.Text = value;
                _migrationsPath = value;
                if (!System.IO.Directory.Exists(_migrationsPath))
                {
                    throw new Exception("Folder of scripts doesn't exists");
                }
            } 
        }
        public string DatabasePath { get
            {
                return _databasePath;
            } 
            set
            {
                textBoxDatabasePath.Text = value;
                _databasePath = value;
            } 
        }
        public FormMain()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                var connectionString = $@"Data Source={DatabasePath};";
                var upgrader =
                    DeployChanges.To
                    .SQLiteDatabase(connectionString)
                    .WithScriptsFromFileSystem($@"{MigrationsPath}")
                    .LogToConsole()
                    .Build();
                var result = upgrader.PerformUpgrade();
                if (!result.Successful)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(result.Error);
                    Console.ResetColor();
                    throw new Exception("Folder of scripts doesn't exists");
                }
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("Success!");
                Console.ResetColor();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                throw;
            }
        }

        private void buttonAddDatabase_Click(object sender, EventArgs e)
        {
            openFileDialogDatabase.ShowDialog();            
        }

        private void openFileDialogDatabase_FileOk(object sender, CancelEventArgs e)
        {
            //verify if openfiledialog is ok and databse exists, if true set database path
            if (openFileDialogDatabase.CheckFileExists)
            {
                DatabasePath = openFileDialogDatabase.FileName;
            }
            else
            {
                try
                {
                    SQLiteConnection sQLiteConnection = new SQLiteConnection($@"Data Source={openFileDialogDatabase.FileName}");
                    sQLiteConnection.Open();
                    sQLiteConnection.Close();
                }
                catch(Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    Console.ReadLine();
                    throw;
                }
                DatabasePath = openFileDialogDatabase.FileName;
            }
        }



        private void button3_Click(object sender, EventArgs e)
        {
            folderBrowserDialogMigrations.ShowDialog();

            try
            {
                //verify if folder exists
                if (System.IO.Directory.Exists(folderBrowserDialogMigrations.SelectedPath))
                {
                    MigrationsPath = folderBrowserDialogMigrations.SelectedPath;
                }
                else
                {
                    throw new Exception("Folder of scripts doesn't exists");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.ReadLine();
                throw;
            }
        }
    }
}
