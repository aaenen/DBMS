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
using static 教室信息管理系统.PublicVariable;

namespace 教室信息管理系统
{
    public partial class FrmMain : Form
    {
        /// <summary>
        /// SQL连接语句
        /// </summary>
        /// <param name="sqlString"></param>
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
        public FrmMain()
        {
            InitializeComponent();
        }

        public FrmMain(PublicVariable.Ring ring, string user_id,string user_UID)
        {
            InitializeComponent();
            Authority(ring, user_id, user_UID);
        }

        /// <summary>
        /// 关闭按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseTheInterface_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// 最小化按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimizeTheInterface_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 鼠标移到用户图标，显示用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void pictureBoxUser_MouseEnter(object sender, EventArgs e)
        {
            panelUserInfo.Visible = true;       //显示用户信息

        }

        private void pictureBoxUser_MouseLeave(object sender, EventArgs e)
        {
            panelUserInfo.Visible = false;       //隐藏用户信息
        }

        /// <summary>
        /// 点击“推出登陆”触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExitLogin_Click(object sender, EventArgs e)
        {
            this.Close();
            FrmLogin frmLogin = new FrmLogin();
            frmLogin.Show();

        }

        /// <summary>
        /// 鼠标移到用户图标时，显示用户信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panelUserInfo_MouseEnter(object sender, EventArgs e)
        {
            panelUserInfo.Visible = true;
        }

        /// <summary>
        /// 选择了查找教室
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSearchClassroom_CheckedChanged(object sender, EventArgs e)
        {
            panelSearchClassroom.Visible = true;        //显示查询教室的选择框
            panelSearchClass.Visible = false;        //隐藏查询课程的选择框
            panelSearchTeacher.Visible = false;        //隐藏查询教师的选择框
            panelSearchBox.Visible = true;        //显示查询搜索框
            buttonModifyClassroomManage.Visible = false;   //隐藏修改教室按钮
            buttonAddClassroomManage.Visible = false;   //隐藏增加教室按钮
            buttonDeleteClassroomManage.Visible = false;   //隐藏删除教室按钮
            radioButtonClassroomID.Checked = true;
            panelClassroomManage.Visible = false;        //隐藏教室管理的选择框
            panelAdvancedSearch.Visible = false;         //隐藏高级搜索栏
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
            textBoxSearchBox.Text = "";
            textBoxAdvancedCourseName.Text = "";
            textBoxAdvancedTeacherID.Text = "";
            textBoxAdvancedClassDate.Text = "";
            textBoxAdvancedWeekday.Text = "";
            textBoxAdvancedClassNum.Text = "";
            textBoxAdvancedClassroomID.Text = "";
            NumberOfRecords.Text = "";
            panelClassroonManage.Visible = true;
            
        }

        /// <summary>
        /// 选择了查找教师
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSearchTeacher_CheckedChanged(object sender, EventArgs e)
        {
            panelSearchClassroom.Visible = false;        //隐藏查询教室的选择框
            panelSearchClass.Visible = false;        //隐藏查询课程的选择框
            panelSearchTeacher.Visible = true;        //显示查询教师的选择框
            panelSearchBox.Visible = true;        //显示查询搜索框
            buttonModifyClassroomManage.Visible = false;   //隐藏修改教室按钮
            buttonAddClassroomManage.Visible = false;   //隐藏增加教室按钮
            buttonDeleteClassroomManage.Visible = false;   //隐藏删除教室按钮
            panelClassroomManage.Visible = false;        //隐藏教室管理的选择框
            panelAdvancedSearch.Visible = false;         //隐藏高级搜索栏
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
            textBoxSearchBox.Text = "";
            textBoxAdvancedCourseName.Text = "";
            textBoxAdvancedTeacherID.Text = "";
            textBoxAdvancedClassDate.Text = "";
            textBoxAdvancedWeekday.Text = "";
            textBoxAdvancedClassNum.Text = "";
            textBoxAdvancedClassroomID.Text = "";
            NumberOfRecords.Text = "";
            panelClassroonManage.Visible = false;
        }

        /// <summary>
        /// 选择了查找课程
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSearchClass_CheckedChanged(object sender, EventArgs e)
        {
            panelSearchClassroom.Visible = false;        //隐藏查询教室的选择框
            panelSearchClass.Visible = true;        //显示查询课程的选择框
            panelSearchTeacher.Visible = false;        //隐藏查询教师的选择框
            panelSearchBox.Visible = true;        //显示查询搜索框
            buttonModifyClassroomManage.Visible = false;   //隐藏修改教室按钮
            buttonAddClassroomManage.Visible = false;   //隐藏增加教室按钮
            buttonDeleteClassroomManage.Visible = false;   //隐藏删除教室按钮
            panelClassroomManage.Visible = false;        //隐藏教室管理的选择框
            panelAdvancedSearch.Visible = false;         //隐藏高级搜索栏
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
            textBoxSearchBox.Text = "";
            textBoxAdvancedCourseName.Text = "";
            textBoxAdvancedTeacherID.Text = "";
            textBoxAdvancedClassDate.Text = "";
            textBoxAdvancedWeekday.Text = "";
            textBoxAdvancedClassNum.Text = "";
            textBoxAdvancedClassroomID.Text = "";
            NumberOfRecords.Text = "";
            panelClassroonManage.Visible = false;
        }

        /// <summary>
        /// 选择了教室管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonClassroomManagement_CheckedChanged(object sender, EventArgs e)
        {
            panelSearchClassroom.Visible = false;        //隐藏查询教室的选择框
            panelSearchClass.Visible = false;        //隐藏查询课程的选择框
            panelSearchTeacher.Visible = false;        //隐藏查询教师的选择框
            panelSearchBox.Visible = false;        //隐藏查询搜索框
            panelClassroomManage.Visible = true;        //显示教室管理的选择框
            panelSearchBox.Visible = true;        //显示查询搜索框
            buttonModifyClassroomManage.Visible = true;   //显示修改教室按钮
            buttonAddClassroomManage.Visible = true;   //显示增加教室按钮
            buttonDeleteClassroomManage.Visible = true;   //显示删除教室按钮
            panelAdvancedSearch.Visible = true;         //显示高级搜索栏
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
            textBoxSearchBox.Text = "";
            textBoxAdvancedCourseName.Text = "";
            textBoxAdvancedTeacherID.Text = "";
            textBoxAdvancedClassDate.Text = "";
            textBoxAdvancedWeekday.Text = "";
            textBoxAdvancedClassNum.Text = "";
            textBoxAdvancedClassroomID.Text = "";
            NumberOfRecords.Text = "";
            panelClassroonManage.Visible = false;
        }

        /// <summary>
        /// 选择了查询教室安排信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonSearchClassroomManage_CheckedChanged(object sender, EventArgs e)
        {
            panelSearchClassroom.Visible = false;        //隐藏查询教室的选择框
            panelSearchClass.Visible = false;        //隐藏查询课程的选择框
            panelSearchTeacher.Visible = false;        //隐藏查询教师的选择框
            panelSearchBox.Visible = false;        //隐藏查询搜索框
            panelClassroomManage.Visible = true;        //显示教室管理的选择框
            panelSearchBox.Visible = true;        //显示查询搜索框
            buttonAddClassroomManage.Visible = false;   //隐藏增加教室按钮
            buttonDeleteClassroomManage.Visible = false;   //隐藏删除教室按钮
            buttonModifyClassroomManage.Visible = false;   //隐藏修改教室按钮
            panelAdvancedSearch.Visible = true;         //显示高级搜索栏
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
            textBoxSearchBox.Text = "";
            textBoxAdvancedCourseName.Text = "";
            textBoxAdvancedTeacherID.Text = "";
            textBoxAdvancedClassDate.Text = "";
            textBoxAdvancedWeekday.Text = "";
            textBoxAdvancedClassNum.Text = "";
            textBoxAdvancedClassroomID.Text = "";
            NumberOfRecords.Text = "";
            panelClassroonManage.Visible = false;
        }
        /// <summary>
        /// 切换查询时清空搜索栏和表格
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonNum_CheckedChanged(object sender, EventArgs e)
        {
            NumberOfRecords.Text = "";
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
        }

        private void radioButton_CheckedChanged(object sender, EventArgs e)
        {
            NumberOfRecords.Text = "";
            textBoxSearchBox.Text = "";
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
        }

        /// <summary>
        /// 搜索栏上的清除按钮
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            textBoxSearchBox.Text = "";
 
        }
        private void button3_Click(object sender, EventArgs e)
        {
            textBoxAdvancedClassroomID.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBoxAdvancedCourseName.Text = "";
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBoxAdvancedTeacherID.Text = "";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBoxAdvancedClassDate.Text = "";
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBoxAdvancedWeekday.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            textBoxAdvancedClassNum.Text = "";
        }

        //判断登陆的是管理员还是用户，执行不同的权限
        public void Authority(PublicVariable.Ring ring, string user_id, string user_UID)
        {
            if (ring == PublicVariable.Ring.Admin)
            {
                /*
                 登陆的是管理员，显示管理员的信息
                 */
                pictureBoxAdminInfo.Visible = true;
                labelAdminId.Visible = true;
                labelAdminUID.Visible = true;
                pictureBoxUserInfo.Visible = false;
                textBoxUserName.Visible = false;
                labelUserName.Visible = false;
                labelUserUID.Visible = false;
                textBoxUserUID.Visible = false;
                //只有管理员可以进行课程管理
                radioButtonClassroomManagement.Enabled = true;
                panelClassroonManage.Enabled = true;
            }
            else
            {
                /*
                登陆的是其他用户，显示其他用户的信息
                */
                pictureBoxAdminInfo.Visible = false;
                labelAdminId.Visible = false;
                labelAdminUID.Visible = false;
                pictureBoxUserInfo.Visible = true;
                textBoxUserName.Visible = true;
                labelUserName.Visible = true;
                labelUserUID.Visible = true;
                textBoxUserUID.Visible = true;
                textBoxUserName.Text = user_id;
                textBoxUserUID.Text = user_UID;

                //用户不可以进行课程管理
                radioButtonClassroomManagement.Enabled = false;
                radioButtonClassroomManagement.Visible = false;
                panelClassroonManage.Enabled = false;

            }
        }

        private void buttonSerach_Click(object sender, EventArgs e)
        {
            Search();
            NumberOfRecords.Text = "一共搜索到" + dataGridView1.Rows.Count + "条记录。";
        }

        private void Search()
        {
            if (textBoxSearchBox.Text.Length == 0)
            {

                DataTable[][] dataTable = null;
                dataGridView1.DataSource = dataTable;
                MessageBox.Show("请输入要查询的内容！输入*为查询整个表格。", "消息提醒", MessageBoxButtons.OK, MessageBoxIcon.Error);
                //dataGridView1.Rows.Clear();
                return;
            }
            else
            {
                //查询教室
                if (radioButtonSearchClassroom.Checked == true)
                {
                    //搜索教室编号
                    if (radioButtonClassroomID.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomid LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //搜索教室类型
                    else if (radioButtonClassroomType.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomtype LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //搜索教室人数
                    else if (radioButtonClassroomNum.Checked == true)
                    {
                        //string strSearch = '%' + textBoxSearchBox.Text + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {
                            int strSearch = int.Parse(textBoxSearchBox.Text);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomnum >= '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //搜索空闲开始时间
                    else if (radioButtonClassroomFreetimeBegin.Checked == true)
                    {
                        // string 转 DateTime
                        //DateTime dt = Convert.ToDateTime(textBoxSearchBox.Text);
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {

                            DateTime dt = DateTime.ParseExact(textBoxSearchBox.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomfreetimebegin <= '" + dt + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //搜索空闲结束时间
                    else if (radioButtonClassroomFreetimeEnd.Checked == true)
                    {
                        // string 转 DateTime
                        //DateTime dt = Convert.ToDateTime(textBoxSearchBox.Text);
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {
                            DateTime dt = DateTime.ParseExact(textBoxSearchBox.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomfreetimeend >= '" + dt + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //搜索教室拥有设备
                    else if (radioButtonClassroomEquipent.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroom WHERE classroomequipment LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }
                }

                //查询教师信息
                else if (radioButtonSearchTeacher.Checked == true)
                {
                    //查询教工号
                    if (radioButtonTeacherID.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher WHERE teacherid LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询教师姓名
                    if (radioButtonTeacherName.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher WHERE teachername LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询教师职称
                    if (radioButtonTeacherTitle.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher WHERE teachertitle LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询教师学院
                    if (radioButtonTeacherCollege.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM teacher WHERE teachercollege LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }
                }

                //查询课程信息
                else if (radioButtonSearchClass.Checked == true)
                {
                    //查询课程名
                    if (radioButtonClassname.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course WHERE coursename LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询课程学分
                    if (radioButtonCourseCredits.Checked == true)
                    {
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course ";
                        }
                        else
                        {
                            float strSearch = float.Parse(textBoxSearchBox.Text);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course WHERE coursecredits = '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询课程大类
                    if (radioButtonCourseType.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course WHERE coursetype LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询修读方式
                    if (radioButtonCourseIfication.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM course WHERE courseification LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                }

                //教室管理
                else if (radioButtonClassroomManagement.Checked == true || radioButtonSearchClassroomManage.Checked == true)
                {
                    //查询流水号
                    if (radioButtonSerialNumber.Checked == true)
                    {
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroommanage ";
                        }
                        else
                        {
                            int strSearch = int.Parse(textBoxSearchBox.Text);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroommanage WHERE serialnumber = '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询教室编号
                    if (radioButtonManageClassroomID.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage WHERE classroomid LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询课程名
                    if (radioButtonManageCourseName.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage WHERE coursename LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;

                    }

                    //查询教工号
                    if (radioButtonManageClassTeacherId.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage WHERE teacherid LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询上课日期
                    if (radioButtonManageClassDate.Checked == true)
                    {
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage ";
                        }
                        else
                        {

                            DateTime dt = DateTime.ParseExact(textBoxSearchBox.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage WHERE classdate = '" + dt + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }
                    //查询上课星期
                    if (radioButtonManageWeekDay.Checked == true)
                    {
                        string strSearch = '%' + sample(textBoxSearchBox.Text) + '%';
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage ";
                        }
                        else
                        {
                            //拼接SQL语句
                            strSQL = "SELECT *  FROM classroommanage WHERE weekday LIKE '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                    //查询上课人数
                    if (radioButtonManageClassNum.Checked == true)
                    {
                        string strSQL;
                        if (textBoxSearchBox.Text == "*")
                        {
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroommanage ";
                        }
                        else
                        {
                            int strSearch = int.Parse(textBoxSearchBox.Text);
                            //拼接SQL语句
                            strSQL = "SELECT * FROM classroommanage WHERE classnum >= '" + strSearch + "'";
                        }

                        //执行SQL语句
                        DataTable dataTable = SQL_Oparation(strSQL);
                        dataGridView1.DataSource = dataTable;
                        return;
                    }

                }

            }
        }


        /// <summary>        
        /// 按指定间隔插入字符        
        /// </summary>       
        /// <param name="str">原字符串</param>      
        /// <param name="len">间隔长度</param>     
        /// <param name="chr">插入的字符</param>  
        /// <returns>返回值为处理好的字符处</returns>        
        private string sample(string str, int len, char chr)        
        {   
            string result = "";            
            if(str.Length<=len) return str;            
            for (int i = 0; i < (str.Length / len); i++)                
                result += str.Substring(i * len, len) + chr;            
            if (str.Length % len != 0) result += str.Substring((str.Length / len) * len);            
            result = result.Trim(chr);            
            return result;        
        }

        /// <summary>
        /// 每隔一个字符插入一个%
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private string sample(string str)
        {
            string result = "";
            if (str.Length <= 1) return str;
            for (int i = 0; i < str.Length ; i++)
                result += str.Substring(i * 1, 1) + '%';
            if (str.Length % 1 != 0) result += str.Substring((str.Length / 1) * 1);
            result = result.Trim('%');
            return result;
        }

        private void buttonAddClassroom_Click(object sender, EventArgs e)
        {
            FrmAdd frmAdd = new FrmAdd();
            frmAdd.ShowDialog();
        }

        private void buttonModifyClassroom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0 )
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("只能一行一行改哦，不能太着急！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string strSerialNumber = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中的那一行的第一个单元格，转换为string类型
                string strClassroomID = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//选中的那一行的第二个单元格，转换为string类型
                string strCourseName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//选中的那一行的第三个单元格，转换为string类型
                string strTeacherID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//选中的那一行的第四个单元格，转换为string类型
                string strDate = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//选中的那一行的第五个单元格，转换为string类型
                DateTime dateTime = Convert.ToDateTime(strDate);
                string strClassDate = dateTime.ToString("yyyyMMdd");
                //string.Format("{0:d}", dateTime);
                //dateTime.GetDateTimeFormats('D')[1].ToString();
                //ToShortDateString().ToString();

                string strClassNum = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();//选中的那一行的第七个单元格，转换为string类型
                FrmModify frmModify = new FrmModify(strSerialNumber, strClassroomID, strCourseName, strTeacherID, strClassDate, strClassNum);
                frmModify.ShowDialog();
                
            }
            else
            {
                MessageBox.Show("未选中任何行，无法修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void buttonDeleteClassroom_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("只能一行一行删除哦，不能太着急！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                int intSerialNumber = int.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());//选中的那一行的第一个单元格，转换为string类型
                string strClassroomID = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//选中的那一行的第二个单元格，转换为string类型
                string strCourseName = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//选中的那一行的第三个单元格，转换为string类型
                string strTeacherID = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//选中的那一行的第四个单元格，转换为string类型
                string strDate = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//选中的那一行的第五个单元格，转换为string类型
                DateTime dateTime = Convert.ToDateTime(strDate);
                string strClassDate = dateTime.ToString("yyyyMMdd");
                //string.Format("{0:d}", dateTime);
                //dateTime.GetDateTimeFormats('D')[1].ToString();
                //ToShortDateString().ToString();

                string strClassNum = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();//选中的那一行的第七个单元格，转换为string类型
                FrmDelete frmDelete = new FrmDelete(intSerialNumber, strClassroomID, strCourseName, strTeacherID, strClassDate, strClassNum);
                frmDelete.ShowDialog();

            }
            else
            {
                MessageBox.Show("未选中任何行，无法删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void buttonAdvancedSearch_Click(object sender, EventArgs e)
        {
            string strAdvancedClassroomID = textBoxAdvancedClassroomID.Text;
            string strAdvancedCourseName = textBoxAdvancedCourseName.Text;
            string strAdvancedTeacherID = textBoxAdvancedTeacherID.Text;
            string strAdvancedClassDate = textBoxAdvancedClassDate.Text;
            string strAdvancedWeekday = textBoxAdvancedWeekday.Text;
            string strAdvancedClassNum = textBoxAdvancedClassNum.Text;


            /*
             判断是否均为空，均为空则输出所有信息
             */
            if (strAdvancedCourseName.Length == 0 && strAdvancedTeacherID.Length == 0 && strAdvancedClassDate.Length == 0 && strAdvancedWeekday.Length == 0 && strAdvancedClassNum.Length == 0 && strAdvancedClassroomID.Length == 0)
            {
                //拼接SQL语句
                string strSQL = "SELECT * FROM classroommanage";
                //执行SQL语句
                DataTable dataTable = SQL_Oparation(strSQL);
                dataGridView1.DataSource = dataTable;
                NumberOfRecords.Text = "一共搜索到" + dataGridView1.Rows.Count + "条记录。";
                return;

            }
            else
            {
                string strSearchAdvancedClassroomID = '%' + sample(textBoxAdvancedClassroomID.Text) + '%';
                string strSearchAdvancedCourseName = '%' + sample(textBoxAdvancedCourseName.Text) + '%';
                string strSearchAdvancedTeacherID = '%' + sample(textBoxAdvancedTeacherID.Text) + '%';
                string strSearchAdvancedWeekday = '%' + sample(textBoxAdvancedWeekday.Text) + '%';

                string strSQL = "SELECT *  FROM classroommanage WHERE ";
                
                if (strAdvancedClassroomID.Length != 0)
                {
                    strSQL+= "classroomid LIKE '" + strSearchAdvancedClassroomID + "'";
                    if (strAdvancedCourseName.Length != 0)
                    {
                        strSQL += "AND coursename LIKE '" + strSearchAdvancedCourseName + "'";
                        if (strAdvancedTeacherID.Length != 0)
                        {
                            strSQL += "AND teacherid LIKE '" + strSearchAdvancedTeacherID + "'";
                            if (strAdvancedClassDate.Length != 0)
                            {

                                DateTime dt = DateTime.ParseExact(textBoxAdvancedClassDate.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                strSQL += "AND classdate = '" + dt + "'";
                                if (strAdvancedWeekday.Length != 0)
                                {
                                    strSQL += "AND weekday LIKE '" + strSearchAdvancedWeekday + "'";
                                    if (strAdvancedClassNum.Length != 0)
                                    {
                                        int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                                        strSQL += "AND classnum >= '" + intSearchAdvancedClassNum + "'";
                                    }
                                }
                            }
                        }
                    }
                }
                else
                {
                    if (strAdvancedCourseName.Length != 0)
                    {
                        strSQL += "coursename LIKE '" + strSearchAdvancedCourseName + "'";
                        if (strAdvancedTeacherID.Length != 0)
                        {
                            strSQL += "AND teacherid LIKE '" + strSearchAdvancedTeacherID + "'";
                        }
                        if (strAdvancedClassDate.Length != 0)
                        {
                            DateTime dt = DateTime.ParseExact(textBoxAdvancedClassDate.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                            strSQL += "AND classdate = '" + dt + "'";
                        }
                        if (strAdvancedWeekday.Length != 0)
                        {
                            strSQL += "AND weekday LIKE '" + strSearchAdvancedWeekday + "'";
                        }
                        if (strAdvancedClassNum.Length != 0)
                        {
                            int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                            strSQL += "AND classnum >= '" + intSearchAdvancedClassNum + "'";
                        }
                    }
                    else
                    {
                        if (strAdvancedTeacherID.Length != 0)
                        {
                            strSQL += "teacherid LIKE '" + strSearchAdvancedTeacherID + "'";
                            if (strAdvancedClassDate.Length != 0)
                            {
                                DateTime dt = DateTime.ParseExact(textBoxAdvancedClassDate.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                strSQL += "AND classdate = '" + dt + "'";
                            }
                            if (strAdvancedWeekday.Length != 0)
                            {
                                strSQL += "AND weekday LIKE '" + strSearchAdvancedWeekday + "'";
                            }
                            if (strAdvancedClassNum.Length != 0)
                            {
                                int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                                strSQL += "AND classnum >= '" + intSearchAdvancedClassNum + "'";
                            }
                        }
                        else
                        {
                            if (strAdvancedClassDate.Length != 0)
                            {
                                DateTime dt = DateTime.ParseExact(textBoxAdvancedClassDate.Text, "yyyyMMdd", System.Globalization.CultureInfo.InvariantCulture);
                                strSQL += "classdate = '" + dt + "'";
                                if (strAdvancedWeekday.Length != 0)
                                {
                                    strSQL += "AND weekday LIKE '" + strSearchAdvancedWeekday + "'";
                                }
                                if (strAdvancedClassNum.Length != 0)
                                {
                                    int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                                    strSQL += "AND classnum >= '" + intSearchAdvancedClassNum + "'";
                                }
                            }
                            else
                            {
                                if (strAdvancedWeekday.Length != 0)
                                {
                                    strSQL += "weekday LIKE '" + strSearchAdvancedWeekday + "'";
                                    if (strAdvancedClassNum.Length != 0)
                                    {
                                        int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                                        strSQL += "AND classnum >= '" + intSearchAdvancedClassNum + "'";
                                    }
                                }
                                else
                                {
                                    if (strAdvancedClassNum.Length != 0)
                                    {
                                        int intSearchAdvancedClassNum = int.Parse(textBoxAdvancedClassNum.Text);
                                        strSQL += "classnum >= '" + intSearchAdvancedClassNum + "'";
                                    }
                                }
                            }
                        }
                    }
                }

                //执行SQL语句
                DataTable dataTable = SQL_Oparation(strSQL);
                dataGridView1.DataSource = dataTable;
                NumberOfRecords.Text = "一共搜索到" + dataGridView1.Rows.Count + "条记录。";
                return;
                
            }

        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataTable[][] dataTable = null;
            dataGridView1.DataSource = dataTable;
        }
        private void textBoxTime_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (((int)e.KeyChar < 48 || (int)e.KeyChar > 57) && (int)e.KeyChar != 8)
            {
                e.Handled = true;
            }
        }

        private void buttonAddClassroon_Click(object sender, EventArgs e)
        {
            FrmAddClassroom frmAddClassroom = new FrmAddClassroom();
            frmAddClassroom.ShowDialog();
        }

        private void buttonModifyClassroon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("只能一行一行改哦，不能太着急！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string strClassroomID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中的那一行的第一个单元格，转换为string类型
                string strClassroomType = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();//选中的那一行的第二个单元格，转换为string类型
                string strClassroomNum = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();//选中的那一行的第三个单元格，转换为string类型
                string strDatebegin = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();//选中的那一行的第四个单元格，转换为string类型
                string strDateend = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();//选中的那一行的第五个单元格，转换为string类型
                DateTime dateTime1 = Convert.ToDateTime(strDatebegin);
                string strFreetimeBegin = dateTime1.ToString("yyyyMMdd");
                DateTime dateTime = Convert.ToDateTime(strDateend);
                string strFreetimeEnd = dateTime.ToString("yyyyMMdd");

                string strClassroomEquipment = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();//选中的那一行的第六个单元格，转换为string类型
                //FrmModify frmModify = new FrmModify(strSerialNumber, strClassroomID, strCourseName, strTeacherID, strClassDate, strClassNum);
                //frmModify.ShowDialog();
                FrmModifyClassroom frmModifyClassroom = new FrmModifyClassroom(strClassroomID, strClassroomType, strClassroomNum, strFreetimeBegin, strFreetimeEnd, strClassroomEquipment);
                frmModifyClassroom.ShowDialog();

            }
            else
            {
                MessageBox.Show("未选中任何行，无法修改！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDeleteClassroon_Click(object sender, EventArgs e)
        {
            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 1)
                {
                    MessageBox.Show("只能一行一行删除哦，不能太着急！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                string strClassroomID = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();//选中的那一行的第二个单元格，转换为string类型


                FrmDeleteClassroom frmDeleteClassroom = new FrmDeleteClassroom(strClassroomID);
                frmDeleteClassroom.ShowDialog();

            }
            else
            {
                MessageBox.Show("未选中任何行，无法删除！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
