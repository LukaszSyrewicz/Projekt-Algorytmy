namespace TaskManager
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtCategory = new System.Windows.Forms.TextBox();
            this.txtPriority = new System.Windows.Forms.TextBox();
            this.dtpDueDate = new System.Windows.Forms.DateTimePicker();
            this.btnAddTask = new System.Windows.Forms.Button();
            this.btnDeleteTask = new System.Windows.Forms.Button();
            this.btnSortTasks = new System.Windows.Forms.Button();
            this.dgvTasks = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).BeginInit();
            this.SuspendLayout();

            // txtTitle
            this.txtTitle.Location = new System.Drawing.Point(12, 12);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(200, 23);
            this.txtTitle.Text = "Tytuł zadania";
            this.txtTitle.ForeColor = System.Drawing.Color.Gray;
            this.txtTitle.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtTitle.Leave += new System.EventHandler(this.TextBox_Leave);

            // txtCategory
            this.txtCategory.Location = new System.Drawing.Point(12, 41);
            this.txtCategory.Name = "txtCategory";
            this.txtCategory.Size = new System.Drawing.Size(200, 23);
            this.txtCategory.Text = "Kategoria";
            this.txtCategory.ForeColor = System.Drawing.Color.Gray;
            this.txtCategory.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtCategory.Leave += new System.EventHandler(this.TextBox_Leave);

            // txtPriority
            this.txtPriority.Location = new System.Drawing.Point(12, 70);
            this.txtPriority.Name = "txtPriority";
            this.txtPriority.Size = new System.Drawing.Size(200, 23);
            this.txtPriority.Text = "Priorytet (liczba)";
            this.txtPriority.ForeColor = System.Drawing.Color.Gray;
            this.txtPriority.Enter += new System.EventHandler(this.TextBox_Enter);
            this.txtPriority.Leave += new System.EventHandler(this.TextBox_Leave);

            // dtpDueDate
            this.dtpDueDate.Location = new System.Drawing.Point(12, 99);
            this.dtpDueDate.Name = "dtpDueDate";
            this.dtpDueDate.Size = new System.Drawing.Size(200, 23);

            // btnAddTask
            this.btnAddTask.Location = new System.Drawing.Point(12, 128);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(200, 30);
            this.btnAddTask.Text = "Dodaj zadanie";
            this.btnAddTask.UseVisualStyleBackColor = true;
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);

            // btnDeleteTask
            this.btnDeleteTask.Location = new System.Drawing.Point(12, 164);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(200, 30);
            this.btnDeleteTask.Text = "Usuń zaznaczone";
            this.btnDeleteTask.UseVisualStyleBackColor = true;
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);

            // btnSortTasks
            this.btnSortTasks.Location = new System.Drawing.Point(12, 200);
            this.btnSortTasks.Name = "btnSortTasks";
            this.btnSortTasks.Size = new System.Drawing.Size(200, 30);
            this.btnSortTasks.Text = "Sortuj zadania";
            this.btnSortTasks.UseVisualStyleBackColor = true;
            this.btnSortTasks.Click += new System.EventHandler(this.btnSortTasks_Click);

            // dgvTasks
            this.dgvTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTasks.Location = new System.Drawing.Point(230, 12);
            this.dgvTasks.Name = "dgvTasks";
            this.dgvTasks.Size = new System.Drawing.Size(500, 300);
            this.dgvTasks.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;

            // Form1
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(750, 330);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.txtCategory);
            this.Controls.Add(this.txtPriority);
            this.Controls.Add(this.dtpDueDate);
            this.Controls.Add(this.btnAddTask);
            this.Controls.Add(this.btnDeleteTask);
            this.Controls.Add(this.btnSortTasks);
            this.Controls.Add(this.dgvTasks);
            this.Name = "Form1";
            this.Text = "Task Manager";
            ((System.ComponentModel.ISupportInitialize)(this.dgvTasks)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtCategory;
        private System.Windows.Forms.TextBox txtPriority;
        private System.Windows.Forms.DateTimePicker dtpDueDate;
        private System.Windows.Forms.Button btnAddTask;
        private System.Windows.Forms.Button btnDeleteTask;
        private System.Windows.Forms.Button btnSortTasks;
        private System.Windows.Forms.DataGridView dgvTasks;
    }
}

