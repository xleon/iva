using System;
using System.Linq;
using System.Text;

namespace Iva
{
    class Program
    {
        private const decimal IvaPercent = 0.21M;
        private const decimal IrpfPercent = 0.15M;
        private const char Currency = '€';
        
        static int Main(string[] args)
        {
            try
            {
                Console.OutputEncoding = Encoding.UTF8;
                
                var amount = decimal.Parse(args[0]);
                var useIrpf = args.Contains("-i");
                var iva = amount * IvaPercent;
                var total = amount + iva;
                var net = amount;
                
                Console.WriteLine($"Base imponible: {amount:0.##} {Currency}");
                Console.WriteLine($"I.V.A ({(int)(IvaPercent * 100)}%): {iva:0.##} {Currency}");
                
                if (useIrpf)
                {
                    var irpfPercent = args.Length > 2 ? decimal.Parse(args[2]) / 100 : IrpfPercent;
                    var irpf = amount * irpfPercent;
                    
                    Console.WriteLine($"I.R.F.F ({(int)(irpfPercent * 100)}%): -{irpf:0.##} {Currency}");
                    total = amount + iva - irpf;
                    net = amount - irpf;
                }
                
                Console.WriteLine($"Total a facturar: {total:0.##} {Currency}");
                Console.WriteLine($"Neto: {net:0.##} {Currency}");
                
                return 0;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                return 1;
            }
        }
    }
}