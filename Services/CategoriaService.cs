using Domain.Entities;
using Domain.Interfaces;
using Domain.Repositories;
using System.Collections.Generic;

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

        public Categoria CarregarRegistro(int id)
        {
            return CategoriaRepository.Read(id);
        }

        public void Excluir(int id)
        {
            CategoriaRepository.Delete(id);
        }

        public IEnumerable<Categoria> Listagem()
        {
            return CategoriaRepository.Read();
        }
    }
}
