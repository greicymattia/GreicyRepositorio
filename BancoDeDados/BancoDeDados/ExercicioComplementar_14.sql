SELECT D. Nome, COUNT(*) as Quantidade from Funcionario As F INNER JOIN Departamento AS D ON F.Departamento_Id = D.Id GROUP BY D.Nome
--14)	 Liste a quantidade de funcionários de cada departamento. 