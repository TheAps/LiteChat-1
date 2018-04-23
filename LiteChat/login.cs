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
        

        LiteChat a = new LiteChat();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var client = new MongoClient("mongodb://125.27.10.67:27017");
            var mongo = client.GetDatabase("LiteChat");
            var db = mongo.GetCollection<userac>("User");
            var user = new userac();
            user.user = username.Text;
            user.password = password.Text;

            var check = db.Find(b => b.user == username.Text && b.password == password.Text)
                .ToListAsync()
                .Result;
            foreach(var x in check)
            {
                Console.WriteLine("---" + x.user);
            }
            Console.WriteLine("OK");
           
            /*
            a.Visible = true;
            Visible = false;
            */
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regis x = new regis();
            x.Visible = true;
        }
    }
    public class userac
    {
        public string user { get; set; }
        public string password { get; set; }
    }
}
