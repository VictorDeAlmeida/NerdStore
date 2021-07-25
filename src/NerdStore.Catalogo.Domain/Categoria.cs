using NerdStore.Core.DomainObjects;

namespace NerdStore.Catalogo.Domain
{
    public class Categoria : Entity
    {
        public string Nome { get; private set; }

        public int Codigo { get; private set; }

        public Categoria(string nome, int codigo)
        {
            Nome = nome;
            Codigo = codigo;
        }

        public void Validar()
        {
            Validacoes.ValidarNaoVazio(Nome, "O campo Nome da categoria não pode estar vazio");
            Validacoes.ValidarSeDiferente(Codigo, 0, "O campo Codigo de categoria não pode ser 0");
        }

        public override string ToString()
        {
            return $"{Nome} - {Codigo}";
        }
    }
}
