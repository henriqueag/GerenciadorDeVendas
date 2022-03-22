SET IDENTITY_INSERT Categorias ON
INSERT INTO Categorias(CategoriaId, Nome) VALUES (1, 'DOCES/PASTAS' )
INSERT INTO Categorias(CategoriaId, Nome) VALUES (2, 'SUPLEMENTO CAPSULA' )
INSERT INTO Categorias(CategoriaId, Nome) VALUES (3, 'SUPLEMENTO EM PÓ' )
INSERT INTO Categorias(CategoriaId, Nome) VALUES (4, 'OUTROS ALIMENTOS' )
SET IDENTITY_INSERT Categorias OFF

SET IDENTITY_INSERT Enderecos ON
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (1, '38400-670', 'Rua José Rezende dos Santos', 'Brasil', 'Uberlândia', 'MG', 759)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (2, '38421-046', 'Rua do Sai-Azul', 'Loteamento Residencial Pequis', 'Uberlândia', 'MG', 356)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (3, '38421-643', 'Rua Odécio dos Santos', 'Residencial Lago Azul', 'Uberlândia', 'MG', 358)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (4, '38433-018', 'Rua Quatro', 'Vila Marielza', 'Uberlândia', 'MG', 999)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (5, '38400-708', 'Avenida Afonso Pena', 'Nossa Senhora Aparecida', 'Uberlândia', 'MG', 657)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (6, '38400-329', 'Avenida Getúlio Vargas', 'Daniel Fonseca', 'Uberlândia', 'MG', 60)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (7, '32240-351', 'Beco Caramuru', 'Bandeirantes', 'Contagem', 'MG', 253)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (8, '35302-660', 'Rua Marcelo Moreira Rezende de Araújo', 'Rafael José de Lima', 'Caratinga', 'MG', 272)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (9, '38071-306', 'Avenida Doutor Milton Campos', 'Vila Arquelau', 'Uberaba', 'MG', 918)
INSERT INTO Enderecos (EnderecoId, Cep, Logradouro, Bairro, Cidade, Uf, Numero) VALUES (10, '31540-474', 'Beco B', 'Jardim Leblon', 'Belo Horizonte', 'MG', 654)
SET IDENTITY_INSERT Enderecos OFF

SET IDENTITY_INSERT Fornecedores ON
INSERT INTO Fornecedores(FornecedorId, Nome, CNPJ, EnderecoId) VALUES (1, 'APIARIOS MACKILANI LTDA', '10.340.623/0001-67', 7)
INSERT INTO Fornecedores(FornecedorId, Nome, CNPJ, EnderecoId) VALUES (2, 'SOARES E TECLES COM. REP. LTDA', '67.653.454/0001-32', 8)
INSERT INTO Fornecedores(FornecedorId, Nome, CNPJ, EnderecoId) VALUES (3, 'DISTRIBUIDORA MINEIRA DE DOCES LTDA', '60.888.582/0001-16', 9)
INSERT INTO Fornecedores(FornecedorId, Nome, CNPJ, EnderecoId) VALUES (4, 'KAZJEL COM.REP.LTDA', '52.357.810/0001-01', 10)
SET IDENTITY_INSERT Fornecedores OFF

SET IDENTITY_INSERT Solicitantes ON
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(1, 'Leandro Nelson Carlos da Costa', '542.737.276-84', '(34) 99845-8473', 'leandronelsoncarlosdacosta@mail.com', 1)
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(2, 'Rosa Yasmin Daiane', '026.626.186-80', '(34) 98715-9676', 'rosayasmindaiane@outlook.com', 2)
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(3, 'Nina Jennifer Isabel', '683.112.266-36', '(34) 99813-3514', 'ninajenniferisabel@outlook.com', 3)
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(4, 'Thomas Yago da Mota', '741.781.786-60', '(34) 98736-9088', 'thomasyagodamota@yahoo.com', 4)
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(5, 'Danilo Severino Nathan Ribeiro', '516.413.856-50', '(34) 99779-7817', 'daniloseverinonathanribeiro@gmail.com', 5)
INSERT INTO Solicitantes(SolicitanteId, Nome, CPF, Telefone, Email, EnderecoId) VALUES(6, 'Calebe Anderson Peixoto', '846.236.776-05', '(34) 99889-9582', 'calebeandersonpeixoto@hotmail.com', 6)
SET IDENTITY_INSERT Solicitantes OFF

SET IDENTITY_INSERT Produtos ON
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(1, '0000000000001', 'ABSOLUT PASTA AMENDOIM BEIJINHO 1KG', 19.948005, 44.3289, 9, 'UN', 1, '2022-03-01', '2022-03-01', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(2, '0000000000002', 'ABSOLUT PASTA AMENDOIM BEIJINHO 500G', 14.948505, 33.2189, 8, 'UN', 1, '2022-03-01', '2022-03-01', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(3, '0000000000003', 'ABSOLUT PASTA AMENDOIM BROWNIE 1KG', 19.948005, 44.3289, 7, 'UN', 1, '2022-03-01', '2022-03-01', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(4, '0000000000004', 'ABSOLUT PASTA AMENDOIM BROWNIE 500G', 14.948505, 33.2189, 4, 'UN', 1, '2022-03-01', '2022-03-01', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(5, '0000000000005', 'ACAI BANANA ECO FLASH 200G', 3.8746125, 8.61025, 5, 'UN', 1, '2022-03-01', '2022-03-01', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(6, '0000000000006', 'ACAI DESIDRATADO TIARAJU 150G', 12.448755, 27.6639, 6, 'UN', 1, '2022-03-02', '2022-03-02', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(7, '0000000000007', 'ACAI ECO FLESH GUARANA 1000G', 12.948705, 28.7749, 4, 'UN', 1, '2022-03-02', '2022-03-02', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(8, '0000000000008', 'ADOCANTE ABSOLUT 100% ESTEVIA 150G', 17.448255, 38.7739, 5, 'UN', 1, '2022-03-03', '2022-03-03', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(9, '0000000000009', 'ADOCANTE ABSOLUT 100% XYLITOL 300G', 19.948005, 44.3289, 8, 'UN', 1, '2022-03-03', '2022-03-03', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(10, '0000000000010', 'ADOCANTE AIROM TAUMATINA 100 ML', 8.19918, 18.2204, 9, 'UN', 1, '2022-03-04', '2022-03-04', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(11, '0000000000011', 'ALBUMINA MILLENNIUM BAUNILHA 500G', 26.947305, 59.8829, 6, 'UN', 1, '2022-03-04', '2022-03-04', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(12, '0000000000012', 'ALBUMINA MILLENNIUM CHOCOLATE 500G', 26.947305, 59.8829, 8, 'UN', 1, '2022-03-04', '2022-03-04', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(13, '0000000000013', 'ALBUMINA MILLENNIUM MOR.BANANA.500G', 26.947305, 59.8829, 5, 'UN', 1, '2022-03-05', '2022-03-05', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(14, '0000000000014', 'BANANINHA HUE 117G', 5.749425, 12.7765, 5, 'UN', 1, '2022-03-06', '2022-03-06', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(15, '0000000000015', 'BANANINHA NUTRYLLACK 28G', 6.449355, 14.3319, 7, 'UN', 1, '2022-03-06', '2022-03-06', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(16, '0000000000016', 'BANANINHA PASSA TIPIKUS 1 KG', 13.948605, 30.9969, 4, 'UN', 1, '2022-03-08', '2022-03-08', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(17, '0000000000017', 'BCAA PLUS PROBIOTICA 120 CAP', 51.944805, 115.4329, 9, 'UN', 1, '2022-03-09', '2022-03-09', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(18, '0000000000018', 'BCAA PRO PROBIOTICA 120 CAP', 37.8212175, 84.04715, 5, 'UN', 1, '2022-03-09', '2022-03-09', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(19, '0000000000019', 'BCAA PRO PROBIOTICA 60 CAPS', 17.448255, 38.7739, 3, 'UN', 1, '2022-03-09', '2022-03-09', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(20, '0000000000020', 'BCAA PROBIOTICA BLACK NATURAL 300G', 87.49125, 194.425, 8, 'UN', 1, '2022-03-09', '2022-03-09', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(21, '0000000000021', 'CREATINA INTEGRAL 100G', 18.49815, 41.107, 9, 'UN', 1, '2022-03-10', '2022-03-10', 2)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(22, '0000000000022', 'CREATINA INTEGRAL 120 CAPS', 32.446755, 72.1039, 9, 'UN', 1, '2022-03-10', '2022-03-10', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(23, '0000000000023', 'CREATINA INTEGRAL 120 CPS', 41.745825, 92.7685, 3, 'UN', 1, '2022-03-11', '2022-03-11', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(24, '0000000000024', 'CRISTAIS GENGIBRE ARDRAK ANIS 22G', 5.6744325, 12.60985, 5, 'UN', 1, '2022-03-12', '2022-03-12', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(25, '0000000000025', 'CRISTAIS GENGIBRE ARDRAK CANELA 22G', 5.6744325, 12.60985, 5, 'UN', 1, '2022-03-13', '2022-03-13', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(26, '0000000000026', 'CRISTAIS GENGIBRE ARDRAK FRU.CITRICAS 22G', 5.6744325, 12.60985, 7, 'UN', 1, '2022-03-14', '2022-03-14', 4)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(27, '0000000000027', 'ISO 100 WHEY DYMATIZE BAUNILHA 726G', 172.48275, 383.295, 7, 'UN', 1, '2022-03-14', '2022-03-14', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(28, '0000000000028', 'ISO 100 WHEY DYMATIZE BOLO ANIVERSARIO 726G', 172.48275, 383.295, 7, 'UN', 1, '2022-03-14', '2022-03-14', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(29, '0000000000029', 'ISO 100 WHEY DYMATIZE BROWNIE 893G', 179.48205, 398.849, 4, 'UN', 1, '2022-03-15', '2022-03-15', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(30, '0000000000030', 'ISO 100 WHEY DYMATIZE CAKE 893G', 179.48205, 398.849, 3, 'UN', 1, '2022-03-16', '2022-03-16', 3)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(31, '0000000000031', 'LEITE CONDENSADO S.LOURENCO 210G', 7.449255, 16.5539, 3, 'UN', 1, '2022-03-17', '2022-03-17', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(32, '0000000000032', 'LEITE CONDENSADO S.LOURENCO 335G', 11.9988, 26.664, 5, 'UN', 1, '2022-03-18', '2022-03-18', 1)
INSERT INTO Produtos(ProdutoId,CodBarras,Descricao,PrecoCusto,PrecoVenda,Estoque,UniMedida,Ativo,DataCadastro,UltimaAlteracao,CategoriaId) VALUES(33, '0000000000033', 'LEITE CONDENSADO S.LOURENCO S/LACT 380G', 5.29947, 11.7766, 6, 'UN', 1, '2022-03-19', '2022-03-19', 1)
SET IDENTITY_INSERT Produtos OFF