namespace java_list_CSharp;

internal class Program<T>
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");
        List<string> lista1 = new ArrayList<string>();
        List<string> lista2 = new LinkedList<string>();

        Console.WriteLine();

        Console.WriteLine("Prueba sobre la linked list:");
        TryList(lista1);

        Console.WriteLine();

        Console.WriteLine("Prueba sobre la array list:");
        TryList(lista2);
    }

    public static void TryList<T>(List<T> list)
    {
        Console.WriteLine("Inserta al inicio y al final");
        list.addAtHead((T)Convert.ChangeType("Hola", typeof(T)));
        list.addAtTail((T)Convert.ChangeType("Adios", typeof(T)));
        Iterator<T> iterator = list.getIterator();
        Console.WriteLine("Puede leer el tamaño de la lista");
        int tam = list.getSize();

        Object content;

        Console.WriteLine(tam);
        Console.WriteLine("Contenido de la lista");
        while (iterator.hasNext())
        {
            content = iterator.next();
            Console.WriteLine(content);
        }
        Console.WriteLine();

        Console.WriteLine("Lee contenido en la primera posición");
        Object text = list.getAt(1);
        Console.WriteLine(text);
        Console.WriteLine();

        Console.WriteLine("Agrega y lee contenido en la primera posición");
        list.setAt(1, (T)Convert.ChangeType("Hello", typeof(T)));
        text = list.getAt(1);
        Console.WriteLine(text);
        Console.WriteLine();

        Console.WriteLine("Elimina contenido en la primera posición, lee contenido actualizado de la primera posición e imprime el tamaño de la lista");
        list.remove(1);
        text = list.getAt(1);
        Console.WriteLine(text);

        tam = list.getSize();
        Console.WriteLine(tam);

        Iterator<T> iterator2 = list.getIterator();

        for (int i = 0; i < 3; i++)
        {
            list.addAtHead((T)Convert.ChangeType("Repetido", typeof(T)));
        }

        Console.WriteLine("Agrega contenido repetido(3) e imprime el tamaño");
        for (int i = 0; i < list.getSize(); i++)
        {
            Object content2 = list.getAt(i + 1);
            Console.WriteLine(content2);
        }
        tam = list.getSize();
        Console.WriteLine(tam);
        Console.WriteLine();

        Console.WriteLine("Elimina el contenido repetido e imprime su tamaño");
        list.removeAllWithValue((T)Convert.ChangeType("Repetido", typeof(T)));

        for (int i = 0; i < list.getSize(); i++)
        {
            Object content2 = list.getAt(i + 1);
            Console.WriteLine(content2);
        }
        tam = list.getSize();
        Console.WriteLine(tam);
        Console.WriteLine();

        Console.WriteLine("Agrega más contenido al final e imprime el tamaño actualizado");
        for (int i = 0; i < 3; i++)
        {
            list.addAtTail((T)Convert.ChangeType("Fin", typeof(T)));
        }
        for (int i = 0; i < list.getSize(); i++)
        {
            Object content2 = list.getAt(i + 1);
            Console.WriteLine(content2);
        }
        tam = list.getSize();
        Console.WriteLine(tam);
        Console.WriteLine();

        Console.WriteLine("Elimina todo el contenido y regresa el tamaño actualizado");
        list.removeAll();
        for (int i = 0; i < list.getSize(); i++)
        {
            Object content2 = list.getAt(i + 1);
            Console.WriteLine(content2);
        }
        tam = list.getSize();
        Console.WriteLine(tam);
    }
}