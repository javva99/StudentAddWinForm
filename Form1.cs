namespace studentform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string firstname = tbname.Text;
            string secondname = tbsurname.Text;
            string id = tbid.Text;

            if (string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(secondname) ||
                string.IsNullOrWhiteSpace(id))
            {
                MessageBox.Show("All boxes must be filled");
                return;
            }

            Client NewClient = new Client(firstname, secondname, id);

            MessageBox.Show(NewClient.ToString());

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}