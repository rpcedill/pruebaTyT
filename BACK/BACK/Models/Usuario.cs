namespace BACK.Models
{
    public class Usuario
    {
        public string user { get; set; }
        public string nombres { get; set; }
        public string apellidos { get; set; }
        public string departamento { get; set; }
        public string cargo { get; set; }
        public string email { get; set; }

        public static List<Usuario> usuarios = new List<Usuario>
            {
                new Usuario{
                user = "ppicapiedra",
                nombres = "Pedro",
                apellidos = "Picapiedra",
                departamento = "Tecnologías de la Información",
                cargo = "Administrador",
                email = "ppicapiedra@mail.com",
                },
                new Usuario{
                user = "pmarmol",
                nombres = "Pablo",
                apellidos = "Marmol",
                departamento = "Tecnologías de la Información",
                cargo = "Líder Frontend",
                email = "pmarmol@mail.com",
                }
            };

    }

}
