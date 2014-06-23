--Faça um comando em SQL que retorne o nome do aluno, suma matricula e o curso que está fazendo... ordenado pela matricula
SELECT M.Id as Matricula, A.Nome as Aluno, C.Nome as Curso from TBCurso As C INNER JOIN TBMatricula as M ON  C.Id = M.Curso_Id INNER JOIN TBAluno As A ON M.Aluno_Id = A.Id ORDER BY M.Id ASC

