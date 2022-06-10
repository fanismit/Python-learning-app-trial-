namespace ekpaideytikologismiko
{
    public partial class Form1 : Form
    {
        //private Form2 connection_form;       
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ControlBox = false;
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_SizeChanged(object sender, EventArgs e)
        {
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
            this.Hide();
            Form2 connection_form = new Form2();
            connection_form.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
            
        }

        private void resize_control(Rectangle r,Control c)
        {
    
            
        }
        private void Form1_Resize(object sender, EventArgs e)
        {
   
        }
    }
}