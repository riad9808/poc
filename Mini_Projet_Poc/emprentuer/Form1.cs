using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace emprentuer
{
	public partial class homeForm : Form
	{
		public homeForm()
		{
			InitializeComponent();
		}

		private void conexion_Click(object sender, EventArgs e)
		{
			conexionForm c = new conexionForm();
			c.Show();
			this.Hide();
		}

		private void inscription_Click(object sender, EventArgs e)
		{
			inscription ins = new inscription();
			ins.Show();
			this.Hide();
		}
	}
}
