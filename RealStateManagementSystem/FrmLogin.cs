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

    private void btnEnter_Click(object sender, EventArgs e)
    {
        Properties.Settings.Default.ShowLogin = checkboxRememberMe.Checked;
        Properties.Settings.Default.Save();
        var userLog = new UserLogin();
        var result = userLog.FindUser(txtusername.Text, txtpassword.Text);
        if (result != null)
        {
            var frmDashboard = new frmDashboard(result.Id);
            frmDashboard.Show();
            this.Hide();
            frmDashboard.FormClosing += FrmDashboard_FormClosing;
        }
        else
            MessageBox.Show("کاربر وجود ندارد ");
    }
}
