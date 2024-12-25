using System;
using System.Collections.Generic;

struct Animal
{
    public string AnimalSpecies;
    public string AnimalID;
    public string AnimalAge;
    public string AnimalPhysicalDescription;
    public string AnimalPersonalityDescription;
    public string AnimalNickname;

    public Animal(string animalID, string animalSpecies, string animalAge, string animalPhysicalDescription, string animalPersonalityDescription, string animalNickname)
    {
        AnimalID = animalID;
        AnimalSpecies = animalSpecies;
        AnimalAge = animalAge;
        AnimalPhysicalDescription = animalPhysicalDescription;
        AnimalPersonalityDescription = animalPersonalityDescription;
        AnimalNickname = animalNickname;
    }

    // Sobrescrever o m�todo 'ToString' para exibir as informa��es do animal
    public override string ToString()
    {
        return $"ID: {AnimalID}\n" +
               $"Esp�cie: {AnimalSpecies}\n" +
               $"Idade: {AnimalAge}\n" +
               $"Apelido: {AnimalNickname}\n" +
               $"Descri��o F�sica: {AnimalPhysicalDescription}\n" +
               $"Personalidade: {AnimalPersonalityDescription}\n";
    }
}

class Principal
{
    public static void Main()
    {
        int maxPets = 8;
        Animal[] ourAnimals = new Animal[maxPets];

        ourAnimals[0] = new Animal("C01", "Cachorro", "03", "Preto, Atl�tico", "Amig�vel", "Reuri");
        ourAnimals[1] = new Animal("C02", "Gato", "02", "Branco, Peludo", "Independente", "Mimi");
        ourAnimals[2] = new Animal("C03", "Papagaio", "05", "Verde, Falante", "Soci�vel", "Loro");
        ourAnimals[3] = new Animal("C04", "Gato", "05", "Preto, Agitado", "Soci�vel", "Xane");
        ourAnimals[4] = new Animal("C05", "Cachorro", "05", "Branco, Quieto", "Soci�vel", "Auau");
        ourAnimals[5] = new Animal("C06", "Cachorro", "05", "Branco, Quieto", "Soci�vel", "Auau");
        ourAnimals[6] = new Animal("C07", "Gato", "05", "Branco, Quieto", "Soci�vel", "Pixane");
        ourAnimals[7] = new Animal("C08", "Gato", "05", "Branco, Quieto", "Soci�vel", "Zulu");

        string menuSelection = "";

        Console.WriteLine("" +
                          "Welcome to the Contoso PetFriends app. Your main menu options are:\r\n" +
                          "1. List all of our current pet information\r\n" +
                          "2. Add a new animal friend to the ourAnimals array\r\n" +
                          "3. Ensure animal ages and physical descriptions are complete\r\n" +
                          "4. Ensure animal nicknames and personality descriptions are complete\r\n" +
                          "5. Edit an animal's age\r\n" +
                          "6. Edit an animal's personality description\r\n" +
                          "7. Display all cats with a specified characteristic\r\n" +
                          "8. Display all dogs with a specified characteristic\r\n\r\n" +
                          "Enter your selection number (or type Exit to exit the program)");

        do
        {
            string readResult = Console.ReadLine().ToLower();

            if (readResult == "exit")
            {
                menuSelection = "exit";
            }
            else if (readResult == "1")
            {
                foreach (Animal animal in ourAnimals)
                {
                    if (!string.IsNullOrEmpty(animal.AnimalID)) 
                    {
                        Console.WriteLine(animal);
                    }
                }
            }
            else if (readResult == "2")
            {
                if (ourAnimals.Length < maxPets)
                {
                    Console.WriteLine("Preencha os dados do Pet");
                    Console.WriteLine("Digite o ID do animal:");
                    string id = Console.ReadLine();

                    Console.WriteLine("Digite a esp�cie do animal:");
                    string especie = Console.ReadLine();

                    Console.WriteLine("Digite a idade do animal:");
                    string idade = Console.ReadLine();

                    Console.WriteLine("Digite a descri��o f�sica do animal:");
                    string descricaoFisica = Console.ReadLine();

                    Console.WriteLine("Digite a descri��o de personalidade do animal:");
                    string personalidade = Console.ReadLine();

                    Console.WriteLine("Digite o apelido do animal:");
                    string apelido = Console.ReadLine();

                    // Adicionar o novo animal ao array
                    ourAnimals[Array.FindIndex(ourAnimals, a => a.AnimalID == null)] = new Animal(id, especie, idade, descricaoFisica, personalidade, apelido);
                }
                else
                {
                    Console.WriteLine("N�o h� espa�o dispon�vel para mais animais.");
                }
            }
            else if (readResult == "3")
            {
                List<int> incompleteDescriptions = new List<int>();

                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalPhysicalDescription == null)
                    {
                        Console.WriteLine($"Descri��o n�o est� completa para o animal no �ndice {i}.");
                        incompleteDescriptions.Add(i);
                    }
                }

                // Retornando ou processando os �ndices
                if (incompleteDescriptions.Count > 0)
                {
                    Console.WriteLine("�ndices dos animais com descri��o f�sica incompleta: " + string.Join(", ", incompleteDescriptions));
                }
            }
            else if (readResult == "4")
            {
                List<int> incompleteNicknames = new List<int>();

                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalNickname == null)
                    {
                        Console.WriteLine($"Apelido n�o preenchido referente ao animal no �ndice {i}.");
                        incompleteNicknames.Add(i);
                    }
                }

                // Retornando ou processando os �ndices
                if (incompleteNicknames.Count > 0)
                {
                    Console.WriteLine("�ndices dos animais com apelido incompleto: " + string.Join(", ", incompleteNicknames));
                }
            }
            else if (readResult == "5")
            {
                // Mostrar os animais antes da edi��o
                Console.WriteLine("Animais antes da edi��o:");
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                    {
                        Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                    }
                }

                // Solicitar ao usu�rio o �ndice do animal a ser editado
                Console.WriteLine("Digite o �ndice do animal que voc� deseja editar a idade:");
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < ourAnimals.Length)
                {
                    // Solicitar o novo valor para a idade do animal
                    Console.WriteLine("Digite a nova idade do animal:");
                    string newAge = Console.ReadLine();

                    // Atualizar a propriedade de idade do animal no array
                    ourAnimals[index].AnimalAge = newAge;

                    // Mostrar os animais ap�s a edi��o
                    Console.WriteLine("Animais ap�s a edi��o:");
                    for (int i = 0; i < ourAnimals.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                        {
                            Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("�ndice inv�lido.");
                }
            }
            else if (readResult == "6")
            {
                // Mostrar os animais antes da edi��o
                Console.WriteLine("Animais antes da edi��o:");
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                    {
                        Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                    }
                }

                // Solicitar ao usu�rio o �ndice do animal a ser editado
                Console.WriteLine("Digite o �ndice do animal que voc� deseja editar a descri��o de personalidade:");
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < ourAnimals.Length)
                {
                    // Solicitar o novo valor para a descri��o de personalidade do animal
                    Console.WriteLine("Digite a nova descri��o de personalidade:");
                    string newPersonality = Console.ReadLine();

                    // Atualizar a propriedade de descri��o de personalidade do animal no array
                    ourAnimals[index].AnimalPersonalityDescription = newPersonality;

                    // Mostrar os animais ap�s a edi��o
                    Console.WriteLine("Animais ap�s a edi��o:");
                    for (int i = 0; i < ourAnimals.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                        {
                            Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("�ndice inv�lido.");
                }
            }
            else if (readResult == "7")
            {
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalSpecies == "Gato")
                    {
                        // Realizar alguma opera��o com os animais de esp�cie "Gato"
                        Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                    }
                }
            }
            else if (readResult == "8")
            {
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalSpecies == "Cachorro")
                    {
                        Console.WriteLine($"�ndice {i}: {ourAnimals[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Op��o inv�lida. Por favor, tente novamente.");
            }

        } while (menuSelection != "exit");
    }
}
