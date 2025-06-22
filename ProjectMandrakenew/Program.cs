using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading;

namespace ProjectMandrakenew
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("======================== Bem Vindos ao Suporte da Netsuporte ===================\n");
            Console.WriteLine("Nome do técnico:\t\tAntônio Eduardo");
            Console.WriteLine("Profissão: \tSuporte Técnico e Desenvolvimento\n");
            Console.WriteLine("\nComo atuamos : \n \tHardware, Software e Resolução de Problemas");
            Console.WriteLine("=============================================================\n");

            Console.Write("Apresento para você as opções para abertura de chamado:\n");
            Console.Write("Opção 0 : encerrando o sistema\n"); 
            Console.Write("Opção 1 : para abertura de chamado com o nossos técnicos\n");
            //string Opçãokey = "Opção 1";
            Console.Write("Opção 2 : para falar com o nosso financeiro\n");
            //string Opçãochave = "Opção 2";
            Console.Write("Opção 3 : para falar com o nosso comercial\n");
            //string Opçãomoeda = "Opção 3";

            Console.WriteLine("\nPreciso que digite a opção que você precisa :\n");

            string escolha = Console.ReadLine();

            if (escolha == "Opção 1" || escolha == "1")
            {
                Console.WriteLine("\nOk, estarei te passando para o suporte técnico\n");
                Console.Write("\nCarregando\n");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("...");
                }

                Console.Write("\nBem vindo ao portal do suporte T.I\n");
                Console.Write("\n Como posso ajuda-lo?\n");
                Console.Write("\n Opção 1 : Visita técnica");
                Console.Write("\n Opção 2 : Preciso de uma ajuda remotamente");
                Console.Write("\n Opção 3 : Preciso fazer uma solicitação de cartucho de toner\n");

                Console.WriteLine("\nDigite a opção que mais se enquadra nos chamados:\n");

                string ESCOLHA = Console.ReadLine();

                Console.WriteLine("\nCarregando\n");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(1000);
                    Console.WriteLine("...");
                }

                if (ESCOLHA == "Opção 1" || ESCOLHA == "1")
                {
                    Console.Write("\nPreciso que você me diga um pouco mais sobre o defeito, por favor me mande um e-mail me informando o que está ocorrendo. (edu.coding@suportenet.com.br).\n");
                    Console.Write("Preciso que me informe seu numero de telefone por e-mail.\n");
                    Console.WriteLine("\nEu já estou abrindo o seu chamado esta sendo aberto para verificarmos.\n");

                    Random rnd = new Random();
                    int numerochamado = rnd.Next(100, 99999);

                    Console.WriteLine($"Chamado registrado no sistema com sucesso : #{numerochamado}");
                    Console.Write("\nApós o recebimento do e-mail com as informações do defeito do equipamento, temos um prazo de 48 horas para continuarmos as tratativas.\n");

                }

                else if (ESCOLHA == "Opção 2" || ESCOLHA == "2")
                {

                    Console.Write("\nEntendido, você precisa de uma ajuda remota");
                    Console.Write("Nos trabalhamos com o aplicativo Anydesk, você conhece?\n");
                    Console.Write("\nEu deixo aqui para você o link de instalação do software : https://anydesk.com/pt/downloads/windows\n ");
                    Console.WriteLine("Assim que você fizer a instalação, peço para que me mande um e-mail (edu.coding@suportenet.com.br) com o numero de ID para fazermos o acesso remoto, e preciso que você me especifique como posso ajudar.\n");

                    Random rnd = new Random();
                    int newchamado = rnd.Next(100, 99999);

                    Console.WriteLine($"O seu chamado foi aberto! : #{newchamado}\n");

                }

                else if (ESCOLHA == "Opção 3" || ESCOLHA == "3")

                {
                    Console.Write("\nHuum, entendido.\n");
                    Console.Write("\nParece que acabaram seus suprimentos\n");
                    Console.Write("\nEstarei abrindo o seu chamado, preciso apenas que você me mande um e-mail (edu.coding@suportenet.com.br) confirmando o modelo do equipamento.\n");

                    Random rnd = new Random();
                    int new_toner = rnd.Next(100, 99999);

                    Console.WriteLine($"\nO seu chamado foi aberto #{new_toner}\n");
                }
                else
                {
                    Console.WriteLine("\nEsta opção não é válida, escolha as opções são : Opção 1, Opção 2, Opção 3");
                }

            }

            else if (escolha == "Opção 2" || escolha == "2")
            {
                Console.WriteLine("OK, estarei te passando para o Financeiro");

                Console.WriteLine("\nCarregando\n");
                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("...\n");
                }

                Console.WriteLine("Bem vindo a central Financeira do SuporteNet\n");
                Console.WriteLine("\nComo podemos te ajudar?\n");

                Console.WriteLine("Opção 1 : Preciso de minha fatura deste mês\n");
                Console.WriteLine("Opção 2 : Preciso contratar outro plano\n");
                Console.WriteLine("Opção 3 : Preciso cancelar o plano\n");

                string decisão = Console.ReadLine();

                if (decisão == "Opção 1" || decisão == "1")
                {
                    Console.WriteLine("\nCarregando\n");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(2000);
                        Console.WriteLine("...");
                    }

                    Console.WriteLine("\n OK você precisa de sua fatura\n");
                    Console.Write("Segue o e-mail do financeiro : financeiro@suportenet.com.br\n");
                    Console.Write("\nComo faturas são confidenciais preciso que entre em contato com o financeiro por e-mail para verificar tal questão,não normalizamos atrasos\n");

                }
                else if (decisão == "Opção 2" || decisão == "2")
                {

                    Console.WriteLine("\nCarregando\n");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(2000);
                        Console.Write("...\n");

                    }

                    Console.Write("Ficamos felizes em ter você conosco\n");
                    Console.Write("Estarei te passando os e-mails dos nossos representantes comerciais\n");

                    Console.WriteLine("comercial@suportenet.com.br\n");
                    Console.WriteLine("administrativo@suportenet.com.br\n");

                    Console.WriteLine("\nVerifique com eles sobre assinatura de planos e Upgrades\n");
                }

                else if (decisão == "Opção 3" || decisão == "3")
                {
                    Console.WriteLine("\nCarregando\n");
                    for (int i = 0; i < 3; i++)
                    {
                        Thread.Sleep(2000);
                        Console.Write("...");
                    }

                    Console.WriteLine("\nPreciso que voce formalize um e-mail para a direção solicitando o cancelamento do seu plano, segue o e-mail : direcao@suportenet.com.br\n");

                    Console.Write("\n Deixo abaixo o protocolo do cancelamento\n");

                    Random rnd = new Random();
                    int cancel = rnd.Next(100, 99999);

                    Console.WriteLine($"\nSegue o protocolo de cancelamento {cancel}");

                }
                else
                {
                    Console.WriteLine("Esta opção é invalida, as opções validas são apenas as opções : Opção 1, Opção 2, Opção 3\n");
                }
            }

            else if (escolha == "Opção 3" || escolha == "3")
            {
                Console.WriteLine("Estou te transferindo para o comercial\n");

                Console.WriteLine("\nCarregando\n");

                for (int i = 0; i < 3; i++)
                {
                    Thread.Sleep(2000);
                    Console.WriteLine("\n...\n");
                }

                Console.WriteLine("\nBem vindo a área comercial\n");
                Console.WriteLine("\nDigite sua mensagem : \n");

                string frase = Console.ReadLine();

                Console.WriteLine("\nSua Mensagem foi enviada ao e-mail do comercial\n");
                Console.Write("\nEm 48 horas entraremos em contato com voce\n");

            }

            else 
            {
                Console.Write("\nEncerrando o Sistema\n");
                Thread.Sleep(1000);
                Environment.Exit(0);

            }

            
        }
 

    }

}
  
    

