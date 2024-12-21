using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SmartTicket.comV1
{
    public partial class SalonListesi : UserControl
    {
        public SalonListesi()
        {
            InitializeComponent();
        }

        private void uzerinde(object sender, MouseEventArgs e)
        {
            lblSalonAdı.ForeColor=Color.Red;
            this.BackColor= Color.DarkSlateGray;
        }

        private void ayrıl(object sender, EventArgs e)
        {
            lblSalonAdı.ForeColor=Color.FromArgb(84,110,122);
            this.BackColor = Color.White;

        }

        private void SalonListesi_Load(object sender, EventArgs e)
        {

        }
    }
}
