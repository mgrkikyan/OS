using System;
using System.IO;
using System.Windows.Forms;

namespace LAB5
{
    public partial class Form1 : Form
    {
        private string currentPath;
        private string previousPath;

        public Form1()
        {
            InitializeComponent();
            currentPath = Path.GetPathRoot(Environment.SystemDirectory); // Начинаем с корневого каталога
            LoadContent();
        }

        private void LoadContent()
        {
            try
            {
                listBoxFiles.Items.Clear(); // Очищаем список
                var directories = Directory.GetDirectories(currentPath);
                var files = Directory.GetFiles(currentPath);

                // Добавляем директории в список
                foreach (var dir in directories)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(dir) + " [Folder]");
                }

                // Добавляем файлы в список
                foreach (var file in files)
                {
                    listBoxFiles.Items.Add(Path.GetFileName(file));
                }
            }
            catch (UnauthorizedAccessException)
            {
                MessageBox.Show("Нет доступа к данному каталогу.", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (listBoxFiles.SelectedItem != null)
            {
                string selectedItem = listBoxFiles.SelectedItem.ToString();
                string selectedPath = Path.Combine(currentPath, selectedItem.Replace(" [Folder]", ""));

                if (Directory.Exists(selectedPath)) // Проверяем, является ли выбранный элемент папкой
                {
                    previousPath = currentPath; // Сохраняем предыдущий путь
                    currentPath = selectedPath;
                    LoadContent();
                }
                else
                {
                    MessageBox.Show($"{selectedItem} - это файл, а не каталог.", "Информация", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Выберите элемент из списка.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(previousPath))
            {
                currentPath = previousPath;
                previousPath = Path.GetDirectoryName(currentPath);
                LoadContent();
            }
            else
            {
                MessageBox.Show("Вы находитесь в корневом каталоге.", "Предупреждение", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}

