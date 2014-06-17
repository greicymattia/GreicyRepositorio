SELECT F.PrimeiroNome, D.Nome  from Departamento As D INNER JOIN Funcionario as F ON  F.Departamento_Id =D.Id WHERE F.PrimeiroNome LIKE 'M%' ORDER BY D.Nome ASC
