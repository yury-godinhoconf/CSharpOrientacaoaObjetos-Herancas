using ByteBank_ADM.Funcionarios;
using ByteBank_ADM.Parceria;
using ByteBank_ADM.SistemaInterno;
using ByteBank_ADM.Utilitario;
using System.Security.Cryptography.X509Certificates;

#region
//Funcionario pedro = new Funcionario("12345678900", 2000);
//pedro.Nome = "Pedro Malazartes";

//Console.WriteLine("\n"+pedro.Nome);
//Console.WriteLine("Bonificação: "+pedro.GetBonificacao());

//Diretor roberta = new Diretor("98765432199");
//roberta.Nome = "Roberta Silva";

//Console.WriteLine("\n"+roberta.Nome);
//Console.WriteLine("Bonificação: " + roberta.GetBonificacao());

//GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();
//gerenciador.Registrar(pedro);
//gerenciador.Registrar(roberta);

//Console.WriteLine("\nTotal de bonificações: "+ gerenciador.TotalDeBonificacao);
//Console.WriteLine("\nTotal de Funcionarios: " + Funcionario.TotalDeFuncionarios);

//pedro.AumentarSalario();
//roberta.AumentarSalario();

//Console.WriteLine("\nNovo salário Pedro: " + pedro.Salario);
//Console.WriteLine("\nNovo salário Roberta: " + roberta.Salario);
#endregion


//CalcularBonificacao(); //invocando metodo
UsarSistema();
void CalcularBonificacao() //metodo
{
    GerenciadorDeBonificacao gerenciador = new GerenciadorDeBonificacao();

    Designer ulisses = new Designer("12345678900");
    ulisses.Nome = "Ulisses Souza";

    Diretor paula = new Diretor("98765432199");
    paula.Nome = "Paula Souza";

    Auxiliar igor = new Auxiliar("36925814766");
    igor.Nome = "Igor Dias";

    GerenteDeContas camila = new GerenteDeContas("14725836944");
    camila.Nome = "Camila Oliveira";

    gerenciador.Registrar(camila);
    gerenciador.Registrar(igor);
    gerenciador.Registrar(paula);
    gerenciador.Registrar(ulisses);

    Console.WriteLine("Total de Bonificação = "+gerenciador.TotalDeBonificacao);

    //Funcionario pedro = new Funcionario("25814736955", 2000);
}

void UsarSistema()
{
    SistemaInterno sistema = new SistemaInterno();

    Diretor ingrid = new Diretor("74185296399");
    ingrid.Nome = "Ingrid Novaes";
    ingrid.Login = "ingrid@gmail.com";
    ingrid.Senha = "123";

    GerenteDeContas ursula = new GerenteDeContas("85214735711");
    ursula.Nome = "Ursula Alcantara";
    ursula.Login = "ursula@login.com";
    ursula.Senha= "321";

    ParceiroComercial caio = new ParceiroComercial();
    caio.Senha = "999";
    caio.Login = "caio@gmail.com";


    sistema.Logar(ingrid, "123", "ingrid@gmail.com");
    sistema.Logar(ursula, "963", "ursula@login.com");
    sistema.Logar(caio, "999", "caio@gmail.com");
}
