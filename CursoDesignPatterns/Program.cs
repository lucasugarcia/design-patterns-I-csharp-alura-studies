using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoDesignPatterns
{
    internal class Program
    {
        static void Main(string[] args)
        {
            NotaFiscalBuilder criador = new NotaFiscalBuilder();

            criador.ParaEmpresa("Alura")
                .ComCnpj("23.456.789/0001-12")
                .ComItem(new ItemDaNota("item 1", 100.0))
                .ComItem(new ItemDaNota("item 2", 200.0))
                .NaDataAtual()
                .ComObservacoes("Observação");

            NotaFiscal nf = criador.Constroi();

            Console.WriteLine(nf.ValorBruto);
            Console.WriteLine(nf.Impostos);

            Console.ReadLine();
        }
    }
}
