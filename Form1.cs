using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace TaskManager
{
    public partial class Form1 : Form
    {
        // Lista do przechowywania zadań
        private List<TaskItem> tasks = new List<TaskItem>();

        public Form1()
        {
            InitializeComponent();
        }

        private void btnAddTask_Click(object sender, EventArgs e)
        {
            // Pobierz dane z pól
            string title = txtTitle.Text;
            string category = txtCategory.Text;
            int priority;
            DateTime dueDate = dtpDueDate.Value;

            // Walidacja danych
            if (string.IsNullOrWhiteSpace(title) || !int.TryParse(txtPriority.Text, out priority))
            {
                MessageBox.Show("Proszę podać poprawne dane dla zadania.");
                return;
            }

            // Dodaj nowe zadanie do listy
            tasks.Add(new TaskItem
            {
                Title = title,
                Category = category,
                Priority = priority,
                DueDate = dueDate
            });

            // Zaktualizuj widok
            UpdateTaskGrid();
            ClearInputFields();
        }

        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dgvTasks.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow row in dgvTasks.SelectedRows)
                {
                    TaskItem task = row.DataBoundItem as TaskItem;
                    tasks.Remove(task);
                }
                UpdateTaskGrid();
            }
            else
            {
                MessageBox.Show("Proszę zaznaczyć zadanie do usunięcia.");
            }
        }

        private void btnSortTasks_Click(object sender, EventArgs e)
        {
            tasks = tasks.OrderBy(t => t.Priority).ThenBy(t => t.DueDate).ToList();
            UpdateTaskGrid();
        }

        private void UpdateTaskGrid()
        {
            dgvTasks.DataSource = null;
            dgvTasks.DataSource = tasks;
        }

        private void ClearInputFields()
        {
            txtTitle.Clear();
            txtCategory.Clear();
            txtPriority.Clear();
            dtpDueDate.Value = DateTime.Now;
        }
        private void TextBox_Enter(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && textBox.ForeColor == System.Drawing.Color.Gray)
            {
                textBox.Text = string.Empty;
                textBox.ForeColor = System.Drawing.Color.Black;
            }
        }

        private void TextBox_Leave(object sender, EventArgs e)
        {
            TextBox textBox = sender as TextBox;

            if (textBox != null && string.IsNullOrWhiteSpace(textBox.Text))
            {
                if (textBox == txtTitle)
                {
                    textBox.Text = "Tytuł zadania";
                }
                else if (textBox == txtCategory)
                {
                    textBox.Text = "Kategoria";
                }
                else if (textBox == txtPriority)
                {
                    textBox.Text = "Priorytet (liczba)";
                }

                textBox.ForeColor = System.Drawing.Color.Gray;
            }
        }
    }

    // Klasa reprezentująca zadanie
    public class TaskItem
    {
        public string Title { get; set; }
        public string Category { get; set; }
        public int Priority { get; set; }
        public DateTime DueDate { get; set; }
    }
}
