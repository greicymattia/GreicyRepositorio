SELECT D.Nome, SUM(F.Salario) as FolhaPag from Departamento As D INNER JOIN Funcionario as F ON  F.Departamento_Id =D.Id GROUP BY D.Nome
--8)	Liste o valor da folha de pagamento de cada departamento.
