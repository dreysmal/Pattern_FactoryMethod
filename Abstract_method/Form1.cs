using System;
using System.Drawing;
using System.Windows.Forms;

namespace Abstract_method
{
    public partial class Form1 : Form, Ichoose
    {
        public Form1()
        {
            InitializeComponent();
            listBox1.SelectedIndex = 0;
        }
        #region дисплей
        public Boolean Display1
        {
            get
            {
                return label1.Visible;
            }
            set
            {
                label1.Visible = value;
            }
        }
        public Boolean Display2
        {
            get
            {
                return label2.Visible;
            }
            set
            {
                label2.Visible = value;
            }
        }
        public Boolean Display3
        {
            get
            {
                return label3.Visible;
            }
            set
            {
                label3.Visible = value;
            }
        }
        public Boolean Display4
        {
            get
            {
                return label4.Visible;
            }
            set
            {
                label4.Visible = value;
            }
        }
        public Boolean Display5
        {
            get
            {
                return label5.Visible;
            }
            set
            {
                label5.Visible = value;
            }
        }
        public Boolean Display6
        {
            get
            {
                return label6.Visible;
            }
            set
            {
                label6.Visible = value;
            }
        }
        public Boolean Display7
        {
            get
            {
                return label7.Visible;
            }
            set
            {
                label7.Visible = value;
            }
        }
        public Boolean Display8
        {
            get
            {
                return label8.Visible;
            }
            set
            {
                label8.Visible = value;
            }
        }
        public Boolean Display9
        {
            get
            {
                return label9.Visible;
            }
            set
            {
                label9.Visible = value;
            }
        }
        public Boolean Display10
        {
            get
            {
                return label10.Visible;
            }
            set
            {
                label10.Visible = value;
            }
        }
        public Boolean Display11
        {
            get
            {
                return label11.Visible;
            }
            set
            {
                label11.Visible = value;
            }
        }
        public Boolean Display12
        {
            get
            {
                return label12.Visible;
            }
            set
            {
                label12.Visible = value;
            }
        }
        public Boolean Display13
        {
            get
            {
                return label13.Visible;
            }
            set
            {
                label13.Visible = value;
            }
        }
        public Boolean Display14
        {
            get
            {
                return label14.Visible;
            }
            set
            {
                label14.Visible = value;
            }
        }
        public Boolean Display15
        {
            get
            {
                return label15.Visible;
            }
            set
            {
                label15.Visible = value;
            }
        }
        public Boolean Display16
        {
            get
            {
                return label16.Visible;
            }
            set
            {
                label16.Visible = value;
            }
        }
        #endregion

        public String Color_
        {
            get
            {
                return listBox1.SelectedItem.ToString();
            }
            set
            {
                label_color(value);
            }
        }

        public new String Name
        {
            get
            {
                return string.Empty;
            }
            set
            {
                button9.Text = value;
            }
        }

        public event mydelegate choosing;


        private void button1_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Cross");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Zig_Zag_Left");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Angle_Left");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Zig_Zag_Right");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Angle_Right");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            choosing?.Invoke(Color_, "Pillar");
        }


        private void label_color(String color)
        {
            switch (color)
            {
                case "Yellow":
                    foreach (Control item in Controls)
                    {
                        if(item is Label)
                        {
                            item.BackColor = Color.Yellow;
                        }
                    }
                    break;
                case "Red":
                    foreach (Control item in Controls)
                    {
                        if (item is Label)
                        {
                            item.BackColor = Color.Red;
                        }
                    }
                    break;
                case "Green":
                    foreach (Control item in Controls)
                    {
                        if (item is Label)
                        {
                            item.BackColor = Color.Green;
                        }
                    }
                    break;
                case "Gold":
                    foreach (Control item in Controls)
                    {
                        if (item is Label)
                        {
                            item.BackColor = Color.Gold;
                        }
                    }
                    break;
                case "Blue":
                    foreach (Control item in Controls)
                    {
                        if (item is Label)
                        {
                            item.BackColor = Color.Blue;
                        }
                    }
                    break;
                case "DarkBlue":
                    foreach (Control item in Controls)
                    {
                        if (item is Label)
                        {
                            item.BackColor = Color.DarkBlue;
                        }
                    }
                    break;
                default:
                    break;
            }
        }
    }
}
