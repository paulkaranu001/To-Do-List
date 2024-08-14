namespace To_Do_List
{
    partial class ToDoList
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            titleTextBox = new TextBox();
            descriptionTextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            newbutton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            SaveButton = new Button();
            ToDoListView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)ToDoListView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Georgia", 36F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(21, 7);
            label1.Name = "label1";
            label1.Size = new Size(1329, 77);
            label1.TabIndex = 0;
            label1.Text = "To Do List ";
            label1.TextAlign = ContentAlignment.TopCenter;
            label1.Click += label1_Click;
            // 
            // titleTextBox
            // 
            titleTextBox.Location = new Point(21, 109);
            titleTextBox.Name = "titleTextBox";
            titleTextBox.Size = new Size(1329, 27);
            titleTextBox.TabIndex = 1;
            // 
            // descriptionTextBox
            // 
            descriptionTextBox.Location = new Point(21, 167);
            descriptionTextBox.Name = "descriptionTextBox";
            descriptionTextBox.Size = new Size(1329, 27);
            descriptionTextBox.TabIndex = 2;
            // 
            // label2
            // 
            label2.Location = new Point(21, 136);
            label2.Name = "label2";
            label2.Size = new Size(325, 25);
            label2.TabIndex = 3;
            label2.Text = "Description:";
            // 
            // label3
            // 
            label3.Location = new Point(21, 71);
            label3.Name = "label3";
            label3.Size = new Size(325, 25);
            label3.TabIndex = 4;
            label3.Text = "Title:";
            label3.Click += label3_Click;
            // 
            // newbutton
            // 
            newbutton.Location = new Point(21, 216);
            newbutton.Name = "newbutton";
            newbutton.Size = new Size(300, 51);
            newbutton.TabIndex = 5;
            newbutton.Text = "NEW";
            newbutton.UseVisualStyleBackColor = true;
            newbutton.Click += newbutton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(374, 216);
            editButton.Name = "editButton";
            editButton.Size = new Size(300, 51);
            editButton.TabIndex = 6;
            editButton.Text = "EDIT";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(716, 216);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(300, 51);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "DELETE";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(1051, 216);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(300, 51);
            SaveButton.TabIndex = 8;
            SaveButton.Text = "SAVE";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // ToDoListView
            // 
            ToDoListView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            ToDoListView.BackgroundColor = Color.White;
            ToDoListView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            ToDoListView.Location = new Point(21, 295);
            ToDoListView.Name = "ToDoListView";
            ToDoListView.RowHeadersWidth = 51;
            ToDoListView.Size = new Size(1346, 588);
            ToDoListView.TabIndex = 9;
            // 
            // ToDoList
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Fuchsia;
            ClientSize = new Size(1362, 872);
            Controls.Add(ToDoListView);
            Controls.Add(SaveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newbutton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(descriptionTextBox);
            Controls.Add(titleTextBox);
            Controls.Add(label1);
            Name = "ToDoList";
            Text = "To Do List ";
            Load += toDoList_Load;
            ((System.ComponentModel.ISupportInitialize)ToDoListView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titleTextBox;
        private TextBox descriptionTextBox;
        private Label label2;
        private Label label3;
        private Button newbutton;
        private Button editButton;
        private Button deleteButton;
        private Button SaveButton;
        private DataGridView ToDoListView;
    }
}
