using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Здоровое_питание_2_оригинал
{
    public partial class home : Form
    {
        public home()
        {
            InitializeComponent();

            LoadData();
        }

        private void LoadData()
        {
            listView1.Items.Clear(); 

            ImageList imageList = new ImageList();

            imageList.ImageSize = new Size(30, 30);
            imageList.Images.Add(new Bitmap(""));
        }
    }
}
