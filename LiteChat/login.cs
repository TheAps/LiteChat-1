using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MongoDB.Driver;
using MongoDB.Bson;

namespace LiteChat
{
    public partial class login : Form
      
    {
        

        
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://125.27.10.67:27017");
            var mongo = client.GetDatabase("LiteChat");
            var coll = mongo.GetCollection<BsonDocument>("USER");


            
            var filter = Builders<BsonDocument>.Filter.Eq("user", username.Text ) ;
            filter = filter & (Builders<BsonDocument>.Filter.Eq("password", password.Text));
            var check = coll.Find(filter).Count();
            
            if (check>0)
            {
                var a = new LiteChat();
                a.user = username.Text;

                a.Visible = true;
                a.start();
                Visible = false;

            }
            


        }

        private void button2_Click(object sender, EventArgs e)
        {
            regis x = new regis();
            x.Visible = true;
        }
    }
  
}
