using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace laboratorna_5
{
    public partial class fHouse : Form
    {
        public fHouse(House t)
        {
            TheHouse = t;
            InitializeComponent();
        }
        public House TheHouse;
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (TheHouse == null)
            {
                MessageBox.Show("House object is null.");
                return;
            }
            if (double.TryParse(tbWidth.Text.Trim(), out double width) &&
                double.TryParse(tbLength.Text.Trim(), out double length) &&
                double.TryParse(tbHeight.Text.Trim(), out double height) &&
                int.TryParse(tbRoom.Text.Trim(), out int room) &&
                int.TryParse(tbFloor.Text.Trim(), out int floor) &&
                double.TryParse(tbValue.Text.Trim(), out double value) &&
                double.TryParse(tbPrice.Text.Trim(), out double price))
            {
                TheHouse.Width = width;
                TheHouse.Length = length;
                TheHouse.Height = height;
                TheHouse.Room = room;
                TheHouse.Floor = floor;
                TheHouse.Value = value;
                TheHouse.Price = price;
                TheHouse.HasForniture = chbHasForniture.Checked;
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Invalid input. Please check your values.");
            }
        }
        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
        private void fHouse_Load(object sender, EventArgs e)
        {
            if (TheHouse != null)
            {
                tbWidth.Text = TheHouse.Width.ToString();
                tbLength.Text = TheHouse.Length.ToString();
                tbHeight.Text = TheHouse.Height.ToString();
                tbRoom.Text = TheHouse.Room.ToString();
                tbFloor.Text = TheHouse.Floor.ToString();
                tbValue.Text = TheHouse.Value.ToString();
                tbPrice.Text = TheHouse.Price.ToString();
                chbHasForniture.Checked = TheHouse.HasForniture;
            }
        }
    }
}
