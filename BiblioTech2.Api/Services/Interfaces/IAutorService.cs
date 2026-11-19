using BiblioTech2.Api.DTOs.Autores;

namespace BiblioTech2.Api.Services.Interfaces
{
    public class IAutorService
    {
        Task<List<AutorDto>> ListarAsync();
        Task<List<AutorDto>> ObtenerAsync(int id);
        Task<AutorDto> CrerAsync(AutorGuardarDto dto);
        Task ActualizarAsync(int id, AutorGuardarDto dto);
        Task EliminarAsync(int id);
    }
}
