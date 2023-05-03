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
using System.Runtime.InteropServices;
using System.IO;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace DbUpSQLite_48
{
    public partial class FormMain : Form
    {
        [DllImport("kernel32.dll", SetLastError = true)]
        [return: MarshalAs(UnmanagedType.Bool)]
        static extern bool AllocConsole();
        [DllImport("kernel32.dll")]
        private static extern bool FreeConsole();
        string _migrationsPath { get; set; }
        string _databasePath { get; set; }
        public string MigrationsPath { get 
            {
                return _migrationsPath;
            } 
            set {
                textBoxMigrationsPath.Text = value;
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

        private void buttonExecuteMigrations_Click(object sender, EventArgs e)
        {
            AllocConsole();
            Console.SetOut(new ControlWriter(textBoxConsoleLog));
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
                this.Size = new Size(this.Width, 421);
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
            FreeConsole();
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
                //set database dir path to migrations path
                if (DatabasePath == null)
                {
                    throw new Exception("Database path is null");
                }
                else
                {
                    folderBrowserDialogMigrations.SelectedPath = System.IO.Path.GetDirectoryName(DatabasePath);
                }
                
            }
        }



        private void buttonSetMigrationsFolder_Click(object sender, EventArgs e)
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

        private void FormMain_Load(object sender, EventArgs e)
        {

        }
    }
    class ControlWriter : TextWriter
    {
        private readonly Control control;

        public ControlWriter(Control control)
        {
            this.control = control;
        }

        public override void Write(char value)
        {
            control.Invoke(new Action(() => control.Text += value));
        }

        public override Encoding Encoding => Encoding.ASCII;
    }
}
