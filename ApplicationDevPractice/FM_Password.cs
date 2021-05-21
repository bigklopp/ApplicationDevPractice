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

namespace ApplicationDevPractice
{
    public partial class FM_Password : Form
    {
        SqlConnection Connect = null;
        SqlCommand cmd = new SqlCommand();
        SqlTransaction Tran;
        public FM_Password()
        {
            InitializeComponent();
        }


        private void btnPWreg_Click(object sender, EventArgs e)
        {
            string strCon = "DATA Source = 61.105.9.203; Initial Catalog = AppDev;" +
                    "User ID =kfqs; Password =1234;";
            Connect = new SqlConnection(strCon);

            Connect.Open();

            if (Connect.State != System.Data.ConnectionState.Open)
            {
                MessageBox.Show("데이터 베이스 연결에 실패하였습니다.");
                return;
            }

            string inputID = txtID.Text;
            string PrevPW = txtPrevPW.Text;
            string ChgPW = txtChgedPW.Text;

            SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW FROM TB_USER_LHC " +
                "WHERE UserID = '" + inputID + "'", Connect);

            DataTable DtTemp1 = new DataTable();
            try
            {
                Adapter.Fill(DtTemp1);

            }
            catch (Exception ex)
            {
                MessageBox.Show("예외 발생");

            }
            finally { Connect.Close(); }
            if (DtTemp1.Rows.Count == 0)
            {
                MessageBox.Show("없는 아이디입니다.");
                return;
            }
            else if (DtTemp1.Rows[0]["PW"].ToString() != txtPrevPW.Text)
            {
                MessageBox.Show("비밀번호가 틀렸습니다.");
                return;
            }
            else
            {
                if (MessageBox.Show("해당 비밀번호로 변경 하시겠습니까?", "비밀번호 변경",
                    MessageBoxButtons.YesNo) == DialogResult.No)
                { return; }
            }



        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
