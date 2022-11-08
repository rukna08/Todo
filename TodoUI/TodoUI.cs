using System;
using System.Windows.Forms;
using TodoLibrary;

namespace TodoUI {
    
    public partial class TodoUI : Form {
        
        private Todo todo = new Todo();

        public TodoUI() {

            InitializeComponent();

        }

        private void addItem_Click(object sender, EventArgs e) {
            
            todo.items.Add(new Item { Text = itemsTextBox.Text });

            itemsListBox.Items.Add(todo.items[todo.items.Count - 1].Text);

            itemsTextBox.Text = string.Empty;

        }

        private void removeItem_Click(object sender, EventArgs e) {

            string selectedItem = (string)itemsListBox.SelectedItem;

            Item tempItem = new Item() {
                Text = selectedItem
            };

            todo.items.Remove(tempItem);

            itemsListBox.Items.Remove(selectedItem);

        }

    }

}