namespace ValueHolder;

public class Teste
{
    private Lazy<User>? teste;

    public User? GetUser() {
        return teste?.Value;
    }
}
