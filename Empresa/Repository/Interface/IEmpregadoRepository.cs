using Empresa.Model;

namespace Empresa.Repository.Interface
{
    public interface IEmpregadoRepository
    {
        Task<IEnumerable<Empregado>> GetEmpregados();
        Task<Empregado> GetEmpregado(int Empid);
        Task<Empregado> AddEmpregado(Empregado empregado);
        Task<Empregado> UpdateEmpregado(Empregado empregado);
        void DeleteEmpregado(int Empid);

    }
}
