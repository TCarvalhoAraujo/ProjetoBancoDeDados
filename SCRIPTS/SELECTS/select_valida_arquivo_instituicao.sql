-- VERIFICA SE EXISTE UM ARQUIVO COM O NOME = @NOME, E SE ELE PERTENCE A UMA INSTITUICAO
-- USADO PARA ABRIR ARQUIVOS DE UMA INSTITUICAO E ADICIONAR COMENTARIOS EM UM ARQUIVO
SELECT COUNT(*) FROM ARQUIVO A 
JOIN USUARIO U ON U.ID_USUARIO = A.ID_USUARIO 
JOIN INSTITUICAO I ON I.ID_INSTITUICAO = U.ID_INSTITUICAO 
WHERE A.NOME = @NOME;