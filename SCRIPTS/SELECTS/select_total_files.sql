-- RETORNA O TOTAL DE ARQUIVOS PERTENCENTES A UM USUARIO
SELECT COUNT(*) FROM ARQUIVO 
WHERE ID_USUARIO = @ID_USUARIO;