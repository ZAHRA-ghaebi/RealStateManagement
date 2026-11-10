using Microsoft.VisualBasic;
using RealState.Data;
using RealState.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace RealStateManagementSystem;

public partial class frmDashboard : Form
{
    public frmDashboard()
    {
        InitializeComponent();
    }
    int _Id;
    public frmDashboard(int Id):this() 
    {
            _Id = Id;
    }

    private void btnfrmcustomer_Click(object sender, EventArgs e)
    {
        var frmCustomer = new frmCustomer();
        frmCustomer.Show();
        this.Hide();
        frmCustomer.FormClosing += FrmCustomer_FormClosing;
    }

    private void FrmCustomer_FormClosing(object? sender, FormClosingEventArgs e)
    {
        this.Show();
    }

    private void btnfrmproperty_Click(object sender, EventArgs e)
    {
        var frmProperty = new frmPropertiy();
        frmProperty.Show();
        this.Hide();
        frmProperty.FormClosing += FrmProperty_FormClosing;
    }

    private void FrmProperty_FormClosing(object? sender, FormClosingEventArgs e)
    {
        this.Show();
    }
    private void btnExist_Click(object sender, EventArgs e)
    {
        var frmLogin = new FrmLogin();
        frmLogin.Show();
        this.Hide();
        frmLogin.FormClosed += FrmLogin_FormClosed;
    }

    private void FrmLogin_FormClosed(object? sender, FormClosedEventArgs e)
    {
        this.Close();
    }

    private void frmDashboard_Load(object sender, EventArgs e)
    {
        var dbContext = MyDbContextFactory.Create();
        var findUser = dbContext.Users.FirstOrDefault(x => x.Id == _Id);
        if (findUser != null)
        {
            tslFullName.Text = findUser.FirstName;
            tslLoginTime.Text = DateTime.Now.ToString() ;
            Properties.Settings.Default.FullName = tslFullName.Text;
            Properties.Settings.Default.datetime= DateTime.Now;
            Properties.Settings.Default.Save();
        }
        tslFullName.Text=Properties.Settings.Default.FullName;
        tslLoginTime.Text=Properties.Settings.Default.datetime.ToString();
    }
}
