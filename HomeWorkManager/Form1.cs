using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace HomeWorkManager
{
    public partial class frmMaster : Form
    {
        private const string P1 = "●";
        private const string P2 = "○";
        private List<Assignment> assignments;
        public frmMaster()
        {
            XDocument doc;
            try
            {
                doc = XDocument.Load("Assignments.xml");
            }
            catch (Exception exc)
            {
                doc = new XDocument(new XElement("Assignments"));
            }
            CreateList(doc);
            InitializeComponent();
            DrawList();
            DrawComboBox();
            calendar.MinDate = calendar.TodayDate;
        }

        private XDocument CreateXML()
        {
            XDocument newDoc = new XDocument(new XElement("Assignments"));
            XElement root = newDoc.Root;
            foreach (Assignment a in assignments)
            {
                root.Add(new XElement("Assignment",
                    new XElement("CourseName", a.CourseName),
                    new XElement("AssignmentName", a.AssignmentName),
                    new XElement("SubmissionDeadline", a.SubmissionDeadline.ToShortDateString()),
                    new XElement("IsFinished", a.IsFinished)
                    ));
            }
            return newDoc;
        }
        private void CreateList(XDocument doc)
        {
            string CourseName, AssignmentName, date;
            int day, month, year;
            bool IsFinished;
            assignments = new List<Assignment>();
            IEnumerable<XElement> assignmentsXML = doc.Root.Elements("Assignment");
            foreach (XElement assignmentXML in assignmentsXML)
            {
                CourseName = assignmentXML.Element("CourseName").Value;
                AssignmentName = assignmentXML.Element("AssignmentName").Value;
                IsFinished = bool.Parse(assignmentXML.Element("IsFinished").Value);
                date = assignmentXML.Element("SubmissionDeadline").Value;
                day = int.Parse(date.Substring(0, 2));
                month = int.Parse(date.Substring(3, 2));
                year = int.Parse(date.Substring(6, 4));
                assignments.Add(new Assignment(new DateTime(year, month, day), CourseName, AssignmentName, IsFinished));
            }
            assignments.Sort();
        }
        private void DrawList()
        {
            string str = "";
            foreach (Assignment a in assignments)
            {
                str += P1 + "  " + a.CourseName + ":\n"
                    + "     " + P2 + "  " + "שם המטלה - " + a.AssignmentName + ".\n"
                    + "     " + P2 + "  " + "תאריך הגשה - " + a.SubmissionDeadline.ToShortDateString() + ".\n"
                    + "     " + P2 + "  " + "האם סוימה - ";
                if (a.IsFinished)
                    str += "כן";
                else
                    str += "לא";
                str += ".\n";
            }
            lblAssignmentList.Text = str;
            lblAssignmentList.Refresh();
        }
        private void DrawComboBox()
        {
            foreach (Assignment a in assignments)
                cboChooseAssignment.Items.Add(a);
            cboChooseAssignment.Refresh();
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            CreateXML().Save("Assignments.xml");
            this.Close();
        }

        private void btnAddAssignment_Click(object sender, EventArgs e)
        {
            if (txtAssigmentName.Text == "" || txtCourseName.Text == "")
            {

                MessageBox.Show(
                    "נא הכנס שם קורס, שם מטלה ותאריך.",
                    "הפעולה בוטלה",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button3, MessageBoxOptions.RtlReading);
                return;
            }
            Assignment newAssignment = new Assignment(calendar.SelectionStart, txtCourseName.Text, txtAssigmentName.Text);
            assignments.Add(newAssignment);
            cboChooseAssignment.Items.Add(newAssignment);
            assignments.Sort();
            txtAssigmentName.Text = "";
            txtCourseName.Text = "";
            MessageBox.Show(
                    "המטלה הוספה בהצלחה.",
                    "שיגעון!",
                    MessageBoxButtons.OK, MessageBoxIcon.Asterisk, MessageBoxDefaultButton.Button3, MessageBoxOptions.RtlReading);
            DrawList();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {

            assignments.Remove((Assignment)cboChooseAssignment.SelectedItem);
            cboChooseAssignment.Items.Remove(cboChooseAssignment.SelectedItem);
            cboChooseAssignment.Text = "";
            DrawList();

        }

        private void btnFinishAssignment_Click(object sender, EventArgs e)
        {

            ((Assignment)cboChooseAssignment.SelectedItem).IsFinished = true;
            DrawList();
        }
    }
}
