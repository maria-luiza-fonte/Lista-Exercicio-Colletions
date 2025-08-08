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
       foreach()
        

        Console.WriteLine("\n******************************02******************************************");

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
