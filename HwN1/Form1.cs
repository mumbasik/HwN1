namespace HwN1
{
    public partial class Form1 : Form
    {
        Form notmodal = new Form();
        Form modal = new Form();
        public Form1()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
            this.Text = "MyApplication1";
            this.Size = new Size(400, 300);
            this.BackColor = Color.LightGray;
            button1.Size = new Size(100, 100);
            button1.BackColor = Color.Gray;
            button2.Size = new Size(100, 100);
            button2.BackColor = Color.Gray;
            button3.Size = new Size(100, 100);
            button3.BackColor = Color.Gray;

            notmodal.Text = "Not modal";
            modal.Text = "Modal";


        }



        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("This is Application", "MyApplication", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            notmodal.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            modal.ShowDialog();
        }
    }
}
