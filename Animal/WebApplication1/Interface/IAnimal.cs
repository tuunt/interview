using System.Collections.Generic;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Interface
{
    public interface IAnimal
    {
        public Task<ResponeModel> GetAnimalAsync();
    }
}
