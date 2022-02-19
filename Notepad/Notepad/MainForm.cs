using System;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Notepad
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }
        


        private void ExitTSMI_Click(object sender, EventArgs e)
        {
            //Закрытие программы
            this.Close();
        }

        //Сохранение файла
        private void UTF8TSMI_Click(object sender, EventArgs e)
        {
            Encoding encode = Encoding.UTF8;
            Saving(encode);
        }

        private void UTF32TSMI_Click(object sender, EventArgs e)
        {
            Encoding encode = Encoding.UTF32;
            Saving(encode);
        }

        private void ASCIITSMI_Click(object sender, EventArgs e)
        {
            ASCIIEncoding ascii = new ASCIIEncoding();
            Saving(ascii);
        }



        //Открытие файла
        private void OpenTSMI_Click(object sender, EventArgs e)
        {
            //Открытие файла формата .txt
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NotePadRichTextBox.Text = File.ReadAllText(ofd.FileName, Encoding.UTF8);
                MessageBox.Show("Файл открыт");
            }
        }

        private void OpenUTF8TSMI_Click(object sender, EventArgs e)
        {
            Opening(Encoding.UTF8);
        }

        private void OpenUTF32TSMI_Click(object sender, EventArgs e)
        {
            Opening(Encoding.UTF32);
        }

        private void OpenAsciiTSMI_Click(object sender, EventArgs e)
        {
            Opening(Encoding.ASCII);
        }

        private void CreateTSMI_Click(object sender, EventArgs e)
        {
            //Создание файла, по факту просто очистка страницы
            NotePadRichTextBox.Clear();
        }



        //О программе
        private void AboutProgrammTSMI_Click(object sender, EventArgs e)
        {
            //Показ сообщения с небольшим описанием программы
            MessageBox.Show("Программа \"Блокнот\" содержит базовый функционал для редактирования текста.\n\nАвтор: Кузнецов А.В.", "О программе");
        }



        //Правка
        private void PasteTSMI_Click(object sender, EventArgs e)
        {
            //Вставка текста из буфера обмена (замена Ctrl + V)
            NotePadRichTextBox.Text += Clipboard.GetText();
        }

        private void DeleteTSMI_Click(object sender, EventArgs e)
        {
            //Удаление выделенного текста
            int StartPosition = NotePadRichTextBox.SelectionStart;
            int LengthSelection = NotePadRichTextBox.SelectionLength;
            NotePadRichTextBox.Text = NotePadRichTextBox.Text.Remove(StartPosition, LengthSelection);
        }

        private void CopyTSMI_Click(object sender, EventArgs e)
        {
            //Копирование текста в буфер обмена (замена Ctrl + C)
            Clipboard.SetText(NotePadRichTextBox.Text);

        }


        //Tool Menu
        private void BoldTool_Click(object sender, EventArgs e)
        {
            //Жирный
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //Ошибка при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Bold)
            {
                style &= ~FontStyle.Bold;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Bold;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }

        private void ItalicTool_Click(object sender, EventArgs e)
        {
            //Курсив
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //Ошибка при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Italic)
            {
                style &= ~FontStyle.Italic;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Italic;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }

        private void UnderlineTool_Click(object sender, EventArgs e)
        {
            FontStyle style;
            try
            {
                style = NotePadRichTextBox.SelectionFont.Style; //Здесь возникает ошибка при разных размерах текста
            }
            catch
            {
                style = 0;
            }

            if (NotePadRichTextBox.SelectionFont.Underline)
            {
                style &= ~FontStyle.Underline;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Regular);
            }
            else
            {
                style |= FontStyle.Underline;
                BoldTool.Font = new Font(BoldTool.Font, FontStyle.Bold);
            }
            NotePadRichTextBox.SelectionFont = new Font(NotePadRichTextBox.SelectionFont, style);
            NotePadRichTextBox.Focus();
        }

        private void RedTool_Click(object sender, EventArgs e)
        {
            //Красный цвет текста
            NotePadRichTextBox.SelectionColor = Color.Red;
        }

        private void GreenTool_Click(object sender, EventArgs e)
        {
            //Зелёный цвет текста
            NotePadRichTextBox.SelectionColor = Color.Green;
        }

        private void BlueTool_Click(object sender, EventArgs e)
        {
            //Голубой цвет текста
            NotePadRichTextBox.SelectionColor = Color.SkyBlue;
        }

        private void BlackTool_Click(object sender, EventArgs e)
        {
            NotePadRichTextBox.SelectionColor = Color.Black;
        }



        //Событийные методы
        private void FontComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (FontComboBox.Text)
            {
                case "Times New Roman":
                    {
                        Font myfont = new Font("Times New Roman", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Arial":
                    {
                        Font myfont = new Font("Arial", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Tahoma":
                    {
                        Font myfont = new Font("Tahoma", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Verdana":
                    {
                        Font myfont = new Font("Verdana", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Georgia":
                    {
                        Font myfont = new Font("Georgia", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "Marlett":
                    {
                        Font myfont = new Font("Marlett", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                case "MS Sans Serif":
                    {
                        Font myfont = new Font("MS Sans Serif", (byte)FontNumericUpFown.Value);
                        NotePadRichTextBox.SelectionFont = myfont;
                        break;
                    }
                default:
                    {
                        MessageBox.Show("Ошибка в определении шрифта.", "not stonks");
                        break;
                    }
            }
        }

        private void FontNumericUpDown_ValueChanged(object sender, EventArgs e)
        {
            Font myfont = new Font(FontComboBox.SelectedText, (byte)FontNumericUpFown.Value);
            NotePadRichTextBox.SelectionFont = myfont;
        }



        //Метод для сохранения в переданной кодировке
        private void Saving(Encoding encode)
        {
            SaveFileDialog sfd = new SaveFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (sfd.ShowDialog() == DialogResult.OK)
            {
                File.WriteAllText(sfd.FileName, NotePadRichTextBox.Text, encode);
                MessageBox.Show("Файл сохранен", "Успешный успех");
            }
        }

        //Метод для открытия файла в заданной кодировке
        private void Opening(Encoding encode)
        {
            OpenFileDialog ofd = new OpenFileDialog
            {
                Filter = "Текстовый документ (*.txt)|*.txt|Все файлы (*.*)|*.*"
            };

            if (ofd.ShowDialog() == DialogResult.OK)
            {
                NotePadRichTextBox.Text = File.ReadAllText(ofd.FileName, encode);
                MessageBox.Show("Файл открыт", "Успешный успех");
            }
        }
    }
}
