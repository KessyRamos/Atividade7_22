double n1 = 9;
double n2 = 10;
double n3 = 8;
double n4 = 6;
double media;

Console.WriteLine("Calcular media da nota do aluno!!!");

media = (n1 + n2 + n3 + n4) / 4;
Console.WriteLine("");

Console.WriteLine($"A média do aluno é {media}");

Console.WriteLine("");
if (media > 7 ){
    Console.WriteLine("O aluno foi APROVADO!!");
} else{
    Console.WriteLine("O aluno foi REPROVADO!");
}
