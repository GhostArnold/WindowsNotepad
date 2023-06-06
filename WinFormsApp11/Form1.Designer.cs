namespace WinFormsApp11
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.файлToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewFile = new System.Windows.Forms.ToolStripMenuItem();
            this.createNewWindow = new System.Windows.Forms.ToolStripMenuItem();
            this.openFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFile = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileAs = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.параметрыСтраницыToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.printFile = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripSeparator();
            this.appExit = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.вырезатьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.копироватьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.удалитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripSeparator();
            this.поискСПомощьюBingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиДалееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.найтиРанееToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.заменитьToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.перейтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripSeparator();
            this.выделитьВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dateAndTime = new System.Windows.Forms.ToolStripMenuItem();
            this.Undo = new System.Windows.Forms.ToolStripMenuItem();
            this.Redo = new System.Windows.Forms.ToolStripMenuItem();
            this.форматToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.переномПоСловамToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.fontOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColor = new System.Windows.Forms.ToolStripMenuItem();
            this.видToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.масштабToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.plusZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.minusZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.mainZoom = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.просмотретьСправкуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.отправитьОтзывToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripSeparator();
            this.aboutProgram = new System.Windows.Forms.ToolStripMenuItem();
            this.MainRichTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.файлToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.форматToolStripMenuItem,
            this.видToolStripMenuItem,
            this.справкаToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(6, 3, 0, 3);
            this.menuStrip1.Size = new System.Drawing.Size(643, 30);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // файлToolStripMenuItem
            // 
            this.файлToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.createNewFile,
            this.createNewWindow,
            this.openFile,
            this.saveFile,
            this.saveFileAs,
            this.toolStripMenuItem1,
            this.параметрыСтраницыToolStripMenuItem,
            this.printFile,
            this.toolStripMenuItem2,
            this.appExit});
            this.файлToolStripMenuItem.Name = "файлToolStripMenuItem";
            this.файлToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.файлToolStripMenuItem.Text = "Файл";
            // 
            // createNewFile
            // 
            this.createNewFile.Name = "createNewFile";
            this.createNewFile.ShortcutKeyDisplayString = "CTRL+N";
            this.createNewFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
            this.createNewFile.Size = new System.Drawing.Size(309, 26);
            this.createNewFile.Text = "Создать";
            this.createNewFile.Click += new System.EventHandler(this.createNewFile_Click);
            // 
            // createNewWindow
            // 
            this.createNewWindow.Name = "createNewWindow";
            this.createNewWindow.ShortcutKeyDisplayString = "CTRL+SHIFT+N";
            this.createNewWindow.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.N)));
            this.createNewWindow.Size = new System.Drawing.Size(309, 26);
            this.createNewWindow.Text = "Новое окно";
            this.createNewWindow.Click += new System.EventHandler(this.createNewWindow_Click);
            // 
            // openFile
            // 
            this.openFile.Name = "openFile";
            this.openFile.ShortcutKeyDisplayString = "CTRL+O";
            this.openFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
            this.openFile.Size = new System.Drawing.Size(309, 26);
            this.openFile.Text = "Открыть";
            this.openFile.Click += new System.EventHandler(this.openFile_Click);
            // 
            // saveFile
            // 
            this.saveFile.Name = "saveFile";
            this.saveFile.ShortcutKeyDisplayString = "CTRL+S";
            this.saveFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.saveFile.Size = new System.Drawing.Size(309, 26);
            this.saveFile.Text = "Сохранить";
            this.saveFile.Click += new System.EventHandler(this.saveFile_Click);
            // 
            // saveFileAs
            // 
            this.saveFileAs.Name = "saveFileAs";
            this.saveFileAs.ShortcutKeyDisplayString = "CTRL+SHIFT+S";
            this.saveFileAs.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.S)));
            this.saveFileAs.Size = new System.Drawing.Size(309, 26);
            this.saveFileAs.Text = "Сохранить как...";
            this.saveFileAs.Click += new System.EventHandler(this.saveFileAs_Click);
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(306, 6);
            // 
            // параметрыСтраницыToolStripMenuItem
            // 
            this.параметрыСтраницыToolStripMenuItem.Name = "параметрыСтраницыToolStripMenuItem";
            this.параметрыСтраницыToolStripMenuItem.Size = new System.Drawing.Size(309, 26);
            this.параметрыСтраницыToolStripMenuItem.Text = "Параметры страницы...";
            // 
            // printFile
            // 
            this.printFile.Name = "printFile";
            this.printFile.ShortcutKeyDisplayString = "CTRL+P";
            this.printFile.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.printFile.Size = new System.Drawing.Size(309, 26);
            this.printFile.Text = "Печать...";
            this.printFile.Click += new System.EventHandler(this.printFile_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(306, 6);
            // 
            // appExit
            // 
            this.appExit.Name = "appExit";
            this.appExit.Size = new System.Drawing.Size(309, 26);
            this.appExit.Text = "Выход";
            this.appExit.Click += new System.EventHandler(this.appExit_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.отменитьToolStripMenuItem,
            this.toolStripMenuItem3,
            this.вырезатьToolStripMenuItem,
            this.копироватьToolStripMenuItem,
            this.вставитьToolStripMenuItem,
            this.удалитьToolStripMenuItem,
            this.toolStripMenuItem4,
            this.поискСПомощьюBingToolStripMenuItem,
            this.найтиToolStripMenuItem,
            this.найтиДалееToolStripMenuItem,
            this.найтиРанееToolStripMenuItem,
            this.заменитьToolStripMenuItem,
            this.перейтиToolStripMenuItem,
            this.toolStripMenuItem5,
            this.выделитьВсеToolStripMenuItem,
            this.dateAndTime,
            this.Undo,
            this.Redo});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // отменитьToolStripMenuItem
            // 
            this.отменитьToolStripMenuItem.Name = "отменитьToolStripMenuItem";
            this.отменитьToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+Z";
            this.отменитьToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.отменитьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.отменитьToolStripMenuItem.Text = "Отменить";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(320, 6);
            // 
            // вырезатьToolStripMenuItem
            // 
            this.вырезатьToolStripMenuItem.Name = "вырезатьToolStripMenuItem";
            this.вырезатьToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+X";
            this.вырезатьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.вырезатьToolStripMenuItem.Text = "Вырезать";
            // 
            // копироватьToolStripMenuItem
            // 
            this.копироватьToolStripMenuItem.Name = "копироватьToolStripMenuItem";
            this.копироватьToolStripMenuItem.ShortcutKeyDisplayString = "  CTRL+C";
            this.копироватьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.копироватьToolStripMenuItem.Text = "Копировать";
            // 
            // вставитьToolStripMenuItem
            // 
            this.вставитьToolStripMenuItem.Name = "вставитьToolStripMenuItem";
            this.вставитьToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+V";
            this.вставитьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.вставитьToolStripMenuItem.Text = "Вставить";
            // 
            // удалитьToolStripMenuItem
            // 
            this.удалитьToolStripMenuItem.Name = "удалитьToolStripMenuItem";
            this.удалитьToolStripMenuItem.ShortcutKeyDisplayString = "Del";
            this.удалитьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.удалитьToolStripMenuItem.Text = "Удалить";
            // 
            // toolStripMenuItem4
            // 
            this.toolStripMenuItem4.Name = "toolStripMenuItem4";
            this.toolStripMenuItem4.Size = new System.Drawing.Size(320, 6);
            // 
            // поискСПомощьюBingToolStripMenuItem
            // 
            this.поискСПомощьюBingToolStripMenuItem.Name = "поискСПомощьюBingToolStripMenuItem";
            this.поискСПомощьюBingToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+E";
            this.поискСПомощьюBingToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.поискСПомощьюBingToolStripMenuItem.Text = "Поиск с помощью Bing...";
            // 
            // найтиToolStripMenuItem
            // 
            this.найтиToolStripMenuItem.Name = "найтиToolStripMenuItem";
            this.найтиToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+F";
            this.найтиToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.найтиToolStripMenuItem.Text = "Найти...";
            // 
            // найтиДалееToolStripMenuItem
            // 
            this.найтиДалееToolStripMenuItem.Name = "найтиДалееToolStripMenuItem";
            this.найтиДалееToolStripMenuItem.ShortcutKeyDisplayString = "F3";
            this.найтиДалееToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.найтиДалееToolStripMenuItem.Text = "Найти далее";
            // 
            // найтиРанееToolStripMenuItem
            // 
            this.найтиРанееToolStripMenuItem.Name = "найтиРанееToolStripMenuItem";
            this.найтиРанееToolStripMenuItem.ShortcutKeyDisplayString = "SHIFT+F3";
            this.найтиРанееToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.найтиРанееToolStripMenuItem.Text = "Найти ранее";
            // 
            // заменитьToolStripMenuItem
            // 
            this.заменитьToolStripMenuItem.Name = "заменитьToolStripMenuItem";
            this.заменитьToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+H";
            this.заменитьToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.заменитьToolStripMenuItem.Text = "Заменить...";
            // 
            // перейтиToolStripMenuItem
            // 
            this.перейтиToolStripMenuItem.Name = "перейтиToolStripMenuItem";
            this.перейтиToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+G";
            this.перейтиToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.перейтиToolStripMenuItem.Text = "Перейти...";
            // 
            // toolStripMenuItem5
            // 
            this.toolStripMenuItem5.Name = "toolStripMenuItem5";
            this.toolStripMenuItem5.Size = new System.Drawing.Size(320, 6);
            // 
            // выделитьВсеToolStripMenuItem
            // 
            this.выделитьВсеToolStripMenuItem.Name = "выделитьВсеToolStripMenuItem";
            this.выделитьВсеToolStripMenuItem.ShortcutKeyDisplayString = "CTRL+A";
            this.выделитьВсеToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.выделитьВсеToolStripMenuItem.Size = new System.Drawing.Size(323, 26);
            this.выделитьВсеToolStripMenuItem.Text = "Выделить все";
            this.выделитьВсеToolStripMenuItem.Click += new System.EventHandler(this.выделитьВсеToolStripMenuItem_Click);
            // 
            // dateAndTime
            // 
            this.dateAndTime.Name = "dateAndTime";
            this.dateAndTime.ShortcutKeyDisplayString = "F5";
            this.dateAndTime.Size = new System.Drawing.Size(323, 26);
            this.dateAndTime.Text = "Время и дата";
            this.dateAndTime.Click += new System.EventHandler(this.dateAndTime_Click);
            // 
            // Undo
            // 
            this.Undo.Enabled = false;
            this.Undo.Name = "Undo";
            this.Undo.ShortcutKeyDisplayString = "CTRL+Z";
            this.Undo.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Undo.Size = new System.Drawing.Size(323, 26);
            this.Undo.Text = "Отменить";
            this.Undo.Click += new System.EventHandler(this.Undo_Click);
            // 
            // Redo
            // 
            this.Redo.Enabled = false;
            this.Redo.Name = "Redo";
            this.Redo.ShortcutKeyDisplayString = "CTRL+SHIFT+Z";
            this.Redo.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
            this.Redo.Size = new System.Drawing.Size(323, 26);
            this.Redo.Text = "Отвенить отмену";
            this.Redo.Click += new System.EventHandler(this.Redo_Click);
            // 
            // форматToolStripMenuItem
            // 
            this.форматToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.переномПоСловамToolStripMenuItem,
            this.fontOpen,
            this.changeColor});
            this.форматToolStripMenuItem.Name = "форматToolStripMenuItem";
            this.форматToolStripMenuItem.Size = new System.Drawing.Size(77, 24);
            this.форматToolStripMenuItem.Text = "Формат";
            // 
            // переномПоСловамToolStripMenuItem
            // 
            this.переномПоСловамToolStripMenuItem.Name = "переномПоСловамToolStripMenuItem";
            this.переномПоСловамToolStripMenuItem.Size = new System.Drawing.Size(234, 26);
            this.переномПоСловамToolStripMenuItem.Text = "Переном по словам";
            // 
            // fontOpen
            // 
            this.fontOpen.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fontOpen.Name = "fontOpen";
            this.fontOpen.Size = new System.Drawing.Size(234, 26);
            this.fontOpen.Text = "Шрифт...";
            this.fontOpen.Click += new System.EventHandler(this.fontOpen_Click);
            // 
            // changeColor
            // 
            this.changeColor.Name = "changeColor";
            this.changeColor.Size = new System.Drawing.Size(234, 26);
            this.changeColor.Text = "Изменение цвета...";
            this.changeColor.Click += new System.EventHandler(this.changeColor_Click);
            // 
            // видToolStripMenuItem
            // 
            this.видToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.масштабToolStripMenuItem});
            this.видToolStripMenuItem.Name = "видToolStripMenuItem";
            this.видToolStripMenuItem.Size = new System.Drawing.Size(49, 24);
            this.видToolStripMenuItem.Text = "Вид";
            // 
            // масштабToolStripMenuItem
            // 
            this.масштабToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.plusZoom,
            this.minusZoom,
            this.mainZoom});
            this.масштабToolStripMenuItem.Name = "масштабToolStripMenuItem";
            this.масштабToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.масштабToolStripMenuItem.Text = "Масштаб";
            // 
            // plusZoom
            // 
            this.plusZoom.Name = "plusZoom";
            this.plusZoom.Size = new System.Drawing.Size(365, 26);
            this.plusZoom.Text = "Увеличить";
            this.plusZoom.Click += new System.EventHandler(this.plusZoom_Click);
            // 
            // minusZoom
            // 
            this.minusZoom.Name = "minusZoom";
            this.minusZoom.Size = new System.Drawing.Size(365, 26);
            this.minusZoom.Text = "Уменьшить";
            this.minusZoom.Click += new System.EventHandler(this.minusZoom_Click);
            // 
            // mainZoom
            // 
            this.mainZoom.Name = "mainZoom";
            this.mainZoom.Size = new System.Drawing.Size(365, 26);
            this.mainZoom.Text = "Восстановить мастштаб по умолчанию";
            this.mainZoom.Click += new System.EventHandler(this.mainZoom_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.просмотретьСправкуToolStripMenuItem,
            this.отправитьОтзывToolStripMenuItem,
            this.toolStripMenuItem6,
            this.aboutProgram});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // просмотретьСправкуToolStripMenuItem
            // 
            this.просмотретьСправкуToolStripMenuItem.Name = "просмотретьСправкуToolStripMenuItem";
            this.просмотретьСправкуToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.просмотретьСправкуToolStripMenuItem.Text = "Просмотреть справку";
            // 
            // отправитьОтзывToolStripMenuItem
            // 
            this.отправитьОтзывToolStripMenuItem.Name = "отправитьОтзывToolStripMenuItem";
            this.отправитьОтзывToolStripMenuItem.Size = new System.Drawing.Size(244, 26);
            this.отправитьОтзывToolStripMenuItem.Text = "Отправить отзыв";
            // 
            // toolStripMenuItem6
            // 
            this.toolStripMenuItem6.Name = "toolStripMenuItem6";
            this.toolStripMenuItem6.Size = new System.Drawing.Size(241, 6);
            // 
            // aboutProgram
            // 
            this.aboutProgram.Name = "aboutProgram";
            this.aboutProgram.Size = new System.Drawing.Size(244, 26);
            this.aboutProgram.Text = "О программе";
            this.aboutProgram.Click += new System.EventHandler(this.aboutProgram_Click);
            // 
            // MainRichTextBox1
            // 
            this.MainRichTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainRichTextBox1.Location = new System.Drawing.Point(0, 30);
            this.MainRichTextBox1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MainRichTextBox1.Name = "MainRichTextBox1";
            this.MainRichTextBox1.Size = new System.Drawing.Size(643, 739);
            this.MainRichTextBox1.TabIndex = 1;
            this.MainRichTextBox1.Text = "";
            this.MainRichTextBox1.TextChanged += new System.EventHandler(this.MainRichTextBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(643, 769);
            this.Controls.Add(this.MainRichTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Notepad";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem файлToolStripMenuItem;
        private ToolStripMenuItem createNewFile;
        private ToolStripMenuItem createNewWindow;
        private ToolStripMenuItem openFile;
        private ToolStripMenuItem saveFile;
        private ToolStripMenuItem saveFileAs;
        private ToolStripSeparator toolStripMenuItem1;
        private ToolStripMenuItem параметрыСтраницыToolStripMenuItem;
        private ToolStripMenuItem printFile;
        private ToolStripSeparator toolStripMenuItem2;
        private ToolStripMenuItem appExit;
        private ToolStripMenuItem правкаToolStripMenuItem;
        private ToolStripMenuItem отменитьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem3;
        private ToolStripMenuItem вырезатьToolStripMenuItem;
        private ToolStripMenuItem копироватьToolStripMenuItem;
        private ToolStripMenuItem вставитьToolStripMenuItem;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem4;
        private ToolStripMenuItem поискСПомощьюBingToolStripMenuItem;
        private ToolStripMenuItem найтиToolStripMenuItem;
        private ToolStripMenuItem найтиДалееToolStripMenuItem;
        private ToolStripMenuItem найтиРанееToolStripMenuItem;
        private ToolStripMenuItem заменитьToolStripMenuItem;
        private ToolStripMenuItem перейтиToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem5;
        private ToolStripMenuItem выделитьВсеToolStripMenuItem;
        private ToolStripMenuItem dateAndTime;
        private ToolStripMenuItem форматToolStripMenuItem;
        private ToolStripMenuItem видToolStripMenuItem;
        private ToolStripMenuItem справкаToolStripMenuItem;
        private RichTextBox MainRichTextBox1;
        private ToolStripMenuItem переномПоСловамToolStripMenuItem;
        private ToolStripMenuItem fontOpen;
        private ToolStripMenuItem масштабToolStripMenuItem;
        private ToolStripMenuItem plusZoom;
        private ToolStripMenuItem minusZoom;
        private ToolStripMenuItem mainZoom;
        private ToolStripMenuItem просмотретьСправкуToolStripMenuItem;
        private ToolStripMenuItem отправитьОтзывToolStripMenuItem;
        private ToolStripSeparator toolStripMenuItem6;
        private ToolStripMenuItem aboutProgram;
        private ToolStripMenuItem Undo;
        private ToolStripMenuItem Redo;
        private ToolStripMenuItem changeColor;
    }
}