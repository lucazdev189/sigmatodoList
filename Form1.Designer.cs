namespace todolistApp
{
    partial class Form1
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
            titletextBox = new TextBox();
            label2 = new Label();
            label3 = new Label();
            descriptiontextBox = new TextBox();
            newButton = new Button();
            editButton = new Button();
            deleteButton = new Button();
            saveButton = new Button();
            todolistView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)todolistView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.Font = new Font("Comic Sans MS", 21.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(1117, 61);
            label1.TabIndex = 0;
            label1.Text = "To-Do List";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // titletextBox
            // 
            titletextBox.Location = new Point(12, 88);
            titletextBox.Name = "titletextBox";
            titletextBox.Size = new Size(1117, 24);
            titletextBox.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(12, 62);
            label2.Name = "label2";
            label2.Size = new Size(46, 23);
            label2.TabIndex = 2;
            label2.Text = "Title";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Comic Sans MS", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 115);
            label3.Name = "label3";
            label3.Size = new Size(96, 23);
            label3.TabIndex = 3;
            label3.Text = "Description";
            // 
            // descriptiontextBox
            // 
            descriptiontextBox.Location = new Point(12, 141);
            descriptiontextBox.Name = "descriptiontextBox";
            descriptiontextBox.Size = new Size(1117, 24);
            descriptiontextBox.TabIndex = 4;
            // 
            // newButton
            // 
            newButton.Location = new Point(134, 171);
            newButton.Name = "newButton";
            newButton.Size = new Size(182, 43);
            newButton.TabIndex = 5;
            newButton.Text = "New";
            newButton.UseVisualStyleBackColor = true;
            newButton.Click += newButton_Click;
            // 
            // editButton
            // 
            editButton.Location = new Point(361, 171);
            editButton.Name = "editButton";
            editButton.Size = new Size(182, 43);
            editButton.TabIndex = 6;
            editButton.Text = "Edit";
            editButton.UseVisualStyleBackColor = true;
            editButton.Click += editButton_Click;
            // 
            // deleteButton
            // 
            deleteButton.Location = new Point(592, 171);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(182, 43);
            deleteButton.TabIndex = 7;
            deleteButton.Text = "Delete";
            deleteButton.UseVisualStyleBackColor = true;
            deleteButton.Click += deleteButton_Click;
            // 
            // saveButton
            // 
            saveButton.Location = new Point(820, 171);
            saveButton.Name = "saveButton";
            saveButton.Size = new Size(182, 43);
            saveButton.TabIndex = 8;
            saveButton.Text = "Save";
            saveButton.UseVisualStyleBackColor = true;
            saveButton.Click += button3_Click;
            // 
            // todolistView
            // 
            todolistView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            todolistView.BackgroundColor = Color.OliveDrab;
            todolistView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            todolistView.Location = new Point(12, 235);
            todolistView.Name = "todolistView";
            todolistView.Size = new Size(1117, 436);
            todolistView.TabIndex = 9;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.DarkOliveGreen;
            ClientSize = new Size(1141, 683);
            Controls.Add(todolistView);
            Controls.Add(saveButton);
            Controls.Add(deleteButton);
            Controls.Add(editButton);
            Controls.Add(newButton);
            Controls.Add(descriptiontextBox);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(titletextBox);
            Controls.Add(label1);
            Font = new Font("Comic Sans MS", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Margin = new Padding(4);
            Name = "Form1";
            Text = "Sigma To-Do List App";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)todolistView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox titletextBox;
        private Label label2;
        private Label label3;
        private TextBox descriptiontextBox;
        private Button newButton;
        private Button editButton;
        private Button deleteButton;
        private Button saveButton;
        private DataGridView todolistView;
    }
}
