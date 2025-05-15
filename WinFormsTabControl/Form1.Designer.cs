namespace WinFormsTabControl
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
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            btnStart = new Button();
            label3 = new Label();
            txtdiferenca1 = new TextBox();
            txtfim1 = new TextBox();
            label2 = new Label();
            txtInicio1 = new TextBox();
            label1 = new Label();
            tabPage2 = new TabPage();
            btnstart2 = new Button();
            label4 = new Label();
            txtDiferenca2 = new TextBox();
            txtFim2 = new TextBox();
            label5 = new Label();
            txtInicio2 = new TextBox();
            label6 = new Label();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage2.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Location = new Point(24, 26);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(389, 266);
            tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            tabPage1.Controls.Add(btnStart);
            tabPage1.Controls.Add(label3);
            tabPage1.Controls.Add(txtdiferenca1);
            tabPage1.Controls.Add(txtfim1);
            tabPage1.Controls.Add(label2);
            tabPage1.Controls.Add(txtInicio1);
            tabPage1.Controls.Add(label1);
            tabPage1.Location = new Point(4, 24);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(381, 238);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "StringNormal";
            tabPage1.UseVisualStyleBackColor = true;
            // 
            // btnStart
            // 
            btnStart.Location = new Point(71, 209);
            btnStart.Name = "btnStart";
            btnStart.Size = new Size(91, 23);
            btnStart.TabIndex = 6;
            btnStart.Text = "Start";
            btnStart.UseVisualStyleBackColor = true;
            btnStart.Click += btnStart_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(6, 161);
            label3.Name = "label3";
            label3.Size = new Size(57, 15);
            label3.TabIndex = 5;
            label3.Text = "Diferença";
            // 
            // txtdiferenca1
            // 
            txtdiferenca1.Location = new Point(69, 158);
            txtdiferenca1.Name = "txtdiferenca1";
            txtdiferenca1.Size = new Size(125, 23);
            txtdiferenca1.TabIndex = 4;
            // 
            // txtfim1
            // 
            txtfim1.Location = new Point(71, 93);
            txtfim1.Name = "txtfim1";
            txtfim1.Size = new Size(125, 23);
            txtfim1.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(9, 96);
            label2.Name = "label2";
            label2.Size = new Size(27, 15);
            label2.TabIndex = 2;
            label2.Text = "Fim";
            // 
            // txtInicio1
            // 
            txtInicio1.Location = new Point(71, 42);
            txtInicio1.Name = "txtInicio1";
            txtInicio1.Size = new Size(125, 23);
            txtInicio1.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(9, 42);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 0;
            label1.Text = "Inicio";
            // 
            // tabPage2
            // 
            tabPage2.Controls.Add(btnstart2);
            tabPage2.Controls.Add(label4);
            tabPage2.Controls.Add(txtDiferenca2);
            tabPage2.Controls.Add(txtFim2);
            tabPage2.Controls.Add(label5);
            tabPage2.Controls.Add(txtInicio2);
            tabPage2.Controls.Add(label6);
            tabPage2.Location = new Point(4, 24);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(381, 238);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "String Builder";
            tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnstart2
            // 
            btnstart2.Location = new Point(78, 185);
            btnstart2.Name = "btnstart2";
            btnstart2.Size = new Size(91, 23);
            btnstart2.TabIndex = 13;
            btnstart2.Text = "Start";
            btnstart2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(6, 140);
            label4.Name = "label4";
            label4.Size = new Size(57, 15);
            label4.TabIndex = 12;
            label4.Text = "Diferença";
            // 
            // txtDiferenca2
            // 
            txtDiferenca2.Location = new Point(69, 137);
            txtDiferenca2.Name = "txtDiferenca2";
            txtDiferenca2.Size = new Size(125, 23);
            txtDiferenca2.TabIndex = 11;
            // 
            // txtFim2
            // 
            txtFim2.Location = new Point(64, 72);
            txtFim2.Name = "txtFim2";
            txtFim2.Size = new Size(125, 23);
            txtFim2.TabIndex = 10;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(6, 75);
            label5.Name = "label5";
            label5.Size = new Size(27, 15);
            label5.TabIndex = 9;
            label5.Text = "Fim";
            // 
            // txtInicio2
            // 
            txtInicio2.Location = new Point(64, 24);
            txtInicio2.Name = "txtInicio2";
            txtInicio2.Size = new Size(125, 23);
            txtInicio2.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(6, 24);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 7;
            label6.Text = "Inicio";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(tabControl1);
            Name = "Form1";
            Text = "Form1";
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage1.PerformLayout();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TabControl tabControl1;
        private TabPage tabPage1;
        private TextBox txtInicio1;
        private Label label1;
        private TabPage tabPage2;
        private Button btnStart;
        private Label label3;
        private TextBox txtdiferenca1;
        private TextBox txtfim1;
        private Label label2;
        private Button btnstart2;
        private Label label4;
        private TextBox txtDiferenca2;
        private TextBox txtFim2;
        private Label label5;
        private TextBox txtInicio2;
        private Label label6;
    }
}
