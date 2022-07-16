namespace project4form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
        private void button1_Click(object sender, EventArgs e)
        {
            Class1 p = new Class1
            {
                Name = tb1.Text,
                date = dateTimePicker1.Text,
                id = tb2.Text,
                phonenumber = tb3.Text,

            };
            p.save();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = Class1.GetAllProducts();
        }

        // we can display error using error provider or message box 
        private void button2_Click(object sender, EventArgs e)
        {
            Class1 c = new Class1();
            c.Name = tb1.Text;
            c.date = dateTimePicker1.Text;
            c.id = tb2.Text;
            c.phonenumber = tb3.Text;

            //if (tb1.Text.Length < 3)
            //   MessageBox.Show("name must have atleast 3 letters ");
            // if (String.IsNullOrEmpty(tb1.Text))
            //   MessageBox.Show("name is required ");
            /*  else
                 {
               try
               {


               }
               catch
                   { 

                    }
                 }            
          }

       private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
       {
           //dataGridView1.DataSource = null;
           //dataGridView1.DataSource = Class1.GetAllProducts();
       }
            */

        }
     }
    }