/* 
 
 * Exercício de Orientação a Objetos em C#

Objetivo: Praticar os conceitos de herança, polimorfismo, encapsulamento e tratamento de exceções em C#.

Primeiro, crie uma nova classe chamada Estagiario que herda da classe Funcionario. Um estagiário tem um atributo adicional chamado Curso, que representa o curso que ele está cursando. Certifique-se de definir um construtor para a classe Estagiario que inclua todos os atributos necessários, incluindo o curso. Implemente o método salario() para retornar um valor fixo para estagiários.

Crie uma lista de objetos que inclua instâncias de Funcionario, Estagiario, Aluno e Professor. Certifique-se de adicionar pelo menos um objeto de cada tipo à lista.

Use uma estrutura de loop para percorrer a lista e exibir as informações de cada objeto, incluindo seu nome, tipo (Funcionario, Estagiario, Aluno ou Professor), RG, CPF e o cargo (se aplicável). Certifique-se de lidar com exceções para garantir que o programa não quebre se algum atributo estiver ausente ou em branco.

Teste o tratamento de exceções para o atributo Cargo. Tente inserir um cargo em branco para um Funcionario e um Professor e veja como o programa lida com isso.

Adicione pelo menos um número de telefone a cada objeto da lista usando o método AddTel. Em seguida, exiba a lista de telefones para cada objeto.

Crie um novo objeto Noia e adicione-o à lista de pessoas. Verifique como a classe Noia lida com os métodos salario() e outras informações.

Este exercício ajudará a praticar os conceitos apresentados no código, como herança, encapsulamento, polimorfismo e tratamento de exceções em C#. Certifique-se de compreender como esses 
conceitos funcionam à medida que trabalha no exercício.

*/



namespace Projeto
{
    class Program
    {

        // Pessoa
        
        public abstract class Pessoa
        {
            public string Nome {  get; }

            public string Cpf { get; }

            public DateTime DateTime { get; }

            public string Rg {  get; }


            public char Sexo { get; }





            public Pessoa(string nome, string cpf, DateTime dtnascimento,string rg ,char sexo)  // construtor 
            {

                this.Nome = nome;
            }

        }




        // estagiario 
            
            // curso





        // funcionario 



       
        // professor 




        // noia




        static void Main(string[] args)
        {



        }

    }
}