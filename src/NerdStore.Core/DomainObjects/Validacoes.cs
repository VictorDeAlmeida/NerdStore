using System.Text.RegularExpressions;

namespace NerdStore.Core.DomainObjects
{
    // Conceito de Assertion Concerns de Vaughn Vernon - valida diversos tipos de situações orientado a Domain Exceptions
    public class Validacoes
    {
        public static void ValidarSeIgual(object object1, object object2, string mensagem)
        {
            if (!object1.Equals(object2)) throw new DomainException(mensagem);
        }

        public static void ValidarSeDiferente(object object1, object object2, string mensagem)
        {
            if (object1.Equals(object2)) throw new DomainException(mensagem);
        }

        public static void ValidarCaracteres(string valor, int maximo, string mensagem)
        {
            var tamanho = valor.Trim().Length;
            if (tamanho > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarCaracteres(string valor, int minimo, int maximo, string mensagem)
        {
            var tamanho = valor.Trim().Length;
            if (tamanho < minimo || tamanho > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarExpressao(string padrao, string valor, string mensagem)
        {
            var regex = new Regex(padrao);
            if (!regex.IsMatch(valor)) throw new DomainException(mensagem);
        }

        public static void ValidarNaoVazio(string valor, string mensagem)
        {
            if (string.IsNullOrEmpty(valor.Trim())) throw new DomainException(mensagem);
        }

        public static void ValidarNaoNulo(string valor, string mensagem)
        {
            if (valor == null) throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(double valor, double minimo, double maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(float valor, float minimo, float maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(int valor, int minimo, int maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(long valor, long minimo, long maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarMinimoMaximo(decimal valor, decimal minimo, decimal maximo, string mensagem)
        {
            if (valor < minimo || valor > maximo) throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorIgualMinimo(long valor, long minimo, string mensagem)
        {
            if (valor > minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorIgualMinimo(double valor, double minimo, string mensagem)
        {
            if (valor > minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorIgualMinimo(decimal valor, decimal minimo, string mensagem)
        {
            if (valor > minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorIgualMinimo(int valor, int minimo, string mensagem)
        {
            if (valor > minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeMenorIgualMinimo(float valor, float minimo, string mensagem)
        {
            if (valor > minimo) throw new DomainException(mensagem);
        }

        public static void ValidarSeVerdadeiro(bool valor, string mensagem)
        {
            if (!valor) throw new DomainException(mensagem);
        }

        public static void ValidarSeFalso(bool valor, string mensagem)
        {
            if (valor) throw new DomainException(mensagem);
        }
    }
}
