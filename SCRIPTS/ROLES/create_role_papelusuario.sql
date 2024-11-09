
CREATE ROLE PapelUsuario;


GRANT SELECT, INSERT, UPDATE ON tabela_arquivos TO PapelUsuario;


ALTER TABLE tabela_arquivos ENABLE ROW LEVEL SECURITY;


CREATE POLICY acesso_arquivos_usuario ON tabela_arquivos
    USING (usuario_id = current_user);
