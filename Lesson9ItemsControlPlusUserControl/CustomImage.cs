using System.IO;

namespace Lesson9ItemsControlPlusUserControl
{
    public class CustomImage
    {
        public string ImagePath { get; set; }
        public string Description { get; set; }
        public bool IsFound { get; set; }

        public CustomImage()
        {
            ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", ImagePath);
            Description = "Default";
        }

        public CustomImage(string imagePath, string description)
        {
            ImagePath = Path.Combine(Directory.GetCurrentDirectory(), "Images", imagePath);
            Description = description;
            IsFound = File.Exists(Path.Combine(Directory.GetCurrentDirectory(), "Images", ImagePath));
        }
    }
}
