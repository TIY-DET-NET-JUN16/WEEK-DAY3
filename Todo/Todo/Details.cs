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
    public partial class DetailsForm : Form
    {
        public TodoItem NewItem { get; set; }

        public DetailsForm()
        {
            InitializeComponent();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            TodoItem item = new TodoItem();
            item.Title = textBoxTitle.Text;
            item.Details = textBoxDetails.Text;
            NewItem = item;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            NewItem = new TodoItem();
            this.Close();
        }
    }
}
