SELECT U.ID_USUARIO, U.LOGIN, U.EMAIL, U.SENHA, U.DATA_INGRESSO, I.NOME, I.ID_INSTITUICAO
FROM USUARIO U
INNER JOIN INSTITUICAO I ON U.ID_INSTITUICAO = I.ID_INSTITUICAO
WHERE U.EMAIL = @EMAIL AND U.SENHA = @SENHA;