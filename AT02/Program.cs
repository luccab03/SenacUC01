using System;
using System.Globalization;

namespace AT02
{
    class Program
    {
        static void Main(string[] args)
        {
            //Inputs: data de nascimento e nome
            //nome+idade se tiver -18
            //idade+nome se tiver +18
            Console.WriteLine("Gerador de Senhas");
            restart: Console.Write("Qual é seu nome? "); //Pergunta e recebe o nome do usuário
            string nome = Console.ReadLine();
            Console.WriteLine($"Bem vindo {nome}");
            CultureInfo.CurrentCulture = new CultureInfo("pt-BR", true); //Define a "cultura" do usuario para a Brasileira (caso o usuario use o SO em ingles podera inserir as datas em formato brasileiro)
            retry: Console.Write("Quando você nasceu? (Use o formato DD/MM/AAAA) "); //Pergunta e recebe a data de nascimento do usuario
            DateTime nascimento;
            DateTime hoje = DateTime.Today;
            try {
                nascimento = DateTime.Parse(Console.ReadLine());
            } catch (System.Exception){
                Console.WriteLine("Data invalida, por favor use o formato DD/MM/AAAA");
                goto retry;
            }
            string senha = "";
            if((hoje.Year - nascimento.Year) > 18){
                senha = gerasenha(hoje.Year - nascimento.Year, nome);
            } else if ((hoje.Year - nascimento.Year) == 18){
                if(hoje.Month > nascimento.Month){
                    if(hoje.Day >= nascimento.Day){
                        senha = gerasenha(18, nome);
                    }
                }
            } else {
                senha = gerasenha(hoje.Year - nascimento.Year, nome);
            }
            Console.WriteLine("Sua senha é " + senha);
            Console.Write("Você deseja utilizar o programa de novo? (Use s para sim e n para não): ");
            if(Console.ReadLine().Equals("s") || Console.ReadLine().Equals("S")){
                goto restart;
            }
        }
        static string gerasenha(int age, string nome){
            if(age >= 18){
                return age+nome;
            } else {
                return nome+age;
            }
        }
    }
}