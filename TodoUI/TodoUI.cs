using System;
using System.IO;
using System.Windows.Forms;
using TodoLibrary;

namespace TodoUI {
    
    public partial class TodoUI : Form {
        
        private Todo todo = new Todo();

        private BinaryWriter binaryWriter;

        private BinaryReader binaryReader;

        public TodoUI() {

            InitializeComponent();

            LoadItems();

        }

        private void addItem_Click(object sender, EventArgs e) {

            if (itemsTextBox.Text != string.Empty) {
            
                todo.items.Add(new Item { Text = itemsTextBox.Text });

                itemsListBox.Items.Add(todo.items[todo.items.Count - 1].Text);

                itemsTextBox.Text = string.Empty;
            
            }

        }

        private void removeItem_Click(object sender, EventArgs e) {

            string selectedItemString = (string)itemsListBox.SelectedItem;

            Item itemToBeRemoved = null;

            for (int i = 0; i < todo.items.Count; i++) {

                if (todo.items[i].Text == selectedItemString) {

                    itemToBeRemoved = todo.items[i];

                    break;

                }

            }

            if (itemToBeRemoved != null) {
                
                todo.items.Remove(itemToBeRemoved);

            }


            itemsListBox.Items.Remove(selectedItemString);

        }

        private void saveItems_Click(object sender, EventArgs e) {

            if (File.Exists("itemdata")) {

                File.Delete("itemdata");

            }

            binaryWriter = new BinaryWriter(new FileStream("itemdata", FileMode.Create));

            foreach(Item item in todo.items) {
                binaryWriter.Write(item.Text);
            }

            binaryWriter.Close();

            MessageBox.Show("Items saved!");

        }

        private void loadPreviousState_Click(object sender, EventArgs e) {

            LoadItems();

        }

        private void clearItems_Click(object sender, EventArgs e) {

            itemsListBox.Items.Clear();

            todo.items.Clear();

        }

        private void LoadItems() {

            if (File.Exists("itemdata")) {

                itemsListBox.Items.Clear();

                todo.items.Clear();

                binaryReader = new BinaryReader(new FileStream("itemdata", FileMode.Open));

                string currentString;

                do {

                    currentString = binaryReader.ReadString();

                    Item tempItem = new Item() {

                        Text = currentString

                    };

                    todo.items.Add(tempItem);

                } while (binaryReader.PeekChar() != -1);

                int i = 0;

                foreach (Item item in todo.items) {

                    itemsListBox.Items.Add(todo.items[i].Text);

                    i++;

                }

                binaryReader.Close();

            }

        }

    }

}