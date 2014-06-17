SELECT F.PrimeiroNome, F.Funcao, D.Nome  from Departamento As D INNER JOIN Funcionario as F ON  F.Departamento_Id =D.Id ORDER BY F.PrimeiroNome ASC
--inner join, lefth join, full, join, rigth join