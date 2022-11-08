namespace TodoUI {
    partial class TodoUI {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TodoUI));
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemsTextBox = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.saveItems = new System.Windows.Forms.Button();
            this.loadPreviousState = new System.Windows.Forms.Button();
            this.clearItems = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.ItemHeight = 20;
            this.itemsListBox.Location = new System.Drawing.Point(12, 12);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(417, 404);
            this.itemsListBox.TabIndex = 0;
            // 
            // itemsTextBox
            // 
            this.itemsTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.itemsTextBox.Location = new System.Drawing.Point(12, 422);
            this.itemsTextBox.Name = "itemsTextBox";
            this.itemsTextBox.Size = new System.Drawing.Size(417, 26);
            this.itemsTextBox.TabIndex = 1;
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(12, 454);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(107, 59);
            this.addItem.TabIndex = 2;
            this.addItem.Text = "Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.Location = new System.Drawing.Point(125, 454);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(107, 59);
            this.removeItem.TabIndex = 3;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // saveItems
            // 
            this.saveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.saveItems.Location = new System.Drawing.Point(12, 524);
            this.saveItems.Name = "saveItems";
            this.saveItems.Size = new System.Drawing.Size(107, 59);
            this.saveItems.TabIndex = 4;
            this.saveItems.Text = "Save";
            this.saveItems.UseVisualStyleBackColor = true;
            this.saveItems.Click += new System.EventHandler(this.saveItems_Click);
            // 
            // loadPreviousState
            // 
            this.loadPreviousState.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.loadPreviousState.Location = new System.Drawing.Point(125, 524);
            this.loadPreviousState.Name = "loadPreviousState";
            this.loadPreviousState.Size = new System.Drawing.Size(107, 59);
            this.loadPreviousState.TabIndex = 5;
            this.loadPreviousState.Text = "Load";
            this.loadPreviousState.UseVisualStyleBackColor = true;
            this.loadPreviousState.Click += new System.EventHandler(this.loadPreviousState_Click);
            // 
            // clearItems
            // 
            this.clearItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.clearItems.Location = new System.Drawing.Point(238, 454);
            this.clearItems.Name = "clearItems";
            this.clearItems.Size = new System.Drawing.Size(107, 59);
            this.clearItems.TabIndex = 6;
            this.clearItems.Text = "Clear";
            this.clearItems.UseVisualStyleBackColor = true;
            this.clearItems.Click += new System.EventHandler(this.clearItems_Click);
            // 
            // TodoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 595);
            this.Controls.Add(this.clearItems);
            this.Controls.Add(this.loadPreviousState);
            this.Controls.Add(this.saveItems);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemsTextBox);
            this.Controls.Add(this.itemsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "TodoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox itemsTextBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
        private System.Windows.Forms.Button saveItems;
        private System.Windows.Forms.Button loadPreviousState;
        private System.Windows.Forms.Button clearItems;
    }
}

