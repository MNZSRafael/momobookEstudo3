Livro livro1 = new Livro();
livro1.NomeDoLivro = "Cem anos de solidão";
livro1.Autor = "Gabriel García Marquez";
livro1.Editora = "Record";
livro1.Paginas = 396;
livro1.Disponivel = true;

Livro livro2 = new Livro();
livro2.NomeDoLivro = "A metamorfose";
livro2.Autor = "Franz Kakfa";
livro2.Editora = "Record";
livro2.Paginas = 96;
livro2.Disponivel = false;

livro1.ExibirFichaCadastral();
livro2.ExibirFichaCadastral();



Console.ReadLine();
Console.Clear();
Console.WriteLine("Aperte qualquer tecla para voltar");
Console.ReadLine();
