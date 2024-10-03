public class Dragon
{
    public static Dragon instance;
    private readonly string name;

    // Um objeto para sincronização
    private static readonly object lockObject = new object();

    // Construtor privado para evitar instanciamento externo
    private Dragon(string name)
    {
        this.name = name;
    }

    // Propriedade pública para obter a instância
    public static Dragon Instance
    {
        get
        {
            // Usa bloqueio para garantir que apenas uma instância seja criada em ambientes multithread
            lock (lockObject)
            {
                if (instance == null)
                {
                    // Array de nomes de dragão
                    string[] names = [ "Draconis", "Draveris", "Drove", "Falkor", "Smaug", "Alduin",
                                       "Toothless", "Viserion", "Rhaegal", "Drogon", "Ancalagon",
                                       "Saphira", "Norbert", "Charizard", "Puff" ];

                    // Instância de Random para selecionar um nome aleatório
                    Random random = new Random();
                    string selectedName = names[random.Next(names.Length)];

                    // Cria a instância do dragão
                    instance = new Dragon(selectedName);
                }
                return instance;
            }
        }
    }

    // Um exemplo de método da classe
    public void ShowMessage()
    {
        Console.WriteLine($"Hello from Eldoria! My name is {name}, the dragon.");
    }
}
