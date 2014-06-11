SELECT sum(altura)FROM Aluno -- soma das alturas
SELECT sum(altura)FROM Aluno WHERE Aprovado = 0 -- soma das alturas dos alunos reprovados
SELECT COUNT(*) FROM Aluno -- conta o total de registro
SELECT MAX(Altura) FROM Aluno -- maior altura
SELECT MIN(altura) FROM Aluno -- menor altura
SELECT COUNT(*) as APROVADOS FROM Aluno WHERE Aprovado = 1 -- quantos aprovados
-- AS APROVADOS EH UM APELIDO QUE SE DA A RESPOSTA.... AO INVEZ DE FICAR (NO COLUMN NAME)
