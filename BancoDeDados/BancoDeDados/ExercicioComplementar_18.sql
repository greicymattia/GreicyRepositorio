SELECT D.Nome as Departamento, F.PrimeiroNome as Nome from Departamento As D INNER JOIN Funcionario as F ON  F.Departamento_Id =D.Id ORDER BY D.Nome, F.PrimeiroNome ASC
