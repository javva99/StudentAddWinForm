namespace studentform
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
            this.btn1Click = new System.Windows.Forms.Button();
            this.Sname = new System.Windows.Forms.Label();
            this.Ssurname = new System.Windows.Forms.Label();
            this.Sid = new System.Windows.Forms.Label();
            this.tbname = new System.Windows.Forms.TextBox();
            this.tbsurname = new System.Windows.Forms.TextBox();
            this.tbid = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn1Click
            // 
            this.btn1Click.Location = new System.Drawing.Point(173, 239);
            this.btn1Click.Name = "btn1Click";
            this.btn1Click.Size = new System.Drawing.Size(94, 29);
            this.btn1Click.TabIndex = 0;
            this.btn1Click.Text = "Add";
            this.btn1Click.UseVisualStyleBackColor = true;
            this.btn1Click.Click += new System.EventHandler(this.button1_Click);
            // 
            // Sname
            // 
            this.Sname.AutoSize = true;
            this.Sname.Location = new System.Drawing.Point(12, 15);
            this.Sname.Name = "Sname";
            this.Sname.Size = new System.Drawing.Size(49, 20);
            this.Sname.TabIndex = 1;
            this.Sname.Text = "Name";
            // 
            // Ssurname
            // 
            this.Ssurname.AutoSize = true;
            this.Ssurname.Location = new System.Drawing.Point(12, 71);
            this.Ssurname.Name = "Ssurname";
            this.Ssurname.Size = new System.Drawing.Size(67, 20);
            this.Ssurname.TabIndex = 2;
            this.Ssurname.Text = "Surname";
            // 
            // Sid
            // 
            this.Sid.AutoSize = true;
            this.Sid.Location = new System.Drawing.Point(12, 138);
            this.Sid.Name = "Sid";
            this.Sid.Size = new System.Drawing.Size(24, 20);
            this.Sid.TabIndex = 3;
            this.Sid.Text = "ID";
            // 
            // tbname
            // 
            this.tbname.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbname.Location = new System.Drawing.Point(173, 12);
            this.tbname.Name = "tbname";
            this.tbname.Size = new System.Drawing.Size(125, 25);
            this.tbname.TabIndex = 4;
            this.tbname.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // tbsurname
            // 
            this.tbsurname.Font = new System.Drawing.Font("SimSun", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tbsurname.Location = new System.Drawing.Point(173, 71);
            this.tbsurname.Name = "tbsurname";
            this.tbsurname.Size = new System.Drawing.Size(125, 25);
            this.tbsurname.TabIndex = 5;
            // 
            // tbid
            // 
            this.tbid.Font = new System.Drawing.Font("MS UI Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.tbid.Location = new System.Drawing.Point(173, 138);
            this.tbid.Name = "tbid";
            this.tbid.Size = new System.Drawing.Size(125, 22);
            this.tbid.TabIndex = 6;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.ClientSize = new System.Drawing.Size(320, 300);
            this.Controls.Add(this.tbid);
            this.Controls.Add(this.tbsurname);
            this.Controls.Add(this.tbname);
            this.Controls.Add(this.Sid);
            this.Controls.Add(this.Ssurname);
            this.Controls.Add(this.Sname);
            this.Controls.Add(this.btn1Click);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn1Click;
        private Label Sname;
        private Label Ssurname;
        private Label Sid;
        private TextBox tbname;
        private TextBox tbsurname;
        private TextBox tbid;
    }
}