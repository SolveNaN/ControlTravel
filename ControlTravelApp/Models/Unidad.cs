namespace ControlTravelApp.Models
{
    public class Unidad
    {
        public int Id { get; set; }
        public string? Nombre { get; set; }
        public string? Titulo { get; set; }
        public string? SubTitulo { get; set; }
        public string? Descripcion1 { get; set; }
        public string? Descripcion2 { get; set; }
        public string? Ubicacion { get; set; }//descripcion de la ubicacion
        public string? Costo { get; set; }//Aplica para sitios de un solo costo, si es gratis, gratis
        public string? Tipo { get; set; }//Bar, Restaurane, Hotel, Parador, bar.., Parquedero, Mirador, Centro Recreacional, Transporte, Evento...
        public string? UrlImg1 { get; set; }
        public string? UrlImg2 { get; set; }
        public string? UrlImg3 { get; set; }
        public string? Horario { get; set; }//Una descripcion del horario de atencion
        public DateTime HoraInicio { get; set; }
        public DateTime HoraFinal { get; set; }
        public int CantidadHoras { get; set; }//Numero de horas que dura el evento si aplica
        //OPCIONES DE ADMINISTRADOR
        public string? Habilidato { get; set; }//Si o No

    }
}
