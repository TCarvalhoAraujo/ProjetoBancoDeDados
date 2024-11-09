
CREATE ROLE PapelEmpresa;


GRANT SELECT ON tabela_usuarios TO PapelEmpresa;
GRANT SELECT ON tabela_arquivos TO PapelEmpresa;


ALTER TABLE tabela_arquivos ENABLE ROW LEVEL SECURITY;


CREATE POLICY acesso_arquivos_empresa ON tabela_arquivos
    USING (empresa_id = current_user_empresa);
