using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BAL;
using DevExpress.XtraEditors;
using DevExpress.XtraPrinting.Native;

namespace ZCF
{
    public partial class FrmLogin : DevExpress.XtraEditors.XtraForm
    {
        public int id;
        public FrmLogin()
        {
            InitializeComponent();
        }
        private void textTaiKhoan_Click(object sender, EventArgs e)
        {
            textTaiKhoan.SelectAll();
        }

        private void txtPassword_Click(object sender, EventArgs e)
        {
            txtPassword.Text = "";
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!textTaiKhoan.Text.IsEmpty() && !txtPassword.Text.IsEmpty())
            {
                // ---- Gọi phương thức đăng nhập
                id = NguoiDung.Login(textTaiKhoan.Text.Trim(), txtPassword.Text.Trim());
                if (id != 0)
                {
                    Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản đăng nhập không tồn tại! Vui long nhập lại!");
                    textTaiKhoan.Focus();
                }
            }
        }

        private void btnHuyBo_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)
                btnDangNhap_Click(null,null);
        }
    }
}