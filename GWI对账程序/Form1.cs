///Coder:soupHM
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;

namespace GWI对账程序
{
    public partial class Form1 : Form
    {        
        public static string dataFileAdr;//数据库文件地址
        public static string bankFileAdr;//银行文件地址
        public static string dayData;//记录日期
        public static string nullString = "000|000|000|000|000";//为空时的数据

        /// <summary>
        /// 初始化
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //银行设置
            comboBox_bankCard.Text = "3";
            comboBox_bankFH.Text = "|";
            comboBox_bankMoney.Text ="4";
            comboBox_bankPersonID.Text = "8";
            //HIS设置
            comboBox_hisBankCard.Text = "14";
            //comboBox_hisFH.Text = "";
            comboBox_hisMoney.Text = "9";
            comboBox_hisPersonID.Text = "6";
            comboBox_hisName.Text = "8";
        }

        /// <summary>
        /// 银行文件打开按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openfileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "文本文件(*.txt)|*.txt";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    openFileTextBox.Text = file.ToString();
                    bankFileAdr = file.ToString();
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception eMsg)
            {
                MessageBox.Show(eMsg.Message);
            }            
        }

        /// <summary>
        /// 数据文件打开按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DataFileButton_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog fileDialog = new OpenFileDialog();
                fileDialog.Multiselect = true;
                fileDialog.Title = "请选择文件";
                fileDialog.Filter = "xls文件(*.xls)|*.xls";
                if (fileDialog.ShowDialog() == DialogResult.OK)
                {
                    string file = fileDialog.FileName;
                    DataFileBox.Text = file.ToString();
                    dataFileAdr = file.ToString();
                    //MessageBox.Show("已选择文件:" + file, "选择文件提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception eMsg)
            {
                MessageBox.Show(eMsg.Message);
            }            
        }
        
        /// <summary>
        /// 检查所有必选项是否有值
        /// </summary>
        private bool CheckAll() {
            if (openFileTextBox.Text != "" && DataFileBox.Text != "" && textBox_bank.Text != "" && textBox_his.Text != "")
	        {
                return true;
	        }
            else
            {
                MessageBox.Show("必要参数填写为空！");
                return false;
            }
        }

        /// <summary>
        /// 按钮触发事件 主要代码
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (CheckAll() == true)
                {
                    MessageBox.Show("对比文件将存入C盘根目录！");
                    //文件对比代码开始
                    if (dataFileAdr != "" && bankFileAdr != "")
                    {
                        //银行数据处理
                        ArrayList bank_List = SumBankData(bankFileAdr);
                        //读取xls文件并处理
                        ArrayList data_List = SumData(dataFileAdr);
                        ////对比两个数组
                        int eorNum = System.Math.Abs(bank_List.Count - data_List.Count); //数量上的差值
                        ArrayList Biger_List;
                        ArrayList Smart_List;
                        //标记
                        string bj;
                        if (bank_List.Count > data_List.Count)
                        {
                            Biger_List = bank_List;
                            Smart_List = data_List;
                            bj = "bank_List";
                        }
                        else
                        {
                            Biger_List = data_List;
                            Smart_List = bank_List;
                            bj = "data_List";
                        }

                        Data.WorkForData(Biger_List, Smart_List);
                        Biger_List = Data.dataOne;
                        Smart_List = Data.dataTwo;
                        //Data.ClearDataArrayList();

                        //删除多余数据
                        ArrayList Biger_List_New = Data.DeleteUnuserfullData(Biger_List);
                        ArrayList Smart_List_New = Data.DeleteUnuserfullData(Smart_List);
                        
                        //计算总金额差值  并进行二次筛选
                        double i1 = System.Math.Abs(Data.MathAllNumble(Biger_List_New) - Data.MathAllNumble(Smart_List_New));
                        double i2 = System.Math.Abs(double.Parse(textBox_bank.Text) - double.Parse(textBox_his.Text));
                        ArrayList iList_ = new ArrayList();

                        if (System.Math.Abs(i1 - i2) <= 0.5)
                        {
                            ArrayList iList_1 = Data.WorkForDataAgain(Biger_List_New, Smart_List_New);
                            ArrayList iList_2 = Data.WorkForDataAgain(Smart_List_New, Biger_List_New);
                            iList_ = iList_1.Count > iList_2.Count ? iList_1 : iList_2;
                            if (bj == "bank_List")
                            {
                                Data.TxtWrite("C:\\对账比对结果（银行多）" + dayData.ToString() + ".txt", iList_);
                                MessageBox.Show("输出文件:对账比对结果（银行多）" + dayData.ToString() + ".txt");
                                Data.TxtWrite("C:\\bank_List.txt", Biger_List_New);
                                Data.TxtWrite("C:\\data_List.txt", Smart_List_New);
                            }
                            else
                            {
                                Data.TxtWrite("C:\\对账比对结果（HIS多）" + dayData.ToString() + ".txt", iList_);
                                MessageBox.Show("输出文件:对账比对结果（HIS多）" + dayData.ToString() + ".txt");
                                Data.TxtWrite("C:\\bank_List.txt", Smart_List_New);
                                Data.TxtWrite("C:\\data_List.txt", Biger_List_New);
                            }
                        }
                        else
                        {
                            StringBuilder sb = new StringBuilder();
                            sb.AppendFormat("金额差额不匹配：({0},{1})", i1, i2);
                            MessageBox.Show(sb.ToString());
                        }
                    }
                    else
                    {
                        MessageBox.Show("银行文件或者数据库文件值为空，请检查！");
                    }
                }                
            }
            catch (Exception eMsg)
            {
                MessageBox.Show(eMsg.Message);                
            }
            finally
            {
                //数据清空
                dayData = "";//记录日期
            }      
            
        }

        /// <summary>
        /// 存储HIS数据
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        private ArrayList SumData(string FilePath)
        {
            DataTable dtExcel = new DataTable();
            //数据表
            DataSet ds = new DataSet();
            //获取文件扩展名
            string strExtension = System.IO.Path.GetExtension(FilePath);
            string strFileName = System.IO.Path.GetFileName(FilePath);
            //Excel的连接
            OleDbConnection objConn = null;
            switch (strExtension)
            {
                case ".xls":
                    objConn = new OleDbConnection("Provider=Microsoft.Jet.OLEDB.4.0;Data Source=" + FilePath + ";" + "Extended Properties=\"Excel 8.0;HDR=NO;IMEX=1;\"");
                    break;
                case ".xlsx":
                    objConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + FilePath + ";" + "Extended Properties=\"Excel 12.0;HDR=NO;IMEX=1;\"");
                    break;
                default:
                    objConn = null;
                    break;
            }
            if (objConn == null)
            {
                return null;
            }
            objConn.Open();
            //获取Excel中所有Sheet表的信息
            System.Data.DataTable schemaTable = objConn.GetOleDbSchemaTable(System.Data.OleDb.OleDbSchemaGuid.Tables, null);
            //获取Excel的第一个Sheet表名
            string tableName = schemaTable.Rows[0][2].ToString().Trim();
            string strSql = "select * from [" + tableName + "]";
            //获取Excel指定Sheet表中的信息
            OleDbCommand objCmd = new OleDbCommand(strSql, objConn);
            OleDbDataAdapter myData = new OleDbDataAdapter(strSql, objConn);
            myData.Fill(ds,tableName);//填充数据
            objConn.Close();
            //dtExcel即为excel文件中指定表中存储的信息
            dtExcel = ds.Tables[tableName];  

            //开始处理数据
            int j=0;
            ArrayList dataList = new ArrayList();//动态数组存储数据库数据
            foreach (DataRow dr in dtExcel.Rows) //set.Tables[0].Rows 找到指定表的所有行 0这里可以填表名
            {
                string a = dr[int.Parse(comboBox_hisMoney.Text.ToString())].ToString() 
                    + "|" + dr[int.Parse(comboBox_hisBankCard.Text.ToString())].ToString()
                    + "|" + dr[int.Parse(comboBox_hisName.Text.ToString())].ToString()
                    + "|" + dr[int.Parse(comboBox_hisPersonID.Text.ToString())].ToString();
                dataList.Add(a);
                //new_ds.Columns.Add(ds.Tables[0].Rows[9].ToString());
                //new_ds.Columns.Add(ds.Tables[0].Rows[14].ToString());
                //Console.WriteLine(dr[i].ToString()); //col[0]这一行的索引是0单元格，也就是列，你只要在0这里填上你要输出的第几列就行了
                j++;
            }            
            return dataList;             
        }

        /// <summary>
        /// 存储银行数据
        /// </summary>
        /// <param name="FilePath"></param>
        /// <returns></returns>
        public ArrayList SumBankData(string FilePath)
        {
            int i = 0;//文件行数
            String line;//临时存储数据

            ArrayList bankList = new ArrayList();//动态数组存储银行数据
            //读取txt文件
            StreamReader rd = File.OpenText(FilePath);
            while ((line = rd.ReadLine()) != null)
            {
                string[] ss = line.Split(char.Parse(comboBox_bankFH.Text.ToString()));//分割符号
                if (ss[0] == "1")
                {
                    string[] Mon = ss[int.Parse(comboBox_bankCard.Text.ToString())].ToString().Split('=');//排除某些银行卡 610**********=25431 这种情况，仅取=前面字串，与我们数据库对应。
                    string data = ss[int.Parse(comboBox_bankMoney.Text.ToString())] + "|" + Mon[0] + "|" + ss[8];
                    bankList.Add(data);
                }                
                if (dayData == "" || dayData == null)
                {
                    dayData = ss[1];//设置日期
                }
                i++;
            }
            return bankList;
        }

    }
}
