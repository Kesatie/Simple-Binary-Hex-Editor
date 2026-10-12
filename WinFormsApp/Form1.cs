using System.Globalization;
using System.Text;

namespace WinFormsApp
{
    public partial class Form1 : Form
    {
        byte[]? data;

        public Form1()
        {
            InitializeComponent();
            grid.VirtualMode = true;
            grid.ColumnHeadersVisible = false;
            grid.RowHeadersVisible = false;
            grid.AllowUserToAddRows = false;
            Encoding.RegisterProvider(CodePagesEncodingProvider.Instance);





            for (int c = 0; c < 18; c++)
            {
                int idx = grid.Columns.Add($"col{c}", "");

                int width;
                if (c == 0) width = 100;
                else if (c == 9) width = 10;
                else if (c <= 3) width = 26;
                else width = 27;

                grid.Columns[idx].Width = width;


            }
            grid.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            grid.Columns[0].DefaultCellStyle.ForeColor = Color.Indigo;
            grid.Columns[0].DefaultCellStyle.Font = new Font(grid.Font, FontStyle.Bold);
        }

        private void ShowInfo(int index)
        {
            if (data == null || index < 0 || index >= data.Length) return;

            byte b = data[index];

            OffsetHexLabel.Text = $"0x{index:X}";
            OffsetDecLabel.Text = index.ToString();
            ValueInByteHex.Text = $"0x{b:X2}";
            ValueInByteDec.Text = b.ToString();

            bool printable = (b >= 32 && b < 127) || b >= 160;
            ValueInCharacter.Text = printable ? ((char)b).ToString() : ".";
        }

        private int GetSelectedIndex()
        {
            if (data == null || grid.CurrentCell == null) return -1;

            int col = grid.CurrentCell.ColumnIndex;
            if (col == 0 || col == 9) return -1;

            int byteCol = col < 9 ? col - 1 : col - 2;
            int index = grid.CurrentCell.RowIndex * 16 + byteCol;

            return index < data.Length ? index : -1;
        }

        private void ReplaceHex()
        {
            if (data == null)
            {
                MessageBox.Show("Open a file first.");
                return;
            }

            int index = GetSelectedIndex();
            if (index < 0)
            {
                MessageBox.Show("Select a byte cell first.");
                return;
            }

            string? input = PromptHex(index, data[index]);
            if (input == null) return;

            input = input.Trim();
            if (input.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                input = input.Substring(2);

            if (!byte.TryParse(input, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out byte newValue))
            {
                MessageBox.Show("Enter a hex value from 00 to FF.");
                return;
            }

            data[index] = newValue;
            grid.Invalidate();
            ShowInfo(index);
        }

        private string? PromptHex(int index, byte current)
        {
            using var form = new Form();
            form.Text = "Replace byte";
            form.FormBorderStyle = FormBorderStyle.FixedDialog;
            form.StartPosition = FormStartPosition.CenterParent;
            form.MaximizeBox = false;
            form.MinimizeBox = false;
            form.ClientSize = new Size(260, 110);

            var label = new Label
            {
                Text = $"Offset 0x{index:X}   (current: {current:X2})\nNew value (hex):",
                AutoSize = true,
                Left = 12,
                Top = 10
            };
            var box = new TextBox { Left = 12, Top = 50, Width = 236, MaxLength = 4, Text = current.ToString("X2") };
            var ok = new Button { Text = "OK", Left = 92, Top = 76, DialogResult = DialogResult.OK };
            var cancel = new Button { Text = "Cancel", Left = 173, Top = 76, DialogResult = DialogResult.Cancel };

            form.Controls.AddRange(new Control[] { label, box, ok, cancel });
            form.AcceptButton = ok;
            form.CancelButton = cancel;
            form.Shown += (s, e) => box.SelectAll();

            return form.ShowDialog(this) == DialogResult.OK ? box.Text : null;
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.R))
            {
                ReplaceHex();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void openFileDialog1_FileOk(object sender, System.ComponentModel.CancelEventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                data = File.ReadAllBytes(openFileDialog1.FileName);
                FileName.Text = Path.GetFileName(openFileDialog1.FileName);
                FileSizeHexLabel.Text = $"0x{data.Length.ToString("X2")}";
                FileSizeDecLabel.Text = data.Length.ToString();
                grid.RowCount = (data.Length + 15) / 16;
                grid.Invalidate();
            }
        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {
        }

        private void grid_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void grid_CellValueNeeded(object sender, DataGridViewCellValueEventArgs e)
        {

            if (data == null) return;

            if (e.ColumnIndex == 0)
            {
                e.Value = (e.RowIndex * 16).ToString("X8");
                return;
            }


            if (e.ColumnIndex == 9)
            {

                e.Value = "";
                return;
            }
            int ByteCol = e.ColumnIndex < 9 ? e.ColumnIndex - 1 : e.ColumnIndex - 2;
            int index = e.RowIndex * 16 + ByteCol;

            if (index >= data.Length)
            {
                e.Value = "";
                return;
            }

            e.Value = data[index].ToString("X2").ToUpper();
        }

        private void grid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (data == null) return;
            if (e.RowIndex < 0) return;
            if (e.ColumnIndex == 0 || e.ColumnIndex == 9) return;

            int ByteCol = e.ColumnIndex < 9 ? e.ColumnIndex - 1 : e.ColumnIndex - 2;
            int index = e.RowIndex * 16 + ByteCol;

            if (index >= data.Length) return;

            byte b = data[index];

            OffsetHexLabel.Text = $"0x{index:X}";
            OffsetDecLabel.Text = index.ToString();
            ValueInByteHex.Text = $"0x{b:X2}";
            ValueInByteDec.Text = b.ToString();
            string ch = Encoding.GetEncoding(1252).GetString(new[] { b });
            bool printable = b >= 32 && b != 127
                          && b != 0x81 && b != 0x8D && b != 0x8F && b != 0x90 && b != 0x9D
                          && b != 0xA0 && b != 0xAD;
            ValueInCharacter.Text = printable ? ch : ".";
        }

        private void GotoAddressButton_Click(object sender, EventArgs e)
        {
            if (data == null) return;

            string text = GotoAddressTextBox.Text.Trim();
            if (text.StartsWith("0x", StringComparison.OrdinalIgnoreCase))
                text = text.Substring(2);

            if (!int.TryParse(text, NumberStyles.HexNumber, CultureInfo.InvariantCulture, out int index))
            {
                MessageBox.Show("Enter a hex address, like 1A0.");
                return;
            }

            if (index < 0 || index >= data.Length)
            {
                MessageBox.Show($"Address is outside the file (size is 0x{data.Length:X}).");
                return;
            }

            int row = index / 16;
            int byteInRow = index % 16;
            int column = byteInRow < 8 ? byteInRow + 1 : byteInRow + 2;

            grid.ClearSelection();
            grid.CurrentCell = grid.Rows[row].Cells[column];
            grid.FirstDisplayedScrollingRowIndex = row;
        }

        private void grid_CurrentCellChanged(object sender, EventArgs e)
        {
            if (data == null || grid.CurrentCell == null) return;

            int row = grid.CurrentCell.RowIndex;
            int col = grid.CurrentCell.ColumnIndex;

            if (col == 0 || col == 9) return;   // offset column and gap have no byte

            int byteCol = col < 9 ? col - 1 : col - 2;
            ShowInfo(row * 16 + byteCol);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            if (data == null)
            {
                MessageBox.Show("Open a file first.");
                return;
            }

            using var dialog = new SaveFileDialog();
            dialog.Filter = "Binary files (*.bin)|*.bin|All files (*.*)|*.*";
            dialog.InitialDirectory = Path.GetDirectoryName(openFileDialog1.FileName);
            dialog.FileName = Path.GetFileNameWithoutExtension(openFileDialog1.FileName) + "_R1.bin";

            if (dialog.ShowDialog() != DialogResult.OK) return;

            if (string.Equals(dialog.FileName, openFileDialog1.FileName, StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please save to a new file so the original stays untouched.");
                return;
            }

            try
            {
                File.WriteAllBytes(dialog.FileName, data);
                MessageBox.Show($"Saved {data.Length} bytes.");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Could not save: " + ex.Message);
            }
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            ReplaceHex();
        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
