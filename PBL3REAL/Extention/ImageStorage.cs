using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;

namespace PBL3REAL.Extention
{
    public class ImageStorage
    {
        private ImageStorage() { }
        private static ImageStorage _Instance;
        public static ImageStorage Instance
        {
            get
            {
                if (_Instance == null)
                {
                    _Instance = new ImageStorage();
                }
                return _Instance;
            }
            private set {}
        }
        private string FileName { get; set; }

        private string FilePath { get; set; }

        private string FileExtension { get; set; }

        private static readonly string[] ValidFileExtension = new string[]
        {
            ".jpg",
            ".JPG",
            ".jpeg",
            ".JPEG",
            ".bmp",
            ".BMP",
            ".gif",
            ".GIF",
            ".png",
            ".PNG"
        };
        public bool ValidateFileName(string FileName)
        {
            return !(FileName.IndexOfAny(Path.GetInvalidFileNameChars()) >= 0);
        }
        public bool ValidateFilePath(string FilePath)
        {
            return !(FilePath.IndexOfAny(Path.GetInvalidPathChars()) >= 0);
        }
        public bool ValidateFileExtension(string FileExtension)
        {
            for (int i = 0; i < ValidFileExtension.Length; i++)
            {
                if (ValidFileExtension[i].ToLower() == FileExtension.ToLower()) { return true; }
            }    
            return false;
        }
        public bool CreateStoragingFolder(string FolderName, string FolderPath)
        {

            string FullPath = FolderPath + "\\" + FolderName;
            try
            {
                // If the directory doesn't exist, create it.
                if (!System.IO.Directory.Exists(FullPath))
                {
                    System.IO.Directory.CreateDirectory(FullPath);
                }
            }
            catch (Exception)
            {
                // Fail silently
                return false;
            }
            return true;
        }
        public bool SaveImage(Bitmap Image, string FileName, string FilePath, string FileExtention)
        {
            string FullPath = FilePath + "\\" + FileName + FileExtention;
            try
            {
                //Image.Save(FullPath, FileExtension);
            }
            catch (Exception)
            {
                return false;
            } 
            
            return true;
        }

    }
}
