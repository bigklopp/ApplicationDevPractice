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
    public partial class FM_Login : Form
    {
        SqlConnection Connect = null;
        

        int WrongPWCount = 0;
        public FM_Login()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                string strCon = "DATA Source =  61.105.9.203; Initial Catalog = AppDev;" +
                    "User ID =kfqs; Password = 1234;";
                Connect = new SqlConnection(strCon);

                Connect.Open();

                if (Connect.State != ConnectionState.Open)
                {
                    MessageBox.Show("연결이 되지 않습니다.");
                    return;
                }
                string inputID = txtID.Text;
                string inputPW = txtPW.Text;

                SqlDataAdapter Adapter = new SqlDataAdapter("SELECT PW, UserName FROM TB_USER_LHC" +
                    " WHERE UserID ='" + inputID + "'", Connect);
                DataTable DtTemp = new DataTable();

                Adapter.Fill(DtTemp);

                if (DtTemp.Rows.Count == 0)
                {
                    MessageBox.Show("아이디가 없습니다.");
                    return;
                }
                else if (DtTemp.Rows[0]["PW"].ToString() != inputPW)
                {
                    WrongPWCount++;

                    MessageBox.Show($"비밀번호가 다릅니다. 3회 이상 틀리면 종료합니다. 누적 {WrongPWCount} 회");
                    if (WrongPWCount >= 3)
                    {
                        MessageBox.Show("비밀번호를 3회 이상 틀렸습니다. 종료합니다.");
                        this.Close();
                    }
                    return;
                }
                else
                {
                    MessageBox.Show("환영합니다!");
                    this.Tag = DtTemp.Rows[0]["UserName"].ToString();
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"예외 발생 로그인 작업 중 오류 : {ex}");

            }
            finally
            {
                Connect.Close();
            }
        }

        private void btnPWChg_Click(object sender, EventArgs e)
        {
            FM_Password PWChg = new FM_Password();
            PWChg.ShowDialog();
        }
    }
}
