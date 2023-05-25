using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace csv1
{
    public partial class Form1 : Form
    {
        public struct punto1
        {
            public string r;
            public string anni;
            public string stalli;
            public string Casual;
        }


        public int ncampi;
        public int lunghmax;
        public punto1[] p;

        public int dim;

        public string path;
        public Form1()
        {
            InitializeComponent();
            path = Path.GetFullPath("..\\..\\..\\files\\sciusco.csv");
            dim = 0;
            p = new punto1[200];
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
