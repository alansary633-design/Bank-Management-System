namespace Bank1._1
{
    partial class frmTransactions
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pcbTransferLog = new System.Windows.Forms.PictureBox();
            this.pcbDeposit = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.lblTransactions = new System.Windows.Forms.Label();
            this.lblTransferLog = new System.Windows.Forms.Label();
            this.pcbWithdraw = new System.Windows.Forms.PictureBox();
            this.lblWithdraw = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.pcbFind = new System.Windows.Forms.PictureBox();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.pcbSearchLine = new System.Windows.Forms.PictureBox();
            this.lblDepositAmont = new System.Windows.Forms.Label();
            this.lblID = new System.Windows.Forms.Label();
            this.lblBalance1 = new System.Windows.Forms.Label();
            this.lblClientName1 = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.lblID1 = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.pcbClientNameLine = new System.Windows.Forms.PictureBox();
            this.pcbBalanceLine = new System.Windows.Forms.PictureBox();
            this.pcbClientIDLine = new System.Windows.Forms.PictureBox();
            this.lblSave = new System.Windows.Forms.Label();
            this.pcbSave = new System.Windows.Forms.PictureBox();
            this.lblCancel = new System.Windows.Forms.Label();
            this.pcbCancel = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.lblTransferAmont = new System.Windows.Forms.Label();
            this.lblReceiverACCT = new System.Windows.Forms.Label();
            this.pcbReceiverACCTLine = new System.Windows.Forms.PictureBox();
            this.txtReceiverACCT = new System.Windows.Forms.MaskedTextBox();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCluck)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTransferLog)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeposit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWithdraw)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFind)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientNameLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBalanceLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientIDLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSave)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceiverACCTLine)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.SuspendLayout();
            // 
            // pcbLine1
            // 
            this.pcbLine1.Size = new System.Drawing.Size(43, 604);
            // 
            // pcbCluck
            // 
            this.pcbCluck.Location = new System.Drawing.Point(892, 475);
            // 
            // lblTime
            // 
            this.lblTime.Location = new System.Drawing.Point(749, 481);
            this.lblTime.Size = new System.Drawing.Size(144, 18);
            this.lblTime.Text = "16/08/23 09:17:23 ص";
            // 
            // pcbOut
            // 
            this.pcbOut.Location = new System.Drawing.Point(871, 0);
            // 
            // pcbTransferLog
            // 
            this.pcbTransferLog.Image = global::Bank1._1.Properties.Resources.data_transfer;
            this.pcbTransferLog.Location = new System.Drawing.Point(784, 390);
            this.pcbTransferLog.Name = "pcbTransferLog";
            this.pcbTransferLog.Size = new System.Drawing.Size(131, 57);
            this.pcbTransferLog.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbTransferLog.TabIndex = 67;
            this.pcbTransferLog.TabStop = false;
            this.pcbTransferLog.Click += new System.EventHandler(this.pcbTransferLog_Click);
            this.pcbTransferLog.MouseEnter += new System.EventHandler(this.pcbTransferLog_MouseEnter);
            this.pcbTransferLog.MouseLeave += new System.EventHandler(this.pcbTransferLog_MouseLeave);
            // 
            // pcbDeposit
            // 
            this.pcbDeposit.Image = global::Bank1._1.Properties.Resources.money_transfer;
            this.pcbDeposit.Location = new System.Drawing.Point(709, 1);
            this.pcbDeposit.Name = "pcbDeposit";
            this.pcbDeposit.Size = new System.Drawing.Size(126, 66);
            this.pcbDeposit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbDeposit.TabIndex = 69;
            this.pcbDeposit.TabStop = false;
            this.pcbDeposit.Click += new System.EventHandler(this.pcbDeposit_Click);
            this.pcbDeposit.MouseEnter += new System.EventHandler(this.pcbDeposit_MouseEnter);
            this.pcbDeposit.MouseLeave += new System.EventHandler(this.pcbDeposit_MouseLeave);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::Bank1._1.Properties.Resources.transfer;
            this.pictureBox5.Location = new System.Drawing.Point(6, 1);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(161, 105);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 70;
            this.pictureBox5.TabStop = false;
            // 
            // lblTransactions
            // 
            this.lblTransactions.AutoSize = true;
            this.lblTransactions.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransactions.Location = new System.Drawing.Point(739, 68);
            this.lblTransactions.Name = "lblTransactions";
            this.lblTransactions.Size = new System.Drawing.Size(62, 17);
            this.lblTransactions.TabIndex = 72;
            this.lblTransactions.Text = "Transfer";
            this.lblTransactions.UseWaitCursor = true;
            // 
            // lblTransferLog
            // 
            this.lblTransferLog.AutoSize = true;
            this.lblTransferLog.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferLog.Location = new System.Drawing.Point(801, 445);
            this.lblTransferLog.Name = "lblTransferLog";
            this.lblTransferLog.Size = new System.Drawing.Size(97, 17);
            this.lblTransferLog.TabIndex = 73;
            this.lblTransferLog.Text = "Transfers Log";
            this.lblTransferLog.UseWaitCursor = true;
            this.lblTransferLog.Click += new System.EventHandler(this.lblTransferLog_Click);
            // 
            // pcbWithdraw
            // 
            this.pcbWithdraw.Image = global::Bank1._1.Properties.Resources.atm;
            this.pcbWithdraw.Location = new System.Drawing.Point(559, 1);
            this.pcbWithdraw.Name = "pcbWithdraw";
            this.pcbWithdraw.Size = new System.Drawing.Size(126, 66);
            this.pcbWithdraw.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbWithdraw.TabIndex = 65;
            this.pcbWithdraw.TabStop = false;
            this.pcbWithdraw.Click += new System.EventHandler(this.pcbWithdraw_Click);
            this.pcbWithdraw.MouseEnter += new System.EventHandler(this.pcbWithdraw_MouseEnter);
            this.pcbWithdraw.MouseLeave += new System.EventHandler(this.pcbWithdraw_MouseLeave);
            // 
            // lblWithdraw
            // 
            this.lblWithdraw.AutoSize = true;
            this.lblWithdraw.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWithdraw.Location = new System.Drawing.Point(585, 66);
            this.lblWithdraw.Name = "lblWithdraw";
            this.lblWithdraw.Size = new System.Drawing.Size(66, 17);
            this.lblWithdraw.TabIndex = 74;
            this.lblWithdraw.Text = "Withdraw";
            this.lblWithdraw.UseWaitCursor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(427, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 76;
            this.label2.Text = "Deposit";
            this.label2.UseWaitCursor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bank1._1.Properties.Resources.deposit;
            this.pictureBox1.Location = new System.Drawing.Point(395, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(126, 66);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 75;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            this.pictureBox1.MouseEnter += new System.EventHandler(this.pictureBox1_MouseEnter);
            this.pictureBox1.MouseLeave += new System.EventHandler(this.pictureBox1_MouseLeave);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.Location = new System.Drawing.Point(192, 133);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Size = new System.Drawing.Size(454, 334);
            this.dataGridView1.TabIndex = 77;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // pcbFind
            // 
            this.pcbFind.Image = global::Bank1._1.Properties.Resources.FirndUser;
            this.pcbFind.Location = new System.Drawing.Point(217, 98);
            this.pcbFind.Name = "pcbFind";
            this.pcbFind.Size = new System.Drawing.Size(29, 25);
            this.pcbFind.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbFind.TabIndex = 131;
            this.pcbFind.TabStop = false;
            // 
            // txtSearch
            // 
            this.txtSearch.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtSearch.Location = new System.Drawing.Point(249, 102);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(175, 13);
            this.txtSearch.TabIndex = 132;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // pcbSearchLine
            // 
            this.pcbSearchLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbSearchLine.Location = new System.Drawing.Point(233, 104);
            this.pcbSearchLine.Name = "pcbSearchLine";
            this.pcbSearchLine.Size = new System.Drawing.Size(163, 23);
            this.pcbSearchLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbSearchLine.TabIndex = 133;
            this.pcbSearchLine.TabStop = false;
            // 
            // lblDepositAmont
            // 
            this.lblDepositAmont.AutoSize = true;
            this.lblDepositAmont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepositAmont.Location = new System.Drawing.Point(224, 233);
            this.lblDepositAmont.Name = "lblDepositAmont";
            this.lblDepositAmont.Size = new System.Drawing.Size(108, 17);
            this.lblDepositAmont.TabIndex = 138;
            this.lblDepositAmont.Text = "Deposit Amont :";
            // 
            // lblID
            // 
            this.lblID.AutoSize = true;
            this.lblID.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID.Location = new System.Drawing.Point(653, 136);
            this.lblID.Name = "lblID";
            this.lblID.Size = new System.Drawing.Size(52, 18);
            this.lblID.TabIndex = 139;
            this.lblID.Text = "ACCT:";
            // 
            // lblBalance1
            // 
            this.lblBalance1.AutoSize = true;
            this.lblBalance1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance1.Location = new System.Drawing.Point(717, 284);
            this.lblBalance1.Name = "lblBalance1";
            this.lblBalance1.Size = new System.Drawing.Size(67, 25);
            this.lblBalance1.TabIndex = 140;
            this.lblBalance1.Text = "50032";
            // 
            // lblClientName1
            // 
            this.lblClientName1.AutoSize = true;
            this.lblClientName1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName1.Location = new System.Drawing.Point(708, 204);
            this.lblClientName1.Name = "lblClientName1";
            this.lblClientName1.Size = new System.Drawing.Size(160, 25);
            this.lblClientName1.TabIndex = 141;
            this.lblClientName1.Text = "Ahmed Alansary";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBalance.Location = new System.Drawing.Point(653, 290);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(69, 18);
            this.lblBalance.TabIndex = 142;
            this.lblBalance.Text = "Balance :";
            this.lblBalance.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblID1
            // 
            this.lblID1.AutoSize = true;
            this.lblID1.Font = new System.Drawing.Font("Sylfaen", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblID1.Location = new System.Drawing.Point(698, 129);
            this.lblID1.Name = "lblID1";
            this.lblID1.Size = new System.Drawing.Size(45, 25);
            this.lblID1.TabIndex = 143;
            this.lblID1.Text = "156";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(653, 210);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(56, 18);
            this.lblClientName.TabIndex = 144;
            this.lblClientName.Text = "Name :";
            // 
            // pcbClientNameLine
            // 
            this.pcbClientNameLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbClientNameLine.Location = new System.Drawing.Point(687, 218);
            this.pcbClientNameLine.Name = "pcbClientNameLine";
            this.pcbClientNameLine.Size = new System.Drawing.Size(244, 23);
            this.pcbClientNameLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClientNameLine.TabIndex = 145;
            this.pcbClientNameLine.TabStop = false;
            // 
            // pcbBalanceLine
            // 
            this.pcbBalanceLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbBalanceLine.Location = new System.Drawing.Point(695, 298);
            this.pcbBalanceLine.Name = "pcbBalanceLine";
            this.pcbBalanceLine.Size = new System.Drawing.Size(236, 23);
            this.pcbBalanceLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbBalanceLine.TabIndex = 146;
            this.pcbBalanceLine.TabStop = false;
            // 
            // pcbClientIDLine
            // 
            this.pcbClientIDLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbClientIDLine.Location = new System.Drawing.Point(688, 143);
            this.pcbClientIDLine.Name = "pcbClientIDLine";
            this.pcbClientIDLine.Size = new System.Drawing.Size(170, 23);
            this.pcbClientIDLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbClientIDLine.TabIndex = 147;
            this.pcbClientIDLine.TabStop = false;
            // 
            // lblSave
            // 
            this.lblSave.AutoSize = true;
            this.lblSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSave.Location = new System.Drawing.Point(304, 384);
            this.lblSave.Name = "lblSave";
            this.lblSave.Size = new System.Drawing.Size(40, 17);
            this.lblSave.TabIndex = 4;
            this.lblSave.Text = "Save";
            this.lblSave.UseWaitCursor = true;
            this.lblSave.Click += new System.EventHandler(this.lblSave_Click);
            // 
            // pcbSave
            // 
            this.pcbSave.Image = global::Bank1._1.Properties.Resources.diskette;
            this.pcbSave.Location = new System.Drawing.Point(265, 329);
            this.pcbSave.Name = "pcbSave";
            this.pcbSave.Size = new System.Drawing.Size(120, 52);
            this.pcbSave.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbSave.TabIndex = 148;
            this.pcbSave.TabStop = false;
            this.pcbSave.Click += new System.EventHandler(this.pcbSave_Click);
            // 
            // lblCancel
            // 
            this.lblCancel.AutoSize = true;
            this.lblCancel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCancel.Location = new System.Drawing.Point(502, 384);
            this.lblCancel.Name = "lblCancel";
            this.lblCancel.Size = new System.Drawing.Size(51, 17);
            this.lblCancel.TabIndex = 3;
            this.lblCancel.Text = "Cancel";
            this.lblCancel.UseWaitCursor = true;
            this.lblCancel.Click += new System.EventHandler(this.lblCancel_Click);
            // 
            // pcbCancel
            // 
            this.pcbCancel.Image = global::Bank1._1.Properties.Resources.cancel__1_;
            this.pcbCancel.Location = new System.Drawing.Point(463, 329);
            this.pcbCancel.Name = "pcbCancel";
            this.pcbCancel.Size = new System.Drawing.Size(120, 52);
            this.pcbCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbCancel.TabIndex = 150;
            this.pcbCancel.TabStop = false;
            this.pcbCancel.Click += new System.EventHandler(this.pcbCancel_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(264, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 17);
            this.label3.TabIndex = 153;
            this.label3.Text = "Clients List";
            this.label3.UseWaitCursor = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Bank1._1.Properties.Resources.customer__1_;
            this.pictureBox2.Location = new System.Drawing.Point(241, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(126, 66);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 152;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            this.pictureBox2.MouseEnter += new System.EventHandler(this.pictureBox2_MouseEnter);
            this.pictureBox2.MouseLeave += new System.EventHandler(this.pictureBox2_MouseLeave);
            // 
            // lblTransferAmont
            // 
            this.lblTransferAmont.AutoSize = true;
            this.lblTransferAmont.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTransferAmont.Location = new System.Drawing.Point(216, 234);
            this.lblTransferAmont.Name = "lblTransferAmont";
            this.lblTransferAmont.Size = new System.Drawing.Size(114, 17);
            this.lblTransferAmont.TabIndex = 155;
            this.lblTransferAmont.Text = "Transfer Amont :";
            // 
            // lblReceiverACCT
            // 
            this.lblReceiverACCT.AutoSize = true;
            this.lblReceiverACCT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiverACCT.Location = new System.Drawing.Point(224, 190);
            this.lblReceiverACCT.Name = "lblReceiverACCT";
            this.lblReceiverACCT.Size = new System.Drawing.Size(112, 17);
            this.lblReceiverACCT.TabIndex = 158;
            this.lblReceiverACCT.Text = "Receiver ACCT: ";
            // 
            // pcbReceiverACCTLine
            // 
            this.pcbReceiverACCTLine.Image = global::Bank1._1.Properties.Resources.Line_1;
            this.pcbReceiverACCTLine.Location = new System.Drawing.Point(319, 193);
            this.pcbReceiverACCTLine.Name = "pcbReceiverACCTLine";
            this.pcbReceiverACCTLine.Size = new System.Drawing.Size(181, 23);
            this.pcbReceiverACCTLine.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pcbReceiverACCTLine.TabIndex = 159;
            this.pcbReceiverACCTLine.TabStop = false;
            // 
            // txtReceiverACCT
            // 
            this.txtReceiverACCT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtReceiverACCT.Location = new System.Drawing.Point(341, 191);
            this.txtReceiverACCT.Mask = "L00000000";
            this.txtReceiverACCT.Name = "txtReceiverACCT";
            this.txtReceiverACCT.Size = new System.Drawing.Size(157, 13);
            this.txtReceiverACCT.TabIndex = 1;
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.numericUpDown1.InterceptArrowKeys = false;
            this.numericUpDown1.Location = new System.Drawing.Point(340, 235);
            this.numericUpDown1.Maximum = new decimal(new int[] {
            999999,
            0,
            0,
            0});
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(162, 20);
            this.numericUpDown1.TabIndex = 2;
            // 
            // frmTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(916, 499);
            this.Controls.Add(this.lblTransferLog);
            this.Controls.Add(this.pcbTransferLog);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.txtSearch);
            this.Controls.Add(this.lblReceiverACCT);
            this.Controls.Add(this.txtReceiverACCT);
            this.Controls.Add(this.numericUpDown1);
            this.Controls.Add(this.pcbFind);
            this.Controls.Add(this.pcbSearchLine);
            this.Controls.Add(this.pcbReceiverACCTLine);
            this.Controls.Add(this.lblTransferAmont);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lblDepositAmont);
            this.Controls.Add(this.lblCancel);
            this.Controls.Add(this.pcbCancel);
            this.Controls.Add(this.lblSave);
            this.Controls.Add(this.pcbSave);
            this.Controls.Add(this.lblID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblWithdraw);
            this.Controls.Add(this.lblTransactions);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pcbDeposit);
            this.Controls.Add(this.pcbWithdraw);
            this.Controls.Add(this.lblClientName);
            this.Controls.Add(this.lblBalance);
            this.Controls.Add(this.lblID1);
            this.Controls.Add(this.lblClientName1);
            this.Controls.Add(this.lblBalance1);
            this.Controls.Add(this.pcbClientNameLine);
            this.Controls.Add(this.pcbBalanceLine);
            this.Controls.Add(this.pcbClientIDLine);
            this.Name = "frmTransactions";
            this.Text = "Transactions";
            this.Load += new System.EventHandler(this.frmTransactions_Load);
            this.Controls.SetChildIndex(this.pcbClientIDLine, 0);
            this.Controls.SetChildIndex(this.pcbBalanceLine, 0);
            this.Controls.SetChildIndex(this.pcbClientNameLine, 0);
            this.Controls.SetChildIndex(this.lblBalance1, 0);
            this.Controls.SetChildIndex(this.lblClientName1, 0);
            this.Controls.SetChildIndex(this.lblID1, 0);
            this.Controls.SetChildIndex(this.lblBalance, 0);
            this.Controls.SetChildIndex(this.lblClientName, 0);
            this.Controls.SetChildIndex(this.pcbWithdraw, 0);
            this.Controls.SetChildIndex(this.pcbDeposit, 0);
            this.Controls.SetChildIndex(this.pictureBox5, 0);
            this.Controls.SetChildIndex(this.lblTransactions, 0);
            this.Controls.SetChildIndex(this.lblWithdraw, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.lblID, 0);
            this.Controls.SetChildIndex(this.pcbSave, 0);
            this.Controls.SetChildIndex(this.lblSave, 0);
            this.Controls.SetChildIndex(this.pcbCancel, 0);
            this.Controls.SetChildIndex(this.lblCancel, 0);
            this.Controls.SetChildIndex(this.lblDepositAmont, 0);
            this.Controls.SetChildIndex(this.pictureBox2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.lblTransferAmont, 0);
            this.Controls.SetChildIndex(this.pcbReceiverACCTLine, 0);
            this.Controls.SetChildIndex(this.pcbSearchLine, 0);
            this.Controls.SetChildIndex(this.pcbFind, 0);
            this.Controls.SetChildIndex(this.numericUpDown1, 0);
            this.Controls.SetChildIndex(this.txtReceiverACCT, 0);
            this.Controls.SetChildIndex(this.lblReceiverACCT, 0);
            this.Controls.SetChildIndex(this.pcbLine, 0);
            this.Controls.SetChildIndex(this.lblTime, 0);
            this.Controls.SetChildIndex(this.pcbBank, 0);
            this.Controls.SetChildIndex(this.pcbLine1, 0);
            this.Controls.SetChildIndex(this.pcbCluck, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.pcbOut, 0);
            this.Controls.SetChildIndex(this.txtSearch, 0);
            this.Controls.SetChildIndex(this.dataGridView1, 0);
            this.Controls.SetChildIndex(this.pcbTransferLog, 0);
            this.Controls.SetChildIndex(this.lblTransferLog, 0);
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCluck)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbTransferLog)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbDeposit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbWithdraw)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbFind)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSearchLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientNameLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbBalanceLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbClientIDLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbSave)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pcbReceiverACCTLine)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pcbTransferLog;
        private System.Windows.Forms.PictureBox pcbDeposit;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Label lblTransactions;
        private System.Windows.Forms.Label lblTransferLog;
        private System.Windows.Forms.PictureBox pcbWithdraw;
        private System.Windows.Forms.Label lblWithdraw;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.PictureBox pcbFind;
        private System.Windows.Forms.TextBox txtSearch;
        protected System.Windows.Forms.PictureBox pcbSearchLine;
        private System.Windows.Forms.Label lblDepositAmont;
        private System.Windows.Forms.Label lblID;
        private System.Windows.Forms.Label lblBalance1;
        private System.Windows.Forms.Label lblClientName1;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblID1;
        private System.Windows.Forms.Label lblClientName;
        protected System.Windows.Forms.PictureBox pcbClientNameLine;
        protected System.Windows.Forms.PictureBox pcbBalanceLine;
        protected System.Windows.Forms.PictureBox pcbClientIDLine;
        private System.Windows.Forms.Label lblSave;
        private System.Windows.Forms.PictureBox pcbSave;
        private System.Windows.Forms.Label lblCancel;
        private System.Windows.Forms.PictureBox pcbCancel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label lblTransferAmont;
        private System.Windows.Forms.Label lblReceiverACCT;
        protected System.Windows.Forms.PictureBox pcbReceiverACCTLine;
        private System.Windows.Forms.MaskedTextBox txtReceiverACCT;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
    }
}