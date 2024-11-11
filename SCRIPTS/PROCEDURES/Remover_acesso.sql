DELIMITER $$
CREATE PROCEDURE RemoveAcessoArquivo (IN arquivo_id INT)
BEGIN
    DECLARE dono_id INT;
    IF EXISTS (SELECT 1 FROM ARQUIVO WHERE ID_ARQUIVO = arquivo_id) THEN
        SELECT ID_DONO INTO dono_id FROM COMPARTILHAR WHERE ID_ARQUIVO = arquivo_id LIMIT 1;
        DELETE FROM COMPARTILHAR
        WHERE ID_ARQUIVO = arquivo_id
        AND ID_RECEPTOR <> dono_id;
    ELSE
        SIGNAL SQLSTATE '45000' SET MESSAGE_TEXT = 'Arquivo não encontrado';
    END IF;
END $$

DELIMITER ;
