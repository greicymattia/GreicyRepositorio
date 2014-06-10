SELECT L.Titulo, L.Ano_de_Publicacao, A.Nome FROM Livro as L, Autor as A
WHERE A.Id = L.Autor_Id