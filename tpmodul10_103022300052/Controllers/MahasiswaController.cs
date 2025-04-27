using Microsoft.AspNetCore.Mvc;

namespace tpmodul10_103022300052.Controllers
{
    [Route("api/[controller]")]
    public class MahasiswaController : ControllerBase
    {
        public static List<Mahasiswa> dataMahasiswa = new List<Mahasiswa>
        {
            new Mahasiswa("Apriliani", "103022300052"),
            new Mahasiswa("Aisyah", "103022300116"),
            new Mahasiswa("Nadya Aulya salma", "103022300022"),
            new Mahasiswa("Deswita Syaharani", "103022300004")
          
        };

        [HttpGet]
        public IEnumerable<Mahasiswa> Get()
        {
            return dataMahasiswa;
        }

        [HttpGet("{id}")]
        public Mahasiswa Get(int id)
        {
            return dataMahasiswa[id];
        }

        [HttpPost]
        public void Post([FromBody] Mahasiswa mahasiswa)
        {
            dataMahasiswa.Add(mahasiswa);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            dataMahasiswa.RemoveAt(id);
        }
    }
}
