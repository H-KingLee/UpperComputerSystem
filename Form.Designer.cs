namespace UpperComputerSystem
{
    partial class Form_Main
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            menuStrip1 = new MenuStrip();
            Menu_Interface_Main = new ToolStripMenuItem();
            Menu_Interface_AlarmForm = new ToolStripMenuItem();
            Menu_Interface_Users = new ToolStripMenuItem();
            Menu_Interface_Password = new ToolStripMenuItem();
            Menu_Interface_UserManage = new ToolStripMenuItem();
            Menu_TextBoxTime = new ToolStripTextBox();
            Menu_TextBoxUser = new ToolStripTextBox();
            timer1 = new System.Windows.Forms.Timer(components);
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { Menu_Interface_Main, Menu_Interface_AlarmForm, Menu_Interface_Users, Menu_TextBoxTime, Menu_TextBoxUser });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1331, 31);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // Menu_Interface_Main
            // 
            Menu_Interface_Main.Name = "Menu_Interface_Main";
            Menu_Interface_Main.Size = new Size(53, 27);
            Menu_Interface_Main.Text = "界面";
            // 
            // Menu_Interface_AlarmForm
            // 
            Menu_Interface_AlarmForm.Name = "Menu_Interface_AlarmForm";
            Menu_Interface_AlarmForm.Size = new Size(53, 27);
            Menu_Interface_AlarmForm.Text = "报警";
            // 
            // Menu_Interface_Users
            // 
            Menu_Interface_Users.DropDownItems.AddRange(new ToolStripItem[] { Menu_Interface_Password, Menu_Interface_UserManage });
            Menu_Interface_Users.Name = "Menu_Interface_Users";
            Menu_Interface_Users.Size = new Size(53, 27);
            Menu_Interface_Users.Text = "用户";
            // 
            // Menu_Interface_Password
            // 
            Menu_Interface_Password.Name = "Menu_Interface_Password";
            Menu_Interface_Password.Size = new Size(152, 26);
            Menu_Interface_Password.Text = "修改密码";
            // 
            // Menu_Interface_UserManage
            // 
            Menu_Interface_UserManage.Name = "Menu_Interface_UserManage";
            Menu_Interface_UserManage.Size = new Size(152, 26);
            Menu_Interface_UserManage.Text = "用户管理";
            // 
            // Menu_TextBoxTime
            // 
            Menu_TextBoxTime.Alignment = ToolStripItemAlignment.Right;
            Menu_TextBoxTime.BorderStyle = BorderStyle.None;
            Menu_TextBoxTime.Name = "Menu_TextBoxTime";
            Menu_TextBoxTime.ReadOnly = true;
            Menu_TextBoxTime.Size = new Size(100, 27);
            // 
            // Menu_TextBoxUser
            // 
            Menu_TextBoxUser.Alignment = ToolStripItemAlignment.Right;
            Menu_TextBoxUser.HideSelection = false;
            Menu_TextBoxUser.Name = "Menu_TextBoxUser";
            Menu_TextBoxUser.Size = new Size(250, 27);
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick;
            // 
            // Form_Main
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1331, 717);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form_Main";
            Text = "Form1";
            Load += Form_Main_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private ToolStripMenuItem Menu_Interface_Main;
        private ToolStripTextBox Menu_TextBoxUser;
        private ToolStripMenuItem Menu_Interface_AlarmForm;
        private ToolStripMenuItem Menu_Interface_Users;
        private ToolStripMenuItem Menu_Interface_Password;
        private ToolStripMenuItem Menu_Interface_UserManage;
        private ToolStripTextBox Menu_TextBoxTime;
        private System.Windows.Forms.Timer timer1;
    }
}
