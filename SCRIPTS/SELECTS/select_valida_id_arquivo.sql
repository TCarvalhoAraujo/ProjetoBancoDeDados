-- VERIFICA SE UM USUARIO POSSUI UM ARQUIVO COM ID_ARQUIVO = @ID_ARQUIVO
-- USADO PARA PEDIR SUPORTE SOBRE UM ARQUIVO
-- USADO PARA COMPARTILHAR UM ARQUIVO
SELECT COUNT(*) FROM ARQUIVO 
WHERE ID_USUARIO = @ID_USUARIO AND 
ID_ARQUIVO = @ID_ARQUIVO;