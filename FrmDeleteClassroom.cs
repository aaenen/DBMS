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

namespace 教室信息管理系统
{
    
    public partial class FrmDeleteClassroom : Form
    {

        string strClassroomID;


        /// <summary>
        /// 向SQL Server 提交SQL语句。
        /// </summary>
        /// <param name="sqlString">SQL语句</param>
        /// <returns></returns>
        private DataTable SQL_Oparation(string sqlString)
        {
            DataTable dT1 = new DataTable();
            try
            {
                //设置连接字符串
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = @"AAENEN";
                builder.InitialCatalog = "ClassroomManage";
                builder.IntegratedSecurity = true;
                SqlConnection sqlConnection = new SqlConnection(builder.ConnectionString);
                SqlCommand sqlCom = new SqlCommand(sqlString, sqlConnection);

                SqlDataAdapter sqlDataAdapter = new SqlDataAdapter(sqlCom);
                sqlDataAdapter.Fill(dT1);

                return dT1;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
                return dT1;
            }
        }
        public FrmDeleteClassroom()
        {
            InitializeComponent();
        }
        public FrmDeleteClassroom(string strClassroomID)
        {
            InitializeComponent();
            this.strClassroomID = strClassroomID;
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            string message = DeleteData(strClassroomID);
            PublicVariable.row_count = 0;
            MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();   //关闭本窗口
        }

        private string DeleteData(string strClassroomID)
        {
            string strSQL = @"DELETE FROM [dbo].[classroom]
                                    WHERE [classroomid] = '" + strClassroomID + "' ";

            try
            {
                PublicVariable.row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return "删除成功！";
        }
    }
}
