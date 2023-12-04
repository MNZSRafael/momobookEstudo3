class Livro
    
    {
    public string NomeDoLivro { get; set; } 
    public string Autor { get; set; }   
    public string Editora { get; set; }
    public int Paginas { get; set; }
    public bool Disponivel { get; set; }
    public string DescricaoResumida => $"O livro {NomeDoLivro} foi escrito por {Autor}.\n";



    public void ExibirFichaCadastral() 
    {
        Console.WriteLine($"Título: {NomeDoLivro}");
        Console.WriteLine($"Autor(a): {Autor}");
        Console.WriteLine($"Editora: {Editora}");
        Console.WriteLine($"nº páginas: {Paginas}");
        Console.WriteLine(DescricaoResumida);
        if (Disponivel)
        {
            Console.WriteLine("O livro encontra-se disponível.\n");
        }

        else { Console.WriteLine("O livro está esgotado.\n"); }
       
    }

    }