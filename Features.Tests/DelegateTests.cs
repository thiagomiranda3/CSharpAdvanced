using Features.Delegates;
using Xunit;

namespace Features.Tests
{
    public class DelegateTests
    {
        [Fact]
        public void TestandoDelegateSimples()
        {
            var photoProcessor = new PhotoProcessor();
            var filters = new PhotoFilter();
            
            PhotoProcessor.PhotoFilterHandler filterHandler;
            filterHandler = filters.ApplyBrightness;

            // Adicionando métodos no delegate faz com que um seja executado após o outro em ordem
            filterHandler += filters.ApplyContrast;
            
            Assert.True(photoProcessor.Process(filterHandler) == "contrast", "Deve retornar brightness");

            // Remove o método adicionado no delegate
            filterHandler -= filters.ApplyContrast;

            Assert.True(photoProcessor.Process(filterHandler) == "brightness", "Deve retornar brightness");
        }
    }
}