namespace TestWin_DIan
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void lblEgn_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Person person = new Person();
            person.Name = txtName.Text;
            person.Secondname = txtSecondName.Text;
            person.Lastname = txtLastName.Text;
            if (CheckMale.Checked)
            {
                person.Gender = CheckMale.Text;
            }
            if (checkWoman.Checked)
            {
                person.Gender = checkWoman.Text;
            }
            if (rbCountryServicer.Checked)
            {
                person.Job = rbCountryServicer.Text;
            }
            if (rbPrivate.Checked)
            {
                person.Job = rbPrivate.Text;
            }
            if (rbJobless.Checked)
            {
                person.Job = rbJobless.Text;
            }
            if(string.IsNullOrEmpty(txtName.Text)) 
            {
                MessageBox.Show("You haven't entered Name");
            }
            if (string.IsNullOrEmpty(txtLastName.Text))
            {
                MessageBox.Show("You haven't entered Last name");
            }
            if (string.IsNullOrEmpty(txtEgn.Text))
            {
                MessageBox.Show("You haven't entered EGN");
            }
            if (string.IsNullOrEmpty(grpGender.Text))
            {
                MessageBox.Show("You haven't choosed Gender");
            }
            if (string.IsNullOrEmpty(grpJob.Text))
            {
                MessageBox.Show("You haven't choosed Job Sphere");
            }

            List<Person> list = new List<Person>();
            MessageBox.Show($"Name: {txtName.Text}, Second Name: {txtSecondName.Text}, Last Name: {txtLastName.Text}, Egn: {txtEgn.Text}, Gender: {grpGender}, Job:{grpJob}");

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            txtName.Clear();
            txtSecondName.Clear();
            txtLastName.Clear();
            txtEgn.Clear();
            
        }
    }
}