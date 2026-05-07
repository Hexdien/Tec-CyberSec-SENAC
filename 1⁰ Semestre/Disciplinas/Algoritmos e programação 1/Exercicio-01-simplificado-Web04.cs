

Continue cont = new Continue();

cont.digitarNumero();

class Continue{
int num;
List<int> lista = new List<int>();

  public void digitarNumero()
    {
        while (true)
        {
            num = int.TryParse(Console.ReadLine(), out int value)
                ? value
                : 0;

            if (num < 0)
            {
                Console.WriteLine("Número negativo digitado.");
                break;
            }

            lista.Add(num);

            continue;
        }
        Console.WriteLine($"Total da lista somado: {this.lista.Sum()} ");
        Console.WriteLine($"Média da lista : {this.lista.Average()} ");
        Console.WriteLine("Fim do programa");
    }


}
