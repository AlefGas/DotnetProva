using Empresa.Model;

namespace Empresa.Repository.Interface
{
    public interface IDepartamentoRepository
    {
        IEnumerable<Departamento> GetDepartamento();

    }
}
