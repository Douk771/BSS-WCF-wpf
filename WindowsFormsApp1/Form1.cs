using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.ServiceReference;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ServiceClient client = new ServiceClient();
            dataGridView1.DataSource = client.AutorsInStore(1);
           // client.CreateAutor("Кинг Стивен");

        }
    }
}
