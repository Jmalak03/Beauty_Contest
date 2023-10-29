using FreeSql.Extensions;
using Beauty_Contest.Controllers;

namespace Beauty_Contest.Models
{
    public class VotacionModel
    {
        public class Concursante
        {
            public int ConcursanteId { get; set; }
            public string Concursantes { get; set; }
            public int Votos { get; set; }
        }

        public class Voto
        {
            public int VotoId { get; set; }
            public string ConcursanteId { get; set; }
            public int UserId { get; set; }
        }
    }
}
