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

namespace WindowsFormsApp1
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        public int num;//今日可抽次數
        int start = 1, length = 2;
        string select_picture;
        string[] picture_array = new string[5];
        string[] picture_arr = new string[1];
        int n = 0;  //紀錄抽牌次數
        string[] picture_78 = new string[78];
        PictureBox pic = new PictureBox();
        PictureBox pic1 = new PictureBox();
        PictureBox pic2 = new PictureBox();
        PictureBox pic3 = new PictureBox();
        PictureBox pic4 = new PictureBox();
        string newPath = "./diary/result/ " + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
        Button bt = new Button();
        string[,] dataArray;
        int number_of_words;
        AVLTree av1;

        

        private void pictureBox78_MouseUp(object sender, MouseEventArgs e)
        {
            string sTxt = "";
            if (File.Exists(newPath))
            {
                StreamReader sr = new StreamReader(newPath);
                sTxt = sr.ReadToEnd();
                sr.Dispose();
                
            }
            if (sTxt.Contains(comboBox1.Text))
                MessageBox.Show("抽過此類型了！不能再抽了！", "抽卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (comboBox2.Text == "牌陣一張牌")
                {
                    if (button9.Image == null)
                    {
                        if (e.Button == MouseButtons.Left)
                        {
                            if (n == 0) pic = (PictureBox)sender;

                            ((PictureBox)sender).Visible = false;

                            select_picture = ((PictureBox)sender).Name.Substring(10);
                            picture_arr[n] = picture_78[int.Parse(select_picture) - 1];

                            Bitmap bmPic;
                            bmPic = new Bitmap("000.jpg");
                            if (n == 0) button9.Image = bmPic;
                            n = n + 1;
                            if (n >= 1) MessageBox.Show("可以翻牌囉！");
                        }
                    }
                    else
                        MessageBox.Show("要重新開始才能再選喔！", "抽卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        int numTmp;
        string allTmp = "";
        private void Form4_Load(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader(path);
            allTmp += sr.ReadToEnd();
            allTmp = allTmp.Remove(0, 10);
            sr.Dispose();
            numTmp = num;
            label6.Text = "今日可抽次數：" + num;
            label3.Visible = false;
            label4.Visible = false;
            label5.Visible = false;
            button10.Visible = false;
            Random rand = new Random(Guid.NewGuid().GetHashCode());

            List<int> listLinq = new List<int>(Enumerable.Range(0, 78));
            listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

            for (int j = 0; j < 78; j++)
            {
                picture_78[j] = listLinq[j].ToString() + ".jpg";
            }
        }
        public string path;
        
        
        private void button1_Click_1(object sender, EventArgs e)
        {
            string sTxt = "";
            if (File.Exists(newPath))
            {
                StreamReader sr = new StreamReader(newPath);
                sTxt = sr.ReadToEnd();
                sr.Dispose();
                
            }
            if (sTxt.Contains(comboBox1.Text))
                MessageBox.Show("抽過此類型了！不能再抽了！", "抽卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            else
            {
                if (comboBox2.Text == "牌陣一張牌")
                {
                    if (num > 0)
                    {
                        button9.Visible = true;
                        button9.Image = null;
                        label3.Visible = false;
                        label4.Visible = false;
                        label5.Visible = false;
                        num -= 1;
                        label6.Text = "今日可抽次數：" + num;
                        button10.Visible = false;

                        pic.Visible = true;
                        pic1.Visible = true;
                        pic2.Visible = true;
                        pic3.Visible = true;
                        pic4.Visible = true;

                        n = 0;
                        Random rand = new Random(Guid.NewGuid().GetHashCode());

                        List<int> listLinq = new List<int>(Enumerable.Range(0, 78));
                        listLinq = listLinq.OrderBy(num => rand.Next()).ToList<int>();

                        for (int j = 0; j < 78; j++)
                        {
                            picture_78[j] = listLinq[j].ToString() + ".jpg";
                        }
                    }
                    else
                        MessageBox.Show("次數已滿，無法再抽了！", "無法抽卡", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                    MessageBox.Show("請先選擇想要抽卡的項目！", "無法抽卡", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                
        }

        

        private void button8_Click_1(object sender, EventArgs e)
        {
            
            if (comboBox2.Text == "牌陣一張牌")
            {
                Bitmap bmPic;
                bmPic = new Bitmap(picture_arr[0]);
                button9.Image = bmPic;
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (comboBox2.Text == "牌陣一張牌")
            {
                Bitmap bmPic;
                bmPic = new Bitmap(picture_arr[0]);
                button9.Image = bmPic;
                button10.Visible = true;
            }
        }

        private void button10_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.Text != null && comboBox2.Text == "牌陣一張牌")
            {
                display(comboBox1.Text);
            }
        }

        private void Form4_FormClosed(object sender, FormClosedEventArgs e)
        {
            string all = "塔羅牌未抽卡次數：" + num + allTmp;
            StreamWriter sw = new StreamWriter(path);
            sw.Write(all);
            sw.Dispose();
        }

        public void display(string s)
        {
            label3.Visible = true;
            label4.Visible = true;
            label5.Visible = true;
            av1 = new AVLTree();
            StreamReader sr1 = new StreamReader(s + "-1.txt", Encoding.UTF8); //利用StreamReader來讀取文字內容
            string data = File.ReadAllText(s + "-1.txt", Encoding.UTF8); //一次讀完
            data = data.Replace("\"", ""); //把中間本來有上引號 "" 的部分都去除
            string[] dataLines = data.Split('\n'); //每一行就是一個解釋，所以先用"\n"來切割成字串陣列
            number_of_words = dataLines.Length; // 此時就可以知道大概有幾個解釋

            dataArray = new string[dataLines.Length, 2]; //宣告陣列的大小
            for (int i = 0; i < dataLines.Length; i++) //對每一行都做讀取
            {
                string[] vars = dataLines[i].Split('\t'); //每一行會有二個欄位，用tab分隔，因此用"\t"來切割成字串陣列
                for (int j = 0; j < vars.Length; j++)
                    dataArray[i, j] = vars[j];
                
                AVLTree tree = new AVLTree();

                tree.root = tree.insert(tree.root, vars[1].ToLower().GetHashCode());
            }
            for (int i = 0; i < number_of_words; i++) //每一行有二筆文字內容
            {
                string[] Num = picture_arr[0].Split('.');
                if (int.Parse(dataArray[i, 0].Substring(start - 1, length)) == int.Parse(Num[0]))
                {
                    string[] stmp = new string[2];
                    for (int t = 0; t < 78; t++)
                        if (int.Parse(Num[0]) == t)
                        {
                            var watch = System.Diagnostics.Stopwatch.StartNew();
                            AVLTree tree = new AVLTree();
                            tree.preOrder(tree.root);//查詢
                            watch.Stop();
                            label3.Text = dataArray[i, 0];
                            string tmp = dataArray[i, 1];
                            string elapsedTicks = watch.ElapsedTicks.ToString();
                            //顯示行控制
                            //參考
                            
                            int maxNum = 30;
                            
                            //本身就已將AutoSize設為False
                            
                            label4.Text = "";
                            for (int k = 0; k <= tmp.Length; k += maxNum)
                            {
                                try
                                {
                                    label4.Text += tmp.Substring(k, maxNum) + "\n";
                                }
                                catch
                                {
                                    label4.Text += tmp.Substring(k, tmp.Length % maxNum);
                                }

                            }
                            //儲存解牌結果到TXT
                            string sTxt;
                            
                            if (File.Exists(newPath))
                            {
                                StreamReader sr = new StreamReader(newPath);
                                sTxt = sr.ReadToEnd() + "\n" + comboBox1.Text + "\n解牌結果：\n" 
                                    + dataArray[i, 0] + "\n" + dataArray[i, 1] + "\n";
                                sr.Dispose();
                            }
                            else
                                sTxt = comboBox1.Text + "\n解牌結果：\n" + dataArray[i, 0] + "\n" + dataArray[i, 1] + "\n";
                            StreamWriter sw = new StreamWriter(newPath);
                            sw.Write(sTxt);
                            sw.Dispose();
                            break;
                        }
                }
            }
        }
    }
}
