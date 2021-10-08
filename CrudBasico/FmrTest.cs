using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;

namespace CrudBasico
{
    public partial class Test : Form
    {
        public Test()
        {
            InitializeComponent();
        }

        private void BtnTest_Click(object sender, EventArgs e)
        {

            String ConnectionString = "";
            MySqlConnection conn;

            try
            {
                ConnectionString = @"Server=localhost;Database=smis015421;Uid=root;
                                     Pwd=usbw;SSL Mode=None";
                conn = new MySqlConnection(ConnectionString);
                conn.Open();
                MetroFramework.MetroMessageBox.Show(this, " Se establecio conexion!",
                    "CONEXION EXITOSA", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
            catch (Exception Ex)
            {
                MetroFramework.MetroMessageBox.Show(this, Ex.Message,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }

        }
    }
}
