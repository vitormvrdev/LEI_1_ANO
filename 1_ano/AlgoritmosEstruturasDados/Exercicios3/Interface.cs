using Microsoft.Identity.Client;
using System.Threading.Tasks;
using Refit;

namespace Exercicios3
{
    public interface IMyApiService
    {
        [Get("/api/People")]
        Task<List<Person>> GetPeople();

        [Post("/api/People")]
        Task CreateUser(Person person);
    }
}
