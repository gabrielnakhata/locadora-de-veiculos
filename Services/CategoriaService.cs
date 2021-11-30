using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System.Collections.Generic;
using System.Linq;

namespace Services
{
    public class CategoriaService : ICategoriaService
    {
        ICategoriaRepository CategoriaRepository;

        public CategoriaService(ICategoriaRepository categoriaRepository)
        {
            CategoriaRepository = categoriaRepository;
        }

        public void Atualizar(Categoria categoria)
        {
            CategoriaRepository.Update(categoria);
        }

        public void Cadastrar(Categoria entidade)
        {
            CategoriaRepository.Create(entidade);
        }

        public Categoria CarregarRegistro(string id)
        {
            return CategoriaRepository.List(id).FirstOrDefault();
        }

        public void Excluir(string id)
        {
            CategoriaRepository.Delete(id.ToString());
        }

        public IEnumerable<Categoria> Listagem()
        {
            return CategoriaRepository.List(null);
        }
    }
}
