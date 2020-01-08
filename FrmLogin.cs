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
    public partial class FrmLogin : Form
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

        public FrmLogin()
        {
            InitializeComponent();
        }
        /// <summary>
        /// 点击“退出X”时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonCloseTheInterface_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        /// <summary>
        /// 点击最小化时的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonMinimizeTheInterface_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        /// <summary>
        /// 点击注册按钮，进入注册界面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRegistered_Click(object sender, EventArgs e)
        {
            buttonReturn.Visible = true;    //显示可以回退的按钮
            textBoxUserName.Visible = true;    //显示用户名
            labelUserName.Visible = true;    //显示用户名框
            labelTitle.Visible = false;    //隐藏界面标题
            panelUID.Visible = true;    //显示UID
            buttonRegistered.Visible = false;    //隐藏首页的注册
            radioButtonAdmin.Visible = false;    //隐藏首页的管理员
            radioButtonUser.Visible = false;    //隐藏首页的用户
            buttonLogin.Visible = false;    //隐藏首页的登陆
            buttonRegistered2.Visible = true;    //显示注册界面的注册
            pictureBoxAdmin.Visible = false;    //隐藏管理员图片
            textBoxUserName.Text = "";          //将用户名框清空
            textBoxPassword.Text = "";          //将密码框清空
            //textBoxPassword.UseSystemPasswordChar = false;  //密码框按照原来的输出
            DateTime t = DateTime.Now;
            textBoxUID.Text = t.ToString("yyyyMMddHHmmssfff");


        }
    /// <summary>
    /// 注册页面的返回按钮
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void buttonReturn_Click(object sender, EventArgs e)
        {
            buttonReturn.Visible = false;    //隐藏可以回退的按钮
            labelTitle.Visible = true;    //显示界面标题
            panelUID.Visible = false;    //隐藏UID
            buttonRegistered.Visible = true;    //显示首页的注册
            buttonLogin.Visible = true;    //显示首页的登陆
            buttonRegistered2.Visible = false;    //隐藏注册界面的注册
            radioButtonAdmin.Visible = true;    //显示首页的管理员
            radioButtonUser.Visible = true;    //显示首页的用户
            textBoxUserName.Visible = false;    //隐藏用户名
            labelUserName.Visible = false;    //隐藏用户名框
            pictureBoxAdmin.Visible = true;    //显示管理员图片
            textBoxUserName.Text = "Admin";     //管理员的用户名默认为Admin
            textBoxPassword.Text = "";          //将密码框清空
            textBoxPassword.UseSystemPasswordChar = true;  //密码框按照密码样式输出
            radioButtonAdmin.Checked = true;    //回退后默认还是管理员被选中
        }

        /// <summary>
        /// 点击管理员登陆时触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonAdmin_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAdmin.Visible = true;    //显示管理员图片
            textBoxUserName.Visible = false;    //隐藏首页的用户名
            labelUserName.Visible = false;    //隐藏首页的用户名输入框
            textBoxUserName.Text = "Admin";     //管理员的用户名默认为Admin
            textBoxPassword.Text = "";       //将密码框重置为密码
        }

        /// <summary>
        /// 点击用户登陆时出发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void radioButtonUser_CheckedChanged(object sender, EventArgs e)
        {
            pictureBoxAdmin.Visible = false;    //隐藏管理员图片
            textBoxUserName.Visible = true;    //显示首页的用户名
            labelUserName.Visible = true;    //显示首页的用户名输入框
            textBoxUserName.Text = "";     //将用户名清空
            textBoxPassword.Text = "";       //将密码框重置为密码
            textBoxUserName.TabIndex = 0;
        }
        /// <summary>
        /// 点击登陆按钮触发的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            Login();    //使用登陆方法
        }

        private void buttonRegistered2_Click(object sender, EventArgs e)
        {
            string user_id = textBoxUserName.Text.Trim();
            string user_pwd = textBoxPassword.Text;
            string user_UID = textBoxUID.Text;
            bool flagID = LoginID(user_id);

            //生成注册信息
            if (user_id.Length == 0 || user_pwd.Length == 0)
            {
                MessageBox.Show("注册失败，请按要求完整填写！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (flagID)
            {
                MessageBox.Show("注册失败，该用户名已存在！", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                string message = Registered(user_id, user_pwd, user_UID);
                PublicVariable.row_count = 0;
                MessageBox.Show(message, "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        /// <summary>
        /// 检测密码是否正确
        /// </summary>
        /// <param name="user_id"></param>
        /// <param name="user_pwd"></param>
        /// <returns></returns>
        public bool Login(String user_id,string user_pwd)
        {
            //拼接SQL语句
            string strSQL = "SELECT * FROM userinfo WHERE user_id = '" + user_id + "'AND user_pwd='" + user_pwd + "'";
            //执行SQL语句
            PublicVariable.row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (PublicVariable.row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，可以登陆
            }

            return false;
        }

        /// <summary>
        /// 检测帐号是否存在
        /// </summary>
        /// <param name="user_id"></param>
        /// <returns></returns>
        public bool LoginID(string user_id)
        {
            //拼接SQL语句
            string strSQL = "SELECT * FROM userinfo WHERE user_id = '" + user_id + "'";
            //执行SQL语句
            int row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数

            if (row_count > 0)
            {
                return true; //在用户表中查到这条数据，则count>0，查询成功，可以登陆
            }

            return false;
        }

        /// <summary>
        /// 开局就执行的事件
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_Load(object sender, EventArgs e)
        {

            textBoxUserName.Text = "Admin";     //管理员的用户名默认为Admin
        }


        /// <summary>
        /// 注册帐号
        /// </summary>
        /// <param name="user_id">用户名</param>
        /// <param name="user_pwd">用户密码</param>
        /// <param name="user_UID">用户UID</param>
        /// <returns></returns>
        public string Registered(String user_id, string user_pwd,string user_UID)
        {
            //拼接SQL语句
            string strSQL = @"INSERT INTO [dbo].[userinfo]
                                       ([user_id]
                                       ,[user_pwd]
                                       ,[user_UID])
                                 VALUES
                                       ('" + user_id + @"'
                                       ,'" + user_pwd + @"'
                                       ,'" + user_UID + "')";
            
            try    
            {
                PublicVariable.row_count = SQL_Oparation(strSQL).Rows.Count;   //执行SQL语句，并接收返回的受影响的行数
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
               
            }
            
            return "注册成功，快按返回按钮回去登陆吧！";
            
        }

        public string SearchUID(String user_id, string user_pwd)
        {
            //拼接SQL语句
            string strSQL = "SELECT user_UID FROM userinfo WHERE user_id = '" + user_id + "'AND user_pwd='" + user_pwd + "'";

            //将搜索到的UID传回去
            string UID = SQL_Oparation(strSQL).Rows[0][0].ToString();
            return UID;
        }

        /// <summary>
        /// 用户可以按下回车键登陆
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Return)       //判断用户按下的是否是回车键
            {
                Login();
            }
        }

        /// <summary>
        /// 定义一个方法，用于登录
        /// </summary>
        private void Login()
        {
            string user_id = textBoxUserName.Text.Trim();
            string user_pwd = textBoxPassword.Text;
            bool flag = Login(user_id, user_pwd);
            bool flagID = LoginID(user_id);
            if (flagID)
            {
                if (flag)
                {
                    if (textBoxUserName.Text == "Admin")
                    {
                        FrmMain frmMain = new FrmMain(PublicVariable.Ring.Admin, "Admin", "3117004481");
                        this.Hide();
                        frmMain.Show();
                    }
                    else
                    {
                        FrmMain frmMain = new FrmMain(PublicVariable.Ring.User, user_id, SearchUID(user_id, user_pwd));
                        this.Hide();
                        frmMain.Show();
                    }

                }
                else
                {
                    MessageBox.Show("登陆失败，密码错误", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("登陆失败，此账号不存在", "信息提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
