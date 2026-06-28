namespace Bank1._1
{
    partial class frmDesigne
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
            this.lblTime = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.pcbOut = new System.Windows.Forms.PictureBox();
            this.pcbCluck = new System.Windows.Forms.PictureBox();
            this.pcbLine1 = new System.Windows.Forms.PictureBox();
            this.pcbLine = new System.Windows.Forms.PictureBox();
            this.pcbBank = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCluck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTime.Location = new System.Drawing.Point(810, 479);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(132, 18);
            this.lblTime.TabIndex = 59;
            this.lblTime.Text = "00/00/00 00:00:00  ";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel1.Location = new System.Drawing.Point(-1, 481);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(123, 13);
            this.linkLabel1.TabIndex = 61;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Alansary633@gmail.com";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(-1, 463);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 16);
            this.label1.TabIndex = 60;
            this.label1.Text = "Paowerd By ";
            // 
            // pcbOut
            // 
            this.pcbOut.Image = global::Bank1._1.Properties.Resources.logout;
            this.pcbOut.Location = new System.Drawing.Point(922, 4);
            this.pcbOut.Name = "pcbOut";
            this.pcbOut.Size = new System.Drawing.Size(51, 30);
            this.pcbOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbOut.TabIndex = 62;
            this.pcbOut.TabStop = false;
            this.pcbOut.Click += new System.EventHandler(this.pcbOut_Click);
            this.pcbOut.MouseEnter += new System.EventHandler(this.pcbOut_MouseEnter);
            this.pcbOut.MouseLeave += new System.EventHandler(this.pcbOut_MouseLeave);
            // 
            // pcbCluck
            // 
            this.pcbCluck.Image = global::Bank1._1.Properties.Resources.clock;
            this.pcbCluck.Location = new System.Drawing.Point(946, 473);
            this.pcbCluck.Name = "pcbCluck";
            this.pcbCluck.Size = new System.Drawing.Size(21, 26);
            this.pcbCluck.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCluck.TabIndex = 3;
            this.pcbCluck.TabStop = false;
            // 
            // pcbLine1
            // 
            this.pcbLine1.Image = global::Bank1._1.Properties.Resources.Line;
            this.pcbLine1.Location = new System.Drawing.Point(169, -56);
            this.pcbLine1.Name = "pcbLine1";
            this.pcbLine1.Size = new System.Drawing.Size(43, 557);
            this.pcbLine1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLine1.TabIndex = 0;
            this.pcbLine1.TabStop = false;
            // 
            // pcbLine
            // 
            this.pcbLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbLine.Location = new System.Drawing.Point(-30, 278);
            this.pcbLine.Name = "pcbLine";
            this.pcbLine.Size = new System.Drawing.Size(250, 42);
            this.pcbLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbLine.TabIndex = 2;
            this.pcbLine.TabStop = false;
            // 
            // pcbBank
            // 
            this.pcbBank.Image = global::Bank1._1.Properties.Resources.bank;
            this.pcbBank.Location = new System.Drawing.Point(27, 332);
            this.pcbBank.Name = "pcbBank";
            this.pcbBank.Size = new System.Drawing.Size(129, 106);
            this.pcbBank.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbBank.TabIndex = 1;
            this.pcbBank.TabStop = false;
            this.pcbBank.Tag = "0";
            // 
            // frmDesigne
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 499);
            this.Controls.Add(this.pcbOut);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pcbCluck);
            this.Controls.Add(this.pcbBank);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.pcbLine1);
            this.Controls.Add(this.pcbLine);
            this.Name = "frmDesigne";
            this.Text = "frmDesigne";
            this.Load += new System.EventHandler(this.frmDesigne_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pcbOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCluck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.PictureBox pcbLine1;
        protected System.Windows.Forms.PictureBox pcbBank;
        protected System.Windows.Forms.PictureBox pcbLine;
        protected System.Windows.Forms.PictureBox pcbCluck;
        protected System.Windows.Forms.Label lblTime;
        protected System.Windows.Forms.LinkLabel linkLabel1;
        protected System.Windows.Forms.Label label1;
        protected System.Windows.Forms.PictureBox pcbOut;
    }
}