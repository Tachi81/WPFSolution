using System.IO;

namespace Lesson9ItemsControlPlusUserControl
{
    public class CustomImage
    {
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsFound { get; set; }

        public string DefaultNotFoundImgPath
        {
            get
            {
                return Path.Combine(Directory.GetCurrentDirectory(), "Images", "no-image.png");
            }
        }

        public string DefaultNotFoundDescription => "Image not found"; // to samo co powyżej




        public CustomImage()
        {
            ImagePath = DefaultNotFoundImgPath;
            Description = DefaultNotFoundDescription;

        }

        public CustomImage(string imagePath, string description)
        {
            ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", imagePath);
            Description = description;
            IsFound = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Images", ImagePath));
        }
    }
}
