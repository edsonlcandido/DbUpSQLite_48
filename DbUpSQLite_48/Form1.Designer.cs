namespace DbUpSQLite_48
{
    partial class FormMain
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonOk = new System.Windows.Forms.Button();
            this.buttonAddDatabase = new System.Windows.Forms.Button();
            this.textBoxDatabasePath = new System.Windows.Forms.TextBox();
            this.textBoxMigrationsPath = new System.Windows.Forms.TextBox();
            this.buttonSetMigrationsFolder = new System.Windows.Forms.Button();
            this.openFileDialogDatabase = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogMigrations = new System.Windows.Forms.FolderBrowserDialog();
            this.textBoxConsoleLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // buttonOk
            // 
            this.buttonOk.Location = new System.Drawing.Point(520, 96);
            this.buttonOk.Margin = new System.Windows.Forms.Padding(4);
            this.buttonOk.Name = "buttonOk";
            this.buttonOk.Size = new System.Drawing.Size(174, 32);
            this.buttonOk.TabIndex = 0;
            this.buttonOk.Text = "Execute Migration";
            this.buttonOk.UseVisualStyleBackColor = true;
            this.buttonOk.Click += new System.EventHandler(this.buttonExecuteMigrations_Click);
            // 
            // buttonAddDatabase
            // 
            this.buttonAddDatabase.Location = new System.Drawing.Point(18, 16);
            this.buttonAddDatabase.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAddDatabase.Name = "buttonAddDatabase";
            this.buttonAddDatabase.Size = new System.Drawing.Size(168, 32);
            this.buttonAddDatabase.TabIndex = 1;
            this.buttonAddDatabase.Text = "Database ->";
            this.buttonAddDatabase.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonAddDatabase.UseVisualStyleBackColor = true;
            this.buttonAddDatabase.Click += new System.EventHandler(this.buttonAddDatabase_Click);
            // 
            // textBoxDatabasePath
            // 
            this.textBoxDatabasePath.Location = new System.Drawing.Point(195, 20);
            this.textBoxDatabasePath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxDatabasePath.Name = "textBoxDatabasePath";
            this.textBoxDatabasePath.Size = new System.Drawing.Size(499, 24);
            this.textBoxDatabasePath.TabIndex = 2;
            // 
            // textBoxMigrationsPath
            // 
            this.textBoxMigrationsPath.Location = new System.Drawing.Point(195, 59);
            this.textBoxMigrationsPath.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxMigrationsPath.Name = "textBoxMigrationsPath";
            this.textBoxMigrationsPath.Size = new System.Drawing.Size(499, 24);
            this.textBoxMigrationsPath.TabIndex = 4;
            // 
            // buttonSetMigrationsFolder
            // 
            this.buttonSetMigrationsFolder.Location = new System.Drawing.Point(18, 57);
            this.buttonSetMigrationsFolder.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSetMigrationsFolder.Name = "buttonSetMigrationsFolder";
            this.buttonSetMigrationsFolder.Size = new System.Drawing.Size(168, 32);
            this.buttonSetMigrationsFolder.TabIndex = 3;
            this.buttonSetMigrationsFolder.Text = "Migrations folder ->";
            this.buttonSetMigrationsFolder.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.buttonSetMigrationsFolder.UseVisualStyleBackColor = true;
            this.buttonSetMigrationsFolder.Click += new System.EventHandler(this.buttonSetMigrationsFolder_Click);
            // 
            // openFileDialogDatabase
            // 
            this.openFileDialogDatabase.CheckFileExists = false;
            this.openFileDialogDatabase.DefaultExt = "db";
            this.openFileDialogDatabase.Filter = "Database file|*.db|SQLite files|*.sqlite|SQLite 3 files|*.sqlite3";
            this.openFileDialogDatabase.Title = "Select or create database";
            this.openFileDialogDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogDatabase_FileOk);
            // 
            // folderBrowserDialogMigrations
            // 
            this.folderBrowserDialogMigrations.Description = "Define migrations path";
            this.folderBrowserDialogMigrations.ShowNewFolderButton = false;
            // 
            // textBoxConsoleLog
            // 
            this.textBoxConsoleLog.Location = new System.Drawing.Point(18, 161);
            this.textBoxConsoleLog.Multiline = true;
            this.textBoxConsoleLog.Name = "textBoxConsoleLog";
            this.textBoxConsoleLog.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.textBoxConsoleLog.Size = new System.Drawing.Size(673, 209);
            this.textBoxConsoleLog.TabIndex = 5;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 136);
            this.Controls.Add(this.textBoxConsoleLog);
            this.Controls.Add(this.textBoxMigrationsPath);
            this.Controls.Add(this.buttonSetMigrationsFolder);
            this.Controls.Add(this.textBoxDatabasePath);
            this.Controls.Add(this.buttonAddDatabase);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "DbUpSQLite";
            this.Load += new System.EventHandler(this.FormMain_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAddDatabase;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.TextBox textBoxMigrationsPath;
        private System.Windows.Forms.Button buttonSetMigrationsFolder;
        private System.Windows.Forms.OpenFileDialog openFileDialogDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMigrations;
        private System.Windows.Forms.TextBox textBoxConsoleLog;
    }
}

