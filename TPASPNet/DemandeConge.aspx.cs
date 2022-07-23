using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Configuration;
using MySql.Data.MySqlClient;

namespace TPASPNet
{
    public partial class DemandeConge : System.Web.UI.Page
    {
       

        protected void Page_Load(object sender, EventArgs e)
        {

            
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {


            string connectionString = "SERVER=127.0.0.1;port=3308;DATABASE=rh; UID =root; PASSWORD=";
            MySqlConnection conn = new MySqlConnection(connectionString);

            try
               {               
                   conn.Open();
                   String query = "INSERT INTO `demandeconge`(`Nom`, `Prenom`, `N° matricule`, `Nb jours`) VALUES ('" + TextBox1.Text + "','" + TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "')";
                   MySqlCommand cmd = new MySqlCommand(query, conn);
                   cmd.ExecuteNonQuery();
                ListBox1.Items.Insert(0, string.Format("Nom={0}, Prénom={1}, N° matricule={2}, Nombre de jours={3}", TextBox1.Text.Trim(), TextBox2.Text.Trim(), TextBox3.Text.Trim(), TextBox4.Text.Trim()));

               }
               catch (Exception ex)
               {
                   Console.WriteLine("Error: " + ex.Message);
               }

               conn.Close();
           }

          
        }

    
    
}