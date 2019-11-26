namespace TestProject
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TextBox_OpenInputDialog = new System.Windows.Forms.TextBox();
            this.Button_OpenInputDialog = new System.Windows.Forms.Button();
            this.Run = new System.Windows.Forms.Button();
            this.Label_OpenInputDialog = new System.Windows.Forms.Label();
            this.Button_OpenOutputDialog = new System.Windows.Forms.Button();
            this.TextBox_OpenOutputDialog = new System.Windows.Forms.TextBox();
            this.Label_OpenOutputDialog = new System.Windows.Forms.Label();
            this.Label_top = new System.Windows.Forms.Label();
            this.TextBox_top = new System.Windows.Forms.TextBox();
            // 
            // TextBox_OpenInputDialog
            // 
            this.TextBox_OpenInputDialog.Location = new System.Drawing.Point(7, 34);
            this.TextBox_OpenInputDialog.Name = "TextBox_OpenInputDialog";
            this.TextBox_OpenInputDialog.ReadOnly = true;
            this.TextBox_OpenInputDialog.Size = new System.Drawing.Size(197, 23);
            this.TextBox_OpenInputDialog.TabIndex = 0;
            this.TextBox_OpenInputDialog.Text = "input";
            // 
            // Button_OpenInputDialog
            // 
            this.Button_OpenInputDialog.Location = new System.Drawing.Point(129, 63);
            this.Button_OpenInputDialog.Name = "Button_OpenInputDialog";
            this.Button_OpenInputDialog.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenInputDialog.TabIndex = 1;
            this.Button_OpenInputDialog.Text = "Указать";
            this.Button_OpenInputDialog.UseVisualStyleBackColor = true;
            this.Button_OpenInputDialog.Click += new System.EventHandler(this.Button_OpenInputDialog_Click);
            // 
            // Run
            // 
            this.Run.Location = new System.Drawing.Point(193, 203);
            this.Run.Name = "Run";
            this.Run.Size = new System.Drawing.Size(75, 23);
            this.Run.TabIndex = 2;
            this.Run.Text = "Посчитать";
            this.Run.UseVisualStyleBackColor = true;
            this.Run.Click += new System.EventHandler(this.Run_Click);
            // 
            // Label_OpenInputDialog
            // 
            this.Label_OpenInputDialog.AutoSize = true;
            this.Label_OpenInputDialog.Location = new System.Drawing.Point(7, 16);
            this.Label_OpenInputDialog.Name = "Label_OpenInputDialog";
            this.Label_OpenInputDialog.Size = new System.Drawing.Size(124, 15);
            this.Label_OpenInputDialog.TabIndex = 3;
            this.Label_OpenInputDialog.Text = "Путь для считывания";
            // 
            // Button_OpenOutputDialog
            // 
            this.Button_OpenOutputDialog.Location = new System.Drawing.Point(129, 145);
            this.Button_OpenOutputDialog.Name = "Button_OpenOutputDialog";
            this.Button_OpenOutputDialog.Size = new System.Drawing.Size(75, 23);
            this.Button_OpenOutputDialog.TabIndex = 1;
            this.Button_OpenOutputDialog.Text = "Указать";
            this.Button_OpenOutputDialog.UseVisualStyleBackColor = true;
            this.Button_OpenOutputDialog.Click += new System.EventHandler(this.Button_OpenOutputDialog_Click);
            // 
            // TextBox_OpenOutputDialog
            // 
            this.TextBox_OpenOutputDialog.Location = new System.Drawing.Point(7, 116);
            this.TextBox_OpenOutputDialog.Name = "TextBox_OpenOutputDialog";
            this.TextBox_OpenOutputDialog.ReadOnly = true;
            this.TextBox_OpenOutputDialog.Size = new System.Drawing.Size(197, 23);
            this.TextBox_OpenOutputDialog.TabIndex = 0;
            this.TextBox_OpenOutputDialog.Text = "output";
            // 
            // Label_OpenOutputDialog
            // 
            this.Label_OpenOutputDialog.AutoSize = true;
            this.Label_OpenOutputDialog.Location = new System.Drawing.Point(7, 98);
            this.Label_OpenOutputDialog.Name = "Label_OpenOutputDialog";
            this.Label_OpenOutputDialog.Size = new System.Drawing.Size(122, 15);
            this.Label_OpenOutputDialog.TabIndex = 3;
            this.Label_OpenOutputDialog.Text = "Путь для сохранения";
            // 
            // Label_top
            // 
            this.Label_top.AutoSize = true;
            this.Label_top.Location = new System.Drawing.Point(7, 185);
            this.Label_top.Name = "Label_top";
            this.Label_top.Size = new System.Drawing.Size(109, 15);
            this.Label_top.TabIndex = 4;
            this.Label_top.Text = "Какой топ берем?)";
            // 
            // TextBox_top
            // 
            this.TextBox_top.Location = new System.Drawing.Point(8, 203);
            this.TextBox_top.Name = "TextBox_top";
            this.TextBox_top.Size = new System.Drawing.Size(51, 23);
            this.TextBox_top.TabIndex = 0;
            this.TextBox_top.Text = "10";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(346, 261);
            this.Controls.Add(this.Label_top);
            this.Controls.Add(this.Label_OpenInputDialog);
            this.Controls.Add(this.Run);
            this.Controls.Add(this.Button_OpenInputDialog);
            this.Controls.Add(this.TextBox_OpenInputDialog);
            this.Controls.Add(this.Button_OpenOutputDialog);
            this.Controls.Add(this.TextBox_OpenOutputDialog);
            this.Controls.Add(this.Label_OpenOutputDialog);
            this.Controls.Add(this.TextBox_top);
            this.Name = "Form1";

        }

        #endregion

        private System.Windows.Forms.TextBox TextBox_OpenInputDialog;
        private System.Windows.Forms.Button Button_OpenInputDialog;
        private System.Windows.Forms.Button Run;
        private System.Windows.Forms.Label Label_OpenInputDialog;
        private System.Windows.Forms.Button Button_OpenOutputDialog;
        private System.Windows.Forms.TextBox TextBox_OpenOutputDialog;
        private System.Windows.Forms.Label Label_OpenOutputDialog;
        private System.Windows.Forms.Label Label_top;
        private System.Windows.Forms.TextBox TextBox_top;
    }
}

