-- RETORNA O TOTAL DE INTEGRANTES DE UMA INSTITUICAO
SELECT COUNT(*) FROM USUARIO 
WHERE ID_INSTITUICAO = @ID_INSTITUICAO;