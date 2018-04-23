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
    public partial class login : Form
      
    {
        
        LiteChat a = new LiteChat();
        public login()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            a.Visible = true;
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            regis x = new regis();
            x.Visible = true;
        }
    }
}
