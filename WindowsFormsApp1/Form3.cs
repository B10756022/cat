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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        int num = 0;
        private void Form3_Load(object sender, EventArgs e)
        {
            label1.Text = "現在時間：" + DateTime.Now.ToString("yyyy/MM/dd　ddd　tthh:mm");
            timer1.Interval = 1000; //每秒
            timer1.Enabled = true;
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //參考自https://ithelp.ithome.com.tw/questions/10190675
            int time = 60;

            if ((DateTime.Now.Second) % time == 0)
            {
                label1.Text = "現在時間：" + DateTime.Now.ToString("yyyy/MM/dd　ddd　tthh:mm");
                timer1.Interval = 1000 * 60; //每分鐘
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            timer1.Enabled = false;
            int n = 0;
            string path = "./diary/" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
            if (num >= 100)
                n = 1;
            if (num >= 500)
                n = 2;
            DialogResult saveYN =
            MessageBox.Show(label3.Text + ",可抽卡" + n + "次！\n是否進行儲存？","儲存提醒", MessageBoxButtons.YesNo);
            if (saveYN == DialogResult.Yes)
            {
                if (File.Exists(path))
                {
                    int count = 0;
                    string sTxt = "";
                    string newPath = "./diary/result/" + DateTime.Now.ToString("yyyy_MM_dd") + ".txt";
                    DialogResult dresult =
                    MessageBox.Show("今天已經寫過日記了，是否要覆蓋？", "今天已寫過日記", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if(dresult == DialogResult.Yes)
                        if(File.Exists(newPath))
                        {
                            StreamReader sr = new StreamReader(newPath);
                            sTxt = sr.ReadToEnd();
                            sr.Dispose();
                            if (sTxt.Contains("愛情"))
                                count++;
                            if (sTxt.Contains("友情"))
                                count++;
                            if (sTxt.Contains("事業"))
                                count++;
                            if (sTxt.Contains("學業"))
                                count++;
                            if (n - count == 0)
                                MessageBox.Show("今天已經抽完卡了，不能再抽了喔！");
                            else
                                n = n - count;
                            string s = richTextBox1.Text.Remove(0, 10);
                            //開始抽卡
                            MessageBox.Show("可抽卡次數剩" + n + "次！", "抽卡提醒");
                            save(path, "塔羅牌未抽卡次數：" + n + s);
                            drawCardYN(path);
                        }
                }
                else
                {
                    //開始抽卡
                    save(path, "塔羅牌未抽卡次數：" + n + "\n" + richTextBox1.Text);
                    drawCardYN(path);
                }
                    
                
            }      
        }

        public void save(string path, string s)
        {
            StreamWriter sw = new StreamWriter(path);
            sw.Write(s);
            sw.Dispose();
        }

        public void drawCardYN(string path)
        {
            int n = 0;
            StreamReader sr = new StreamReader(path);
            string tmp = sr.ReadLine();
            
            n = int.Parse(tmp.Remove(0, 9));

            DialogResult dr =
                MessageBox.Show("要現在就開始抽卡嗎？", "抽卡提醒", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                if (n != 0)
                {
                    Form4 f4 = new Form4();
                    f4.num = n;
                    f4.path = path;
                    f4.FormClosed += new FormClosedEventHandler(From4_FormClosed);
                    f4.Show();
                    this.Hide();
                }
                else
                    MessageBox.Show("抽卡次數為0，不能抽卡！", "抽卡失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            sr.Dispose();
        }
        private void From4_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Show();
        }


        string pathTmp;
        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
            num = richTextBox1.TextLength;
            label3.Text = "目前字數：" + num + "字";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            select = null;
                pathTmp = "./diary/";
                //參考https://lifewth.com/c-get-infloder-dataname/
                listBox1.Items.Clear();
                foreach (string fname in System.IO.Directory.GetFileSystemEntries(pathTmp, "*.txt"))
                {
                    /* fname 即為獲得的檔案名稱 */
                    string tmp = Path.GetFileNameWithoutExtension(fname);
                    listBox1.Items.Add(tmp);
                }
                if (listBox1.Items.Count == 0)
                    MessageBox.Show("目前無資料，請再確認一次！", "紀錄為空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                richTextBox1.Enabled = false;
                button5.Enabled = true;
                listBox1.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = true;
            
            
        }
        string select = "";
        int i = 0;
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem != null)
            {
                select = listBox1.SelectedItem.ToString();
                string selectPath = pathTmp + select + ".txt";
                button4.Enabled = true;
                StreamReader sr = new StreamReader(selectPath);
                richTextBox1.Text = sr.ReadToEnd();
                sr.Close();
                i = listBox1.SelectedIndex;

            }
            else if (listBox1.Items.Count == 0)
                richTextBox1.Text = "";
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult dr=
            MessageBox.Show("是否清空並重新開始寫今天日記？", "刪除內容", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
                richTextBox1.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (select != "")
                {
                    DialogResult dr =
                    MessageBox.Show("已選中" + select + "，是否要進行刪除？刪除後無法復原", "刪除", MessageBoxButtons.YesNo);
                    string selectPath = "./diary/" + select + ".txt";
                    if (dr == DialogResult.Yes)
                    {
                        File.Delete(selectPath);
                        listBox1.Items.RemoveAt(i);
                    }
                }
            }
            catch
            {
                MessageBox.Show("還沒選中資料，不能刪除喔！", "刪除失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if (select == DateTime.Now.ToString("yyyy_MM_dd"))
                {
                    string path = "./diary/" + select + ".txt";
                    drawCardYN(path);
                }
                else
                    MessageBox.Show("不是今天不能補抽喔！", "補抽失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch
            {
                MessageBox.Show("還沒選中資料，不能補抽喔！", "補抽失敗", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
                

        }

        private void button6_Click(object sender, EventArgs e)
        {
            select = null;
            richTextBox1.Enabled = false;
                pathTmp = "./diary/result/";
                button5.Enabled = false;
                button4.Enabled = false;
                listBox1.Items.Clear();
                foreach (string fname in System.IO.Directory.GetFileSystemEntries(pathTmp, "*.txt"))
                {
                    /* fname 即為獲得的檔案名稱 */
                    string tmp = Path.GetFileNameWithoutExtension(fname);
                    listBox1.Items.Add(tmp);
                }
                if (listBox1.Items.Count == 0)
                    MessageBox.Show("目前無資料，請再確認一次！", "紀錄為空", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                listBox1.Enabled = true;
                button1.Enabled = false;
                button3.Enabled = false;
                button7.Enabled = true;
                
        }

        private void button7_Click(object sender, EventArgs e)
        {
            button2.Text = "紀錄顯示";
            richTextBox1.Enabled = true;

            if (richTextBox1.Text != "")
            {
                DialogResult dr =
            MessageBox.Show("是否清空並重新開始寫今天日記？", "刪除內容", MessageBoxButtons.YesNo);
                if (dr == DialogResult.Yes)
                    richTextBox1.Text = "";

            }
            listBox1.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button1.Enabled = true;
            button3.Enabled = true;
            listBox1.Items.Clear();
            button7.Enabled = false;
        }
    }
}
