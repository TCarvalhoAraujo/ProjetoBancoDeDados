UPDATE ARQUIVO SET 
NOME = @NOME, TIPO = @TIPO, PERMISSAO_ACESSO = @PERMISSAO, TAMANHO = @TAMANHO, DATA_MODIFICACAO = @DATA_MODIFICACAO, 
LOCALIZACAO = @LOCALIZACAO, URL = @URL, CONTEUDO = @CONTEUDO 
WHERE ID_ARQUIVO = @ID_ARQUIVO;