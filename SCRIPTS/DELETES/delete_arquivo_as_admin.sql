-- DELETA UM ARQUIVO COMO UM ADMINISTRADOR
DELETE FROM ARQUIVO A
WHERE A.ID_ARQUIVO = @ID_ARQUIVO 
AND EXISTS 
        (SELECT 1 FROM ADMINISTRADOR WHERE 
         SENHA = @SENHA AND 
         ID_ADMIN = @ID_ADMIN);