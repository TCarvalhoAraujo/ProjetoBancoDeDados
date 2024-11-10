DELIMITER $$

CREATE TRIGGER safe_security
BEFORE INSERT ON ARQUIVO
FOR EACH ROW
BEGIN
    IF LOWER(NEW.TIPO) = 'exe' 
        OR LOWER(NEW.TIPO) = 'bat'
        OR LOWER(NEW.TIPO) = 'sh'
        OR LOWER(NEW.TIPO) = 'com'
        OR LOWER(NEW.TIPO) = 'cmd' THEN
        SIGNAL SQLSTATE '45000'
        SET MESSAGE_TEXT = 'Arquivos executáveis não são permitidos.';
    END IF;
END $$

DELIMITER ;
