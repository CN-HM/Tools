using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GWI对账程序
{
    public class Data
    { 

        public static ArrayList dataOne;
        public static ArrayList dataTwo;
        public static string nullString = "000|000|000|000|000";//为空时的数据

        /// <summary>
        /// 存储两个数组返回给前台
        /// </summary>
        /// <param name="one"></param>
        /// <param name="two"></param>
        public static void SavaDataArrayList(ArrayList one, ArrayList two)
        {
            dataOne = one;
            dataTwo = two;
        }

        /// <summary>
        /// 计算总金额差值  并进行二次筛选
        /// </summary>
        /// <param name="List_i"></param>
        /// <param name="List_j"></param>
        /// <returns></returns>
        public static ArrayList WorkForDataAgain(ArrayList List_i, ArrayList List_j)
        {
            ArrayList iList = new ArrayList();
            for (int i = 0; i < List_i.Count; i++)
            {
                for (int j = 0; j < List_j.Count; j++)
                {

                    double j_1 = double.Parse(List_j[j].ToString().Split('|')[0]);
                    j_1 = Math.Round(j_1, MidpointRounding.AwayFromZero);
                    double i_2 = double.Parse(List_i[i].ToString().Split('|')[0]);
                    i_2 = Math.Round(i_2, MidpointRounding.AwayFromZero);
                    if (j_1 == i_2)
                    {
                        List_i[i] = nullString;//
                        List_j[j] = nullString;//
                        if (i != List_i.Count - 1)
                        {
                            break;
                        }
                    }
                    else if (j_1 != i_2 && i == List_i.Count - 1)
                    {
                        if (List_j[j] != nullString)
                        {
                            iList.Add(List_j[j]);
                        }
                    }
                }
            }
            return iList;
        }

        /// <summary>
        /// 数据一次处理，两个数组的金额与银行卡号匹配不一致就筛选出来
        /// </summary>
        /// <param name="data1_List"></param>
        /// <param name="data2_List"></param>
        public static void WorkForData(ArrayList data1_List, ArrayList data2_List)
        {
            for (int i = 0; i < data1_List.Count; i++)
            {
                string[] Biger_arr = data1_List[i].ToString().Split('|');
                for (int j = 0; j < data2_List.Count; j++)
                {
                    string[] Smart_arr = data2_List[j].ToString().Split('|');
                    bool ii = (Biger_arr[1] == Smart_arr[1] || Biger_arr[1] == "" || Smart_arr[1] == "");
                    if (Math.Round(double.Parse(Smart_arr[0])) == Math.Round(double.Parse(Biger_arr[0])) && Biger_arr[1] == Smart_arr[1])
                    {
                        data1_List[i] = nullString;
                        data2_List[j] = nullString;
                        break;
                    }
                }
            }
            Data.SavaDataArrayList(data1_List, data2_List);//同时存储两个数据
        }

        /// <summary>
        /// clear
        /// </summary>
        public static void ClearDataArrayList()
        {
            dataOne.Clear();
            dataTwo.Clear();
        }

        /// <summary>
        /// 计算总金额
        /// </summary>
        /// <param name="List"></param>
        /// <returns></returns>
        public static double MathAllNumble(ArrayList List)
        {
            double sumNumble = 0;
            foreach (var iList in List)
            {
                sumNumble += double.Parse(iList.ToString().Split('|')[0]);
            }
            return sumNumble;
        }

        /// <summary>
        /// 删除多余的数据
        /// </summary>
        /// <param name="one_List"></param>
        /// <returns></returns>
        public static ArrayList DeleteUnuserfullData(ArrayList one_List)
        {
            ArrayList One_List_New = new ArrayList();
            for (int i = 0; i < one_List.Count; i++)
            {
                if (one_List[i].ToString() != nullString)
                {
                    One_List_New.Add(one_List[i]);
                }
            }
            return One_List_New;
        }

        /// <summary>
        /// 输出为Txt文件
        /// </summary>
        /// <param name="path"></param>
        /// <param name="List"></param>
        public static void TxtWrite(string path, ArrayList List)
        {
            //"E:\\ak.txt"
            FileStream fs = new FileStream(path, FileMode.Create);
            StreamWriter sw = new StreamWriter(fs);
            //开始写入
            for (int i = 0; i < List.Count; i++)
            {
                sw.Write(List[i]);
                sw.WriteLine(Environment.NewLine);//换行
            }
            //清空缓冲区
            sw.Flush();
            //关闭流
            sw.Close();
            fs.Close();
        }
    }
}
