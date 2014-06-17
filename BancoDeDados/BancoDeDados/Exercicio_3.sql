SELECT*FROM Aluno WHERE Altura = 1.60 -- Procura na tabela os alunos que tenha altura igual a 1.60
SELECT*FROM Aluno WHERE NOT Altura = 1.60 --Procura na tabela os alunos que não tenha altura igual a 1.60
SELECT*FROM Aluno WHERE Altura !=1.75 -- Procura na tabela os alunos que tem a altura diferente de 1.75
SELECT*FROM Aluno WHERE Altura >=1.70 -- Procura na tabela os alunos que tenha a altura maior ou igual a 1.70
SELECT*FROM Aluno WHERE Altura <=1.65 -- Procura na tabela os alunos que tenha a altura menor ou igual a 1.65
SELECT*FROM Aluno WHERE Altura > 1.75 -- Procura na tabela os alunos que tenha a altura maior que 1.75
SELECT*FROM Aluno WHERE Altura < 1.69 -- Procura na tabela os alunos que tenham a altura menor que 1.69
SELECT*FROM Aluno WHERE Aprovado = 0 -- Procura os alunos que estejam reprovados (0)
SELECT*FROM Aluno WHERE Aprovado = 1 -- Procura os alunos que estejam aprovador (1)
SELECT*FROM Aluno WHERE Nome IS NULL -- Procura os alunos que estejam com os nomes NULOS
SELECT*FROM Aluno WHERE Nome is NOT NULL -- Procura os alunos que não estão com o nome NULO
SELECT*FROM Aluno WHERE Email is NULL -- Procura os alunos que estão com o email nulo
SELECT*FROM Aluno WHERE Email is NOT NULL -- Procura os alunos que não estão com o email NULO
SELECT*FROM Aluno WHERE Telefone is NULL -- Procura os alunos que estão com o telefone NULO
SELECT*FROM Aluno WHERE Telefone is NOT NULL -- Procura os alunos que não estão com o telefone NULO
SELECT*FROM Aluno WHERE Altura BETWEEN 1.6 AND 1.8 -- Procura os alunos que tem altura entre 1.60 e 1.80
SELECT*FROM Aluno WHERE Altura NOT BETWEEN 1.7 AND 1.75 -- Procura os alunos que não tem a altura entre 1.70 e 1.75
SELECT*FROM Aluno WHERE Nome LIKE 'Greicy' --Procura o aluno com o nome Greicy
SELECT*FROM Aluno WHERE Nome LIKE 'Joao' -- Procura o aluno com o nome Joao
SELECT*FROM Aluno WHERE Nome LIKE 'Mateus$' -- Procura o aluno com o nome Mateus$
SELECT*FROM Aluno WHERE Nome NOT LIKE 'Camila' -- Procura os alunos com o nome diferente de Camila
SELECT*FROM Aluno WHERE Nome NOT LIKE 'Lucas#' --Procura os alunos com o nome diferente de Lucas#
SELECT*FROM Aluno WHERE Altura IN (1.69, 1.64, 1,70) --Procura os alunos que tenham as alturas 1.69, 1.64, 1.70
SELECT*FROM Aluno WHERE Altura NOT IN (1.69, 1.64, 1,70) -- Procura os alunos que nao tenham as alturas 1.69, 1.64, 1.70
SELECT*FROM Aluno WHERE Nome IN ('Maria', 'Carlos') -- Procura os Alunos com o nome Maria e Carlos
SELECT*FROM Aluno WHERE Nome NOT IN ('Lucas', 'Mateus') -- Procura os Alunos com o nome diferente de Lucas e Mateus
SELECT*FROM Aluno WHERE Email LIKE '@' -- Procura um email @
SELECT*FROM Aluno WHERE Email LIKE 'mateus.martino@gamil.com' -- Procura um e-mail mateus.martino@gmail.com
SELECT*FROM Aluno WHERE Email NOT LIKE 'mateus.martino@gmail.com'-- Procura um email diferente de mateus.martino@gmail.com
SELECT*FROM Aluno WHERE Altura = 1.69 AND Nome LIKE 'Greicy' --Procura o aluno	que tenha 1.69 E o nome de Greicy
SELECT*FROM Aluno WHERE Altura >= 1.69 AND Nome NOT LIKE 'Greicy' -- Procura o aluno que tenha a altura maior ou igual a 1.69 e o nome diferente de Greicy
SELECT*FROM Aluno WHERE Altura = 1.69 AND Nome LIKE 'Greicy' --Procura o aluno	que tenha 1.69 OU o nome de Greicy
SELECT*FROM Aluno WHERE Altura >= 1.69 AND Nome NOT LIKE 'Greicy' -- Procura o aluno que tenha a altura maior ou igual a 1.69 OU nome diferente de Greicy

