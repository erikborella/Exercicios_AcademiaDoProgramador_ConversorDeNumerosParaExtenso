using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ChequePorExtenso
{
    public class NumeroPorExtenso : DicionariosDeConversao
    {
        public double Numero { get; private set; }
        public string NumeroExtenso { get; private set; }

        public NumeroPorExtenso(double numero)
        {
            Numero = numero;
            NumeroExtenso = DeixarAPrimeiraLetraMaiuscula(Parse(numero));
        }

        private string Parse(double n)
        {
            Stack<string> saida = new Stack<string>();

            int centavos = PegarCentavos(n);
            long reais = PegarReais(n);

            if (centavos != 0)
                saida.Push(ConverterCentavosParaExtenso(centavos, NaoTemParteReal(reais)));

            if (reais != 0)
                saida.Push(ConverterReaisParaExtenso(reais));


            string numeroExtenso = StackParaStringAdicionandoLigadura(saida, "e");
            return numeroExtenso;
        }

        private long PegarReais(double n)
        {
            return (long)Math.Truncate(n);
        }

        private int PegarCentavos(double n)
        {
            // https://stackoverflow.com/a/28848788
            string str = n.ToString("0.00", CultureInfo.InvariantCulture);
            return Convert.ToInt32(str.Substring(str.IndexOf('.') + 1));
        }

        private string ConverterCentavosParaExtenso(int centavos, bool temApenasCentavos)
        {
            if (centavos == 0)
                return "";

            StringBuilder saida = new StringBuilder();

            saida.Append(ConverterCentenaParaExtenso(centavos));
            saida.Append(" ");

            saida.Append((centavos == 1) ? "centavo" : "centavos");

            if (temApenasCentavos)
                saida.Append(" de real");

            return saida.ToString();
        }

        private string ConverterReaisParaExtenso(long reais)
        {
            Stack<string> saida = new Stack<string>();
            int unidadeDeMilharAtual = 0;

            saida.Push((reais == 1) ? "real" : "reais");

            while (reais != 0)
            {
                long centena = reais % 1000;
                reais /= 1000;
                unidadeDeMilharAtual++;

                if (centena == 1)
                    saida.Push(unidadesDeMilharSingular[unidadeDeMilharAtual]);

                else if (centena != 0)
                    saida.Push(unidadesDeMilharPlural[unidadeDeMilharAtual]);

                if (NaoEh1mil(unidadeDeMilharAtual, centena))
                    saida.Push(ConverterCentenaParaExtenso(centena));

                if (DeveColocarLigadura(reais, unidadeDeMilharAtual, centena))
                    saida.Push("e");
            }

            return StackParaStringAdicionandoLigadura(saida, "");
        }

        private string ConverterCentenaParaExtenso(long n)
        {
            if (n == 0)
                return "";

            if (n == 100)
                return "cem";

            int contador = 0;
            Stack<string> saida = new Stack<string>();

            long dezena = n % 100;

            if (DezenaEstaEntre10e20(dezena))
            {
                saida.Push(dezenasPorExtenso[dezena]);
                n /= 100;
                contador = 2;
            }

            while (n != 0)
            {
                long unidade = n % 10;
                n /= 10;
                contador++;

                if (unidade == 0)
                    continue;

                saida.Push(dicionariosPorUnidadeDeCentena[contador][unidade]);
            }

            return StackParaStringAdicionandoLigadura(saida, "e");
        }

        private string StackParaStringAdicionandoLigadura(Stack<string> s, string ligadura)
        {
            StringBuilder saida = new StringBuilder();
            string ligaduraUsada;

            if (ligadura == "")
                ligaduraUsada = " ";
            else
                ligaduraUsada = $" {ligadura} ";

            while (s.Count > 0)
            {
                string str = s.Pop();

                if (string.IsNullOrEmpty(str))
                    continue;

                saida.Append(str);

                if (s.Count != 0)
                    saida.Append(ligaduraUsada);
            }

            return saida.ToString();
        }

        private string DeixarAPrimeiraLetraMaiuscula(string str)
        {
            return char.ToUpper(str[0]) + str.Substring(1);
        }

        private bool NaoTemParteReal(long reais)
        {
            return reais == 0;
        }

        private bool NaoEh1mil(int contador, long centena)
        {
            return centena != 1 || contador != 2;
        }

        private bool DeveColocarLigadura(long reais, int contador, long centena)
        {
            return contador == 1 && (centena % 100 == 0 || centena < 100) && reais != 0;
        }

        private bool DezenaEstaEntre10e20(long dezena)
        {
            return dezena >= 10 && dezena < 20;
        }

    }
}
