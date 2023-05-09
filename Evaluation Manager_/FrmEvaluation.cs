using Evaluation_Manager.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evaluation_Manager {
    public partial class FrmEvaluation : Form {

        public FrmEvaluation(Student selectedStudent) {

            InitializeComponent();
            Student = selectedStudent;

        }

        private void textBox1_TextChanged(object sender, EventArgs e) {

        }

        private void label1_Click(object sender, EventArgs e) {

        }

        private void label5_Click(object sender, EventArgs e) {

        }

        private void label6_Click(object sender, EventArgs e) {

        }

        private void FrmEvaluation_Load(object sender, EventArgs e) {
            SetFormText();


        }

        private void SetFormText() {
            Text = student.FirstName + " " + student.LastName; 
        }

        private void txtActivityDescription_TextChanged(object sender, EventArgs e) {

        }

        private void cboActivities_SelectedIndexChanged(object sender, EventArgs e) {

            var currentActivity = cboActivities.SelectedItem as Activity;
            txtActivityDescription.Text = currentActivity.Description;
            txtMinForGrade.Text = currentActivity.MinPointsForGrade + "/" + currentActivity.MaxPoint;
            txtMinForSigniture.Text = currentActivity.MinPointsForSignature + "/" + currentActivity.MaxPoint;

            numPoints.Minimum = 0;
            numPoints.Maximum = currentActivity.MaxPoint;
        }
    }
}
