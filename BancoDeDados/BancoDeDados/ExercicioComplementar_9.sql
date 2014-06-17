SELECT F.PrimeiroNome, F.Sobrenome, F.Salario, F.Funcao, D.Nome FROM Funcionario as F INNER JOIN Departamento as D ON F.Departamento_Id=D.Id where Departamento_Id != 0
