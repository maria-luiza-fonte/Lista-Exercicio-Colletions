public class Program
{
    static void Main()
    {
        List<string> tarefas = new List<string>()

        {
            "Estudar C#",
            "Fazer exercícios",
            "Enviar relatório",
            "Reunião com equipe",
            "Organizar documentos"
        };

        // 2. Inserir nova tarefa na segunda posição (índice 1)
        tarefas.Insert(1, "Comprar café");

        // 3. Alterar a quarta tarefa (índice 3) para outro texto
        tarefas[3] = "Reunião com cliente";

        // 4. Pesquisar se existe a tarefa "Enviar relatório"
        string tarefaProcurada = "Enviar relatório";
        if (tarefas.Contains(tarefaProcurada))
        {
            Console.WriteLine($"A tarefa \"{tarefaProcurada}\" está na lista.");
        }
        else
        {
            Console.WriteLine($"A tarefa \"{tarefaProcurada}\" NÃO está na lista.");
        }

        // 5. Remover uma tarefa pelo nome
        tarefas.Remove("Fazer exercícios");

        // 6. Exibir todas as tarefas restantes com índice
        Console.WriteLine("\nTarefas restantes:");
        foreach (var tarefa in tarefas)
        {
            int indice = tarefas.IndexOf(tarefa);
            Console.WriteLine($"{indice}: {tarefa}");
        }


        Console.WriteLine("\n******************************02******************************************");

        Queue<string> fila = new Queue<string>();

        // Adicionando clientes à fila
        fila.Enqueue("Ana");
        fila.Enqueue("Carlos");
        fila.Enqueue("João");
        fila.Enqueue("Mariana");
        fila.Enqueue("Pedro");

        Console.WriteLine("Fila inicial:");
        foreach (string cliente in fila)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("\n=== Atendimento ===");
        // Atendendo o primeiro cliente da fila
        if (fila.Count > 0)
        {
            string atendido = fila.Dequeue();
            Console.WriteLine("Cliente atendido: " + atendido);
        }

        // Pesquisar se "João" ainda está na fila
        string pesquisa = "João";
        if (fila.Contains(pesquisa))
        {
            int posicao = 1;
            foreach (string cliente in fila)
            {
                if (cliente == pesquisa)
                {
                    Console.WriteLine($"\nO cliente {pesquisa} está na fila, posição: {posicao}");
                    break;
                }
                posicao++;
            }
        }
        else
        {
            Console.WriteLine($"\nO cliente {pesquisa} não está mais na fila.");
        }

        // Exibir todos os clientes restantes na fila
        Console.WriteLine("\nClientes restantes na fila:");
        foreach (string cliente in fila)
        {
            Console.WriteLine(cliente);
        }

        Console.WriteLine("\nAtendimento finalizado.");

        Dictionary<string, string> agenda = new Dictionary<string, string>();


        agenda["João"] = "1111-1111";
        agenda["Maria"] = "2222-2222";
        agenda["Carlos"] = "3333-3333";
        agenda["Ana"] = "4444-4444";
        agenda["Pedro"] = "5555-5555";

        Console.WriteLine("Agenda de Contatos:\n");
        foreach (KeyValuePair<string, string> kvp in agenda)
        {
            Console.WriteLine($"Nome: {kvp.Key}, Telefone: {kvp.Value}");
        }

        string nomePesquisa = "Maria";
        if (agenda.ContainsKey(nomePesquisa))
        {
            Console.WriteLine($"Contato encontrado: {nomePesquisa} - Telefone: {agenda[nomePesquisa]}\n");
        }
        else
        {
            Console.WriteLine($"{nomePesquisa} não está na agenda.\n");
        }


        agenda.Remove("Ana");
        Console.WriteLine("Contato 'Ana' removido da agenda.\n");


        Console.WriteLine("Contatos na agenda:");
        foreach (var contato in agenda)
        {
            Console.WriteLine($"Nome: {contato.Key}, Telefone: {contato.Value}");
        }



        Console.WriteLine("\n******************************03******************************************");


    }
}
