DELIMITER $$
CREATE TRIGGER registrar_create_file
AFTER INSERT ON ARQUIVO 
FOR EACH ROW
BEGIN 
	DECLARE file_id INT;
    DECLARE user_id INT;

    SET file_id = NEW.ID_ARQUIVO;
    SET user_id = NEW.ID_USUARIO;
    
	INSERT INTO OPERAR (TIPO_OPERACAO, ID_ARQUIVO, ID_USUARIO, DATA_OPERACAO)
    VALUES ('CREATE', file_id, user_id, CURDATE());
END $$
DELIMITER ;
