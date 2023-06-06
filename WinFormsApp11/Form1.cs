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
        //Булевая переменная отвечающая за указывание сохранён ли файл или нет, already - уже
        private bool fileAlreadySave;
        //Переменная, которая указывает изменён ли наш TextBox или же нет
        private bool fileUpdated;
        //Переменная записывающая в себя текущее имя файла, current - текущий
        private string currentFileName = "";
        public Form1()
        {
            InitializeComponent();

        }
        private string text = "";
        private void createNewWindow_Click(object sender, EventArgs e)
        {
            //Создаём новое диалоговое окно
            Form1 form = new Form1();
            form.ShowDialog();
        }

        private void openFile_Click(object sender, EventArgs e)
        {
            //Создаём экзэмпляр типа OpenFileDialog
            OpenFileDialog openFileDialog = new OpenFileDialog();
            //Указывает фильтры для формата файлов,которые мы будем использовать 
            openFileDialog.Filter = "Txt files (*.txt)|*.txt|Rtf files (*.rtf)|*.rtf";

            //Создаём экзэмпляр типа DialogResult 
            DialogResult result = openFileDialog.ShowDialog();

            //Если всё сработает положительно
            if(result == DialogResult.OK)
            {
                //Если путь получаемый из переменной "открывания файла".Её название равен формату .txt
                if(Path.GetExtension(openFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);
                }
                // Если путь получаемый из переменной "открывания файла".Её название равен формату.rtf
                if (Path.GetExtension(openFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.RichText);
                }
                //Текст с верхней панели блокнота
                this.Text = openFileDialog.FileName + " Notepad - просто пушка брат";

                //Если мы окрыли файл, то устанавливаем fileUpdate = false
                //И говорим, что файл был сохранён
                fileUpdated = false;
                fileAlreadySave = true;
                currentFileName = openFileDialog.FileName;
            }
            //Чтобы при открытии какого-либо файла кнопки
            //Отмена и Отмена отмены были недействительны до первого ввода текста
            Undo.Enabled = false;
            Redo.Enabled = false;
        }

        private void createNewFile_Click(object sender, EventArgs e)
        {
            if (fileUpdated)
            {
                DialogResult result = MessageBox.Show("Ты хочешь сохранить изменения ёпт?", "Сохранённый файл", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information);
                switch (result)
                {
                    case DialogResult.Yes:
                        fileSave();
                        break;

                    case DialogResult.No:
                        MainRichTextBox1.Clear();
                        fileUpdated = false;
                        this.Text = "Notepad - просто пушка брат";
                        break;

                    case DialogResult.Cancel:
                        break;


                }
            }
            else
            {
                this.Text = "Notepad - просто пушка брат";
            }
        }
        //Отрефакторинговая функция
        private void saveFileAs_Click(object sender, EventArgs e)
        {
            SaveAs();
        }

        private void SaveAs()
        {
            //Создаём экзэмпляр типа SaveFileDialog
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            //Указывает фильтры для формата файлов,которые мы будем использовать 
            saveFileDialog.Filter = "Txt files (*.txt)|*.txt|Rtf files (*.rtf)| *.rtf";

            // Создаём экзэмпляр типа DialogResult
            DialogResult result = saveFileDialog.ShowDialog();

            //Если всё сработает положительно
            if (result == DialogResult.OK)
            {
                //Если путь получаемый из переменной "открывания файла".Её название равен формату .txt
                if (Path.GetExtension(saveFileDialog.FileName) == ".txt")
                {
                    MainRichTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.PlainText);
                    SaveAsMyFicha(saveFileDialog);
                }
                //Если путь получаемый из переменной "открывания файла".Её название равен формату .rtf
                if (Path.GetExtension(saveFileDialog.FileName) == ".rtf")
                {
                    MainRichTextBox1.SaveFile(saveFileDialog.FileName, RichTextBoxStreamType.RichText);
                    SaveAsMyFicha(saveFileDialog);
                }

            }

        }

        private void SaveAsMyFicha(SaveFileDialog saveFileDialog)
        {
            //Если мы окрыли файл, то устанавливаем fileUpdate = false
            //И говорим, что файл был сохранён
            this.Text = saveFileDialog.FileName + " Notepad - просто пушка брат";
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
            //Делаем минимальный размер окна
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
            //Если файл был сохранён
            if (fileAlreadySave)
            {
                //Если название файла имеет расширение .txt
                if (Path.GetExtension(currentFileName) == ".txt")
                {
                    MainRichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.PlainText);
                }
                //Если название файла имеет расширение .rtf
                if (Path.GetExtension(currentFileName) == ".rtf")
                {
                    MainRichTextBox1.SaveFile(currentFileName, RichTextBoxStreamType.RichText);
                }
                fileUpdated = false;
            }
            //Иначе если файл не был сохранён
            else
            {
                //Если TextBox был подвержен измениям
                if (fileUpdated)
                {
                    SaveAs();
                }
                //Иначе просто очищаем TextBox
                else
                {
                    MainRichTextBox1.Clear();
                    fileUpdated = false;
                    this.Text = "Notepad - просто пушка брат";
                }
            }
            //Чтобы при сохранение какого-либо файла кнопки
            //Отмена и Отмена отмены были недействительны до первого ввода текста
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

        private void выделитьВсеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //SelectAll - Выделяет всё содержимое нашего TextBox
            MainRichTextBox1.SelectAll();
        }

        private void dateAndTime_Click(object sender, EventArgs e)
        {
            //Добавляем время сейчас 
            MainRichTextBox1.SelectedText = DateTime.Now.ToString();
        }

        private void fontOpen_Click(object sender, EventArgs e)
        {
            //НАстриваем и выводим окно со шрифтами
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
            //Изменение цвета для выделеного текста
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
            MessageBox.Show("Прога вообще пущка брат, отвечаю чисто"
                , "Справка из военкомата ёпт", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        //Переменная для изменения размера
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