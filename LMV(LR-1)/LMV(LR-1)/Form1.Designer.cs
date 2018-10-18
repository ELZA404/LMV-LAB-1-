namespace LMV_LR_1_
{
	partial class Form1
	{
		/// <summary>
		/// Обязательная переменная конструктора.
		/// </summary>
		private System.ComponentModel.IContainer components = null;

		/// <summary>
		/// Освободить все используемые ресурсы.
		/// </summary>
		/// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing && (components != null))
			{
				components.Dispose();
			}
			base.Dispose(disposing);
		}

		#region Код, автоматически созданный конструктором форм Windows

		/// <summary>
		/// Требуемый метод для поддержки конструктора — не изменяйте 
		/// содержимое этого метода с помощью редактора кода.
		/// </summary>
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
			this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.tabControl1 = new System.Windows.Forms.TabControl();
			this.Afish = new System.Windows.Forms.TabPage();
			this.groupBox2 = new System.Windows.Forms.GroupBox();
			this.groupBox1 = new System.Windows.Forms.GroupBox();
			this.label3 = new System.Windows.Forms.Label();
			this.label2 = new System.Windows.Forms.Label();
			this.label1 = new System.Windows.Forms.Label();
			this.Buying = new System.Windows.Forms.TabPage();
			this.Booking = new System.Windows.Forms.TabPage();
			this.pictureBox1 = new System.Windows.Forms.PictureBox();
			this.pictureBox7 = new System.Windows.Forms.PictureBox();
			this.pictureBox2 = new System.Windows.Forms.PictureBox();
			this.pictureBox4 = new System.Windows.Forms.PictureBox();
			this.pictureBox3 = new System.Windows.Forms.PictureBox();
			this.pictureBox6 = new System.Windows.Forms.PictureBox();
			this.pictureBox5 = new System.Windows.Forms.PictureBox();
			this.tabControl1.SuspendLayout();
			this.Afish.SuspendLayout();
			this.groupBox1.SuspendLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
			this.SuspendLayout();
			// 
			// contextMenuStrip1
			// 
			this.contextMenuStrip1.Name = "contextMenuStrip1";
			this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
			// 
			// tabControl1
			// 
			this.tabControl1.Controls.Add(this.Afish);
			this.tabControl1.Controls.Add(this.Buying);
			this.tabControl1.Controls.Add(this.Booking);
			this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
			this.tabControl1.Location = new System.Drawing.Point(0, 0);
			this.tabControl1.Name = "tabControl1";
			this.tabControl1.SelectedIndex = 0;
			this.tabControl1.Size = new System.Drawing.Size(784, 561);
			this.tabControl1.TabIndex = 2;
			// 
			// Afish
			// 
			this.Afish.Controls.Add(this.groupBox2);
			this.Afish.Controls.Add(this.pictureBox1);
			this.Afish.Controls.Add(this.groupBox1);
			this.Afish.Location = new System.Drawing.Point(4, 22);
			this.Afish.Name = "Afish";
			this.Afish.Padding = new System.Windows.Forms.Padding(3);
			this.Afish.Size = new System.Drawing.Size(776, 535);
			this.Afish.TabIndex = 0;
			this.Afish.Text = "Афиша";
			this.Afish.UseVisualStyleBackColor = true;
			// 
			// groupBox2
			// 
			this.groupBox2.Location = new System.Drawing.Point(15, 299);
			this.groupBox2.Name = "groupBox2";
			this.groupBox2.Size = new System.Drawing.Size(742, 10);
			this.groupBox2.TabIndex = 3;
			this.groupBox2.TabStop = false;
			// 
			// groupBox1
			// 
			this.groupBox1.Controls.Add(this.label3);
			this.groupBox1.Controls.Add(this.pictureBox7);
			this.groupBox1.Controls.Add(this.pictureBox2);
			this.groupBox1.Controls.Add(this.pictureBox4);
			this.groupBox1.Controls.Add(this.pictureBox3);
			this.groupBox1.Controls.Add(this.pictureBox6);
			this.groupBox1.Controls.Add(this.pictureBox5);
			this.groupBox1.Controls.Add(this.label2);
			this.groupBox1.Controls.Add(this.label1);
			this.groupBox1.Location = new System.Drawing.Point(15, 25);
			this.groupBox1.Name = "groupBox1";
			this.groupBox1.Size = new System.Drawing.Size(742, 262);
			this.groupBox1.TabIndex = 2;
			this.groupBox1.TabStop = false;
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Cursor = System.Windows.Forms.Cursors.Hand;
			this.label3.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(615, 215);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(77, 25);
			this.label3.TabIndex = 4;
			this.label3.Text = "Buy Tickets";
			this.label3.Click += new System.EventHandler(this.label3_Click);
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Agency FB", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(386, 50);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(336, 175);
			this.label2.TabIndex = 7;
			this.label2.Text = resources.GetString("label2.Text");
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Agency FB", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(381, 18);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(77, 28);
			this.label1.TabIndex = 1;
			this.label1.Text = "Name of ";
			this.label1.Click += new System.EventHandler(this.label1_Click);
			// 
			// Buying
			// 
			this.Buying.Location = new System.Drawing.Point(4, 22);
			this.Buying.Name = "Buying";
			this.Buying.Padding = new System.Windows.Forms.Padding(3);
			this.Buying.Size = new System.Drawing.Size(776, 535);
			this.Buying.TabIndex = 1;
			this.Buying.Text = "Покупка";
			this.Buying.UseVisualStyleBackColor = true;
			this.Buying.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Buying_MouseClick);
			// 
			// Booking
			// 
			this.Booking.Location = new System.Drawing.Point(4, 22);
			this.Booking.Name = "Booking";
			this.Booking.Padding = new System.Windows.Forms.Padding(3);
			this.Booking.Size = new System.Drawing.Size(776, 535);
			this.Booking.TabIndex = 2;
			this.Booking.Text = "Бронирование";
			this.Booking.UseVisualStyleBackColor = true;
			// 
			// pictureBox1
			// 
			this.pictureBox1.BackColor = System.Drawing.Color.DarkGray;
			this.pictureBox1.Location = new System.Drawing.Point(28, 43);
			this.pictureBox1.Name = "pictureBox1";
			this.pictureBox1.Size = new System.Drawing.Size(362, 227);
			this.pictureBox1.TabIndex = 0;
			this.pictureBox1.TabStop = false;
			// 
			// pictureBox7
			// 
			this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
			this.pictureBox7.Cursor = System.Windows.Forms.Cursors.Hand;
			this.pictureBox7.Image = global::LMV_LR_1_.Properties.Resources.Кнопкаа;
			this.pictureBox7.Location = new System.Drawing.Point(561, 213);
			this.pictureBox7.Name = "pictureBox7";
			this.pictureBox7.Size = new System.Drawing.Size(188, 32);
			this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox7.TabIndex = 4;
			this.pictureBox7.TabStop = false;
			this.pictureBox7.Click += new System.EventHandler(this.pictureBox7_Click);
			this.pictureBox7.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseClick);
			this.pictureBox7.MouseHover += new System.EventHandler(this.pictureBox7_MouseHover);
			this.pictureBox7.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pictureBox7_MouseUp);
			// 
			// pictureBox2
			// 
			this.pictureBox2.Image = global::LMV_LR_1_.Properties.Resources.Star_icon;
			this.pictureBox2.Location = new System.Drawing.Point(386, 213);
			this.pictureBox2.Name = "pictureBox2";
			this.pictureBox2.Size = new System.Drawing.Size(29, 32);
			this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox2.TabIndex = 2;
			this.pictureBox2.TabStop = false;
			// 
			// pictureBox4
			// 
			this.pictureBox4.Image = global::LMV_LR_1_.Properties.Resources.Star_icon;
			this.pictureBox4.Location = new System.Drawing.Point(411, 213);
			this.pictureBox4.Name = "pictureBox4";
			this.pictureBox4.Size = new System.Drawing.Size(29, 32);
			this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox4.TabIndex = 4;
			this.pictureBox4.TabStop = false;
			// 
			// pictureBox3
			// 
			this.pictureBox3.Image = global::LMV_LR_1_.Properties.Resources.Star_icon;
			this.pictureBox3.Location = new System.Drawing.Point(437, 213);
			this.pictureBox3.Name = "pictureBox3";
			this.pictureBox3.Size = new System.Drawing.Size(29, 32);
			this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox3.TabIndex = 3;
			this.pictureBox3.TabStop = false;
			this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
			// 
			// pictureBox6
			// 
			this.pictureBox6.Image = global::LMV_LR_1_.Properties.Resources.Star_icon;
			this.pictureBox6.Location = new System.Drawing.Point(462, 213);
			this.pictureBox6.Name = "pictureBox6";
			this.pictureBox6.Size = new System.Drawing.Size(29, 32);
			this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox6.TabIndex = 6;
			this.pictureBox6.TabStop = false;
			// 
			// pictureBox5
			// 
			this.pictureBox5.Image = global::LMV_LR_1_.Properties.Resources.Star_icon;
			this.pictureBox5.Location = new System.Drawing.Point(486, 213);
			this.pictureBox5.Name = "pictureBox5";
			this.pictureBox5.Size = new System.Drawing.Size(29, 32);
			this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
			this.pictureBox5.TabIndex = 5;
			this.pictureBox5.TabStop = false;
			// 
			// Form1
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(784, 561);
			this.Controls.Add(this.tabControl1);
			this.Name = "Form1";
			this.Text = "Театр";
			this.tabControl1.ResumeLayout(false);
			this.Afish.ResumeLayout(false);
			this.groupBox1.ResumeLayout(false);
			this.groupBox1.PerformLayout();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
			((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
			this.ResumeLayout(false);

		}

		#endregion

		private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
		private System.Windows.Forms.TabControl tabControl1;
		private System.Windows.Forms.TabPage Afish;
		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.PictureBox pictureBox1;
		private System.Windows.Forms.TabPage Buying;
		private System.Windows.Forms.TabPage Booking;
		private System.Windows.Forms.GroupBox groupBox2;
		private System.Windows.Forms.GroupBox groupBox1;
		private System.Windows.Forms.PictureBox pictureBox2;
		private System.Windows.Forms.PictureBox pictureBox4;
		private System.Windows.Forms.PictureBox pictureBox3;
		private System.Windows.Forms.PictureBox pictureBox6;
		private System.Windows.Forms.PictureBox pictureBox5;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.PictureBox pictureBox7;
		private System.Windows.Forms.Label label3;
	}
}

