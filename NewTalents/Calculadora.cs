﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewTalents
{
    public class Calculadora
    {
        private List<string> listaHistorico;
        private string data;

        public Calculadora(string data)
        {
            listaHistorico = new List<string>();

            this.data = data;
        }
        public int Somar(int val1, int val2)
        {
            int resultado = val1 + val2;

            AdionarHistoricoCalculadora(resultado);

            return resultado;
        }

        public int Subtrair(int val1, int val2)
        {
            int resultado = val1 - val2;

            AdionarHistoricoCalculadora(resultado);

            return resultado;
        }

        public int Multiplicar(int val1, int val2)
        {
            int resultado = val1 * val2;

            AdionarHistoricoCalculadora(resultado);

            return resultado;
        }

        public int Dividir(int val1, int val2)
        {
            int resultado = val1 / val2;

            AdionarHistoricoCalculadora(resultado);

            return resultado;
        }

        public List<string> Historico()
        {
            return ExcluirHistoricoCalculadora();
        }

        public void AdionarHistoricoCalculadora(int resultadoHistorico)
        {
            listaHistorico.Insert(0, $"Resultado: { resultadoHistorico} - Data: {data}");
        }

        public List<string> ExcluirHistoricoCalculadora()
        {
            listaHistorico.RemoveRange(3, listaHistorico.Count - 3);

            return listaHistorico;
        }
    }
}
