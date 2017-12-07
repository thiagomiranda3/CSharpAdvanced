namespace Features.Delegates
{
    public class PhotoProcessor
    {
        // Delegate com assinatura void e um parâmetro Photo
        public delegate string PhotoFilterHandler(Photo photo);
        
        public string Process(PhotoFilterHandler f)
        {
            var photo = new Photo();

            return f(photo);
        }
    }
}