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
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.openFileDialogDatabase = new System.Windows.Forms.OpenFileDialog();
            this.folderBrowserDialogMigrations = new System.Windows.Forms.FolderBrowserDialog();
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
            this.buttonOk.Click += new System.EventHandler(this.button1_Click);
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
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(195, 59);
            this.textBox2.Margin = new System.Windows.Forms.Padding(4);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(499, 24);
            this.textBox2.TabIndex = 4;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(18, 57);
            this.button3.Margin = new System.Windows.Forms.Padding(4);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(168, 32);
            this.button3.TabIndex = 3;
            this.button3.Text = "Migrations folder ->";
            this.button3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // openFileDialogDatabase
            // 
            this.openFileDialogDatabase.CheckFileExists = false;
            this.openFileDialogDatabase.FileName = "Select or create database";
            this.openFileDialogDatabase.Filter = "Database file|*.db|SQLite files|*.sqlite|SQLite 3 files|*.sqlite3";
            this.openFileDialogDatabase.FileOk += new System.ComponentModel.CancelEventHandler(this.openFileDialogDatabase_FileOk);
            // 
            // folderBrowserDialogMigrations
            // 
            this.folderBrowserDialogMigrations.ShowNewFolderButton = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 141);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.textBoxDatabasePath);
            this.Controls.Add(this.buttonAddDatabase);
            this.Controls.Add(this.buttonOk);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMain";
            this.Text = "DbUpSQLite";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonOk;
        private System.Windows.Forms.Button buttonAddDatabase;
        private System.Windows.Forms.TextBox textBoxDatabasePath;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.OpenFileDialog openFileDialogDatabase;
        private System.Windows.Forms.FolderBrowserDialog folderBrowserDialogMigrations;
    }
}

