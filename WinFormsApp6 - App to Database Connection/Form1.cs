using System.Data.OleDb;
using System.Data;
using Microsoft.VisualBasic.ApplicationServices;
using System.Xml.Linq;

namespace WinFormsApp6___App_to_Database_Connection
{
    public partial class Form1 : Form
    {
        OleDbConnection? myConn;
        OleDbDataAdapter? da;
        OleDbCommand? cmd;
        DataSet? ds;
        int indexRow;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\L23Y08W29\\Downloads\\Delgado_CPE262 Calculator Project\\database\\Database3.accdb");
            ds = new DataSet();
            myConn.Open();
            System.Windows.Forms.MessageBox.Show("Connected successfully!");
            myConn.Close();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            myConn = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\\Users\\L23Y08W29\\Downloads\\Delgado_CPE262 Calculator Project\\database\\Database3.accdb");

            da = new OleDbDataAdapter("SELECT *FROM Student", myConn);
            //or da = new OleDbDataAdapter("SELECT Student.LastName, Student.FirstName,
            //Student.Course, SubjectsEnrolled.*, FinalGrade.StudentID\r\nFROM (Student
            //INNER JOIN SubjectsEnrolled ON Student.StudentID =
            //SubjectsEnrolled.StudentID) INNER JOIN FinalGrade ON Student.StudentID =
            //FinalGrade.StudentID", myConn);
            ds = new DataSet();
            myConn.Open();
            da.Fill(ds, "Student");
            dgvStudentInfo.DataSource = ds.Tables["Student"];
            myConn.Close();
        }

        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Student (LastName, FirstName) values(@LName, @FName)";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@LName", tbxLname.Text);
            cmd.Parameters.AddWithValue("@FName", tbxFname.Text);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void dgvStudentInfo_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            indexRow = e.RowIndex;
            DataGridViewRow row = dgvStudentInfo.Rows[indexRow];
            tbxID.Text = row.Cells[0].Value.ToString();
            tbxLname.Text = row.Cells[1].Value.ToString();
            tbxFname.Text = row.Cells[2].Value.ToString();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            string query = "Delete From Student Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@id",
            dgvStudentInfo.CurrentRow.Cells[0].Value);
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Student Set LastName = @Lname Where StudentID = @id";
            cmd = new OleDbCommand(query, myConn);
            cmd.Parameters.AddWithValue("@ln", tbxLname.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

            string query1 = "Update Student Set FirstName = @Fname Where StudentID = @id";
            cmd = new OleDbCommand(query1, myConn);
            cmd.Parameters.AddWithValue("@ln", tbxFname.Text);
            cmd.Parameters.AddWithValue("@id", Convert.ToInt32(tbxID.Text));
            myConn.Open();
            cmd.ExecuteNonQuery();
            myConn.Close();

        }

        private void tbxID_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
