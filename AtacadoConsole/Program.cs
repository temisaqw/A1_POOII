namespace AtacadoConsole;

using Atacado.BD.EF.Database;
public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Iniciando programa...");
        AtacadoContext contexto = new AtacadoContext();
     //   foreach(Categorium item in contexto.Categoria)
     //   {
     //       Console.WriteLine($"{item.Codigo} - {item.Descricao}");
     //   }
        foreach(Regiao item in contexto.Regioes){
            Console.WriteLine($"{item.CodigoRegiao} - {item.Nome}");
        }
        foreach(Estado item in contexto.Estados){
            Console.WriteLine($"{item.CodigoEstado} - {item.Nome}");
        }
        Console.ReadLine();
        Console.WriteLine("Finalizado!");
    }
}