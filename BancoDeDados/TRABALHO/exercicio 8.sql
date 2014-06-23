SELECT A.Nome from TBCurso As C INNER JOIN TBMatricula as M ON  C.Id = M.Curso_Id INNER JOIN TBAluno As A ON M.Aluno_Id = A.Id WHERE C.Nome like 'Medicina' and A.Sexo like 'F'

