namespace Ghost;

public class Fantasma
{
    private int Count;
    private bool Inicializado = false;
    private Real? ObjetoReal = null;

    public Real BuscaObjetReal(int Id) {

        if(!Inicializado) {
            ObjetoReal = MetodoGigantesco(Id); 
            Inicializado = true;
        }

        return new Real();
    }

    private Real MetodoGigantesco(int Id) {
        // método que executa algo custoso para aplicação, pode ser calculos, buscar dados em banco
        // ou até calcular um hashcode
        return new Real();
    }
}
