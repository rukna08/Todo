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

        }

        private void addItem_Click(object sender, EventArgs e) {

            if (itemsTextBox.Text != string.Empty) {
            
                todo.items.Add(new Item { Text = itemsTextBox.Text });

                itemsListBox.Items.Add(todo.items[todo.items.Count - 1].Text);

                itemsTextBox.Text = string.Empty;
            
            }

        }

        private void removeItem_Click(object sender, EventArgs e) {

            string selectedItem = (string)itemsListBox.SelectedItem;

            Item tempItem = new Item() {

                Text = selectedItem
            
            };

            todo.items.Remove(tempItem);

            itemsListBox.Items.Remove(selectedItem);

        }

        private void saveItems_Click(object sender, EventArgs e) {

            binaryWriter = new BinaryWriter(new FileStream("itemdata", FileMode.Create));

            foreach(Item item in todo.items) {
                binaryWriter.Write(item.Text);
            }

        }

        private void loadPreviousState_Click(object sender, EventArgs e) {

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

        }

    }

}