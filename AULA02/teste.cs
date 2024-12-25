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

    // Sobrescrever o método 'ToString' para exibir as informações do animal
    public override string ToString()
    {
        return $"ID: {AnimalID}\n" +
               $"Espécie: {AnimalSpecies}\n" +
               $"Idade: {AnimalAge}\n" +
               $"Apelido: {AnimalNickname}\n" +
               $"Descrição Física: {AnimalPhysicalDescription}\n" +
               $"Personalidade: {AnimalPersonalityDescription}\n";
    }
}

class Principal
{
    public static void Main()
    {
        int maxPets = 8;
        Animal[] ourAnimals = new Animal[maxPets];

        ourAnimals[0] = new Animal("C01", "Cachorro", "03", "Preto, Atlético", "Amigável", "Reuri");
        ourAnimals[1] = new Animal("C02", "Gato", "02", "Branco, Peludo", "Independente", "Mimi");
        ourAnimals[2] = new Animal("C03", "Papagaio", "05", "Verde, Falante", "Sociável", "Loro");
        ourAnimals[3] = new Animal("C04", "Gato", "05", "Preto, Agitado", "Sociável", "Xane");
        ourAnimals[4] = new Animal("C05", "Cachorro", "05", "Branco, Quieto", "Sociável", "Auau");
        ourAnimals[5] = new Animal("C06", "Cachorro", "05", "Branco, Quieto", "Sociável", "Auau");
        ourAnimals[6] = new Animal("C07", "Gato", "05", "Branco, Quieto", "Sociável", "Pixane");
        ourAnimals[7] = new Animal("C08", "Gato", "05", "Branco, Quieto", "Sociável", "Zulu");

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

                    Console.WriteLine("Digite a espécie do animal:");
                    string especie = Console.ReadLine();

                    Console.WriteLine("Digite a idade do animal:");
                    string idade = Console.ReadLine();

                    Console.WriteLine("Digite a descrição física do animal:");
                    string descricaoFisica = Console.ReadLine();

                    Console.WriteLine("Digite a descrição de personalidade do animal:");
                    string personalidade = Console.ReadLine();

                    Console.WriteLine("Digite o apelido do animal:");
                    string apelido = Console.ReadLine();

                    // Adicionar o novo animal ao array
                    ourAnimals[Array.FindIndex(ourAnimals, a => a.AnimalID == null)] = new Animal(id, especie, idade, descricaoFisica, personalidade, apelido);
                }
                else
                {
                    Console.WriteLine("Não há espaço disponível para mais animais.");
                }
            }
            else if (readResult == "3")
            {
                List<int> incompleteDescriptions = new List<int>();

                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalPhysicalDescription == null)
                    {
                        Console.WriteLine($"Descrição não está completa para o animal no índice {i}.");
                        incompleteDescriptions.Add(i);
                    }
                }

                // Retornando ou processando os índices
                if (incompleteDescriptions.Count > 0)
                {
                    Console.WriteLine("Índices dos animais com descrição física incompleta: " + string.Join(", ", incompleteDescriptions));
                }
            }
            else if (readResult == "4")
            {
                List<int> incompleteNicknames = new List<int>();

                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalNickname == null)
                    {
                        Console.WriteLine($"Apelido não preenchido referente ao animal no índice {i}.");
                        incompleteNicknames.Add(i);
                    }
                }

                // Retornando ou processando os índices
                if (incompleteNicknames.Count > 0)
                {
                    Console.WriteLine("Índices dos animais com apelido incompleto: " + string.Join(", ", incompleteNicknames));
                }
            }
            else if (readResult == "5")
            {
                // Mostrar os animais antes da edição
                Console.WriteLine("Animais antes da edição:");
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                    {
                        Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                    }
                }

                // Solicitar ao usuário o índice do animal a ser editado
                Console.WriteLine("Digite o índice do animal que você deseja editar a idade:");
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < ourAnimals.Length)
                {
                    // Solicitar o novo valor para a idade do animal
                    Console.WriteLine("Digite a nova idade do animal:");
                    string newAge = Console.ReadLine();

                    // Atualizar a propriedade de idade do animal no array
                    ourAnimals[index].AnimalAge = newAge;

                    // Mostrar os animais após a edição
                    Console.WriteLine("Animais após a edição:");
                    for (int i = 0; i < ourAnimals.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                        {
                            Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Índice inválido.");
                }
            }
            else if (readResult == "6")
            {
                // Mostrar os animais antes da edição
                Console.WriteLine("Animais antes da edição:");
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                    {
                        Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                    }
                }

                // Solicitar ao usuário o índice do animal a ser editado
                Console.WriteLine("Digite o índice do animal que você deseja editar a descrição de personalidade:");
                int index = int.Parse(Console.ReadLine());

                if (index >= 0 && index < ourAnimals.Length)
                {
                    // Solicitar o novo valor para a descrição de personalidade do animal
                    Console.WriteLine("Digite a nova descrição de personalidade:");
                    string newPersonality = Console.ReadLine();

                    // Atualizar a propriedade de descrição de personalidade do animal no array
                    ourAnimals[index].AnimalPersonalityDescription = newPersonality;

                    // Mostrar os animais após a edição
                    Console.WriteLine("Animais após a edição:");
                    for (int i = 0; i < ourAnimals.Length; i++)
                    {
                        if (!string.IsNullOrEmpty(ourAnimals[i].AnimalID)) // Ensure only initialized animals are displayed
                        {
                            Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Índice inválido.");
                }
            }
            else if (readResult == "7")
            {
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalSpecies == "Gato")
                    {
                        // Realizar alguma operação com os animais de espécie "Gato"
                        Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                    }
                }
            }
            else if (readResult == "8")
            {
                for (int i = 0; i < ourAnimals.Length; i++)
                {
                    if (ourAnimals[i].AnimalSpecies == "Cachorro")
                    {
                        Console.WriteLine($"Índice {i}: {ourAnimals[i]}");
                    }
                }
            }
            else
            {
                Console.WriteLine("Opção inválida. Por favor, tente novamente.");
            }

        } while (menuSelection != "exit");
    }
}
