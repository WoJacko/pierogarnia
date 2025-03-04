using Microsoft.EntityFrameworkCore.Storage;

namespace Pierogarnia.DTO
{
    public record CreateDishDTO(string Name, string Description, decimal Price);
    //public record DishDTO(string Name, string Description, decimal Price, byte[] Image);
}
