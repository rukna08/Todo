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
            this.itemsListBox = new System.Windows.Forms.ListBox();
            this.itemTextBox = new System.Windows.Forms.TextBox();
            this.addItem = new System.Windows.Forms.Button();
            this.removeItem = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // itemsListBox
            // 
            this.itemsListBox.FormattingEnabled = true;
            this.itemsListBox.Location = new System.Drawing.Point(12, 12);
            this.itemsListBox.Name = "itemsListBox";
            this.itemsListBox.Size = new System.Drawing.Size(417, 420);
            this.itemsListBox.TabIndex = 0;
            // 
            // itemTextBox
            // 
            this.itemTextBox.Location = new System.Drawing.Point(435, 207);
            this.itemTextBox.Name = "itemTextBox";
            this.itemTextBox.Size = new System.Drawing.Size(353, 20);
            this.itemTextBox.TabIndex = 1;
            // 
            // addItem
            // 
            this.addItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addItem.Location = new System.Drawing.Point(435, 233);
            this.addItem.Name = "addItem";
            this.addItem.Size = new System.Drawing.Size(107, 59);
            this.addItem.TabIndex = 2;
            this.addItem.Text = "<- Add";
            this.addItem.UseVisualStyleBackColor = true;
            this.addItem.Click += new System.EventHandler(this.addItem_Click);
            // 
            // removeItem
            // 
            this.removeItem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.removeItem.Location = new System.Drawing.Point(574, 233);
            this.removeItem.Name = "removeItem";
            this.removeItem.Size = new System.Drawing.Size(107, 59);
            this.removeItem.TabIndex = 3;
            this.removeItem.Text = "Remove";
            this.removeItem.UseVisualStyleBackColor = true;
            this.removeItem.Click += new System.EventHandler(this.removeItem_Click);
            // 
            // TodoUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.removeItem);
            this.Controls.Add(this.addItem);
            this.Controls.Add(this.itemTextBox);
            this.Controls.Add(this.itemsListBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "TodoUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TODO";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox itemsListBox;
        private System.Windows.Forms.TextBox itemTextBox;
        private System.Windows.Forms.Button addItem;
        private System.Windows.Forms.Button removeItem;
    }
}

