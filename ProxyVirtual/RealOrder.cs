namespace ProxyVirtual;

public class RealOrder : IOrder {
    public RealOrder() {
        InitialConfig();
    }

    // Método de inicialização
    private void InitialConfig() {
        // Digamos que aqui seja um método gigantesco que faz muitas coisas
        Console.WriteLine("!!! Inicializando !!!");
    }

    // Método de finalização
    public void ProcessOrder() {
        Console.WriteLine("Morri :(");
    }
}

    