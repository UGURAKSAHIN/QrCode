using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MessagingToolkit.QRCode.Codec;

namespace QRBarkod
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

       

        private void Button1_Click(object sender, EventArgs e)
        {


            QRCodeEncoder qRCodeEncoder = new QRCodeEncoder();

            pictureBox1.Image = qRCodeEncoder.Encode(textBox1.Text);

        }

        

       
    }
}
