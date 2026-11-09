using Microsoft.VisualBasic;
using RealState.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagementSystem;

public partial class frmRegister : Form
{
    public frmRegister()
    {
        InitializeComponent();
    }
    private Random rnd = new Random();
    private string generetedCode;

    private void btngetcode_Click(object sender, EventArgs e)
    {
        generetedCode = rnd.Next(1000, 10000).ToString();
        MessageBox.Show(generetedCode);
    }

    private void btncheeckCode_Click(object sender, EventArgs e)
    {
        if (txtcode.Text == generetedCode)
        {
            pnlUserInfo.Visible = true;

        }
        else
            MessageBox.Show("کد تایید وارد شده اشتباه است");
    }

    private void btnRegisterInfo_Click(object sender, EventArgs e)
    {
        var frmDashboard=new frmDashboard();
        frmDashboard.Show();
        var userService = new UserService();
        userService.Add(
            txtfirstname.Text,
            txtlastname.Text
            ,txtusername.Text,
            txtpassword.Text,
            txtphonenumber.Text);
        
    }
}
