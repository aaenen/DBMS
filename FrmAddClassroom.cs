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
    
    public partial class FrmAddClassroom : Form
    {
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
        public FrmAddClassroom()
        {
            InitializeComponent();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*
             传入六个输入框的的参数
             */
            string strClassroomID = textBoxClassroomID.Text;
            string strClassroomType = textBoxClassroomType.Text;
            string strClassroomNum = textBoxClassroomNum.Text;
            string strFreetimeBegin = textBoxFreetimeBegin.Text;
            string strFreetimeEnd = textBoxFreetimeEnd.Text;
            string strClassroomEquipment = textBoxClassroomEquipment.Text;

            if (strClassroomID.Length == 0 || strClassroomType.Length == 0 || strClassroomNum.Length == 0 || strFreetimeBegin.Length == 0 || strFreetimeEnd.Length == 0 || strClassroomEquipment.Length == 0)
            {
                MessageBox.Show("请按要求完整填写信息！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool blClassroomID = JudgeClassroomID(strClassroomID);
                DateTime dtFreetimeBegin = DateTime.ParseExact(strFreetimeBegin, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                DateTime dtFreetimeEnd = DateTime.ParseExact(strFreetimeEnd, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);

                if (blClassroomID)
                {
                    MessageBox.Show("该教室已存在，添加失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (dtFreetimeBegin > dtFreetimeEnd)
                {
                    MessageBox.Show("空闲开始时间大于空闲结束时间，添加失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {

                    int intClassroomNum = int.Parse(textBoxClassroomNum.Text);
                    string message = InsertData(strClassroomID, strClassroomType, intClassroomNum, strFreetimeBegin, strFreetimeEnd, strClassroomEquipment);
                    PublicVariable.row_count = 0;
                    MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();   //关闭本窗口
                }
            }

        }
        /// <summary>
        /// 判断该教室是否存在
        /// </summary>
        /// <param name="strClassroomID"></param>
        /// <returns></returns>
        private bool JudgeClassroomID(string strClassroomID)
        {
            //拼接SQL语句
            string strSQL = "SELECT * FROM classroom WHERE classroomid = '" + strClassroomID + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，该教室存在
            }

            return false;
        }

        private string InsertData(string strClassroomID, string strClassroomType, int intClassroomNum, string strFreetimeBegin, string strFreetimeEnd, string strClassroomEquipment)
        {
            string strSQL = @"INSERT INTO [dbo].[classroom]
                                       ([classroomid]
                                       ,[classroomtype]
                                       ,[classroomnum]
                                       ,[classroomfreetimebegin]
                                       ,[classroomfreetimeend]
                                       ,[classroomequipment])
                                 VALUES
                                       ('" + strClassroomID + @"'
                                       ,'" + strClassroomType + @"'
                                       ,'" + intClassroomNum + @"'
                                       ,'" + strFreetimeBegin + @"'
                                       ,'" + strFreetimeEnd + @"'
                                       ,'" + strClassroomEquipment + @"')";
            try
            {
                PublicVariable.row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return "插入成功！";
        }
    }
}
