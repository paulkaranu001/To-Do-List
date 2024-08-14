using System.Data;

namespace To_Do_List
{
    public partial class ToDoList : Form
    {
        public ToDoList()
        {
            InitializeComponent();
        }
        DataTable toDoList = new DataTable();
        bool isEditing = false;


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void toDoList_Load(object sender, EventArgs e)
        {
            // create columns 
            toDoList.Columns.Add("Title");
            toDoList.Columns.Add("Description");

            // point our datagridview to our datasource 
            ToDoListView.DataSource = toDoList;

        }

        private void newbutton_Click(object sender, EventArgs e)
        {
            titleTextBox.Text = "";
            descriptionTextBox.Text = "";
        }

        private void editButton_Click(object sender, EventArgs e)
        {
            isEditing = true;
            // fill Text field with data from table
            titleTextBox.Text = toDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[0].ToString();
            descriptionTextBox.Text = toDoList.Rows[ToDoListView.CurrentCell.RowIndex].ItemArray[1].ToString();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            try
            {
                toDoList.Rows[ToDoListView.CurrentCell.RowIndex].Delete();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error: " + ex);
            }


        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(isEditing)
            {
                toDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Title"] = titleTextBox.Text;
                toDoList.Rows[ToDoListView.CurrentCell.RowIndex]["Description"] = descriptionTextBox.Text;

            }
            else
            {
                toDoList.Rows.Add(titleTextBox.Text, descriptionTextBox.Text);

                // clear fields 
                titleTextBox.Text = "";
                descriptionTextBox.Text = "";
                isEditing = false;
                    

            }
        }
    }
}
