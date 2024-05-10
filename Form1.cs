using System.Data;

namespace todolistApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        DataTable todoList = new DataTable();
        bool isEditing = false;
        private void Form1_Load(object sender, EventArgs e)
        {
            todoList.Columns.Add("Title");
            todoList.Columns.Add("Description");

            todolistView.DataSource = todoList;
        }

        private void newButton_Click(object sender, EventArgs e)
        {
            titletextBox.Text = "";
            descriptiontextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;

            titletextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptiontextBox.Text = todoList.Rows[todolistView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                todoList.Rows[todolistView.CurrentCell.RowIndex].Delete();
            }
            catch(Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Title"] = titletextBox.Text;
                todoList.Rows[todolistView.CurrentCell.RowIndex]["Description"] = titletextBox.Text;
            }
            else
            {
                todoList.Rows.Add(titletextBox.Text, descriptiontextBox.Text);
            }
            titletextBox.Text = "";
            descriptiontextBox.Text = "";
            isEditing = false;

        }

    }
}
