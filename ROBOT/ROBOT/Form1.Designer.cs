namespace ROBOT
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.lst1 = new System.Windows.Forms.ListBox();
            this.lst2 = new System.Windows.Forms.ListBox();
            this.lst3 = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn1.Location = new System.Drawing.Point(21, 40);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(97, 83);
            this.btn1.TabIndex = 0;
            this.btn1.Text = "thecomponets";
            this.btn1.UseVisualStyleBackColor = false;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn2.Location = new System.Drawing.Point(21, 129);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(97, 83);
            this.btn2.TabIndex = 1;
            this.btn2.Text = "thelogic";
            this.btn2.UseVisualStyleBackColor = false;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btn3.Location = new System.Drawing.Point(21, 218);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(97, 83);
            this.btn3.TabIndex = 2;
            this.btn3.Text = "thesociety";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Items.AddRange(new object[] {
            "once all components of the robot has been obtained",
            "they are assembled together",
            "and screwed-apart"});
            this.lst1.Location = new System.Drawing.Point(189, 40);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(345, 121);
            this.lst1.TabIndex = 3;
            this.lst1.Visible = false;
            // 
            // lst2
            // 
            this.lst2.FormattingEnabled = true;
            this.lst2.Items.AddRange(new object[] {
            "The logic is the most dentrimental part of the <<society>>",
            "with it it tells you what the robot does, how it talks and where to go"});
            this.lst2.Location = new System.Drawing.Point(189, 167);
            this.lst2.Name = "lst2";
            this.lst2.Size = new System.Drawing.Size(345, 121);
            this.lst2.TabIndex = 4;
            this.lst2.Visible = false;
            // 
            // lst3
            // 
            this.lst3.FormattingEnabled = true;
            this.lst3.Items.AddRange(new object[] {
            "A society in robot terms defines the RobotsManner",
            "and its collective"});
            this.lst3.Location = new System.Drawing.Point(189, 294);
            this.lst3.Name = "lst3";
            this.lst3.Size = new System.Drawing.Size(345, 121);
            this.lst3.TabIndex = 5;
            this.lst3.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 450);
            this.Controls.Add(this.lst3);
            this.Controls.Add(this.lst2);
            this.Controls.Add(this.lst1);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Name = "Form1";
            this.Text = "ROBOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.ListBox lst2;
        private System.Windows.Forms.ListBox lst3;
    }
}

