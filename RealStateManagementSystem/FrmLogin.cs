using RealState.Data;
using RealState.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagementSystem;

public partial class FrmLogin : Form
{
    
    public FrmLogin()
    {
        InitializeComponent();
    }

    private void guna2GradientButton1_Click(object sender, EventArgs e)
    {
        var dbContextFactor = MyDbContextFactory.Create();
        var result = dbContextFactor.Users.FirstOrDefault
            (x => x.UserName == txtusername.Text && x.Password ==txtpassword.Text);
        if(result!=null)
        {
            var frmDashboard = new frmDashboard(result.Id);
            frmDashboard.Show();
            this.Hide();
            frmDashboard.FormClosing += FrmDashboard_FormClosing;
        }
        else
            MessageBox.Show("کاربر وجود ندارد ");



    }

    private void FrmDashboard_FormClosing(object? sender, FormClosingEventArgs e)
    {
        this.Close();
    }

    private void btnRegister_Click(object sender, EventArgs e)
    {
        var frmRegister = new frmRegister();
        frmRegister.Show();
        this.Hide();
        frmRegister.FormClosing += FrmRegister_FormClosing;
    }

    private void FrmRegister_FormClosing(object? sender, FormClosingEventArgs e)
    {
        this.Show();
    }

    private void checkboxRememberMe_CheckedChanged(object sender, EventArgs e)
    {
        var confing = 
            ConfigurationManager.OpenExeConfiguration(ConfigurationUserLevel.None);
        confing.AppSettings.Settings["showLogin"].Value=
            checkboxRememberMe.Checked.ToString();
        confing.Save(ConfigurationSaveMode.Modified);
        ConfigurationManager.RefreshSection("appSettings");
    }

    private void FrmLogin_Load(object sender, EventArgs e)
    {
        checkboxRememberMe.Checked = bool.Parse(ConfigurationManager.AppSettings["showLogin"]);
    }
}
