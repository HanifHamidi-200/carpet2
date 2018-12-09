namespace RFAKE
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
            this.lst1 = new System.Windows.Forms.ListBox();
            this.btnQNext = new System.Windows.Forms.Button();
            this.btnBut = new System.Windows.Forms.Button();
            this.btnCheck = new System.Windows.Forms.Button();
            this.btnFake = new System.Windows.Forms.Button();
            this.btnReal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lst1
            // 
            this.lst1.FormattingEnabled = true;
            this.lst1.Location = new System.Drawing.Point(40, 46);
            this.lst1.Name = "lst1";
            this.lst1.Size = new System.Drawing.Size(288, 277);
            this.lst1.TabIndex = 0;
            // 
            // btnQNext
            // 
            this.btnQNext.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnQNext.Location = new System.Drawing.Point(438, 46);
            this.btnQNext.Name = "btnQNext";
            this.btnQNext.Size = new System.Drawing.Size(82, 86);
            this.btnQNext.TabIndex = 1;
            this.btnQNext.Text = "&QNext";
            this.btnQNext.UseVisualStyleBackColor = false;
            this.btnQNext.Click += new System.EventHandler(this.btnQNext_Click);
            // 
            // btnBut
            // 
            this.btnBut.BackColor = System.Drawing.Color.Lime;
            this.btnBut.Location = new System.Drawing.Point(353, 157);
            this.btnBut.Name = "btnBut";
            this.btnBut.Size = new System.Drawing.Size(167, 36);
            this.btnBut.TabIndex = 2;
            this.btnBut.Text = "But";
            this.btnBut.UseVisualStyleBackColor = false;
            this.btnBut.Click += new System.EventHandler(this.btnBut_Click);
            // 
            // btnCheck
            // 
            this.btnCheck.BackColor = System.Drawing.Color.Lime;
            this.btnCheck.Location = new System.Drawing.Point(353, 199);
            this.btnCheck.Name = "btnCheck";
            this.btnCheck.Size = new System.Drawing.Size(167, 36);
            this.btnCheck.TabIndex = 3;
            this.btnCheck.Text = "Check";
            this.btnCheck.UseVisualStyleBackColor = false;
            this.btnCheck.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnFake
            // 
            this.btnFake.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnFake.Location = new System.Drawing.Point(540, 46);
            this.btnFake.Name = "btnFake";
            this.btnFake.Size = new System.Drawing.Size(82, 86);
            this.btnFake.TabIndex = 4;
            this.btnFake.Text = "FAKE0";
            this.btnFake.UseVisualStyleBackColor = false;
            this.btnFake.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnReal
            // 
            this.btnReal.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.btnReal.Location = new System.Drawing.Point(628, 46);
            this.btnReal.Name = "btnReal";
            this.btnReal.Size = new System.Drawing.Size(82, 86);
            this.btnReal.TabIndex = 5;
            this.btnReal.Text = "REAL0";
            this.btnReal.UseVisualStyleBackColor = false;
            this.btnReal.Click += new System.EventHandler(this.btnReal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(722, 400);
            this.Controls.Add(this.btnReal);
            this.Controls.Add(this.btnFake);
            this.Controls.Add(this.btnCheck);
            this.Controls.Add(this.btnBut);
            this.Controls.Add(this.btnQNext);
            this.Controls.Add(this.lst1);
            this.Name = "Form1";
            this.Text = "RFAKE";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lst1;
        private System.Windows.Forms.Button btnQNext;
        private System.Windows.Forms.Button btnBut;
        private System.Windows.Forms.Button btnCheck;
        private System.Windows.Forms.Button btnFake;
        private System.Windows.Forms.Button btnReal;
    }
}

