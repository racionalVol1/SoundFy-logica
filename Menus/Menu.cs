﻿ using LogicaSoundFY.Modelos;

namespace LogicaSoundFY.Menus;


internal class Menu
{    
    public void ExibirTituloDaOpcao(string titulo)
    {
        int quantidadeDeLetras = titulo.Length;
        string asteriscos = string.Empty.PadLeft(quantidadeDeLetras, '*');
        Console.WriteLine(asteriscos);
        Console.WriteLine(titulo);
        Console.WriteLine(asteriscos + "\n");
    }

    public virtual void Executar(Dictionary<string, Banda> bandasRegistradas)
    {
        Console.Clear();
        
    }

    public virtual void Executar(Dictionary<string, Ouvinte> ouvintesRegistrados)
    {
        Console.Clear();
    }
}
