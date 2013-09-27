namespace SoccerScheduler
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tabControl = new System.Windows.Forms.TabControl();
            this.categoriesPage = new System.Windows.Forms.TabPage();
            this.teamsPage = new System.Windows.Forms.TabPage();
            this.teamsGridView = new System.Windows.Forms.DataGridView();
            this.daysPage = new System.Windows.Forms.TabPage();
            this.daysGridView = new System.Windows.Forms.DataGridView();
            this.categoriesGridView = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.categoryDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dayBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.teamBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.defaultDayDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoryBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dayDataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.startTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.endTimeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControl.SuspendLayout();
            this.categoriesPage.SuspendLayout();
            this.teamsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.teamsGridView)).BeginInit();
            this.daysPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.daysGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl
            // 
            this.tabControl.Controls.Add(this.teamsPage);
            this.tabControl.Controls.Add(this.categoriesPage);
            this.tabControl.Controls.Add(this.daysPage);
            this.tabControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl.Location = new System.Drawing.Point(0, 0);
            this.tabControl.Name = "tabControl";
            this.tabControl.SelectedIndex = 0;
            this.tabControl.Size = new System.Drawing.Size(689, 173);
            this.tabControl.TabIndex = 0;
            // 
            // categoriesPage
            // 
            this.categoriesPage.Controls.Add(this.categoriesGridView);
            this.categoriesPage.Location = new System.Drawing.Point(4, 22);
            this.categoriesPage.Name = "categoriesPage";
            this.categoriesPage.Padding = new System.Windows.Forms.Padding(3);
            this.categoriesPage.Size = new System.Drawing.Size(681, 147);
            this.categoriesPage.TabIndex = 0;
            this.categoriesPage.Text = "Categories";
            this.categoriesPage.UseVisualStyleBackColor = true;
            // 
            // teamsPage
            // 
            this.teamsPage.Controls.Add(this.teamsGridView);
            this.teamsPage.Location = new System.Drawing.Point(4, 22);
            this.teamsPage.Name = "teamsPage";
            this.teamsPage.Padding = new System.Windows.Forms.Padding(3);
            this.teamsPage.Size = new System.Drawing.Size(681, 147);
            this.teamsPage.TabIndex = 1;
            this.teamsPage.Text = "Teams";
            this.teamsPage.UseVisualStyleBackColor = true;
            // 
            // teamsGridView
            // 
            this.teamsGridView.AutoGenerateColumns = false;
            this.teamsGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.teamsGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.categoryDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn,
            this.dayDataGridViewTextBoxColumn});
            this.teamsGridView.DataSource = this.teamBindingSource;
            this.teamsGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.teamsGridView.Location = new System.Drawing.Point(3, 3);
            this.teamsGridView.Name = "teamsGridView";
            this.teamsGridView.Size = new System.Drawing.Size(675, 141);
            this.teamsGridView.TabIndex = 0;
            this.teamsGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // daysPage
            // 
            this.daysPage.Controls.Add(this.daysGridView);
            this.daysPage.Location = new System.Drawing.Point(4, 22);
            this.daysPage.Name = "daysPage";
            this.daysPage.Padding = new System.Windows.Forms.Padding(3);
            this.daysPage.Size = new System.Drawing.Size(681, 147);
            this.daysPage.TabIndex = 2;
            this.daysPage.Text = "Days";
            this.daysPage.UseVisualStyleBackColor = true;
            // 
            // daysGridView
            // 
            this.daysGridView.AutoGenerateColumns = false;
            this.daysGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.daysGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dayDataGridViewTextBoxColumn1,
            this.startTimeDataGridViewTextBoxColumn,
            this.endTimeDataGridViewTextBoxColumn});
            this.daysGridView.DataSource = this.dayBindingSource;
            this.daysGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.daysGridView.Location = new System.Drawing.Point(3, 3);
            this.daysGridView.Name = "daysGridView";
            this.daysGridView.Size = new System.Drawing.Size(675, 141);
            this.daysGridView.TabIndex = 0;
            this.daysGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.daysGridView_CellContentClick);
            // 
            // categoriesGridView
            // 
            this.categoriesGridView.AutoGenerateColumns = false;
            this.categoriesGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.categoriesGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.defaultDayDataGridViewTextBoxColumn,
            this.nameDataGridViewTextBoxColumn1});
            this.categoriesGridView.DataSource = this.categoryBindingSource;
            this.categoriesGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.categoriesGridView.Location = new System.Drawing.Point(3, 3);
            this.categoriesGridView.Name = "categoriesGridView";
            this.categoriesGridView.Size = new System.Drawing.Size(675, 141);
            this.categoriesGridView.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.tabControl);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(689, 173);
            this.panel1.TabIndex = 1;
            // 
            // categoryDataGridViewTextBoxColumn
            // 
            this.categoryDataGridViewTextBoxColumn.DataPropertyName = "Category";
            this.categoryDataGridViewTextBoxColumn.HeaderText = "Category";
            this.categoryDataGridViewTextBoxColumn.Name = "categoryDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn
            // 
            this.nameDataGridViewTextBoxColumn.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn.Name = "nameDataGridViewTextBoxColumn";
            // 
            // dayDataGridViewTextBoxColumn
            // 
            this.dayDataGridViewTextBoxColumn.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn.DataSource = this.dayBindingSource;
            this.dayDataGridViewTextBoxColumn.DisplayMember = "Day";
            this.dayDataGridViewTextBoxColumn.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn.Name = "dayDataGridViewTextBoxColumn";
            this.dayDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayDataGridViewTextBoxColumn.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dayDataGridViewTextBoxColumn.ValueMember = "Instance";
            // 
            // dayBindingSource
            // 
            this.dayBindingSource.DataSource = typeof(SoccerScheduler.Elements.PlayDay);
            this.dayBindingSource.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // teamBindingSource
            // 
            this.teamBindingSource.DataSource = typeof(SoccerScheduler.Elements.Team);
            // 
            // defaultDayDataGridViewTextBoxColumn
            // 
            this.defaultDayDataGridViewTextBoxColumn.DataPropertyName = "DefaultDay";
            this.defaultDayDataGridViewTextBoxColumn.HeaderText = "DefaultDay";
            this.defaultDayDataGridViewTextBoxColumn.Name = "defaultDayDataGridViewTextBoxColumn";
            // 
            // nameDataGridViewTextBoxColumn1
            // 
            this.nameDataGridViewTextBoxColumn1.DataPropertyName = "Name";
            this.nameDataGridViewTextBoxColumn1.HeaderText = "Name";
            this.nameDataGridViewTextBoxColumn1.Name = "nameDataGridViewTextBoxColumn1";
            // 
            // categoryBindingSource
            // 
            this.categoryBindingSource.DataSource = typeof(SoccerScheduler.Elements.Category);
            // 
            // dayDataGridViewTextBoxColumn1
            // 
            this.dayDataGridViewTextBoxColumn1.DataPropertyName = "Day";
            this.dayDataGridViewTextBoxColumn1.HeaderText = "Day";
            this.dayDataGridViewTextBoxColumn1.Name = "dayDataGridViewTextBoxColumn1";
            this.dayDataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dayDataGridViewTextBoxColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // startTimeDataGridViewTextBoxColumn
            // 
            this.startTimeDataGridViewTextBoxColumn.DataPropertyName = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.HeaderText = "StartTime";
            this.startTimeDataGridViewTextBoxColumn.Name = "startTimeDataGridViewTextBoxColumn";
            this.startTimeDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // endTimeDataGridViewTextBoxColumn
            // 
            this.endTimeDataGridViewTextBoxColumn.DataPropertyName = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.HeaderText = "EndTime";
            this.endTimeDataGridViewTextBoxColumn.Name = "endTimeDataGridViewTextBoxColumn";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(607, 179);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(688, 211);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.panel1);
            this.Name = "MainForm";
            this.Text = "Scheduler";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.tabControl.ResumeLayout(false);
            this.categoriesPage.ResumeLayout(false);
            this.teamsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.teamsGridView)).EndInit();
            this.daysPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.daysGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriesGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dayBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teamBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoryBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl;
        private System.Windows.Forms.TabPage categoriesPage;
        private System.Windows.Forms.TabPage teamsPage;
        private System.Windows.Forms.DataGridView teamsGridView;
        private System.Windows.Forms.BindingSource teamBindingSource;
        private System.Windows.Forms.BindingSource dayBindingSource;
        private System.Windows.Forms.BindingSource categoryBindingSource;
        private System.Windows.Forms.TabPage daysPage;
        private System.Windows.Forms.DataGridView categoriesGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn defaultDayDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridView daysGridView;
        private System.Windows.Forms.DataGridViewComboBoxColumn dayDataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn startTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn endTimeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoryDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewComboBoxColumn dayDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button1;
    }
}

