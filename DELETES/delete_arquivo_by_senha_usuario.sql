DELETE ARQUIVO 
FROM ARQUIVO 
JOIN USUARIO ON ARQUIVO.ID_USUARIO = USUARIO.ID_USUARIO 
WHERE ARQUIVO.ID_ARQUIVO = @ID_ARQUIVO 
AND USUARIO.SENHA = @SENHA 
AND USUARIO.ID_USUARIO = @ID_USUARIO;