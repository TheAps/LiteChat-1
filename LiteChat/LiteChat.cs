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
        public LiteChat()
        {
            InitializeComponent();
        }
        public LiteChat(string user)
        {
            InitializeComponent();
            var client = new MongoClient("mongodb://125.27.10.67:27017");
            var mongo = client.GetDatabase("LiteChat");
            var coll = mongo.GetCollection<BsonDocument>("USER");



            var filter = Builders<BsonDocument>.Filter.Eq("user", user);
           
            var check = coll.Find(filter)
                .ToList();
            name.Text = (String)check[0];
            Console.Write(check[0]);


            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
