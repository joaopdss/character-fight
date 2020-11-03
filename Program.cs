using System;

namespace exercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isRunning = true;

            while (isRunning)
            {
                
            bool gelo = false, fogo = false, gelo2 = false, fogo2 = false, magoAtacarNormal = false, magoAtacarNormal2 = false, espadaLonga = false, espadaLonga2 = false, guerreiroAtacarNormal2 = false, guerreiroAtacarNormal = false;
            string tipo = "A";
            Personagem[] personag = new Personagem[2];
            
            

            for (int i = 0; i < personag.Length; i++)
            {
            personag[i] = new Personagem();
            Console.WriteLine("Type character class: 'Guerreiro' or 'Mago'");
            tipo = Console.ReadLine();
            personag[i].Tipo = tipo;
            Console.WriteLine("Type character name: ");
            personag[i].Nome = Console.ReadLine();

            }

            Guerreiro guerreiro1 = new Guerreiro(personag[0].Nome);
            Guerreiro guerreiro2 = new Guerreiro(personag[1].Nome);
            Mago mago1 = new Mago(personag[0].Nome);
            Mago mago2 = new Mago(personag[1].Nome);
            
            if (personag[0].Tipo == "Guerreiro")
            {
                Console.WriteLine("Name: " + guerreiro1.Nome);
                Console.WriteLine("Atack:: " + guerreiro1.Ataque);
                Console.WriteLine("Defense: " + guerreiro1.Defesa);
                Console.WriteLine("Life point: " + guerreiro1.PV);
                Console.WriteLine("Class: " + guerreiro1.Tipo);

            }
            else {
                Console.WriteLine("Name: " + mago1.Nome);
                Console.WriteLine("Atack: " + mago1.Ataque);
                Console.WriteLine("Defense: " + mago1.Defesa);
                Console.WriteLine("Life point: " + mago1.PV);
                Console.WriteLine("Class: " + mago1.Tipo);
            }

            if (personag[1].Tipo == "Guerreiro")
            {
                Console.WriteLine("Name: " + guerreiro2.Nome);
                Console.WriteLine("Atack: " + guerreiro2.Ataque);
                Console.WriteLine("Defense: " + guerreiro2.Defesa);
                Console.WriteLine("Life point: " + guerreiro2.PV);
                Console.WriteLine("Class: " + guerreiro2.Tipo);

            } 
            else {
                Console.WriteLine("Name: " + mago2.Nome);
                Console.WriteLine("Atack: " + mago2.Ataque);
                Console.WriteLine("Defense: " + mago2.Defesa);
                Console.WriteLine("Life point: " + mago2.PV);
                Console.WriteLine("Class: " + mago2.Tipo);
            }
    
            
                Console.WriteLine("Which atack type do you want to use for character 1 " + " ?");
                if (personag[0].Tipo == "Guerreiro")
                {
                    Console.WriteLine("Atacar normal (Digite 1) ou Atacar com espada (Digite 2) ?");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1: 
                            Console.WriteLine("Você selecionou atacar normal");
                            guerreiroAtacarNormal = true;
                            break;
                        case 2: 
                            Console.WriteLine("Você selecionou atacar com espada.");
                            Console.WriteLine("Você deseja atacar com espada longa(Digite 1) ou curta (Digite 2) ?");
                            int opcaoEspada = int.Parse(Console.ReadLine());
                            switch (opcaoEspada)
                            {
                                case 1:
                                Console.WriteLine("Você selecionou atacar com espada longa");
                                espadaLonga = true;
                                break;
                                case 2: 
                                Console.WriteLine("Você selecionou atacar com espada curta");
                                break;
                                default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                            }
                            break;
                            default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                    }
                } else 
                {
                    Console.WriteLine("Atacar normal (Digite 1) ou Atacar com Magia (Digite 2) ?");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Você selecionou atacar normal");
                            magoAtacarNormal = true;
                            break;
                        case 2:
                            Console.WriteLine("Você selecionou atacar com magia");
                            Console.WriteLine("Você deseja atacar com a magia tipo Fogo (Digite 1), Gelo (Digite 2) ou Raio (Digite 3)?");
                            int opcaoMagia = int.Parse(Console.ReadLine());
                            switch (opcaoMagia)
                            {
                                case 1: 
                                    Console.WriteLine("Você selecionou atacar com a magia Fogo");
                                    fogo = true;

                                    break;
                                case 2:
                                    Console.WriteLine("Você selecionou atacar com a magia Gelo");
                                    gelo = true;
                                    break;
                                case 3:
                                    Console.WriteLine("Você selecionou atacar com a magia Raio");
                                    break;
                                default:
                                    Console.WriteLine("Digite apenas as opções 1, 2 ou 3");
                                    break;
                            }
                            break;
                        default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                    }
                }
            

            Console.WriteLine("Qual o tipo de ataque você quer utilizar para o personagem 2 " + " ?");
                if (personag[1].Tipo == "Guerreiro")
                {
                    Console.WriteLine("Atacar normal (Digite 1) ou Atacar com espada (Digite 2) ?");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1: 
                            Console.WriteLine("Você selecionou atacar normal");
                            guerreiroAtacarNormal2 = true;
                            break;
                        case 2: 
                            Console.WriteLine("Você selecionou atacar com espada.");
                            Console.WriteLine("Você deseja atacar com espada longa(Digite 1) ou curta (Digite 2) ?");
                            int opcaoEspada = int.Parse(Console.ReadLine());
                            switch (opcaoEspada)
                            {
                                case 1:
                                Console.WriteLine("Você selecionou atacar com espada longa");
                                espadaLonga2 = true;
                                break;
                                case 2: 
                                Console.WriteLine("Você selecionou atacar com espada curta");
                                break;
                                default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                            }
                            break;
                            default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                    }
                } else 
                {
                    Console.WriteLine("Atacar normal (Digite 1) ou Atacar com Magia (Digite 2) ?");
                    int opcao = int.Parse(Console.ReadLine());
                    switch (opcao)
                    {
                        case 1:
                            Console.WriteLine("Você selecionou atacar normal");
                            magoAtacarNormal2 = true;
                            break;
                        case 2:
                            Console.WriteLine("Você selecionou atacar com magia");
                            Console.WriteLine("Você deseja atacar com a magia tipo Fogo (Digite 1), Gelo (Digite 2) ou Raio (Digite 3)?");
                            int opcaoMagia = int.Parse(Console.ReadLine());
                            switch (opcaoMagia)
                            {
                                case 1: 
                                    Console.WriteLine("Você selecionou atacar com a magia Fogo");
                                    fogo2 = true;
                                    break;
                                case 2:
                                    Console.WriteLine("Você selecionou atacar com a magia Gelo");
                                    gelo2 = true;
                                    break;
                                case 3:
                                    Console.WriteLine("Você selecionou atacar com a magia Raio");
                                    break;
                                default:
                                    Console.WriteLine("Digite apenas as opções 1, 2 ou 3");
                                    break;
                            }
                       
                            break;
                        default:
                                    Console.WriteLine("Digite apenas as opções 1 ou 2");
                                    break;
                    }
                    
                }
            
            // Atacar... 
            
            if (personag[1].Tipo == "Guerreiro")
            {
                // Guerreiro 1 atacando guerreiro2
                if (personag[0].Tipo == "Guerreiro")
                {
                    
                    if (guerreiroAtacarNormal == true)
                    {
                        guerreiro2.Defender(guerreiro1.Atacar());
                    }
                    else if (espadaLonga == true) {
                        guerreiro2.Defender(guerreiro1.AtacarComEspada("longa"));
                    }
                    else {
                        guerreiro2.Defender(guerreiro1.AtacarComEspada("curta"));
                    }
                
                }
                // Mago 1 atacando guerreiro2
                else
                {
                    if (magoAtacarNormal == true)
                    {
                        guerreiro2.Defender(mago1.Atacar());
                    }
                    else if (fogo == true)
                    {
                        guerreiro2.Defender(mago1.AtacarComMagia("fogo"));
                    }
                    else if (gelo == true) {
                        guerreiro2.Defender(mago1.AtacarComMagia("gelo"));
                    }
                    else {
                        guerreiro2.Defender(mago1.AtacarComMagia("raio"));
                    }
                }
            }
          
            else {
                // Guerreiro1 atacando mago2
                if (personag[0].Tipo == "Guerreiro")
                {
                    
                    if (guerreiroAtacarNormal == true)
                    {
                        mago2.Defender(guerreiro1.Atacar());
                    }
                    else if (espadaLonga == true) {
                        mago2.Defender(guerreiro1.AtacarComEspada("longa"));
                    }
                    else {
                        mago2.Defender(guerreiro1.AtacarComEspada("curta"));
                    }
                }
                // Mago1 atacando mago2
                else
                {
                    if (magoAtacarNormal == true)
                    {
                        mago2.Defender(mago1.Atacar());
                    }
                    else if (fogo == true)
                    {
                        mago2.Defender(mago1.AtacarComMagia("fogo"));
                    }
                    else if (gelo == true) {
                        mago2.Defender(mago1.AtacarComMagia("gelo"));
                    }
                    else {
                        mago2.Defender(mago1.AtacarComMagia("raio"));
                    }
                }
            }

           
            if (personag[0].Tipo == "Guerreiro")
            {
                // Guerreiro 2 atacando guerreiro1
                if (personag[1].Tipo == "Guerreiro")
                {
                    
                    if (guerreiroAtacarNormal2 == true)
                    {
                        guerreiro1.Defender(guerreiro2.Atacar());
                    }
                    else if (espadaLonga2 == true) {
                        guerreiro1.Defender(guerreiro2.AtacarComEspada("longa"));
                    }
                    else {
                        guerreiro1.Defender(guerreiro2.AtacarComEspada("curta"));
                    }
                
                }
                // Mago 2 atacando guerreiro1
                else
                {
                    if (magoAtacarNormal2 == true)
                    {
                        guerreiro1.Defender(mago2.Atacar());
                    }
                    else if (fogo2 == true)
                    {
                        guerreiro1.Defender(mago2.AtacarComMagia("fogo"));
                    }
                    else if (gelo2 == true) {
                        guerreiro1.Defender(mago2.AtacarComMagia("gelo"));
                    }
                    else {
                        guerreiro1.Defender(mago2.AtacarComMagia("raio"));
                    }
                }
            }

            else {
                // Guerreiro2 atacando mago1
                if (personag[1].Tipo == "Guerreiro")
                {
                    
                    if (guerreiroAtacarNormal2 == true)
                    {
                        mago1.Defender(guerreiro2.Atacar());
                    }
                    else if (espadaLonga2 == true) {
                        mago1.Defender(guerreiro2.AtacarComEspada("longa"));
                    }
                    else {
                        mago1.Defender(guerreiro2.AtacarComEspada("curta"));
                    }
                }
                // Mago2 atacando mago1
                else
                {
                    if (magoAtacarNormal2 == true)
                    {
                        mago1.Defender(mago2.Atacar());
                    }
                    else if (fogo2 == true)
                    {
                        mago1.Defender(mago2.AtacarComMagia("fogo"));
                    }
                    else if (gelo2 == true) {
                        mago1.Defender(mago2.AtacarComMagia("gelo"));
                    }
                    else {
                        mago1.Defender(mago2.AtacarComMagia("raio"));
                    }
                }
            }


            if (personag[0].Tipo == "Guerreiro")
            {
                if (personag[1].Tipo == "Guerreiro")
                {
                    if (guerreiro1.PV > guerreiro2.PV)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", guerreiro1.Nome, guerreiro1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", guerreiro2.Nome, guerreiro2.PV);   
                    } 
                    else if (guerreiro2.PV > guerreiro1.PV) {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", guerreiro2.Nome, guerreiro2.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", guerreiro1.Nome, guerreiro1.PV);    
                    }
                    else {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", guerreiro1.Nome, guerreiro1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", guerreiro2.Nome, guerreiro2.PV);
                    Console.WriteLine("Ocorreu um empate pois terminaram com os mesmos pontos de vida restantes!");
                    Console.WriteLine(""); 
                    }
                } 
                else 
                {
                    if (guerreiro1.PV > mago2.PV)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", guerreiro1.Nome, guerreiro1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", mago2.Nome, mago2.PV);   
                    } 
                    else if (mago2.PV > guerreiro1.PV) {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", mago2.Nome, mago2.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", guerreiro1.Nome, guerreiro1.PV);    
                    }
                    else {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", guerreiro1.Nome, guerreiro1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", mago2.Nome, mago2.PV);
                    Console.WriteLine("Ocorreu um empate pois terminaram com os mesmos pontos de vida restantes!");
                    Console.WriteLine("");
                    }
                } 
            }    
            else {
                if (personag[1].Tipo == "Guerreiro")
                {
                    if (mago1.PV > guerreiro2.PV)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", mago1.Nome, mago1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", guerreiro2.Nome, guerreiro2.PV);   
                    } 
                    else if (guerreiro2.PV > mago1.PV) {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", guerreiro2.Nome, guerreiro2.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", mago1.Nome, mago1.PV);    
                    }
                    else {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", mago1.Nome, mago1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", guerreiro2.Nome, guerreiro2.PV);
                    Console.WriteLine("Ocorreu um empate pois terminaram com os mesmos pontos de vida restantes!");
                    Console.WriteLine(""); 
                    }
                }
                else 
                {
                    if (mago1.PV > mago2.PV)
                    {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", mago1.Nome, mago1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", mago2.Nome, mago2.PV);   
                    } 
                    else if (mago2.PV > mago1.PV) {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o ganhador", mago2.Nome, mago2.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes e foi o perdedor", mago1.Nome, mago1.PV);    
                    }
                    else {
                    Console.WriteLine("");
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", mago1.Nome, mago1.PV);
                    Console.WriteLine("O personagem {0} terminou com um total de {1} pontos de vida restantes", mago2.Nome, mago2.PV);
                    Console.WriteLine("Ocorreu um empate pois terminaram com os mesmos pontos de vida restantes!");
                    Console.WriteLine("");
                    }
                }    
            }
           
           Console.WriteLine("Você deseja continuar jogando?");
           Console.WriteLine("Sim (Digite 1) ou Não (Digite 2)");
           int opcional = int.Parse(Console.ReadLine());
               switch (opcional)
                {
                case 1: 
                    isRunning = true;
                    break;
                case 2:
                    isRunning = false;
                    break;

               default:
                    Console.WriteLine("Digite apenas '1' ou '2'");
                    break;
                }
           
        

            }

        Console.WriteLine("");
        Console.WriteLine("Obrigado por jogar!");
        }
    }
}
