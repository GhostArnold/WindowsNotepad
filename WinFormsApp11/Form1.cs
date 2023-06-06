using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ToolBar;
using System.Drawing.Printing;
using System.Drawing;
using System.Reflection.Emit;

namespace WinFormsApp11
{
    public partial class Form1 : Form
    {
        //������� ���������� ���������� �� ���������� ������� �� ���� ��� ���, already - ���
        private bool fileAlreadySave;
        //����������, ������� ��������� ������ �� ��� TextBox ��� �� ���
        private bool fileUpdated;
        //���������� ������������ � ���� ������� ��� �����, current - �������
        private string currentFileName = "";
        public Form1()
        {
            InitializeComponent();

        }
        private string text = "";
        private void createNewWindow_Click(object sender, EventArgs e)
        {
            //������ ����� ���������� ����
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            //������ ��������� ���� OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //��������� ������� ��� ������� ������,������� �� ����� ������������ 
            openFileDialog.Filter = "Txt files (*.txt)|*.txt|Rtf files (*.rtf)|*.rtf";

            //������ ��������� ���� DialogResult 
            DialogResult result = openFileDialog.ShowDialog();

            //���� �� ��������� ������������
            if(result == DialogResult.OK)
            {
                //���� ���� ���������� �� ���������� "���������� �����".Ÿ �������� ����� ������� .txt
                if(Path.GetExtension(openFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                // ���� ���� ���������� �� ���������� "���������� �����".Ÿ �������� ����� �������.rtf
                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                //����� � ������� ������ ��������
                this.Text = openFileDialog.FileName + " Notepad - ������ ����� ����";

                //���� �� ������ ����, �� ������������� fileUpdate = false
                //� �������, ��� ���� ��� �������
                fileUpdated = false;
                fileAlreadySave = true;
                currentFileName = openFileDialog.FileName;
            }
            //����� ��� �������� ������-���� ����� ������
            //������ � ������ ������ ���� ��������������� �� ������� ����� ������
            Undo.Enabled = false;
            Redo.Enabled = false;
        }

        private void createNewFile_Click(object sender, EventArgs e)
        {
            if (fileUpdated)
            {
                DialogResult result = MessageBox.Show("�� ������ ��������� ��������� ���?", "���������� ����", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        fileSave();
                        break;

                    case DialogResult.No:
                        MainRichTextBox1.Clear();
                        fileUpdated = false;
                        this.Text = "Notepad - ������ ����� ����";
                        break;

                    case DialogResult.Cancel:
                        break;


                }
            }
            else
            {
                this.Text = "Notepad - ������ ����� ����";
            }
        }
        //����������������� �������
        private void saveFileAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            //������ ��������� ���� SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //��������� ������� ��� ������� ������,������� �� ����� ������������ 
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|Rtf files (*.rtf)| *.rtf";

            // ������ ��������� ���� DialogResult
            DialogResult result = saveFileDialog.ShowDialog();

            //���� �� ��������� ������������
            if (result == DialogResult.OK)
            {
                //���� ���� ���������� �� ���������� "���������� �����".Ÿ �������� ����� ������� .txt
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    SaveAsMyFicha(saveFileDialog);
                }
                //���� ���� ���������� �� ���������� "���������� �����".Ÿ �������� ����� ������� .rtf
                if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    SaveAsMyFicha(saveFileDialog);
                }

            }

        }

        private void SaveAsMyFicha(SaveFileDialog saveFileDialog)
        {
            //���� �� ������ ����, �� ������������� fileUpdate = false
            //� �������, ��� ���� ��� �������
            this.Text = saveFileDialog.FileName + " Notepad - ������ ����� ����";
            fileUpdated = false;
            fileAlreadySave = true;
            currentFileName = saveFileDialog.FileName;
        }

        private void appExit_Click(object sender, EventArgs e)
        {
            
            Application.Exit();
        }

        private void MainRichTextBox1_TextChanged(object sender, EventArgs e)
        {
            fileUpdated = true;
            Undo.Enabled = true;
            Redo.Enabled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //������ ����������� ������ ����
            this.MinimumSize = new Size(400, 400);

            fileUpdated = false;
            fileAlreadySave = false;
            currentFileName = "";

        }

        private void saveFile_Click(object sender, EventArgs e)
        {
            fileSave();

        }

        private void fileSave()
        {
            //���� ���� ��� �������
            if (fileAlreadySave)
            {
                //���� �������� ����� ����� ���������� .txt
                if (Path.GetExtension(currentFileName) == ".txt")
                {
                    MainRichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                }
                //���� �������� ����� ����� ���������� .rtf
                if (Path.GetExtension(currentFileName) == ".rtf")
                {
                    MainRichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.RichText);
                }
                fileUpdated = false;
            }
            //����� ���� ���� �� ��� �������
            else
            {
                //���� TextBox ��� ��������� ��������
                if (fileUpdated)
                {
                    SaveAs();
                }
                //����� ������ ������� TextBox
                else
                {
                    MainRichTextBox1.Clear();
                    fileUpdated = false;
                    this.Text = "Notepad - ������ ����� ����";
                }
            }
            //����� ��� ���������� ������-���� ����� ������
            //������ � ������ ������ ���� ��������������� �� ������� ����� ������
            Undo.Enabled = false;
            Redo.Enabled = false;
        }

        private void Undo_Click(object sender, EventArgs e)
        {
            MainRichTextBox1.Undo();
            Undo.Enabled = false;
            Redo.Enabled = true;
        }

        private void Redo_Click(object sender, EventArgs e)
        {
            MainRichTextBox1.Redo();
            Redo.Enabled = false;
            Undo.Enabled = true;
        }

        private void �����������ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAll - �������� �� ���������� ������ TextBox
            MainRichTextBox1.SelectAll();
        }

        private void dateAndTime_Click(object sender, EventArgs e)
        {
            //��������� ����� ������ 
            MainRichTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void fontOpen_Click(object sender, EventArgs e)
        {
            //���������� � ������� ���� �� ��������
            FontDialog fontDialog = new FontDialog();
            fontDialog.ShowColor = true;

            fontDialog.Font = MainRichTextBox1.Font;
            fontDialog.Color = MainRichTextBox1.ForeColor;

            if (fontDialog.ShowDialog() != DialogResult.Cancel)
            {
                MainRichTextBox1.Font = fontDialog.Font;
                MainRichTextBox1.ForeColor = fontDialog.Color;
            }


        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            //��������� ����� ��� ���������� ������
            ColorDialog colorDialog1 = new ColorDialog();

            // Set the initial color of the dialog to the current text color.
            colorDialog1.Color = MainRichTextBox1.SelectionColor;

            // Determine if the user clicked OK in the dialog and that the color has changed.
            if (colorDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK &&
               colorDialog1.Color != MainRichTextBox1.SelectionColor)
            {
                // Change the selection color to the user specified color.
                MainRichTextBox1.SelectionColor = colorDialog1.Color;
            }
        }

        private void printFile_Click(object sender, EventArgs e)
        {
            text = MainRichTextBox1.Text;
            
             PrintDocument printDocument = new PrintDocument();
            printDocument.PrintPage += PrintPageHandler;

            PrintDialog printDialog = new PrintDialog();
            printDialog.Document = printDocument;
            if(printDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                printDialog.Document.Print();
            }
            
        }
        void PrintPageHandler(object sender, PrintPageEventArgs e)
        {
            //e.Graphics.DrawString(text, new Font("Arial",15),Brushes.Black, 0, 0);
            Graphics g = e.Graphics;
            g.DrawString(MainRichTextBox1.Text, Font, new SolidBrush(Color.Black), 0, 0);
            
        }

        private void aboutProgram_Click(object sender, EventArgs e)
        {
            MessageBox.Show("����� ������ ����� ����, ������� �����"
                , "������� �� ���������� ���", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //���������� ��� ��������� �������
        //float new_size = 9.0f;
        private void plusZoom_Click(object sender, EventArgs e)
        {
            MainRichTextBox1.Font = new Font(MainRichTextBox1.Font.FontFamily, 9, MainRichTextBox1.Font.Style);
        }

        private void minusZoom_Click(object sender, EventArgs e)
        {
            MainRichTextBox1.Font = new Font(MainRichTextBox1.Font.FontFamily, 9, MainRichTextBox1.Font.Style);
            //MainRichTextBox1.Font = new Font(MainRichTextBox1.Font.ToString(), new_size);
        }

        private void mainZoom_Click(object sender, EventArgs e)
        {
            
        }
    }
}