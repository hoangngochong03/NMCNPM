using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace NMCNPM
{
    public partial class FormSua : Form
    {
        static MySqlConnection conn;
        MySqlCommand cmd;
        MySqlDataAdapter adapter;
        string sql;
        int Result;
        public FormSua()
        {
            InitializeComponent();
            Connection();
        }

        static void Connection()
        {
            
            try
            {
                conn = new MySqlConnection(connectionString: @"server=127.0.0.1;userid=root;password=;database=nmcnpm");
                conn.Open();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally { conn.Close(); }

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            sql = "Insert into 'boardgame' ( 'MASP','TENSP','GIA','THELOAI','SOLUONG','MOTA' ) values " + "('" + maSanPham + "' , '" 
                + tenSanPham + "' , '" + giaSanPham + "' , '" + theLoaiSanPham + "','" + soLuongSanPham + "' , '" + moTaSanPham + "' )";
            ChangeBoardGame(sql, "Unable to change Board game", "Change Board game succesfully");
        }

        private void ChangeBoardGame(string sql, string msg_false, string msg_true)
        {
            cmd = new MySqlCommand();
            cmd.Connection = conn;
            cmd.CommandText = sql;
            //Result = cmd.ExecuteNonQuery();
             // Sua doi thong tin san pham'
            
            if (MessageBox.Show("Sửa sản phẩm Board Game này ?","Thông báo ",
                MessageBoxButtons.OKCancel) == System.Windows.Forms.DialogResult.OK)
            {
                string masp = maSanPham.Text;
                string tensp = tenSanPham.Text;
                string gia = giaSanPham.Text;
                string TL = theLoaiSanPham.Text;
                string SoLuong = soLuongSanPham.Text;
                string mt = moTaSanPham.Text;
                conn.Open();
                //MySqlCommand sqlCommand = new MySqlCommand("Insert into 'boardgame' ( 'MASP' , 'TENSP') values " + "('" + masp + "' ," + tensp + "')", conn);
                // sqlCommand.ExecuteNonQuery();
                notifyChangeSuccess();
                conn.Close();
               //if (Result > 0)
                //{
                  //  MessageBox.Show(msg_true);
                //}
            }
            else
            {
                MessageBox.Show("Huy Thanh Cong");
            }
        }

        private void notifyChangeSuccess()
        {
            MessageBox.Show("Sua Broard Game thanh cong");
            maSanPham.Text = "";
            tenSanPham.Text = "";
            giaSanPham.Text = "";
            theLoaiSanPham.Text = "";
            soLuongSanPham.Text = "";
            moTaSanPham.Text = "";
        }
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
