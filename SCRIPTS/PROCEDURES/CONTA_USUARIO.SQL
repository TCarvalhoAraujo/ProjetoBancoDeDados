DELIMITER $$
CREATE PROCEDURE CONTA_USUARIO (IN ID_ARQ INT)
BEGIN
    DECLARE total INT;

    -- Verifica se o arquivo existe na tabela ARQUIVO
    SELECT COUNT(*) INTO total 
    FROM ARQUIVO 
    WHERE ID_ARQUIVO = ID_ARQ;

    IF total = 0 THEN
        SIGNAL SQLSTATE '45000' 
        SET MESSAGE_TEXT = 'Arquivo não encontrado';
    ELSE
        -- Retorna o número de usuários (dono + receptores)
        SELECT 
            ID_ARQ AS id_do_arquivo,
            COUNT(DISTINCT usuario_id) AS numero_de_usuarios
        FROM (
            -- Dono do arquivo
            SELECT ID_USUARIO AS usuario_id, ID_ARQUIVO AS ID_ARQ
            FROM ARQUIVO
            WHERE ID_ARQUIVO = ID_ARQ
            
            UNION ALL
            
            -- Receptores do compartilhamento
            SELECT ID_RECEPTOR AS usuario_id, ID_ARQUIVO AS ID_ARQ
            FROM COMPARTILHAR
            WHERE ID_ARQUIVO = ID_ARQ
        ) AS usuarios;
    END IF;
END $$
DELIMITER ;
