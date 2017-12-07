namespace Features.Delegates
{
    public class Photo
    {
        public string Path { get; set; }
    }

    public class PhotoFilter
    {
        public string ApplyBrightness(Photo photo)
        {
            return "brightness";
        }

        public string ApplyContrast(Photo photo)
        {
            return "contrast";
        }
    }
}