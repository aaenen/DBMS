using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 教室信息管理系统
{
    public static class PublicVariable
    {
        public static int row_count = 0;
        public enum Ring
        {
            /// <summary>
            /// 登陆的是用户
            /// </summary>
            User,
            /// <summary>
            /// 登陆的是管理员
            /// </summary>
            Admin
        }
    }
}
