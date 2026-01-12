using DataLib.UserEnum;
using System.Data;
using System.Diagnostics;
using UI;

namespace UpperComputerSystem
{
    public partial class Form_Main : Form
    {
      private UI.Control.ControlFlow Controlflow=new UI.Control.ControlFlow();
        //private string userName;
        public Form_Main()
        {
            InitializeComponent();
            using (UI.User.UserLogin Form_login = new UI.User.UserLogin())
            {
                if (Form_login.ShowDialog() != DialogResult.OK)
                {
                    Process.GetCurrentProcess().Kill();
                }
                //userName = UI.User.UserLogin.UserName;
            }
            this.StartPosition = FormStartPosition.CenterParent;
            //panel1.Controls.Clear();
            //Controlflow.Show();
            //panel1.Controls.Add(Controlflow);
            Controlflow.TopLevel = false; // 设置为非顶级窗体
            Controlflow.FormBorderStyle = FormBorderStyle.None; // 移除边框
            Controlflow.Dock = DockStyle.Fill; // 填充整个父窗体区域
            this.Controls.Add(Controlflow); // 将form2添加到父窗体的Controls集合中
            Controlflow.Show();
        }
        private void PermissionCheck()
        {
            //操作员权限
            if (UI.User.UserLogin.Permission == PermissionEnum.Operation)
            {
                Menu_Interface_UserManage.Visible = false;
            }
            //访客权限
            if (UI.User.UserLogin.Permission == PermissionEnum.None | UI.User.UserLogin.Permission == PermissionEnum.ReadOnly)
            {
                Menu_Interface_UserManage.Visible = false;
                Menu_Interface_AlarmForm.Visible = false;
            }

        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            //label1.Text= userName;
            PermissionCheck();
            Menu_TextBoxUser.Text = "角色："  +UI.User.UserLogin.Role  + "用户：" +UI.User.UserLogin.UserName;
            Menu_TextBoxUser.AutoSize = true;
            Menu_TextBoxUser.ReadOnly = true;
            Menu_TextBoxUser.BorderStyle = BorderStyle.None;


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Menu_TextBoxTime.Text = DateTime.Now.ToString("HH:mm:ss:f");
        }
    }
}
