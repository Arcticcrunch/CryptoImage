using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Cryptography;

namespace CryptoImage
{
    public partial class MainForm : Form
    {
        protected Image mainImage;

        public event MainImageLoaded MainImageLoadedEvent;
        public event MainImageCleared MainImageClearedEvent;

        public MainForm()
        {
            InitializeComponent();
            AvalableMemoryTooltip.SetToolTip(AvalableMemoryLabel, "0 байт");
            MainImageLoadedEvent += OnImageLoaded;
            MainImageClearedEvent += OnImageCleared;
            
            StatusStripMainText.Text = "Ожидание...";
        }

        // Выбор изображения
        private void OpenImageButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.OpenFileDialog openFile = new OpenFileDialog();
            openFile.Filter = ".BMP Изображения (*.bmp)|*.bmp";
            openFile.Title = "Открыть .BMP изображение";
            openFile.Multiselect = false;
            openFile.FilterIndex = 1;
            DialogResult dialogResult = openFile.ShowDialog();
            if (dialogResult == DialogResult.OK)
            {
                try
                {
                    mainImage = Bitmap.FromFile(openFile.FileName);
                    ImagePreview.Image = mainImage;
                    StatusStripMainText.Text = "Успешно открыто изображение:   " + openFile.FileName;
                    MainImageLoadedEvent?.Invoke(mainImage);
                }
                catch (Exception exception)
                {
                    StatusStripMainText.Text = "Не удалось открыть изображение!   " + openFile.FileName + 
                        "   Ошибка: " + exception.Message;
                }
            }
        }

        // Кнопка главного изображения
        private void ClearMainImageButton_Click(object sender, EventArgs e)
        {
            if (mainImage != null)
            {
                ImagePreview.Image = null;
                mainImage.Dispose();
                MainImageClearedEvent?.Invoke();
            }
        }


        // Событие при загрузке главного изображения
        private void OnImageLoaded(Image image)
        {
            EncryptImageButton.Enabled = true;
            EncryptTextButton.Enabled = true;
            if (Cryptography.Cryptography.IsImageHasEncryptedData(image))
            {
                SetAvalableMemoryLabel(Cryptography.Cryptography.GetAvalableEncryptMemory(image));
            }
            else
            {
                SetAvalableMemoryLabel(141005);
            }
        }
        // Событие при очистке главного изображения
        private void OnImageCleared()
        {
            EncryptImageButton.Enabled = false;
            EncryptTextButton.Enabled = false;
            SetAvalableMemoryLabel(0);
            StatusStripMainText.Text = "Главное изображение очищено.";
        }
        


        private void SetAvalableMemoryLabel(ulong memory)
        {
            string result = "";
            string bytesResult = "";
            string formatedResult = "";
            bool isMegabyte = false;

            if (memory < 1000000)
            {
                result = memory.ToString();
            }
            else
            {
                isMegabyte = true;
                result = ((ulong) Math.Round(memory * 0.000001)).ToString();
                StatusStripMainText.Text = result;
            }

            bytesResult = FormatMemoryString(memory.ToString());
            AvalableMemoryTooltip.SetToolTip(AvalableMemoryLabel, bytesResult + " байт");

            formatedResult = FormatMemoryString(result);
            
            if (isMegabyte)
                formatedResult += " мегабайт";
            else formatedResult += " байт";
            AvalableMemoryLabel.Text = formatedResult;
        }


        /// <summary>
        /// Форматирование строки с пробелами через каждые 3 символа начиная с конца.
        /// </summary>
        /// <param name="inputString">Входная строка</param>
        /// <returns></returns>
        private string FormatMemoryString(string inputString)
        {
            string result = "";
            byte counter = 0;
            if (inputString == null)
                return result;
            if (inputString.Length == 0)
                return result;
            result += inputString[inputString.Length - 1];
            for (int i = inputString.Length - 2; i >= 0; i--)
            {
                if (counter < 2)
                {
                    result += inputString[i];
                    counter++;
                }
                else
                {
                    counter = 0;
                    result += ' ';
                    result += inputString[i];
                }
            }
            char[] reversedString = result.ToCharArray();
            Array.Reverse(reversedString);
            return new string(reversedString);
        }
    }

    public delegate void MainImageLoaded(Image image);
    public delegate void MainImageCleared();
}
