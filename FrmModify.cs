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
    public partial class FrmModify : Form
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
        public FrmModify()
        {
            InitializeComponent();
        }

        public FrmModify(string strSerialNumber, string strClassroomID, string strCourseName, string strTeacherID, string strClassDate, string strClassNum)
        {
            InitializeComponent();
            textBoxSerialNumber.Text = strSerialNumber;
            textBoxClassroomID.Text = strClassroomID;
            textBoxCourseName.Text = strCourseName;
            textBoxTeacherID.Text = strTeacherID;
            textBoxClassDate.Text = strClassDate;
            textBoxClassNumber.Text = strClassNum;
        }

        /// <summary>
        /// 取消按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 确认按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonConfirm_Click(object sender, EventArgs e)
        {
            /*
             传入四个输入框的的参数
             */
            string strSerialNumber = textBoxSerialNumber.Text;
            string strClassroomID = textBoxClassroomID.Text;
            string strCourseName = textBoxCourseName.Text;
            string strTeacherID = textBoxTeacherID.Text;
            string strClassDate = textBoxClassDate.Text;
            string strClassNum = textBoxClassNumber.Text;
            int intClassNumber = int.Parse(textBoxClassNumber.Text);

            if (strClassroomID.Length == 0 || strCourseName.Length == 0 || strTeacherID.Length == 0 || strClassDate.Length == 0 || strClassNum.Length == 0)
            {
                MessageBox.Show("不可以修改为空！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            else
            {
                bool blClassroomID = JudgeClassroomID(strClassroomID);
                bool blCourseName = JudgeCourseName(strCourseName);
                bool blTeacherID = JudgeTeacherID(strTeacherID);
                bool blClassDate = JudgeClassDate(strClassDate);
                bool blClassNumber = JudgeClassNumber(intClassNumber, strClassroomID);

                if (!blClassroomID)
                {
                    MessageBox.Show("该课室不存在，修改失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!blClassDate)
                {
                    MessageBox.Show("该时间不合法，修改失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!blCourseName)
                {
                    MessageBox.Show("该课程不存在，修改失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!blTeacherID)
                {
                    MessageBox.Show("该教师不存在，修改失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else if (!blClassNumber)
                {
                    MessageBox.Show("该上课人数大于该课室可容纳人数，修改失败！", "信息提醒", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }
                else
                {
                    string message = ModifyData(strClassroomID, strCourseName, strTeacherID, strClassDate, intClassNumber);
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


        /// <summary>
        /// 判断该上课日期是否合法
        /// </summary>
        /// <param name="strClassDate"></param>
        /// <returns></returns>

        private bool JudgeClassDate(string strClassDate)
        {
            DateTime dt = DateTime.ParseExact(strClassDate, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
            //拼接SQL语句
            string strSQL = "SELECT * FROM classroom WHERE classroomfreetimebegin < '" + dt + "' AND classroomfreetimeend >'" + dt + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，该时间处于起始和结束时间段内
            }

            return false;
        }

        /// <summary>
        /// 判断该课程名是否存在
        /// </summary>
        /// <param name="strClassName"></param>
        /// <returns></returns>
        private bool JudgeCourseName(string strCourseName)
        {
            //拼接SQL语句
            string strSQL = "SELECT * FROM course WHERE coursename = '" + strCourseName + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，可以插入
            }

            return false;
        }

        /// <summary>
        /// 判断该教师是否存在
        /// </summary>
        /// <param name="strTeacherID"></param>
        /// <returns></returns>
        private bool JudgeTeacherID(string strTeacherID)
        {
            //拼接SQL语句
            string strSQL = "SELECT * FROM teacher WHERE teacherid = '" + strTeacherID + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，可以插入
            }

            return false;
        }

        /// <summary>
        /// 判断上课人数是否合法
        /// </summary>
        /// <param name="strClassNumber"></param>
        /// <returns></returns>
        private bool JudgeClassNumber(int intClassNumber, string strClassroomID)
        {
            //int strSearch = int.Parse(textBoxClassNumber.Text);
            //拼接SQL语句
            string strSQL = "SELECT * FROM classroom WHERE classroomnum >= '" + intClassNumber + "' AND classroomid ='" + strClassroomID + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，该时间处于起始和结束时间段内
            }

            return false;
        }


        private string ModifyData(string strClassroomID, string strCourseName, string strTeacherID, string strClassDate, int intClassNumber)
        {
            int serialnumber = int.Parse(textBoxSerialNumber.Text);
            string strClassweek = BuildWeekday(strClassDate);
            string strSQL = @"UPDATE [dbo].[classroommanage]
                               SET [classroomid] = '" + strClassroomID + @"'
                                  ,[coursename] = '" + strCourseName + @"'
                                  ,[teacherid] = '" + strTeacherID + @"'
                                  ,[classdate] = '" + strClassDate + @"'
                                  ,[weekday] = '" + strClassweek + @"'
                                  ,[classnum] = '" + intClassNumber + @"'
                             WHERE [serialnumber] = '" + serialnumber + @"'";
                
                
                //"UPDATE [dbo].[class]
                //                       SET [classname] = '" + strClassName + @"'
                //                          ,[classdate] = '" + strClassDate + @"'
                //                          ,[teacherid] = '" + strTeacherID + @"'
                //                     WHERE [classroomid] = '" + strClassroomID + @"'";

            try
            {
                PublicVariable.row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());

            }

            return "修改成功！";
        }
        /// <summary>根据日期，获得星期几</summary>
        /// <param name="y">年</param>
        /// <param name="m">月</param>
        /// <param name="d">日</param>
        /// <returns>星期几，1代表星期一；7代表星期日</returns>
        private static int getWeekDay(int y, int m, int d)
        {
            if (m == 1) m = 13;
            if (m == 2) m = 14;
            int week = (d + 2 * m + 3 * (m + 1) / 5 + y + y / 4 - y / 100 + y / 400) % 7 + 1;
            return week;
        }
        /// <summary>
        /// 根据传进来的时间生成对应的星期
        /// </summary>
        /// <param name="strClassDate"></param>
        /// <returns></returns>
        private string BuildWeekday(string strClassDate)
        {
            DateTime dt = DateTime.ParseExact(strClassDate, "yyyyMMdd", System.Globalization.CultureInfo.CurrentCulture);
            int y = dt.Year;
            int m = dt.Month;
            int d = dt.Day;
            int week = getWeekDay(y, m, d);
            if (week == 1)
            {
                return "星期一";
            }
            else if (week == 2)
            {
                return "星期二";
            }
            else if (week == 3)
            {
                return "星期三";
            }
            else if (week == 4)
            {
                return "星期四";
            }
            else if (week == 5)
            {
                return "星期五";
            }
            else if (week == 6)
            {
                return "星期六";
            }
            else
            {
                return "星期天";
            }
        }
    }
}
