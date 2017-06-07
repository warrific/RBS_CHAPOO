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


namespace UI
{
    public partial class Login_Form : Main_Form
    {
        public Login_Form()
        {
            InitializeComponent();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void btn_Submit_Click(object sender, EventArgs e)
        {
            //verwijst naar ChapooDB en maakt connectie met database
            SqlConnection conn = new SqlConnection(@"Data Source=194.171.20.101;Initial Catalog=RBS1617S_db06;Persist Security Info=True;User ID=RBS1617S_grp06;Password=NwawwcGBA7");
            //Maakt queries voor in de database
            string sqlquery = "SELECT * FROM login WHERE password ='" + txt_wachtwoord.Text.Trim() + "'";
            SqlDataAdapter sda = new SqlDataAdapter(sqlquery, conn);
            DataSet dtbl = new DataSet();
            sda.Fill(dtbl);

            if (dtbl.Tables[0].Rows.Count > 0)
            {
                MessageBox.Show("Login is correct");
                Main_Form obj_mainform = new Main_Form();
                this.Hide();
                obj_mainform.Show();

            }
            else
            {
                MessageBox.Show("wachtwoord incorrect");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void txt_wachtwoord_TextChanged(object sender, EventArgs e)
        {
        
        }
    }
}
