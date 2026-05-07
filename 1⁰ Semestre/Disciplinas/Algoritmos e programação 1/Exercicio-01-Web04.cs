

// Instanciando programa
Web04 web = new Web04();

// Chamando método inicial que cuidará da cadeia de execução
web.digitarNumero();

class Web04{
 
  List<int> lista = new List<int>();
  int num=0;


// Método que irá iniciar a cadeia de execução
// enquanto o número digitado pelo usuário for maior ou igual a 0 
// o método continuará executando repetidamente
//
public void digitarNumero(){
  while (this.num >= 0){
Console.WriteLine("Digite um número inteiro!");
this.num = (int.TryParse(Console.ReadLine(), out int value) ? value : 0);
checarNegativo(num);
appendLista(num);
  }
}


// Método privado que terá apenas a responsabilidade de adicionar o número 
// digitado pelo usuário a lista do objeto
void appendLista(int num){
  this.lista.Add(num);
}

// Esse método é responsável por verificar se o número digitado pelo usuário é menor que 0 
// sendo menor que 0, chamamos o próximo método, checarTamanho()
void checarNegativo(int num){
  if(num<0){
    checarTamanho();
    return;
  }
}

// Esse é responsável por verificar o tamanho da lista, caso o tamanho seja menor que 1
// ou seja, nenhum número válido foi digitado pelo usuário, significa que iremos encerrar
// o programa com a mensagem "Nenhum número válido foi digitado!"
void checarTamanho(){
  Console.WriteLine(this.lista.Count);
  if(this.lista.Count == 0){Console.WriteLine("Nenhum número válido foi digitado!");}
  else{
  resultado();}
}


// Caso a verificação de tamanho tenha passado, significa que o usuário digitou 
// ao menos 1 número válido, então o método anterior caiu no else, neste caso 
// estamos pronto para exibir o resultado
// O resultado consiste em 2 métodos, somaLista() e mediaLista(), ambos auto explicativos.
//
void resultado(){
  somaLista();
  mediaLista();
  this.num=-1;      // Definimos num como -1 pois o método digitarNumero() continuará se repetindo 
                    // até que a propriedade num do nosso objeto seja menor que zero, essa foi a condição
                    // de parada que determinei.
}

void mediaLista(){
  //Console.WriteLine(lista.Average());
  Console.WriteLine("media da lista:\n");
  Console.WriteLine(lista.Average());
}

void somaLista(){
  Console.WriteLine("soma da lista:\n");
  Console.WriteLine(lista.Sum());
}


}

    

