-- RETORNA O TOTAL DE ARQUIVOS COMPARTILHADOS POR UM USUARIO
SELECT COUNT(*) FROM COMPARTILHAR 
WHERE ID_DONO = @ID_USUARIO;