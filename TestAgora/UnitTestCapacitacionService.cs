using Service.Models;
using Service.Services;

namespace TestAgora
{
    public class UnitTestCapacitacionService
    {
        [Fact] // Forma en que xUnite identifique que lo que vas a poner es un test
        public async void TestGetCapacitacionesAbiertasAsync()
        {
            // Arrange
            var service = new CapacitacionService();
            // Act
            var result = await service.GetCapacitacionesAbiertasAsync();
            // Assert
            Assert.NotNull(result);
            Assert.IsType<List<Capacitacion>>(result);
            Assert.True(result.Count > 0); // Asumiendo que siempre hay datos en la base de datos
            foreach (var item in result)
            {
                //imprimimos las capacitaciones
                Console.WriteLine($"Id: {item.Id}, Nombre: {item.Nombre}");
            }
        }
    }
}