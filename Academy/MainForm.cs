using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using DBtools;

namespace Academy
{
    public partial class MainForm : Form
    {
        Connector connector;
        DataGridView[] tables;
        Query[] queries =
        {
            new Query
                (
                    "stud_id, last_name, first_name, middle_name, birth_date, group_name, direction_name",
                    "Students,Groups,Directions",
                    "[group]=group_id AND direction=direction_id"
                ),
            new Query
                (
                    "group_id, group_name, start_date, start_time, learning_days, direction_name",
                    "Groups,Directions",
                    "direction=direction_id"
                ),
            new Query("*", "Directions"),
            new Query("*", "Disciplines"),
            new Query("*", "Teachers")
        };

        public MainForm()
        {
            InitializeComponent();

            tables = new DataGridView[] { dgvStudents, dgvGroups, dgvDirections, dgvDisciplines, dgvTeachers };

            connector = new Connector(ConfigurationManager.ConnectionStrings["PV_522_Import"].ConnectionString);
            //dgvDirections.DataSource = connector.Select("SELECT * FROM Directions");
            tabControl_SelectedIndexChanged(tabControl, null);

            cbGroupsDirections.DataSource = connector.Load("SELECT * From Directions");
            cbGroupsDirections.DisplayMember = "direction_name";
            cbGroupsDirections.ValueMember = "direction_id";

            cbStudentsGroups.DisplayMember = "group_name";
            cbStudentsGroups.ValueMember = "group_id";
            cbStudentsGroups.DataSource = connector.Load(queries[1].ToString());

            cbStudentDirection.DisplayMember = "direction_name";
            cbStudentDirection.ValueMember = "direction_id";
            cbStudentDirection.DataSource = connector.Load("SELECT direction_id, direction_name FROM Directions");
        }
        private void tabControl_SelectedIndexChanged(object sender, EventArgs e)
        {
            int i = (sender as TabControl).SelectedIndex;  //Получаем номер выбранной вкладки
            tables[i].DataSource = connector.Load(queries[i].ToString());
           // tables[i].DataSource = connector.Select("*", tabControl.SelectedTab.Text);
            toolStripStatusLabel.Text = $"Количество записей: {tables[i].RowCount-1}";

        }

       
        private void cbGroupsDirections_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvGroups.DataSource = connector.Load(queries[1].ToString() + $" AND direction={cbGroupsDirections.SelectedValue}");
            toolStripStatusLabel.Text = $"Количество записей: {dgvGroups.RowCount - 1}";
        }
        private void cbStudentsGroups_SelectionChangeCommitted(object sender, EventArgs e)
        {
            dgvStudents.DataSource = connector.Load(queries[0].ToString() + $" AND group_id={cbStudentsGroups.SelectedValue}");
            toolStripStatusLabel.Text = $"Количество записей: {dgvStudents.RowCount - 1}";
        }
   
        private void cbStudentDirection_SelectedIndexChanged(object sender, EventArgs e)
        {
            dgvStudents.DataSource = connector.Load(queries[0].ToString() + $" AND direction_id={cbStudentDirection.SelectedValue}");
            cbStudentsGroups.DataSource = connector.Load($"SELECT * FROM Groups WHERE direction = {cbStudentDirection.SelectedValue}");
            toolStripStatusLabel.Text = $"Количество записей: {dgvStudents.RowCount - 1}";
        }
        private void buttonAddStudent_Click(object sender, EventArgs e)
        {
            StudentForm student = new StudentForm();
            student.ShowDialog();
        }

    }
}
