namespace Library
{
    public partial class Form1 : Form
    {
        List<Book> booksList;
        public Form1()
        {
            InitializeComponent();
            booksList = new List<Book>();
        }


        private void addButton_Click(object sender, EventArgs e)
        {
            try
            {
                string name = nameTextBox.Text;
                string author = authorTextBox.Text;
                int year = int.Parse(yearTextBox.Text);
                string jenre = jenreTextBox.Text;

                Book book = new Book(name, author, year, jenre);

                booksList.Add(book);

            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка считывания данных.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            try
            {
                foreach (Book book in booksList)
                {
                    object[] rowValues = new object[] { book.Name, book.Author, book.YearOfPublication, book.Jenre, book.IsReaden ? "Прочтена" : "В процессе" };
                    libraryDataGrid.Rows.Add(rowValues);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления в список книг.", "Ошибка", MessageBoxButtons.OKCancel, MessageBoxIcon.Error);
            }

            Clear_Inputs();
        }

        private void removeButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libraryDataGrid.SelectedRows.Count > 0)
                {
                    int selectedIndex = libraryDataGrid.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < booksList.Count)
                    {
                        booksList.RemoveAt(selectedIndex);
                        libraryDataGrid.Rows.Clear();
                        foreach (Book book in booksList)
                        {
                            object[] rowValues = new object[] { book.Name, book.Author, book.YearOfPublication, book.Jenre, book.IsReaden ? "Прочтена" : "В процессе" };
                            libraryDataGrid.Rows.Add(rowValues);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Выберите книгу для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Выберите книгу для удаления.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка удаления книги.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void libraryDataGrid_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
        }

        private void Clear_Inputs()
        {
            nameTextBox.Clear();
            yearTextBox.Clear();
            jenreTextBox.Clear();
            yearTextBox.Clear();
        }

        private void markAsReaden_Click(object sender, EventArgs e)
        {
            try
            {
                if (libraryDataGrid.SelectedRows.Count > 0)
                {
                    int selectedIndex = libraryDataGrid.SelectedRows[0].Index;
                    if (selectedIndex >= 0 && selectedIndex < booksList.Count)
                    {
                        booksList[selectedIndex].IsReaden = true;

                        libraryDataGrid.Rows.Clear();

                        foreach (Book book in booksList)
                        {
                            object[] rowValues = new object[] { book.Name, book.Author, book.YearOfPublication, book.Jenre, book.IsReaden ? "Прочтена" : "В процессе" };
                            libraryDataGrid.Rows.Add(rowValues);
                        }
                    }

                    else
                    {
                        MessageBox.Show("Выберите книгу для изменения статуса.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }

                else
                {
                    MessageBox.Show("Выберите книгу для изменения статуса.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка изменения статуса.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void redactBookButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (libraryDataGrid.SelectedRows.Count > 0)
                {

                }
            }

            catch
            {
                MessageBox.Show("Ошибка редактирования.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void saveBookInfoButton_Click(object sender, EventArgs e)
        {

        }
    }
}
