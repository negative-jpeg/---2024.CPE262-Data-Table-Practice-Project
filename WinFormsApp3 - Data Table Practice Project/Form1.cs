using GemBox.Spreadsheet.WinFormsUtilities;
using GemBox.Spreadsheet;

namespace WinFormsApp3___Data_Table_Practice_Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SpreadsheetInfo.SetLicense("FREE-LIMITED-KEY");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 4;
            dataGridView1.Columns[3].Name = "COURSE";
            dataGridView1.Rows.Add("DELA CRUZ", "JUAN", "A", "BSCPE");
            dataGridView1.Rows.Add("DELA CRUZ", "JUANA", "B", "BSCE");
        }

        private void btn_Load_Click(object sender, EventArgs e)
        {
            var openFileDialog = new OpenFileDialog();
            openFileDialog.Filter =
            "XLS files (*.xls, *.xlt)|*.xls;*.xlt|" +
            "XLSX files (*.xlsx, *.xlsm, *.xltx, *.xltm)|*.xlsx;*.xlsm;*.xltx;*.xltm|" +
            "ODS files (*.ods, *.ots)|*.ods;*.ots|" +
            "CSV files (*.csv, *.tsv)|*.csv;*.tsv|" +
            "HTML files (*.html, *.htm)|*.html;*.htm";
            openFileDialog.FilterIndex = 2;
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = ExcelFile.Load(openFileDialog.FileName);
                var worksheet = workbook.Worksheets.ActiveWorksheet;
                // From ExcelFile to DataGridView.
                DataGridViewConverter.ExportToDataGridView(
                worksheet,
                this.dataGridView1,
                new ExportToDataGridViewOptions() { ColumnHeaders = true }); ;
            }

        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            var saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter =
            "XLS (*.xls)|*.xls|" +
            "XLT (*.xlt)|*.xlt|" +
            "XLSX (*.xlsx)|*.xlsx|" +
            "XLSM (*.xlsm)|*.xlsm|" +
            "XLTX (*.xltx)|*.xltx|" +
            "XLTM (*.xltm)|*.xltm|" +
            "ODS (*.ods)|*.ods|" +
            "OTS (*.ots)|*.ots|" +
            "CSV (*.csv)|*.csv|" +
            "TSV (*.tsv)|*.tsv|" +
            "HTML (*.html)|*.html|" +
            "MHTML (.mhtml)|*.mhtml|" +
            "PDF (*.pdf)|*.pdf|" +
            "XPS (*.xps)|*.xps|" +
            "BMP (*.bmp)|*.bmp|" +
            "GIF (*.gif)|*.gif|" +
            "JPEG (*.jpg)|*.jpg|" +
            "PNG (*.png)|*.png|" +
            "TIFF (*.tif)|*.tif|" +
            "WMP (*.wdp)|*.wdp";
            saveFileDialog.FilterIndex = 3;
            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var workbook = new ExcelFile();
                var worksheet = workbook.Worksheets.Add("Sheet1");
                // From DataGridView to ExcelFile.
                DataGridViewConverter.ImportFromDataGridView(
                worksheet,
                this.dataGridView1,
                new ImportFromDataGridViewOptions() { ColumnHeaders = true });
                workbook.Save(saveFileDialog.FileName);
            }

        }

        //buttons

        private void btnAddRow_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Add();
        }

        private void btnAddColumn_Click(object sender, EventArgs e)
        {
            TextBoxForm textBoxForm = new TextBoxForm();
            textBoxForm.ShowDialog();

            string textBoxValue = textBoxForm.TextBoxValue;
            dataGridView1.Columns.Add("NewColumn", textBoxValue);
        }

        private void btnDeleteColumn_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedCells.Count > 0)
            {
                foreach(DataGridViewCell cell in dataGridView1.SelectedCells)
                {
                    if(cell.ColumnIndex >= 0 && cell.ColumnIndex < dataGridView1.ColumnCount)
                    {
                        dataGridView1.Columns.RemoveAt(cell.ColumnIndex);
                    }
                }
            }
        }

        private void btnDeleteRow_Click(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                int selectedIndex = dataGridView1.SelectedRows[0].Index;
                dataGridView1.Rows.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Please select a Row to delete.");
            }
        }
    }
}
