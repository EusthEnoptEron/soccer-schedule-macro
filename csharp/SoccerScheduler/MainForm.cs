using SoccerScheduler.Elements;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Linq;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Collections;


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


            dayDataGridViewTextBoxColumn1.ValueMember = "Value";
            dayDataGridViewTextBoxColumn1.DisplayMember = "Display";
            dayDataGridViewTextBoxColumn1.ValueType = typeof(DayOfWeek);

            dayDataGridViewTextBoxColumn1.DataSource =
                new List<DayOfWeek>((DayOfWeek[])Enum.GetValues(typeof(DayOfWeek)))
                .Select(value => new { Display = value.ToString(), Value = value })
                .ToList();

            foreach(DayOfWeek day in Enum.GetValues(typeof(DayOfWeek))) {
                dayBindingSource.List.Add(new PlayDay
                {
                    Day = day
                });
            }
            
        }

        private void LoadState(string path) {
            if (File.Exists(path))
            {
                BinaryFormatter serializer = new BinaryFormatter();
                using(FileStream stream = File.OpenRead(path)) {
                    try
                    {
                        Dictionary<string, IList> elements = (Dictionary<string, IList>)serializer.Deserialize(stream);

                        teamBindingSource.List.Clear();
                        categoryBindingSource.List.Clear();
                        dayBindingSource.List.Clear();

                        foreach(object item in elements["teams"]) teamBindingSource.List.Add(item);
                        foreach(object item in elements["categories"]) categoryBindingSource.List.Add(item);
                        foreach(object item in elements["days"]) dayBindingSource.List.Add(item);
                    }
                    catch (SerializationException e)
                    {
                        MessageBox.Show("Failed to load state: " + e.Message);
                    }
                     
                }
            }
        }

        private void SaveState(string path)
        {
            Dictionary<string, IList> elements = new Dictionary<string, IList>()
            {
                { "teams", teamBindingSource.List },
                { "categories", categoryBindingSource.List },
                { "days", dayBindingSource.List }
            };


            using (Stream TestFileStream = File.Create(path))
            {
                try
                {
                    BinaryFormatter serializer = new BinaryFormatter();
                    serializer.Serialize(TestFileStream, elements);
                }
                catch (SerializationException e)
                {
                    MessageBox.Show("Failed to save state: " + e.Message);
                }
            }
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
            SaveState("test.bin");
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            LoadState("test.bin");
        }
    }
}
