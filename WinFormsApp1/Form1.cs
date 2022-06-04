namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<Employee> data = new List<Employee>(new[] {
                new Employee { Id = 1, Name = "Lorem", LastName = "Ipsum" },
                new Employee { Id = 2, Name = "Dolor Sit", LastName = "Amet" }
            });

            listBox1.DataSource = data;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int id = (listBox1.SelectedValue is null) ? -1 : (int)listBox1.SelectedValue;
            Employee? employee = listBox1.SelectedItem as Employee;
            if (employee is null)
            {
                listBox2.Items.Add("No item selected");
            }
            else
            {
                listBox2.Items.Add($"Selected item {employee.Name} with id {id}.");
            }
        }
    }
}