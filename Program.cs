/*
 * Faça um progrma que verifique se o usuário digitado é igual a 'administrador'
 * e se a senha digitada é igual a '123'
 

string usuario;
string senha;

Console.Write("Usuário: ");
usuario =   Console.ReadLine();
Console.Write("Senha: ");
senha = Console.ReadLine();

if (usuario == "administrador" && senha == "123") // o operador lógico && retorna verdadeiro se
{                                                // a primeira e segunda condição forem verdadeiras
    Console.WriteLine("Acesso autorizado!");
}
else 
{
    Console.WriteLine("Usuário e/ou senha inválidos!\nAcesso Negado!");
}
*/

/*
 * Faça um programa que receba o total de compras de um usuário e um cupom.
 * Se o total de compras exceder 1000 ou se o cupom for igual a DESCONTO20 aplicar um desconto de 20% na compra.
 */

double totalCompra;
double valorFinal;
string cupom;

Console.Write("Digite o total da compra: ");
totalCompra = Convert.ToDouble(Console.ReadLine());
Console.Write("Digite o cupom de Desconto: ");
cupom = Console.ReadLine();

if (totalCompra > 1000 || cupom == "DESCONTO20")
{
    valorFinal = totalCompra - (totalCompra * 0.2); // o 0.2 é equivalente a 20%
}
else
{
    valorFinal = totalCompra;
}

Console.WriteLine("Valor final: R$ {0}", valorFinal.ToString("0.00"));