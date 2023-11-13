using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace WebApplication1.Controllers
{



    [Route("api/[controller]")]
    [ApiController]
    public class DiscosController : ControllerBase
    {
        private static readonly Disco[] Discos = new[]
{
    new Disco
    {
        Id = 1,
        Nombre = "Let It Bleed",
        Descripcion = "Es el octavo álbum de estudio de The Rolling Stones en el Reino Unido y su décimo en los Estados Unidos. Se publicó el 5 de diciembre de 1969, un año después que su predecesor, Beggars Banquet, que había supuesto un éxito de público y crítica.",
        Imagen = "https://upload.wikimedia.org/wikipedia/en/c/c0/LetitbleedRS.jpg",
        Artista = "The Rolling Stones",
        Genero = "Rock, blues rock, hard rock, country blues",
        Precio = 250

    },
    new Disco
    {
        Id = 2,
        Nombre = "Face to Face",
        Descripcion = "El álbum marcó un cambio del estilo duro de beat que había catapultado al grupo a la aclamación internacional en 1964.",
        Imagen = "https://upload.wikimedia.org/wikipedia/en/2/21/Face_to_Face_%28The_Kinks_album%29_coverart.jpg",
        Artista = "The Kinks",
        Genero = "Rock, pop barroco, pop psicodélico, garage pop",
        Precio=300

    },
    new Disco
    {
        Id = 3,
        Nombre = "Quadrophenia",
        Descripcion = "El álbum es la segunda ópera rock de Pete Townshend compuesta para el grupo y relata una serie de sucesos sociales, musicales y psicológicos que afectan a un joven mod británico que tienen lugar entre Londres y Brighton.",
        Imagen = "https://upload.wikimedia.org/wikipedia/en/8/8a/Quadrophenia_%28album%29.jpg",
        Artista = "The Who",
        Genero = "Rock, hard rock, rock and roll, opera rock",
        Precio=500

    },
    new Disco
    {
        Id = 4,
        Nombre = "Blonde on Blonde",
        Descripcion = "Las sesiones de grabación del álbum comenzaron en Nueva York en 1965, con el respaldo de un elevado número de músicos, entre los que se incluyeron miembros de la banda The Hawks, que cuatro años después se convirtió en The Band.",
        Imagen = "https://upload.wikimedia.org/wikipedia/en/3/38/Bob_Dylan_-_Blonde_on_Blonde.jpg",
        Artista = "Bob Dylan",
        Genero = "Rock, folk rock, blues rock",
        Precio = 200

    },
    new Disco
    {
        Id = 5,
        Nombre = "Cosmo's Factory",
        Descripcion = "Es el quinto álbum de estudio de la banda estadounidense Creedence Clearwater Revival, publicado en 1970, por Fantasy Records",
        Imagen = "https://m.media-amazon.com/images/I/81Iuw5AKKbL._UF1000,1000_QL80_.jpg",
        Artista = "Creedence Clearwater Revival",
        Genero = "Swamp rock",
        Precio= 150

    },
    new Disco
    {
        Id = 6,
        Nombre = "Porfiado",
        Descripcion = "Porfiado es el decimotercer álbum de estudio de la banda de rock uruguaya El Cuarteto de Nos. Contiene doce canciones inéditas. Fue lanzado el 25 de abril de 2012 bajo el sello Warner Music.",
        Imagen = "https://m.media-amazon.com/images/I/61Si--2zAvL._UF894,1000_QL80_.jpg",
        Artista = "Cuarteto de Nos",
        Genero = "Rock alternativo, Rap rock, Rock cómico, Pop rock, Cumbia",
        Precio=250

    },
    new Disco
    {
        Id = 7,
        Nombre = "Beggars Banquet",
        Descripcion = "Es el séptimo álbum de estudio en el Reino Unido de la banda de rock británica The Rolling Stones y su noveno en los Estados Unidos.",
        Imagen = "https://m.media-amazon.com/images/I/714bZ8W7wXS._UF894,1000_QL80_.jpg",
        Artista = "The Rolling Stones",
        Genero = "Roots rock, country blues, hard rock",
        Precio= 300

    },
    new Disco
    {
        Id = 8,
        Nombre = "Hackney Diamonds",
        Descripcion = "Es el álbum de estudio número 24 (británico) y 26 (estadounidense) de la banda de rock británica The Rolling Stones.",
        Imagen = "https://m.media-amazon.com/images/I/A1fXb71fhAL._UF1000,1000_QL80_.jpg",
        Artista = "The Rolling Stones",
        Genero = "Blues rock, hard rock",
        Precio=340

    },
    new Disco
    {
        Id = 9,
        Nombre = "Paranoid",
        Descripcion = "Es el segundo álbum de la banda británica de heavy metal Black Sabbath. Originariamente su nombre iba a ser War Pigs, pero debido a presiones de la discográfica se cambió el nombre a Paranoid.",
        Imagen = "https://i0.wp.com/tuonelamagazine.com/wp-content/uploads/2020/08/9a4d3d7f6a8292ef7c313ab00e8262e5.jpg?fit=620%2C620&ssl=1",
        Artista = "Black Sabbath",
        Genero = "Heavy metal, hard rock, Doom metal",
        Precio=250
    },
    new Disco
    {
        Id = 10,
        Nombre = "III",
        Descripcion = "​Sirve como continuación de sus dos primeros álbumes en solitario, McCartney (1970) y McCartney II (1980), y al igual que dichos trabajos, está producido e interpretado por él solo.",
        Imagen = "https://www.mondosonoro.com/wp-content/uploads/2020/12/maccartneyIII.jpg",
        Artista = "Paul McCartney",
        Genero = "Rock",
        Precio=100

    }
};

        [HttpGet("GetAll", Name = "GetAll")]
        public IEnumerable<Disco> GetAll()
        {
            return Discos;
        }

        [HttpGet("search/{nombre}", Name = "GetByName")]
        public IEnumerable<Disco> GetByName(string nombre)
        {
            return Discos.Where(p => p.Nombre.ToLower().Contains(nombre.ToLower()));
        }

        [HttpGet("Get/{id}", Name = "GetById")]
        public ActionResult<Disco> GetById(int id)
        {
            var disco = Discos.FirstOrDefault(p => p.Id == id);

            if (disco == null)
            {
                return NotFound();
            }

            return disco;
        }
    }
}
