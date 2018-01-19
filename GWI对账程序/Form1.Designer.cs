namespace GWI对账程序
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.openfileButton = new System.Windows.Forms.Button();
            this.openFileTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.DataFileBox = new System.Windows.Forms.TextBox();
            this.DataFileButton = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox_his = new System.Windows.Forms.TextBox();
            this.textBox_bank = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboBox_bankPersonID = new System.Windows.Forms.ComboBox();
            this.comboBox_bankCard = new System.Windows.Forms.ComboBox();
            this.comboBox_bankFH = new System.Windows.Forms.ComboBox();
            this.comboBox_bankMoney = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox_hisPersonID = new System.Windows.Forms.ComboBox();
            this.comboBox_hisBankCard = new System.Windows.Forms.ComboBox();
            this.comboBox_hisMoney = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.comboBox_hisName = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // openfileButton
            // 
            this.openfileButton.Location = new System.Drawing.Point(83, 64);
            this.openfileButton.Name = "openfileButton";
            this.openfileButton.Size = new System.Drawing.Size(97, 23);
            this.openfileButton.TabIndex = 0;
            this.openfileButton.Text = "载入文件";
            this.openfileButton.UseVisualStyleBackColor = true;
            this.openfileButton.Click += new System.EventHandler(this.openfileButton_Click);
            // 
            // openFileTextBox
            // 
            this.openFileTextBox.Location = new System.Drawing.Point(201, 42);
            this.openFileTextBox.Name = "openFileTextBox";
            this.openFileTextBox.ReadOnly = true;
            this.openFileTextBox.Size = new System.Drawing.Size(594, 21);
            this.openFileTextBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(82, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "打开银行文件地址：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(245, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "1、首先载入已转换为TXT格式的银行MX文件。";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(81, 115);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "打开数据库文件地址：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(82, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(329, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "2、载入从数据库获取的当日数据，格式为Excel的.xls格式。";
            // 
            // DataFileBox
            // 
            this.DataFileBox.Location = new System.Drawing.Point(201, 111);
            this.DataFileBox.Name = "DataFileBox";
            this.DataFileBox.ReadOnly = true;
            this.DataFileBox.Size = new System.Drawing.Size(594, 21);
            this.DataFileBox.TabIndex = 6;
            // 
            // DataFileButton
            // 
            this.DataFileButton.Location = new System.Drawing.Point(83, 136);
            this.DataFileButton.Name = "DataFileButton";
            this.DataFileButton.Size = new System.Drawing.Size(97, 23);
            this.DataFileButton.TabIndex = 7;
            this.DataFileButton.Text = "载入文件";
            this.DataFileButton.UseVisualStyleBackColor = true;
            this.DataFileButton.Click += new System.EventHandler(this.DataFileButton_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(83, 439);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(712, 40);
            this.button1.TabIndex = 8;
            this.button1.Text = "开始对比";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox_his);
            this.groupBox1.Controls.Add(this.textBox_bank);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Location = new System.Drawing.Point(85, 195);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(710, 58);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "银行与HIS数据(四舍五入取整)";
            // 
            // textBox_his
            // 
            this.textBox_his.Location = new System.Drawing.Point(335, 20);
            this.textBox_his.Name = "textBox_his";
            this.textBox_his.Size = new System.Drawing.Size(136, 21);
            this.textBox_his.TabIndex = 13;
            // 
            // textBox_bank
            // 
            this.textBox_bank.Location = new System.Drawing.Point(90, 20);
            this.textBox_bank.Name = "textBox_bank";
            this.textBox_bank.Size = new System.Drawing.Size(151, 21);
            this.textBox_bank.TabIndex = 11;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(270, 27);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 12);
            this.label7.TabIndex = 12;
            this.label7.Text = "HIS金额：";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(19, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 11;
            this.label6.Text = "银行金额：";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(83, 166);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(281, 12);
            this.label5.TabIndex = 10;
            this.label5.Text = "3、输入银行以及HIS当日总金额（用于匹配差额）。";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(83, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 12);
            this.label8.TabIndex = 11;
            this.label8.Text = "4、银行及HIS文件设置。";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.comboBox_bankPersonID);
            this.groupBox2.Controls.Add(this.comboBox_bankCard);
            this.groupBox2.Controls.Add(this.comboBox_bankFH);
            this.groupBox2.Controls.Add(this.comboBox_bankMoney);
            this.groupBox2.Controls.Add(this.label13);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Location = new System.Drawing.Point(83, 288);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(331, 125);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "银行文件设置";
            // 
            // comboBox_bankPersonID
            // 
            this.comboBox_bankPersonID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bankPersonID.FormattingEnabled = true;
            this.comboBox_bankPersonID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_bankPersonID.Location = new System.Drawing.Point(219, 75);
            this.comboBox_bankPersonID.Name = "comboBox_bankPersonID";
            this.comboBox_bankPersonID.Size = new System.Drawing.Size(62, 20);
            this.comboBox_bankPersonID.TabIndex = 9;
            // 
            // comboBox_bankCard
            // 
            this.comboBox_bankCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bankCard.FormattingEnabled = true;
            this.comboBox_bankCard.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_bankCard.Location = new System.Drawing.Point(82, 98);
            this.comboBox_bankCard.Name = "comboBox_bankCard";
            this.comboBox_bankCard.Size = new System.Drawing.Size(62, 20);
            this.comboBox_bankCard.TabIndex = 8;
            // 
            // comboBox_bankFH
            // 
            this.comboBox_bankFH.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bankFH.FormattingEnabled = true;
            this.comboBox_bankFH.Items.AddRange(new object[] {
            "|",
            "，"});
            this.comboBox_bankFH.Location = new System.Drawing.Point(109, 20);
            this.comboBox_bankFH.Name = "comboBox_bankFH";
            this.comboBox_bankFH.Size = new System.Drawing.Size(55, 20);
            this.comboBox_bankFH.TabIndex = 6;
            // 
            // comboBox_bankMoney
            // 
            this.comboBox_bankMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_bankMoney.FormattingEnabled = true;
            this.comboBox_bankMoney.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_bankMoney.Location = new System.Drawing.Point(82, 75);
            this.comboBox_bankMoney.Name = "comboBox_bankMoney";
            this.comboBox_bankMoney.Size = new System.Drawing.Size(62, 20);
            this.comboBox_bankMoney.TabIndex = 5;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(151, 78);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(65, 12);
            this.label13.TabIndex = 4;
            this.label13.Text = "个人账号：";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(11, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 12);
            this.label12.TabIndex = 3;
            this.label12.Text = "银行卡号：";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(21, 78);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(41, 12);
            this.label11.TabIndex = 2;
            this.label11.Text = "金额：";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(11, 54);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(263, 12);
            this.label10.TabIndex = 1;
            this.label10.Text = "文件中金额、银行卡号、个人账号位置（0开始）";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(11, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(101, 12);
            this.label9.TabIndex = 0;
            this.label9.Text = "银行文件分隔符：";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox_hisName);
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.comboBox_hisPersonID);
            this.groupBox3.Controls.Add(this.comboBox_hisBankCard);
            this.groupBox3.Controls.Add(this.comboBox_hisMoney);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label17);
            this.groupBox3.Controls.Add(this.label18);
            this.groupBox3.Location = new System.Drawing.Point(440, 288);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(355, 125);
            this.groupBox3.TabIndex = 13;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "HIS文件设置";
            // 
            // comboBox_hisPersonID
            // 
            this.comboBox_hisPersonID.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hisPersonID.FormattingEnabled = true;
            this.comboBox_hisPersonID.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_hisPersonID.Location = new System.Drawing.Point(251, 58);
            this.comboBox_hisPersonID.Name = "comboBox_hisPersonID";
            this.comboBox_hisPersonID.Size = new System.Drawing.Size(62, 20);
            this.comboBox_hisPersonID.TabIndex = 14;
            // 
            // comboBox_hisBankCard
            // 
            this.comboBox_hisBankCard.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hisBankCard.FormattingEnabled = true;
            this.comboBox_hisBankCard.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_hisBankCard.Location = new System.Drawing.Point(100, 81);
            this.comboBox_hisBankCard.Name = "comboBox_hisBankCard";
            this.comboBox_hisBankCard.Size = new System.Drawing.Size(62, 20);
            this.comboBox_hisBankCard.TabIndex = 13;
            // 
            // comboBox_hisMoney
            // 
            this.comboBox_hisMoney.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hisMoney.FormattingEnabled = true;
            this.comboBox_hisMoney.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_hisMoney.Location = new System.Drawing.Point(100, 58);
            this.comboBox_hisMoney.Name = "comboBox_hisMoney";
            this.comboBox_hisMoney.Size = new System.Drawing.Size(62, 20);
            this.comboBox_hisMoney.TabIndex = 12;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(180, 61);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(65, 12);
            this.label16.TabIndex = 7;
            this.label16.Text = "个人账号：";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(35, 37);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(263, 12);
            this.label15.TabIndex = 10;
            this.label15.Text = "文件中金额、银行卡号、个人账号位置（0开始）";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(40, 84);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(65, 12);
            this.label17.TabIndex = 6;
            this.label17.Text = "银行卡号：";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(50, 61);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(41, 12);
            this.label18.TabIndex = 5;
            this.label18.Text = "金额：";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(180, 84);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(41, 12);
            this.label14.TabIndex = 15;
            this.label14.Text = "姓名：";
            // 
            // comboBox_hisName
            // 
            this.comboBox_hisName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox_hisName.FormattingEnabled = true;
            this.comboBox_hisName.Items.AddRange(new object[] {
            "0",
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12",
            "13",
            "14",
            "15"});
            this.comboBox_hisName.Location = new System.Drawing.Point(251, 81);
            this.comboBox_hisName.Name = "comboBox_hisName";
            this.comboBox_hisName.Size = new System.Drawing.Size(62, 20);
            this.comboBox_hisName.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 531);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DataFileButton);
            this.Controls.Add(this.DataFileBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.openFileTextBox);
            this.Controls.Add(this.openfileButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button openfileButton;
        private System.Windows.Forms.TextBox openFileTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox DataFileBox;
        private System.Windows.Forms.Button DataFileButton;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBox_his;
        private System.Windows.Forms.TextBox textBox_bank;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox comboBox_bankPersonID;
        private System.Windows.Forms.ComboBox comboBox_bankCard;
        private System.Windows.Forms.ComboBox comboBox_bankFH;
        private System.Windows.Forms.ComboBox comboBox_bankMoney;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox_hisPersonID;
        private System.Windows.Forms.ComboBox comboBox_hisBankCard;
        private System.Windows.Forms.ComboBox comboBox_hisMoney;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.ComboBox comboBox_hisName;
        private System.Windows.Forms.Label label14;
    }
}

