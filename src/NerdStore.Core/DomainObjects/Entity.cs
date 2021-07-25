using System;

namespace NerdStore.Core.DomainObjects
{
    public abstract class Entity
    {
        public Guid Id { get; set; }

        protected Entity()
        {
            Id = Guid.NewGuid();
        }

        // Para ser igual, o Id também precisa ser igual
        public override bool Equals(object obj)
        {
            var compareTo = obj as Entity;

            if (ReferenceEquals(this, compareTo)) return true;
            if (ReferenceEquals(null, compareTo)) return false;

            return Id.Equals(compareTo.Id);
        }

        // Sobrescrevendo este método, podemos utilizar o == em qualquer lugar do código, sem precisar usar Equals diretamente
        public static bool operator ==(Entity a, Entity b)
        {
            if (ReferenceEquals(a, null) && ReferenceEquals(b, null)) return true;
            if (ReferenceEquals(a, null) || ReferenceEquals(b, null)) return false;

            return a.Equals(b);
        }

        // Sobrescrevendo este método, podemos utilizar o != em qualquer lugar do código, sem precisar usar Equals diretamente
        public static bool operator !=(Entity a, Entity b)
        {
            return !(a == b);
        }

        // Para garantir que o Id sempre será diferente para instâncias diferentes. A multiplicação por uma constante (907) garante isso
        public override int GetHashCode()
        {
            return (GetType().GetHashCode() * 907) + Id.GetHashCode();
        }

        public override string ToString()
        {
            return $"{GetType().Name} [Id={Id}]";
        }
    }
}
