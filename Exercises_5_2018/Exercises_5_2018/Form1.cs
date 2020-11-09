using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercises_5_2018
{
    public partial class Form1 : Form
    {
        

        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection dataConnection;
        SqlCommand command;
        SqlDataReader dR;

        List<ExerciseResult> listOfStudnets = new List<ExerciseResult>();

        private void buttonExerciseResults_Click(object sender, EventArgs e)
        {

            dataConnection = new SqlConnection("Data Source=(localdb)\\ProjectsV13;Initial Catalog=FacultyDatabase;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
            command = new SqlCommand();
            dataConnection.Open();
            command.Connection = dataConnection;
            command.CommandText = "SELECT * FROM ExerciseResults";
            dR= command.ExecuteReader();

            while(dR.Read())
            {
                ExerciseResult student = new ExerciseResult();

                student.studentId = dR.GetInt32(0);
                student.studentName = dR.GetString(1);
                student.studentIndex = dR.GetString(2);
                student.studentPoints = dR.GetInt32(3);

                listOfStudnets.Add(student);
            }
            for(int i = 0; i < listOfStudnets.Count; i++)
            {
                listBoxExerciseResults.Items.Add(listOfStudnets[i]);
            }
            dataConnection.Close();
         }
            
            
        
    }
}
