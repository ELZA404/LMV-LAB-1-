using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LMV_LR_1_
{
	public partial class Form2 : Form
	{
		
		struct Place
		{
			public int row;
			public int place;
			public string text; 
		}
		Place[] place = new Place[55];
		int totalsum = 0;
		int[] pickCheck = new int[55];
		public Form2()
		{
			InitializeComponent();
			for (int i = 0; i < pickCheck.Length; i++)
			{
				pickCheck[i] = 1;
			}
			label7.Text = "$" + totalsum.ToString();
		}

		private void pictureBox1_1_Click(object sender, EventArgs e)
		{
			if (pickCheck[0] % 2 != 0)
			{
				pickCheck[0]++;
				place[0].row = 1; place[0].place = 1; place[0].text = "Row: " + place[0].row + ", place: " + place[0].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_1.BackColor = Color.Green;
			}
			else
			{
				pickCheck[0]--;
				if (place[0].row != 0 && place[0].row != 0)
				{
					place[0].row = 0;
					place[0].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_1.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_2_Click(object sender, EventArgs e)
		{
			if (pickCheck[1] % 2 != 0)
			{
				pickCheck[1]++;
				place[1].row = 1; place[1].place = 2; place[1].text = "Row: " + place[1].row + ", place: " + place[1].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_2.BackColor = Color.Green;
			}
			else
			{
				pickCheck[1]--;
				if (place[1].row != 0 && place[1].row != 0)
				{
					place[1].row = 0;
					place[1].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_2.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_3_Click(object sender, EventArgs e)
		{
			if (pickCheck[2] % 2 != 0)
			{
				pickCheck[2]++;
				place[2].row = 1; place[2].place = 3; place[2].text = "Row: " + place[2].row + ", place: " + place[2].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_3.BackColor = Color.Green;
			}
			else
			{
				pickCheck[2]--;
				if (place[2].row != 0 && place[2].row != 0)
				{
					place[2].row = 0;
					place[2].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_3.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_4_Click(object sender, EventArgs e)
		{
			if (pickCheck[3] % 2 != 0)
			{
				pickCheck[3]++;
				place[3].row = 1; place[3].place = 4; place[3].text = "Row: " + place[3].row + ", place: " + place[3].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_4.BackColor = Color.Green;
			}
			else
			{
				pickCheck[3]--;
				if (place[3].row != 0 && place[3].row != 0)
				{
					place[3].row = 0;
					place[3].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_4.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_5_Click(object sender, EventArgs e)
		{
			if (pickCheck[4] % 2 != 0)
			{
				pickCheck[4]++;
				place[4].row = 1; place[4].place = 5; place[4].text = "Row: " + place[4].row + ", place: " + place[4].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_5.BackColor = Color.Green;
			}
			else
			{
				pickCheck[4]--;
				if (place[4].row != 0 && place[4].row != 0)
				{
					place[4].row = 0;
					place[4].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_5.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_6_Click(object sender, EventArgs e)
		{
			if (pickCheck[5] % 2 != 0)
			{
				pickCheck[5]++;
				place[5].row = 1; place[5].place = 6; place[5].text = "Row: " + place[5].row + ", place: " + place[5].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_6.BackColor = Color.Green;
			}
			else
			{
				pickCheck[5]--;
				if (place[5].row != 0 && place[5].row != 0)
				{
					place[5].row = 0;
					place[5].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_6.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_7_Click(object sender, EventArgs e)
		{
			if (pickCheck[6] % 2 != 0)
			{
				pickCheck[6]++;
				place[6].row = 1; place[6].place = 7; place[6].text = "Row: " + place[6].row + ", place: " + place[6].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_7.BackColor = Color.Green;
			}
			else
			{
				pickCheck[6]--;
				if (place[6].row != 0 && place[6].row != 0)
				{
					place[6].row = 0;
					place[6].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_7.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_8_Click(object sender, EventArgs e)
		{
			if (pickCheck[7] % 2 != 0)
			{
				pickCheck[7]++;
				place[7].row = 1; place[7].place = 8; place[7].text = "Row: " + place[7].row + ", place: " + place[7].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_8.BackColor = Color.Green;
			}
			else
			{
				pickCheck[7]--;
				if (place[7].row != 0 && place[7].row != 0)
				{
					place[7].row = 0;
					place[7].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_8.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_9_Click(object sender, EventArgs e)
		{
			if (pickCheck[8] % 2 != 0)
			{
				pickCheck[8]++;
				place[8].row = 1; place[8].place = 9; place[8].text = "Row: " + place[8].row + ", place: " + place[8].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_9.BackColor = Color.Green;
			}
			else
			{
				pickCheck[8]--;
				if (place[8].row != 0 && place[8].row != 0)
				{
					place[8].row = 0;
					place[8].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_9.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_10_Click(object sender, EventArgs e)
		{
			if (pickCheck[9] % 2 != 0)
			{
				pickCheck[9]++;
				place[9].row = 1; place[9].place = 10; place[9].text = "Row: " + place[9].row + ", place: " + place[9].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_10.BackColor = Color.Green;
			}
			else
			{
				pickCheck[9]--;
				if (place[9].row != 0 && place[9].row != 0)
				{
					place[9].row = 0;
					place[9].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_10.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox1_11_Click(object sender, EventArgs e)
		{
			if (pickCheck[10] % 2 != 0)
			{
				pickCheck[10]++;
				place[10].row = 1; place[10].place = 11; place[10].text = "Row: " + place[10].row + ", place: " + place[10].place + "\n";
				totalsum += 20;
				label7.Text = "$" + totalsum.ToString();
				pictureBox1_11.BackColor = Color.Green;
			}
			else
			{
				pickCheck[10]--;
				if (place[10].row != 0 && place[10].row != 0)
				{
					place[10].row = 0;
					place[10].place = 0;
					totalsum -= 20;
					label7.Text = "$" + totalsum.ToString();
					pictureBox1_11.BackColor = Color.DarkGray;
				}
			}
			label8.Text = "";
			for (int i = 0; i < place.Length; i++)
			{
				if (place[i].place != 0 && place[i].row != 0)
				{
					label8.Text += place[i].text;
				}
			}
		}

		private void pictureBox2_1_Click(object sender, EventArgs e)
		{
			pictureBox2_1.BackColor = Color.Green;
		}
		private void pictureBox2_2_Click(object sender, EventArgs e)
		{
			pictureBox2_2.BackColor = Color.Green;
		}

		private void pictureBox2_3_Click(object sender, EventArgs e)
		{
			pictureBox2_3.BackColor = Color.Green;
		}

		private void pictureBox2_4_Click(object sender, EventArgs e)
		{
			pictureBox2_4.BackColor = Color.Green;
		}

		private void pictureBox2_6_Click(object sender, EventArgs e)
		{
			pictureBox2_6.BackColor = Color.Green;
		}

		private void pictureBox2_8_Click(object sender, EventArgs e)
		{
			pictureBox2_8.BackColor = Color.Green;
		}

		private void pictureBox2_10_Click(object sender, EventArgs e)
		{
			pictureBox2_10.BackColor = Color.Green;
		}
		private void pictureBox2_11_Click(object sender, EventArgs e)
		{
			pictureBox2_11.BackColor = Color.Green;
		}

		private void pictureBox3_1_Click(object sender, EventArgs e)
		{
			pictureBox3_1.BackColor = Color.Green;
		}

		private void pictureBox3_2_Click(object sender, EventArgs e)
		{
			pictureBox3_2.BackColor = Color.Green;
		}

		private void pictureBox3_3_Click(object sender, EventArgs e)
		{
			pictureBox3_3.BackColor = Color.Green;
		}

		private void pictureBox3_4_Click(object sender, EventArgs e)
		{
			pictureBox3_4.BackColor = Color.Green;
		}

		private void pictureBox3_5_Click(object sender, EventArgs e)
		{
			pictureBox3_5.BackColor = Color.Green;
		}

		private void pictureBox3_6_Click(object sender, EventArgs e)
		{
			pictureBox3_6.BackColor = Color.Green;
		}

		private void pictureBox3_7_Click(object sender, EventArgs e)
		{
			pictureBox3_7.BackColor = Color.Green;
		}

		private void pictureBox3_9_Click(object sender, EventArgs e)
		{
			pictureBox3_9.BackColor = Color.Green;
		}

		private void pictureBox3_10_Click(object sender, EventArgs e)
		{
			pictureBox3_10.BackColor = Color.Green;
		}

		private void pictureBox3_11_Click(object sender, EventArgs e)
		{
			pictureBox3_11.BackColor = Color.Green;
		}

		private void pictureBox4_1_Click(object sender, EventArgs e)
		{
			pictureBox4_1.BackColor = Color.Green;
		}

		private void pictureBox4_2_Click(object sender, EventArgs e)
		{
			pictureBox4_2.BackColor = Color.Green;
		}

		private void pictureBox4_3_Click(object sender, EventArgs e)
		{
			pictureBox4_3.BackColor = Color.Green;
		}

		private void pictureBox4_4_Click(object sender, EventArgs e)
		{
			pictureBox4_4.BackColor = Color.Green;
		}

		private void pictureBox4_5_Click(object sender, EventArgs e)
		{
			pictureBox4_5.BackColor = Color.Green;
		}

		private void pictureBox4_6_Click(object sender, EventArgs e)
		{
			pictureBox4_6.BackColor = Color.Green;
		}

		private void pictureBox4_7_Click(object sender, EventArgs e)
		{
			pictureBox4_7.BackColor = Color.Green;
		}

		private void pictureBox4_8_Click(object sender, EventArgs e)
		{
			pictureBox4_8.BackColor = Color.Green;
		}

		private void pictureBox4_9_Click(object sender, EventArgs e)
		{
			pictureBox4_9.BackColor = Color.Green;
		}

		private void pictureBox4_10_Click(object sender, EventArgs e)
		{
			pictureBox4_10.BackColor = Color.Green;
		}

		private void pictureBox4_11_Click(object sender, EventArgs e)
		{
			pictureBox4_11.BackColor = Color.Green;
		}

		private void pictureBox5_1_Click(object sender, EventArgs e)
		{
			pictureBox5_1.BackColor = Color.Green;
		}

		private void pictureBox5_2_Click(object sender, EventArgs e)
		{
			pictureBox5_2.BackColor = Color.Green;
		}

		private void pictureBox5_3_Click(object sender, EventArgs e)
		{
			pictureBox5_3.BackColor = Color.Green;
		}

		private void pictureBox5_4_Click(object sender, EventArgs e)
		{
			pictureBox5_4.BackColor = Color.Green;
		}

		private void pictureBox5_5_Click(object sender, EventArgs e)
		{
			pictureBox5_5.BackColor = Color.Green;
		}

		private void pictureBox5_6_Click(object sender, EventArgs e)
		{
			pictureBox5_6.BackColor = Color.Green;
		}

		private void pictureBox5_7_Click(object sender, EventArgs e)
		{
			pictureBox5_7.BackColor = Color.Green;
		}

		private void pictureBox5_8_Click(object sender, EventArgs e)
		{
			pictureBox5_8.BackColor = Color.Green;
		}

		private void pictureBox5_9_Click(object sender, EventArgs e)
		{
			pictureBox5_9.BackColor = Color.Green;
		}

		private void pictureBox5_10_Click(object sender, EventArgs e)
		{
			pictureBox5_10.BackColor = Color.Green;
		}

		private void pictureBox5_11_Click(object sender, EventArgs e)
		{
			pictureBox5_11.BackColor = Color.Green;
		}

		private void groupBox2_Enter(object sender, EventArgs e)
		{

		}

		private void label9_Click(object sender, EventArgs e)
		{
			ErrorMessage.Visible = false;
			if (label8.Text == "" || label8.Text == null)
			{
				ErrorMessage.Text = "Please, choose places to buy";
				ErrorMessage.Visible = true;
			}
			else
			{
				Form3 form3 = new Form3();
				form3.Show();
			}
		}

		private void pictureBox7_Click(object sender, EventArgs e)
		{
			ErrorMessage.Visible = false;
			if (label8.Text == "" || label8.Text == null)
			{
				ErrorMessage.Text = "Please, choose places to buy";
				ErrorMessage.Visible = true;
			}
			else
			{
				Form3 form3 = new Form3();
				form3.Show();
			}
		}
	}
}
