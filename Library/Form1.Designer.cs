namespace Library
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
            panel1 = new Panel();
            markAsReaden = new Button();
            jenreTextBox = new TextBox();
            yearTextBox = new TextBox();
            authorTextBox = new TextBox();
            nameTextBox = new TextBox();
            addButton = new Button();
            removeButton = new Button();
            libraryDataGrid = new DataGridView();
            name = new DataGridViewTextBoxColumn();
            author = new DataGridViewTextBoxColumn();
            year = new DataGridViewTextBoxColumn();
            genre = new DataGridViewTextBoxColumn();
            status = new DataGridViewTextBoxColumn();
            redactBookButton = new Button();
            saveBookInfoButton = new Button();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)libraryDataGrid).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(saveBookInfoButton);
            panel1.Controls.Add(redactBookButton);
            panel1.Controls.Add(markAsReaden);
            panel1.Controls.Add(jenreTextBox);
            panel1.Controls.Add(yearTextBox);
            panel1.Controls.Add(authorTextBox);
            panel1.Controls.Add(nameTextBox);
            panel1.Controls.Add(addButton);
            panel1.Controls.Add(removeButton);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(693, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 586);
            panel1.TabIndex = 1;
            // 
            // markAsReaden
            // 
            markAsReaden.Dock = DockStyle.Bottom;
            markAsReaden.Location = new Point(0, 409);
            markAsReaden.Name = "markAsReaden";
            markAsReaden.Size = new Size(281, 59);
            markAsReaden.TabIndex = 6;
            markAsReaden.Text = "Отметить прочитанной";
            markAsReaden.UseVisualStyleBackColor = true;
            markAsReaden.Click += markAsReaden_Click;
            // 
            // jenreTextBox
            // 
            jenreTextBox.Dock = DockStyle.Top;
            jenreTextBox.Location = new Point(0, 69);
            jenreTextBox.Name = "jenreTextBox";
            jenreTextBox.PlaceholderText = "Жанр";
            jenreTextBox.Size = new Size(281, 23);
            jenreTextBox.TabIndex = 4;
            // 
            // yearTextBox
            // 
            yearTextBox.Dock = DockStyle.Top;
            yearTextBox.Location = new Point(0, 46);
            yearTextBox.Name = "yearTextBox";
            yearTextBox.PlaceholderText = "Год издания";
            yearTextBox.Size = new Size(281, 23);
            yearTextBox.TabIndex = 3;
            // 
            // authorTextBox
            // 
            authorTextBox.Dock = DockStyle.Top;
            authorTextBox.Location = new Point(0, 23);
            authorTextBox.Name = "authorTextBox";
            authorTextBox.PlaceholderText = "Автор";
            authorTextBox.Size = new Size(281, 23);
            authorTextBox.TabIndex = 2;
            // 
            // nameTextBox
            // 
            nameTextBox.Dock = DockStyle.Top;
            nameTextBox.Location = new Point(0, 0);
            nameTextBox.Name = "nameTextBox";
            nameTextBox.PlaceholderText = "Название";
            nameTextBox.Size = new Size(281, 23);
            nameTextBox.TabIndex = 1;
            // 
            // addButton
            // 
            addButton.Dock = DockStyle.Bottom;
            addButton.Location = new Point(0, 468);
            addButton.Name = "addButton";
            addButton.Size = new Size(281, 59);
            addButton.TabIndex = 0;
            addButton.Text = "Добавить";
            addButton.UseVisualStyleBackColor = true;
            addButton.Click += addButton_Click;
            // 
            // removeButton
            // 
            removeButton.Dock = DockStyle.Bottom;
            removeButton.Location = new Point(0, 527);
            removeButton.Name = "removeButton";
            removeButton.Size = new Size(281, 59);
            removeButton.TabIndex = 0;
            removeButton.Text = "Удалить";
            removeButton.UseVisualStyleBackColor = true;
            removeButton.Click += removeButton_Click;
            // 
            // libraryDataGrid
            // 
            libraryDataGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            libraryDataGrid.Columns.AddRange(new DataGridViewColumn[] { name, author, year, genre, status });
            libraryDataGrid.Dock = DockStyle.Fill;
            libraryDataGrid.Location = new Point(0, 0);
            libraryDataGrid.Name = "libraryDataGrid";
            libraryDataGrid.Size = new Size(693, 586);
            libraryDataGrid.TabIndex = 2;
            libraryDataGrid.RowHeaderMouseClick += libraryDataGrid_RowHeaderMouseClick;
            // 
            // name
            // 
            name.HeaderText = "Название";
            name.Name = "name";
            // 
            // author
            // 
            author.HeaderText = "Автор";
            author.Name = "author";
            // 
            // year
            // 
            year.HeaderText = "Год";
            year.Name = "year";
            // 
            // genre
            // 
            genre.HeaderText = "Жанр";
            genre.Name = "genre";
            // 
            // status
            // 
            status.HeaderText = "Статус";
            status.Name = "status";
            // 
            // redactBookButton
            // 
            redactBookButton.Dock = DockStyle.Bottom;
            redactBookButton.Location = new Point(0, 350);
            redactBookButton.Name = "redactBookButton";
            redactBookButton.Size = new Size(281, 59);
            redactBookButton.TabIndex = 7;
            redactBookButton.Text = "Редактировать";
            redactBookButton.UseVisualStyleBackColor = true;
            redactBookButton.Click += redactBookButton_Click;
            // 
            // saveBookInfoButton
            // 
            saveBookInfoButton.Dock = DockStyle.Bottom;
            saveBookInfoButton.Location = new Point(0, 291);
            saveBookInfoButton.Name = "saveBookInfoButton";
            saveBookInfoButton.Size = new Size(281, 59);
            saveBookInfoButton.TabIndex = 8;
            saveBookInfoButton.Text = "Сохранить изменения";
            saveBookInfoButton.UseVisualStyleBackColor = true;
            saveBookInfoButton.Click += saveBookInfoButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(974, 586);
            Controls.Add(libraryDataGrid);
            Controls.Add(panel1);
            Name = "Form1";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)libraryDataGrid).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Button addButton;
        private Button removeButton;
        private DataGridView libraryDataGrid;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn author;
        private DataGridViewTextBoxColumn year;
        private DataGridViewTextBoxColumn genre;
        private DataGridViewTextBoxColumn status;
        private TextBox nameTextBox;
        private Button markAsReaden;
        private TextBox jenreTextBox;
        private TextBox yearTextBox;
        private TextBox authorTextBox;
        private Button saveBookInfoButton;
        private Button redactBookButton;
    }
}
