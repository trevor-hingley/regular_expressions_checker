using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Text.RegularExpressions;

namespace OxfordCC.Tools.RegularExpressionChecker
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			InitializeComponent();
		}

		private void btnGO_Click(object sender, EventArgs e)
		{
			Regex r = new Regex(txtPattern.Text);
			Match m = r.Match(txtText.Text);

			chkSuccess.Checked = m.Success;

			lvwGroups.Items.Clear();

			foreach (Group g in m.Groups)
			{
				lvwGroups.Items.Add(g.Value);
			}

			lvwCaptures.Items.Clear();

			foreach (Capture c in m.Captures)
			{
				lvwCaptures.Items.Add(c.Value);
			}
		}
	}
}
