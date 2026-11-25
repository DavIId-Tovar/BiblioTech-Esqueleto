namespace BiblioTech2.Web.Client.Models.Autores;

public class AutorDto
{
    public int Id { get; set; }
    public string Nombre { get; set; } = string.Empty;
    public string? Nacionalidad { get; set; }
    public int CantidadLibros { get; set; }
}