using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Todo
{
    public partial class MainForm : Form
    {
        List<TodoItem> _items = new List<TodoItem>();

        public MainForm()
        {
            InitializeComponent();

            Button newButton = new Button();
            newButton.Text = "this is a new one";
            newButton.Location = new Point(3, 107);
            newButton.Width = 121;
            newButton.Anchor = AnchorStyles.Right;
            panelButtons.Controls.Add(newButton);
        }

        private void create_Click(object sender, EventArgs e)
        {
            DetailsForm details = new DetailsForm();
            details.FormClosing += Details_FormClosing;
            details.Show();
        }

        private void Details_FormClosing(object sender, FormClosingEventArgs e)
        {
            DetailsForm newForm = sender as DetailsForm;
            TodoItem item = newForm.NewItem;
            _items.Add(item);

            listViewTodos.Clear();

            foreach(TodoItem listItem in _items)
            {
                listViewTodos.Items.Add(new ListViewItem(listItem.Title));
            }
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Visible = true;
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            button1.Text = "Clicked Delete";
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            label2.Text = "this is a bunch more text";
        }
    }
}
