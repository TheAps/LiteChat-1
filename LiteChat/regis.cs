using MongoDB.Bson;
using MongoDB.Driver;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LiteChat
{
    public partial class regis : Form
    {
        public regis()
        {
            InitializeComponent();
        }

        private void regis_FormClosed(object sender, FormClosedEventArgs e)
        {
            Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(username.Text))
            {
                var client = new MongoClient("mongodb://125.27.10.67:27017");
                var mongo = client.GetDatabase("LiteChat");
                var coll = mongo.GetCollection<BsonDocument>("USER");



                var filter = Builders<BsonDocument>.Filter.Eq("user", username.Text);
                
                var check = coll.Find(filter).Count();

                if (check > 0)
                {
                    MessageBox.Show("This User Already Registed");

                }
                else
                {
                    if (password.Text != repassword.Text||String.IsNullOrEmpty(password.Text)||String.IsNullOrEmpty(repassword.Text))
                    {
                        MessageBox.Show("Please Enter Correct Password");
                    }
                    else
                    {
                        if (!String.IsNullOrEmpty(name.Text))
                        {
                            MessageBox.Show("Regised");
                        }
                        else
                        {
                            MessageBox.Show("Please Enter Your Name");
                        }
                    }
                }

            }
        }
    }
}
