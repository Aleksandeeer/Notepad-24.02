
namespace Notepad
{
    partial class MainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MainStripMenu = new System.Windows.Forms.MenuStrip();
            this.FileTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.CreateTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.openTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUTF8TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUTF32TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenAsciiTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveUTF8TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveUTF32TSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.SaveAsciiTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.ExitTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.AboutProgrammTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CopyTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.PasteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.DeleteTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.NotePadRichTextBox = new System.Windows.Forms.RichTextBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.BoldTool = new System.Windows.Forms.ToolStripButton();
            this.UnderlineTool = new System.Windows.Forms.ToolStripButton();
            this.ItalicTool = new System.Windows.Forms.ToolStripButton();
            this.BlackTool = new System.Windows.Forms.ToolStripButton();
            this.BlueTool = new System.Windows.Forms.ToolStripButton();
            this.RedTool = new System.Windows.Forms.ToolStripButton();
            this.GreenTool = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.FontComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripLabel2 = new System.Windows.Forms.ToolStripLabel();
            this.SizeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.PrintTSMI = new System.Windows.Forms.ToolStripMenuItem();
            this.MainStripMenu.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainStripMenu
            // 
            this.MainStripMenu.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.MainStripMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.FileTSMI,
            this.справкаToolStripMenuItem,
            this.правкаToolStripMenuItem});
            this.MainStripMenu.Location = new System.Drawing.Point(0, 0);
            this.MainStripMenu.Name = "MainStripMenu";
            this.MainStripMenu.Size = new System.Drawing.Size(660, 28);
            this.MainStripMenu.TabIndex = 0;
            // 
            // FileTSMI
            // 
            this.FileTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CreateTSMI,
            this.openTSMI,
            this.PrintTSMI,
            this.SaveTSMI,
            this.ExitTSMI});
            this.FileTSMI.Name = "FileTSMI";
            this.FileTSMI.Size = new System.Drawing.Size(59, 24);
            this.FileTSMI.Text = "Файл";
            // 
            // CreateTSMI
            // 
            this.CreateTSMI.Name = "CreateTSMI";
            this.CreateTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Delete)));
            this.CreateTSMI.Size = new System.Drawing.Size(224, 26);
            this.CreateTSMI.Text = "Создать";
            this.CreateTSMI.Click += new System.EventHandler(this.CreateTSMI_Click);
            // 
            // openTSMI
            // 
            this.openTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenUTF8TSMI,
            this.OpenUTF32TSMI,
            this.OpenAsciiTSMI});
            this.openTSMI.Name = "openTSMI";
            this.openTSMI.Size = new System.Drawing.Size(224, 26);
            this.openTSMI.Text = "Загрузить";
            this.openTSMI.Click += new System.EventHandler(this.OpenTSMI_Click);
            // 
            // OpenUTF8TSMI
            // 
            this.OpenUTF8TSMI.Name = "OpenUTF8TSMI";
            this.OpenUTF8TSMI.Size = new System.Drawing.Size(248, 26);
            this.OpenUTF8TSMI.Text = "UTF-8 (по умолчанию)";
            this.OpenUTF8TSMI.Click += new System.EventHandler(this.OpenUTF8TSMI_Click);
            // 
            // OpenUTF32TSMI
            // 
            this.OpenUTF32TSMI.Name = "OpenUTF32TSMI";
            this.OpenUTF32TSMI.Size = new System.Drawing.Size(248, 26);
            this.OpenUTF32TSMI.Text = "UTF-32";
            this.OpenUTF32TSMI.Click += new System.EventHandler(this.OpenUTF32TSMI_Click);
            // 
            // OpenAsciiTSMI
            // 
            this.OpenAsciiTSMI.Name = "OpenAsciiTSMI";
            this.OpenAsciiTSMI.Size = new System.Drawing.Size(248, 26);
            this.OpenAsciiTSMI.Text = "ASCII";
            this.OpenAsciiTSMI.Click += new System.EventHandler(this.OpenAsciiTSMI_Click);
            // 
            // SaveTSMI
            // 
            this.SaveTSMI.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.SaveUTF8TSMI,
            this.SaveUTF32TSMI,
            this.SaveAsciiTSMI});
            this.SaveTSMI.Name = "SaveTSMI";
            this.SaveTSMI.RightToLeftAutoMirrorImage = true;
            this.SaveTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
            this.SaveTSMI.Size = new System.Drawing.Size(224, 26);
            this.SaveTSMI.Text = "Сохранить";
            // 
            // SaveUTF8TSMI
            // 
            this.SaveUTF8TSMI.Name = "SaveUTF8TSMI";
            this.SaveUTF8TSMI.Size = new System.Drawing.Size(248, 26);
            this.SaveUTF8TSMI.Text = "UTF-8 (по умолчанию)";
            this.SaveUTF8TSMI.Click += new System.EventHandler(this.UTF8TSMI_Click);
            // 
            // SaveUTF32TSMI
            // 
            this.SaveUTF32TSMI.Name = "SaveUTF32TSMI";
            this.SaveUTF32TSMI.Size = new System.Drawing.Size(248, 26);
            this.SaveUTF32TSMI.Text = "UTF-32";
            this.SaveUTF32TSMI.Click += new System.EventHandler(this.UTF32TSMI_Click);
            // 
            // SaveAsciiTSMI
            // 
            this.SaveAsciiTSMI.Name = "SaveAsciiTSMI";
            this.SaveAsciiTSMI.Size = new System.Drawing.Size(248, 26);
            this.SaveAsciiTSMI.Text = "ASCII";
            this.SaveAsciiTSMI.Click += new System.EventHandler(this.ASCIITSMI_Click);
            // 
            // ExitTSMI
            // 
            this.ExitTSMI.Name = "ExitTSMI";
            this.ExitTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.End)));
            this.ExitTSMI.Size = new System.Drawing.Size(224, 26);
            this.ExitTSMI.Text = "Выход";
            this.ExitTSMI.Click += new System.EventHandler(this.ExitTSMI_Click);
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.AboutProgrammTSMI});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.справкаToolStripMenuItem.Text = "Справка";
            // 
            // AboutProgrammTSMI
            // 
            this.AboutProgrammTSMI.Name = "AboutProgrammTSMI";
            this.AboutProgrammTSMI.Size = new System.Drawing.Size(187, 26);
            this.AboutProgrammTSMI.Text = "О программе";
            this.AboutProgrammTSMI.Click += new System.EventHandler(this.AboutProgrammTSMI_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.CopyTSMI,
            this.PasteTSMI,
            this.DeleteTSMI});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // CopyTSMI
            // 
            this.CopyTSMI.Name = "CopyTSMI";
            this.CopyTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.CopyTSMI.Size = new System.Drawing.Size(227, 26);
            this.CopyTSMI.Text = "Копировать";
            this.CopyTSMI.Click += new System.EventHandler(this.CopyTSMI_Click);
            // 
            // PasteTSMI
            // 
            this.PasteTSMI.Name = "PasteTSMI";
            this.PasteTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.PasteTSMI.Size = new System.Drawing.Size(227, 26);
            this.PasteTSMI.Text = "Вставить";
            this.PasteTSMI.Click += new System.EventHandler(this.PasteTSMI_Click);
            // 
            // DeleteTSMI
            // 
            this.DeleteTSMI.Name = "DeleteTSMI";
            this.DeleteTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
            this.DeleteTSMI.Size = new System.Drawing.Size(227, 26);
            this.DeleteTSMI.Text = "Вырезать";
            this.DeleteTSMI.Click += new System.EventHandler(this.DeleteTSMI_Click);
            // 
            // NotePadRichTextBox
            // 
            this.NotePadRichTextBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.NotePadRichTextBox.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.NotePadRichTextBox.Location = new System.Drawing.Point(0, 58);
            this.NotePadRichTextBox.Name = "NotePadRichTextBox";
            this.NotePadRichTextBox.Size = new System.Drawing.Size(660, 469);
            this.NotePadRichTextBox.TabIndex = 1;
            this.NotePadRichTextBox.Text = "";
            // 
            // toolStrip1
            // 
            this.toolStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.BoldTool,
            this.UnderlineTool,
            this.ItalicTool,
            this.BlackTool,
            this.BlueTool,
            this.RedTool,
            this.GreenTool,
            this.toolStripLabel1,
            this.FontComboBox,
            this.toolStripLabel2,
            this.SizeComboBox});
            this.toolStrip1.Location = new System.Drawing.Point(0, 28);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(567, 31);
            this.toolStrip1.TabIndex = 2;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // BoldTool
            // 
            this.BoldTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BoldTool.Image = global::Notepad.Properties.Resources.BoldLetter;
            this.BoldTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BoldTool.Name = "BoldTool";
            this.BoldTool.Size = new System.Drawing.Size(29, 25);
            this.BoldTool.Text = "FatTool";
            this.BoldTool.Click += new System.EventHandler(this.BoldTool_Click);
            // 
            // UnderlineTool
            // 
            this.UnderlineTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.UnderlineTool.Image = global::Notepad.Properties.Resources.UnderlineLetter;
            this.UnderlineTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.UnderlineTool.Name = "UnderlineTool";
            this.UnderlineTool.Size = new System.Drawing.Size(29, 25);
            this.UnderlineTool.Text = "toolStripButton1";
            this.UnderlineTool.Click += new System.EventHandler(this.UnderlineTool_Click);
            // 
            // ItalicTool
            // 
            this.ItalicTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ItalicTool.Image = ((System.Drawing.Image)(resources.GetObject("ItalicTool.Image")));
            this.ItalicTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ItalicTool.Name = "ItalicTool";
            this.ItalicTool.Size = new System.Drawing.Size(29, 28);
            this.ItalicTool.Text = "toolStripButton1";
            this.ItalicTool.Click += new System.EventHandler(this.ItalicTool_Click);
            // 
            // BlackTool
            // 
            this.BlackTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlackTool.Image = ((System.Drawing.Image)(resources.GetObject("BlackTool.Image")));
            this.BlackTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlackTool.Name = "BlackTool";
            this.BlackTool.Size = new System.Drawing.Size(29, 25);
            this.BlackTool.Text = "toolStripButton1";
            this.BlackTool.Click += new System.EventHandler(this.BlackTool_Click);
            // 
            // BlueTool
            // 
            this.BlueTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.BlueTool.Image = ((System.Drawing.Image)(resources.GetObject("BlueTool.Image")));
            this.BlueTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.BlueTool.Name = "BlueTool";
            this.BlueTool.Size = new System.Drawing.Size(29, 25);
            this.BlueTool.Text = "toolStripButton1";
            this.BlueTool.Click += new System.EventHandler(this.BlueTool_Click);
            // 
            // RedTool
            // 
            this.RedTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.RedTool.ForeColor = System.Drawing.Color.Red;
            this.RedTool.Image = ((System.Drawing.Image)(resources.GetObject("RedTool.Image")));
            this.RedTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.RedTool.Name = "RedTool";
            this.RedTool.Size = new System.Drawing.Size(29, 25);
            this.RedTool.Text = "toolStripButton1";
            this.RedTool.Click += new System.EventHandler(this.RedTool_Click);
            // 
            // GreenTool
            // 
            this.GreenTool.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.GreenTool.Image = ((System.Drawing.Image)(resources.GetObject("GreenTool.Image")));
            this.GreenTool.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.GreenTool.Name = "GreenTool";
            this.GreenTool.Size = new System.Drawing.Size(29, 25);
            this.GreenTool.Text = "toolStripButton1";
            this.GreenTool.Click += new System.EventHandler(this.GreenTool_Click);
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(57, 25);
            this.toolStripLabel1.Text = "Шрифт";
            // 
            // FontComboBox
            // 
            this.FontComboBox.Items.AddRange(new object[] {
            "Verdana",
            "Times New Roman",
            "Arial",
            "Tahoma",
            "Georgia"});
            this.FontComboBox.Name = "FontComboBox";
            this.FontComboBox.Size = new System.Drawing.Size(155, 28);
            this.FontComboBox.Text = "(по умолчанию)";
            this.FontComboBox.SelectedIndexChanged += new System.EventHandler(this.FontComboBox_SelectedIndexChanged_1);
            // 
            // toolStripLabel2
            // 
            this.toolStripLabel2.Name = "toolStripLabel2";
            this.toolStripLabel2.Size = new System.Drawing.Size(60, 25);
            this.toolStripLabel2.Text = "Размер";
            // 
            // SizeComboBox
            // 
            this.SizeComboBox.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28"});
            this.SizeComboBox.Name = "SizeComboBox";
            this.SizeComboBox.Size = new System.Drawing.Size(75, 28);
            this.SizeComboBox.Text = "10";
            this.SizeComboBox.SelectedIndexChanged += new System.EventHandler(this.SizeComboBox_SelectedIndexChanged);
            // 
            // PrintTSMI
            // 
            this.PrintTSMI.Name = "PrintTSMI";
            this.PrintTSMI.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.P)));
            this.PrintTSMI.Size = new System.Drawing.Size(224, 26);
            this.PrintTSMI.Text = "Печать";
            this.PrintTSMI.Click += new System.EventHandler(this.PrintTSMI_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(660, 527);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.NotePadRichTextBox);
            this.Controls.Add(this.MainStripMenu);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.MainStripMenu;
            this.Name = "MainForm";
            this.Text = "Блокнот";
            this.MainStripMenu.ResumeLayout(false);
            this.MainStripMenu.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MainStripMenu;
        private System.Windows.Forms.ToolStripMenuItem FileTSMI;
        private System.Windows.Forms.ToolStripMenuItem CreateTSMI;
        private System.Windows.Forms.ToolStripMenuItem openTSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveTSMI;
        private System.Windows.Forms.ToolStripMenuItem ExitTSMI;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem AboutProgrammTSMI;
        private System.Windows.Forms.RichTextBox NotePadRichTextBox;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CopyTSMI;
        private System.Windows.Forms.ToolStripMenuItem PasteTSMI;
        private System.Windows.Forms.ToolStripMenuItem DeleteTSMI;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton BoldTool;
        private System.Windows.Forms.ToolStripButton ItalicTool;
        private System.Windows.Forms.ToolStripButton RedTool;
        private System.Windows.Forms.ToolStripButton GreenTool;
        private System.Windows.Forms.ToolStripButton BlueTool;
        private System.Windows.Forms.ToolStripMenuItem SaveUTF8TSMI;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem SaveUTF32TSMI;
        private System.Windows.Forms.ToolStripMenuItem SaveAsciiTSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenUTF8TSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenUTF32TSMI;
        private System.Windows.Forms.ToolStripMenuItem OpenAsciiTSMI;
        private System.Windows.Forms.ToolStripButton BlackTool;
        private System.Windows.Forms.ToolStripButton UnderlineTool;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripComboBox FontComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripLabel2;
        private System.Windows.Forms.ToolStripComboBox SizeComboBox;
        private System.Windows.Forms.ToolStripMenuItem PrintTSMI;
    }
}

