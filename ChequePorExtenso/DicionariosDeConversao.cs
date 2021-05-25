using System;
using System.Collections.Generic;
using System.Text;

namespace ChequePorExtenso
{
    public class DicionariosDeConversao
    {
        public static Dictionary<long, string> unidadesPorExtenso = new Dictionary<long, string>()
        {
            { 1, "um" },
            { 2, "dois" },
            { 3, "tres" },
            { 4, "quatro" },
            { 5, "cinco" },
            { 6, "seis" },
            { 7, "sete" },
            { 8, "oito" },
            { 9, "nove" },
        };

        public static Dictionary<long, string> dezenasPorExtenso = new Dictionary<long, string>()
        {
            { 10, "dez" },
            { 11, "onze" },
            { 12, "doze" },
            { 13, "treze" },
            { 14, "catorze" },
            { 15, "quinze" },
            { 16, "dezesseis" },
            { 17, "dezessete" },
            { 18, "dezoito" },
            { 19, "dezenove" },
            { 2, "vinte" },
            { 3, "trinta" },
            { 4, "quarenta" },
            { 5, "cinquenta" },
            { 6, "sessenta" },
            { 7, "setenta" },
            { 8, "oitenta" },
            { 9, "noventa" },
        };

        public static Dictionary<long, string> centenasPorExtenso = new Dictionary<long, string>()
        {
            { 1, "cento" },
            { 2, "duzentos" },
            { 3, "trezentos" },
            { 4, "quatrocentos" },
            { 5, "quinhentos" },
            { 6, "seiscentos" },
            { 7, "setecentos" },
            { 8, "oitocentos" },
            { 9, "novecentos" },
        };

        public static Dictionary<long, Dictionary<long, string>> dicionariosPorUnidadeDeCentena =
            new Dictionary<long, Dictionary<long, string>>()
        {
            {1, unidadesPorExtenso },
            {2, dezenasPorExtenso },
            {3, centenasPorExtenso }
        };

        public static Dictionary<int, string> unidadesDeMilharSingular = new Dictionary<int, string>()
        {
            {1, "" },
            {2, "mil" },
            {3, "milhão" },
            {4, "bilhão" },
            {5, "trilhão" },
        };

        public static Dictionary<int, string> unidadesDeMilharPlural = new Dictionary<int, string>()
        {
            {1, "" },
            {2, "mil" },
            {3, "milhões" },
            {4, "bilhões" },
            {5, "trilhões" },
        };
    }
}
