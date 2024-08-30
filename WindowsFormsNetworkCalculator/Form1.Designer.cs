namespace WindowsFormsNetworkCalculator
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
            panel1 = new Panel();
            btnNetzwerBerechnen = new Button();
            cboCidr = new ComboBox();
            txtAdress = new TextBox();
            label2 = new Label();
            label1 = new Label();
            listBox1 = new ListBox();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(btnNetzwerBerechnen);
            panel1.Controls.Add(cboCidr);
            panel1.Controls.Add(txtAdress);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(776, 139);
            panel1.TabIndex = 0;
            // 
            // btnNetzwerBerechnen
            // 
            btnNetzwerBerechnen.Location = new Point(456, 59);
            btnNetzwerBerechnen.Name = "btnNetzwerBerechnen";
            btnNetzwerBerechnen.Size = new Size(146, 23);
            btnNetzwerBerechnen.TabIndex = 4;
            btnNetzwerBerechnen.Text = "Netzwerk berechnen";
            btnNetzwerBerechnen.UseVisualStyleBackColor = true;
            btnNetzwerBerechnen.Click += btnNetzwerBerechnen_Click;
            // 
            // cboCidr
            // 
            cboCidr.FormattingEnabled = true;
            cboCidr.Items.AddRange(new object[] { "32", "31", "30", "29", "28", "27", "26", "25", "24", "23", "22", "21", "20", "19", "18", "17", "16", "15", "14", "13", "12", "11", "10", "9", "8", "7", "6", "5", "4", "3", "2", "1", "0" });
            cboCidr.Location = new Point(329, 59);
            cboCidr.Name = "cboCidr";
            cboCidr.Size = new Size(121, 23);
            cboCidr.TabIndex = 3;
            // 
            // txtAdress
            // 
            txtAdress.Location = new Point(223, 59);
            txtAdress.Name = "txtAdress";
            txtAdress.Size = new Size(100, 23);
            txtAdress.TabIndex = 2;
            txtAdress.Text = "192.168.23.11";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(328, 41);
            label2.Name = "label2";
            label2.Size = new Size(38, 17);
            label2.TabIndex = 1;
            label2.Text = "CIDR";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(223, 41);
            label1.Name = "label1";
            label1.Size = new Size(56, 17);
            label1.TabIndex = 0;
            label1.Text = "Adresse";
            label1.Click += label1_Click;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(12, 157);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(776, 289);
            listBox1.TabIndex = 1;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "WinFormsNetworCalc";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Button btnNetzwerBerechnen;
        private ComboBox cboCidr;
        private TextBox txtAdress;
        private Label label2;
        private ListBox listBox1;
    }
}

