SELECT D.Nome, MIN(F.Salario) as MenorSalario from Departamento As D INNER JOIN Funcionario as F ON  F.Departamento_Id =D.Id GROUP BY D.Nome
