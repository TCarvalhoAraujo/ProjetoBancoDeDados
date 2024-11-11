-- CRIA TABELA 'COMPARTILHAR'
CREATE TABLE COMPARTILHAR (
    ID_COMPARTILHAMENTO INT AUTO_INCREMENT,
    ID_DONO INT,
    ID_RECEPTOR INT,
    ID_ARQUIVO INT,
    DATA_COMPARTILHAMENTO DATETIME NOT NULL,
    PRIMARY KEY(ID_COMPARTILHAMENTO),
    FOREIGN KEY (ID_DONO) REFERENCES USUARIO(ID_USUARIO),
    FOREIGN KEY (ID_RECEPTOR) REFERENCES USUARIO(ID_USUARIO),
    FOREIGN KEY (ID_ARQUIVO) REFERENCES ARQUIVO(ID_ARQUIVO) ON DELETE CASCADE
);