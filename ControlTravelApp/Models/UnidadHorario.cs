namespace ControlTravelApp.Models
{
    public class UnidadHorario
    {
        public int Id { get; set; }
        public Unidad? Unidad { get; set; }
        public int UnidadId { get; set; }
        public string? Lunes { get; set; }//Cerrado o Abierto, nos dice si hay atencion este dia
        public string? LunesDescripcion { get; set; }//Da un mensaje o aclaracion si abre los festivos
        public DateTime LunesInicio { get; set; }
        public DateTime LunesFinal { get; set; }
        public string? Martes { get; set; }
        public string? MartesDescripcion { get; set; }
        public DateTime MartesInicio { get; set; }
        public DateTime MartesFinal { get; set; }
        public string? Miercoles { get; set; }
        public string? MiercolesDescripcion { get; set; }
        public DateTime MiercolesInicio { get; set; }
        public DateTime MiercolesFinal { get; set; }
        public string? Jueves { get; set; }
        public string? JuevesDescripcion { get; set; }
        public DateTime JuevesInicio { get; set; }
        public DateTime JuevesFinal { get; set; }
        public string? Viernes { get; set; }
        public string? ViernesDescripcion { get; set; }
        public DateTime ViernesInicio { get; set; }
        public DateTime ViernesFinal { get; set; }
        public string? Sabado { get; set; }
        public string? SabadoDescripcion { get; set; }
        public DateTime SabadoInicio { get; set; }
        public DateTime SabadoFinal { get; set; }
        public string? Domingo { get; set; }
        public string? DomingoDescripcion { get; set; }
        public DateTime DomingoInicio { get; set; }
        public DateTime DomingoFinal { get; set; }
        public string? AtiendeFestivos { get; set; } //Si o No

    }
}
