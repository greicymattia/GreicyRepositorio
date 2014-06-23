--NAO INTENDI DIREITO OQ ERA PRA FAZER NESSE EXERCICIO 10
SELECT C.Nome as Curso, COUNT(*) AS Total_Matriculados from TBCurso As C INNER JOIN TBMatricula as M ON  C.Id = M.Curso_Id INNER JOIN TBAluno As A ON M.Aluno_Id = A.Id GROUP BY C.Nome
