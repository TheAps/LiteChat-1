using MongoDB.Bson;
using MongoDB.Bson.Serialization;
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
    
    public partial class LiteChat : Form
    {
        public string user;
        public LiteChat()
        {
            InitializeComponent();
        }
   
        public void start()
        {

            var client = new MongoClient("mongodb://125.27.10.67:27017");
            var mongo = client.GetDatabase("LiteChat");
            var coll = mongo.GetCollection<UserX>("USER");



            var filter = Builders<UserX>.Filter.Eq("user", user);

            var check = coll.Find(x => x.name == user)
                .ToList();

            foreach(UserX x in check)
            {

            }
            /*
             * 
             * var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
             */
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }

    public class UserX
    {
        public string _id { get; set; }
        public string user { get; set; }
        public string password { get; set; }
        public string name { get; set; }
        public string image { get; set; }
        public string status { get; set; }
    }


}
