namespace Ghost;
public class Complicado
{
    public Complicado() {
    }
}

public class Real {
    private Complicado? ObjetoComplicado = null;

    public Real(int Id) {
        // método que executa algo custoso para aplicação, pode ser calculos, buscar dados em banco
        // ou até calcular um hashcode
    }
}

public class Fantasma
{
    private bool Inicializado = false;
    private Complicado? ObjetoComplicado = null;

    public Complicado? Busca(int Id) {

        if(!Inicializado) {
            ObjetoComplicado = Inicializacao(Id); 
            Inicializado = true;
        }

        return ObjetoComplicado;
    }

    private Complicado Inicializacao(int Id) {
        // método que executa algo custoso para aplicação, pode ser calculos, buscar dados em banco
        // ou até calcular um hashcode
        var objetComplicado = new Complicado();
        return objetComplicado;
    }
}
