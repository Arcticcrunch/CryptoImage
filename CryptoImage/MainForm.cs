using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

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
            ImagePreview.Image = null;
            mainImage.Dispose();
            MainImageClearedEvent?.Invoke();
        }


        // Событие при загрузке главного изображения
        private void OnImageLoaded(Image image)
        {
            EncryptImageButton.Enabled = true;
            EncryptTextButton.Enabled = true;
        }
        // Событие при очистке главного изображения
        private void OnImageCleared()
        {
            EncryptImageButton.Enabled = false;
            EncryptTextButton.Enabled = false;
            StatusStripMainText.Text = "Главное изображение очищено.";
        }
        
    }

    public delegate void MainImageLoaded(Image image);
    public delegate void MainImageCleared();
}
