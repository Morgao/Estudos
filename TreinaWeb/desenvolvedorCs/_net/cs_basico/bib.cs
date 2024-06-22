aplicacao para console
escrever na tela
console.Write // nao pula linha
console.WriteLine("Hello world"); pula linha
console.ReadKey(); // espera uma tecla para finalizar
var nome console.ReadLine();
console.Read // primeiro caracter
console.ReadKey // apos um espaco 

using System;

class TipoVariavel
{
      public static void Main()
      {
            int minhaVariavel = 10;
            //Aparece o tipo da variável
            Console.WriteLine(minhaVariavel.GetType());
      }
}
Isso retornaria o tipo da variável minhaVariavel, neste caso, System.Int32. 

tipagem por inferencia
int inteiro1 = 4; // declaracao de forma explicita



resultado = numero1 + numero2
numero1 += numero2; imprimi numero1;





var inteiro2 = 5; // keyworld variavel nao declarada explicitamente
o compilador decide o tipo de acordo com o tipo de dado que a var recebe
inferencia do compilador
nao pode criar uma var sem atriubicao

tipagem fraca no dot.net
dinamic

dynamic minhavariavel = 2 // tipagem fraca
minhavariavel = "treinaweb" // a mesmas variavel agora assumi tipo de string
 e var depois de declarada assumi o mesmo tipo ate o final da aplicacao[


string s = "Texto";
Console.WriteLine(s);

Você pode concatenar sequências, como este: 

string s = "Texto";
string s2 = "do Curso";
Console.WriteLine(s + " " + s2);

No exemplo abaixo, estamos obtendo, a partir da posição zero, 3 caracteres: 
string s = "Texto";
string s2 = s.Substring(0,3);
Console.WriteLine(s2);

Caracteres de escape

Caracteres de escape, como "\n" (nova linha) e "\t" (tabulação) podem ser incluídos em sequências. Por exemplo:

string s = "ab\ncd";
Console.WriteLine(s);


Teremos como resultado:

Se você desejar incluir uma barra dentro da string, ela deve ser precedida com outra barra invertida. Como no exemplo:

string s = "ab\\ncd";
Console.WriteLine(s);
Repare que, nesse caso, o caractere de escape (\n) acaba sendo anulado pela outra barra que foi acrescentada (“ab\\ncd”).

O símbolo @ ( Arroba )

O @ diz para o construtor da String ignorar caracteres de escape e quebras de linha. Por exemplo:

string s = @"ab\ncd";
Console.WriteLine(s);


Resultado:

Repare que, apesar de haver o caractere de escape (“\n”), ele é ignorado e tratado como uma string comum, graças ao “@”.



string string1 = "ABC";
            string string2 = "001";
            //concatecao pesada lenta
            //Console.WriteLine(string1 +" "+ string2+ " FDK ");
            // classe que faz operacao com strings


declarar um stringbuilder uma classe
StringBuilder sb = new StringBuilder();


//

StringBuilder sb = new StringBuilder();
            sb.Append(string1);
            sb.Append(" ");
            sb.Append(string2);
            sb.Append(" ");
            sb.Append("Fj5");
            Console.WriteLine("{0}", sb.ToString());
            Console.ReadKey();


Existem dois tipos de conversões:

    Explícitas.
    Implícitas.
uma conversão explícita (cast) 
Quando uma variável pode ser mais de um tipo, o recurso de conversão explícita pode ser usado. Veja:

int i;
double y = 10.5;
i = (int)y;



Já nas conversões implícitas isso ocorre de forma transparente nas atribuições de variáveis e passagens de parâmetros de métodos, desde que não se use o cast e os dados “caibam” um no outro. Veja:

long x;
int y = 5;
x = y;

No exemplo, pegou-se o valor de y e simplesmente atribuiu-se à variável x do tipo long, o que pode ser feito sem problemas, pois o tipo int cabe dentro do tipo long. Exemplo: 

boxing e unboxing da dot.net





// operador terinario
// CONdicao ? valor se verdadeiro : valor se falso
// mensagem = nota > 7 ? "Aprovado" : "Reprovado;



// switch case (escolha caso)



