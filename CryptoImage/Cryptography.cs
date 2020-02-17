using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace Cryptography
{
    public static class Cryptography
    {
        /// <summary>
        /// Закодировать текст в .BMP изображении.
        /// </summary>
        /// <param name="mainImage">.BMP изображение.</param>
        /// <param name="text">Строка текста для записи.</param>
        /// <param name="encryptionType">Тип кодирования.</param>
        /// <returns></returns>
        public static bool Encrypt(Image mainImage, string text, EncryptionType encryptionType = EncryptionType.Basic)
        {

            return true;
        }        
        /// <summary>
        /// Закодировать массив байт в .BMP изображении.
        /// </summary>
        /// <param name="mainImage">.BMP изображение.</param>
        /// <param name="data">Массив байт для записи.</param>
        /// <param name="encryptionType">Тип кодирования.</param>
        /// <returns></returns>
        public static bool Encrypt(Image mainImage, byte[] data, EncryptionType encryptionType = EncryptionType.Basic)
        {

            return true;
        }
        /// <summary>
        /// Закодировать .BMP изображение в другое .BMP изображении.
        /// </summary>
        /// <param name="mainImage">.BMP изображение.</param>
        /// <param name="imageToEncrypt">.BMP изображение для записи.</param>
        /// <param name="encryptionType">Тип кодирования.</param>
        /// <returns></returns>
        public static bool Encrypt(Image mainImage, Image imageToEncrypt, EncryptionType encryptionType = EncryptionType.Basic)
        {

            return true;
        }


        /// <summary>
        /// Получить доступную память для записи в изображение.
        /// </summary>
        /// <param name="mainImage">Изображение допустимый объём записи которого нужно получить.</param>
        /// <returns></returns>
        public static ulong GetAvalableEncryptMemory(Image mainImage)
        {
            if (mainImage == null)
                return 0;

            return 0;
        }


        /// <summary>
        /// Проверка изображения на наличие закодированной информации.
        /// </summary>
        /// <param name="mainImage">.BMP изображение.</param>
        /// <returns></returns>
        public static bool IsImageHasEncryptedData(Image mainImage)
        {
            return false;
        }

        /// <summary>
        /// Получить тип закодированой в изображении информации.
        /// </summary>
        /// <param name="mainImage">.BMP изображение.</param>
        /// <returns></returns>
        public static EncryptedData GetTypeOfEncryptedData(Image mainImage)
        {
            return EncryptedData.None;
        }

        public static EncryptedData Decrypt(Image mainImage, out string text, out byte[] data, out Image image)
        {
            text = "";
            data = null;
            image = null;

            if (IsImageHasEncryptedData(mainImage))
            {
                switch (GetTypeOfEncryptedData(mainImage))
                {
                    case EncryptedData.None:
                        return EncryptedData.None;
                    case EncryptedData.Text:
                        text = DecryptText(mainImage);
                        return EncryptedData.Text;
                    case EncryptedData.ByteArray:
                        data = DecryptByteArray(mainImage);
                        return EncryptedData.ByteArray;
                    case EncryptedData.Image:
                        image = DecryptImage(mainImage);
                        return EncryptedData.Image;
                    default:
                        return EncryptedData.None;
                }
            }
            else
            {
                return EncryptedData.None;
            }
        }

        private static string DecryptText(Image mainImage)
        {
            return "";
        }
        private static byte[] DecryptByteArray(Image mainImage)
        {
            return new byte[0];
        }
        private static Image DecryptImage(Image mainImage)
        {
            return null;
        }


    }

    public enum EncryptionType
    {
        Basic
    }
    public enum EncryptedData
    {
        None, Text, ByteArray, Image
    }
}
