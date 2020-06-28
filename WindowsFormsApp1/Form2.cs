using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Globalization;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        string sqlConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|321.mdf;Integrated Security=True;Connect Timeout=30";

        private void Form2_Load(object sender, EventArgs e)
        {

            DateComboBoxRenew();
        }
        //更新日期
        private void DateComboBoxRenew()
        {
            searchDateCmb.Items.Clear();
            modifyCmb.Items.Clear();
            deleteCmb.Items.Clear();
            using (SqlConnection cn = new SqlConnection(sqlConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("SELECT DISTINCT 日期 FROM 記簿", cn);
                SqlDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    searchDateCmb.Items.Add(Convert.ToDateTime(dr[0]));
                    modifyCmb.Items.Add(Convert.ToDateTime(dr[0]));
                    deleteCmb.Items.Add(Convert.ToDateTime(dr[0]));
                }
            }

        }

        //查詢
        private void searchBtn_Click(object sender, EventArgs e)
        {
            dataSearch();
        }

        //資料查詢
        private void dataSearch()
        {
            using (SqlConnection cn = new SqlConnection(sqlConnectionString))
            {
                cn.Open();
                SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM 記簿 WHERE 日期 = '"+searchDateCmb.Text+"'", cn);
                DataSet ds = new DataSet();
                sda.Fill(ds, "當日帳目");
                searchDataGridView.DataSource = ds.Tables["當日帳目"];
                
            }
        }

        //"新增"按確定後
        private void insertBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(sqlConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("INSERT INTO 記簿(日期,收入,支出,備註) VALUES(@date,@income,@expense,@description)",cn);
                cmd.Parameters.Add(new SqlParameter("@date", SqlDbType.Date));
                cmd.Parameters.Add(new SqlParameter("@income", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@expense", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar));
                cmd.Parameters["@date"].Value = insertDate.Text;
                if (insertIncome.Text.CompareTo("") == 0)
                {
                    insertIncome.Text = "0";
                }
                cmd.Parameters["@income"].Value = insertIncome.Text;
                if (insertExpense.Text.CompareTo("") == 0)
                {
                    insertExpense.Text = "0";
                }
                cmd.Parameters["@expense"].Value = insertExpense.Text;
                cmd.Parameters["@description"].Value = insertDescription.Text;
                cmd.ExecuteNonQuery();
            }
            MessageBox.Show("新增項目成功!");
            insertDate.Value = DateTime.Now;
            insertIncome.Text = "0";
            insertExpense.Text = "0";
            insertDescription.Text = "";
            DateComboBoxRenew();
        }


        //"修改"的選擇日期找資料庫的流水號
        private void modifyCmb_TextChanged(object sender, EventArgs e)
        {
            modifyIdCmb.Items.Clear();
            modifyIdCmb.Text = "";
            modifyIncome.Text = "";
            modifyExpense.Text = "";
            modifyDescription.Text = "";
            if (modifyCmb.Text.CompareTo("") != 0)
            {
                using (SqlConnection cn = new SqlConnection(sqlConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT 流水號 FROM 記簿 WHERE 日期 = '" + modifyCmb.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        modifyIdCmb.Items.Add(dr[0]);
                    }

                }
            }
        }

        //"修改"畫面裡的流水號搜尋
        private void modifyDateSearchBtn_Click(object sender, EventArgs e)
        {
            if (modifyIdCmb.Text.CompareTo("")!=0)
            {
                using (SqlConnection cn = new SqlConnection(sqlConnectionString))
                {
                    cn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM 記簿 WHERE 流水號 = '" + modifyIdCmb.Text + "'", cn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "流水號資訊");
                    DataTable dt = new DataTable();
                    dt = ds.Tables["流水號資訊"];
                    modifyIncome.Text = dt.Rows[0]["收入"].ToString();
                    modifyExpense.Text = dt.Rows[0]["支出"].ToString();
                    modifyDescription.Text = dt.Rows[0]["備註"].ToString();

                }
            }
            else
            {
                MessageBox.Show("您尚未選流水帳");
            }
            
        }

        //"修改"按確定後
        private void modifyBtn_Click(object sender, EventArgs e)  
        {
            using (SqlConnection cn = new SqlConnection(sqlConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("UPDATE 記簿 SET 收入=@income ,支出=@expense ,備註=@description WHERE 流水號= '" + modifyIdCmb.Text + "'", cn);
                cmd.Parameters.Add(new SqlParameter("@income", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@expense", SqlDbType.Int));
                cmd.Parameters.Add(new SqlParameter("@description", SqlDbType.NVarChar));
                if (modifyIncome.Text.CompareTo("") == 0)
                {
                    modifyIncome.Text = "0";
                }
                cmd.Parameters["@income"].Value = modifyIncome.Text;
                if (modifyExpense.Text.CompareTo("") == 0)
                {
                    modifyExpense.Text = "0";
                }
                cmd.Parameters["@expense"].Value = modifyExpense.Text;
                cmd.Parameters["@description"].Value = modifyDescription.Text;
                cmd.ExecuteNonQuery();

            }
            MessageBox.Show("修改項目成功!");

            modifyCmb.Text = "";
            modifyIdCmb.Text = "";
            modifyIncome.Text = "0";
            modifyExpense.Text = "0";
            modifyDescription.Text = "";
            DateComboBoxRenew();
        }

        //"刪除"畫面裡的流水號查詢
        private void deleteDateSearchBtn_Click(object sender, EventArgs e)
        {
            if (deleteIdCmb.Text.CompareTo("") != 0)
            {
                using (SqlConnection cn = new SqlConnection(sqlConnectionString))
                {
                    cn.Open();
                    SqlDataAdapter sda = new SqlDataAdapter("SELECT * FROM 記簿 WHERE 流水號 = '" + deleteIdCmb.Text + "'", cn);
                    DataSet ds = new DataSet();
                    sda.Fill(ds, "流水號資訊");
                    DataTable dt = new DataTable();
                    dt = ds.Tables["流水號資訊"];
                    deleteIncome.Text = dt.Rows[0]["收入"].ToString();
                    deleteExpense.Text = dt.Rows[0]["支出"].ToString();
                    deleteDescription.Text = dt.Rows[0]["備註"].ToString();

                }
            }
            else
            {
                MessageBox.Show("您尚未選流水帳");
            }
        }
        //"刪除"的選擇日期找資料庫的流水號
        private void deleteCmb_TextChanged(object sender, EventArgs e)
        {
            deleteIdCmb.Items.Clear();
            deleteIdCmb.Text = "";
            deleteIncome.Text = "";
            deleteExpense.Text = "";
            deleteDescription.Text = "";
            if (deleteCmb.Text.CompareTo("") != 0)
            {
                using (SqlConnection cn = new SqlConnection(sqlConnectionString))
                {
                    cn.Open();
                    SqlCommand cmd = new SqlCommand("SELECT 流水號 FROM 記簿 WHERE 日期 = '" + deleteCmb.Text + "'", cn);
                    SqlDataReader dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        deleteIdCmb.Items.Add(dr[0]);
                    }

                }
            }

        }
        //按下刪除後
        private void deleteBtn_Click(object sender, EventArgs e)
        {
            using (SqlConnection cn = new SqlConnection(sqlConnectionString))
            {
                cn.Open();
                SqlCommand cmd = new SqlCommand("DELETE FROM 記簿 WHERE 流水號= '" + deleteIdCmb.Text + "'", cn);
                cmd.Connection = cn;  //設定連接屬性
                cmd.ExecuteNonQuery(); //執行sql語法
                cn.Close(); //關閉資料庫連線

            }
            MessageBox.Show("刪除項目成功!");
        }

        //切換畫面
        private void searchRdb_CheckedChanged(object sender, EventArgs e)
        {
            searchPanel.BringToFront();
        }
        private void insertRdb_CheckedChanged(object sender, EventArgs e)
        {
            insertPanel.BringToFront();
        }
        private void modifyRdb_CheckedChanged(object sender, EventArgs e)
        {
            modifypanel.BringToFront();
        }

        private void delRdb_CheckedChanged(object sender, EventArgs e)
        {
            deletePanel.BringToFront();
        }

        
    }
}
