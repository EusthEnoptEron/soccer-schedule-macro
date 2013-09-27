using SoccerScheduler.Elements;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;


namespace SoccerScheduler
{
    public partial class MainForm : Form
    {
        List<Team> teams = new List<Team>() {
            new Team()
        };
        List<PlayDay> days = new List<PlayDay>()
        {
            new PlayDay()
            {
                Day = DayOfWeek.Monday
            }
        };

        public MainForm()
        {
            
            InitializeComponent();

            dayDataGridViewTextBoxColumn1.DataSource =
                new List<DayOfWeek>((DayOfWeek[])Enum.GetValues(typeof(DayOfWeek)))
                .Select(value => new { Display = value.ToString(), Value = value })
                .ToList();
            dayDataGridViewTextBoxColumn1.ValueMember = "Value";
            dayDataGridViewTextBoxColumn1.DisplayMember = "Display";
            dayDataGridViewTextBoxColumn1.ValueType = typeof(DayOfWeek);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void daysGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream TestFileStream = File.Create("test.bin");
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(TestFileStream, dayBindingSource.List );
            TestFileStream.Close();
        }
    }
}
