public sealed class SingletonGenerico<G> where G : class, new()
{
    private static G _instance;

    public static G GetInstance()
    {
        lock (typeof(G))
        {
            if (_instance == null)
                _instance = new G();

            return _instance;
        }
    }
}

// Teste do padrão Singleton
public class Person { public string Name { get; set; } }
public class Person { public string Email { get; set; } }
public class Person { public string EmailC { get; set; } }
public class Person { public string CPF { get; set; } }
public class Person { public string Celphone { get; set; } }
public class Person { public DateTime Nascimento { get; set; } }
public class Person { public bool Whatsapp { get; set; } }
public class Person { public bool EmailSms { get; set; } }
public class Person { public string Pais { get; set; } }
public class Person { public string Cidade { get; set; } }
public class Person { public string CEP { get; set; } }
public class Person { public string Endereco { get; set; } }
public class Person { public int Numero { get; set; } }

class Program
{
    static void Main(string[] args)
    {
        Person per = SingletonGenerico<Person>.GetInstance();
        per.Nome = "João";

    }
}