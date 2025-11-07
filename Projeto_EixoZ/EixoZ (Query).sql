-- Database para a empresa de produtos produzidos com modelagem 3D
/*
-- Ideia do projeto(Sequência planejada para a ultilização do app)
-- Criação de conta pelo usuario(ou no caso usuario se refere ao colaborador em contato com o cliente), pois não será possível comprar sem ele 
-- Criação de um pedido (para tal será necessário um fornecedor, produto e cliente )
-- essa etapa irá criar em itens pedido diversos 
-- Estamos sem estoque de produtos e materiais (penso que devemos ter pelo menos de máteriais ) 
-- telas: a pagina inicial, usuarios, produtos, pedidos e rastrear pedidos
        Pagina inicial: Possiblita acesso as outras paginas 
		Produtos: Mostra os produtos e possibilita ver suas informações(possívelmente cadastra-los)
		Pedidos: Mostra todos os pedidos 
		Rastrear pedidos:Rastreia o pedido ?

		CONTROLLERS, MODELS, PAGS DE CADASTROS + CODS, FORMS ("CLIENTE, VENDEDOR, PEDIDOS, "PRODUTOS -- > MATERIAIS", TRANSPORTADORA")

		PEDRO: FAZER AS PÁGINAS DE CADASTROS "CLIENTES, VENDEDOR" + FAZER OS FORMS: "TODOS FALTANTES"
		HENRIQUE: FAZER AS PÁGINAS DE CADASTROS "PEDIDOS, MATERIAIS, TRANSPORTADORA"
		DOUGLAS: FAZER: "CONTROLLERS, MODELS"
		JON: FAZER AS PÁGINAS DE VISUALIZAÇÕES: "UMA PG DE VIEW COM FILTRO DE VISUALIZAÇÃO PARA AS TABELAS"

*/

CREATE DATABASE EixoZ;
GO
USE EixoZ;
GO
-- Cadastro da conta dos Clientes 
CREATE TABLE CLIENTE(
    --id do cliente 
	IdCliente int identity(1,1) primary key,
	--Nome do mesmo
	Nome Nvarchar(255) not null,
	-- Idade do mesmo 
	Idade int not null,
	-- email do cliente 
	Email Nvarchar(255) not null UNIQUE,
	-- Senha do mesmo 
	Senha Nvarchar(255) not null,
	-- Endereço do mesmo 
	Endereco Nvarchar(255) not null
);

CREATE TABLE VENDEDOR(
	--id do vendedor 
	IdVendedor int identity(1,1) primary key,
	--Nome do mesmo
	Nome Nvarchar(255) not null,
	-- Idade do mesmo 
	Idade int not null,
	-- email do vendedor 
	Email Nvarchar(255) not null UNIQUE,
	-- Senha do mesmo 
	Senha Nvarchar(255) not null,
	-- Endereço do mesmo 
	Endereco Nvarchar(255) not null
);

CREATE TABLE PEDIDOS(
    --id do pedido 
	IdPedido int IDENTITY(1,1) PRIMARY KEY,
	--id do cliente que realizou o pedido 
    IdCliente int references CLIENTE(IdCliente),
    -- id da transportadora que o entregará  
	IdTransportadora int references TRANSPORTADORA(IdTransportadora),
	-- id do vendedor que realizou a venda
	IdVendedor int references VENDEDOR(IdVendedor) null,
	-- endereço da entrega 
    EnderecoEntrega Nvarchar(255) NOT NULL,
	--data em que o pedido foi feito 
    DataPedido DATETIME DEFAULT GETDATE(),
    -- Qual o status do pedido 
    StatusPedido NVARCHAR(50) NOT NULL DEFAULT 'Aguardando Pagamento',
    --Observação (por que not null? ) 
	Observacao Nvarchar(255) not null,
);

--Fornecedor de materias para confecção dos produtos
CREATE TABLE MATERIAL(
    --id fornecedor 
	IdMaterial int identity(1,1) primary key,
	-- Qual a materia prima que ele fornece(Somente uma por forcedor ou multiplas contas de fornecedores para varios máteriais ? )
	MateriaPrima Nvarchar(255) not null,
	--Nome da empresa pertencente ao fornedor ou melhor dizendo nome da empresa fornecedora 
	NomeFornecedor Nvarchar(255) not null,
	-- peso da máteria prima inclusa no pedido comprado por nós
	PesoProduto Decimal(4,2) not null,
	--Tipo da máteria prima ou descrição da mesma 
	Tipo Nvarchar(50) not null,
	--Marca da máteria prima comprada
	Marca Nvarchar(50) not null
);

--Empresa que realizará o tranporte das mercadorias 
CREATE TABLE TRANSPORTADORA(
    -- id da transportadora 
	IdTransportadora int identity(1,1) primary key,
	--Nome da empresa pertencente ao Transportador ou melhor dizendo nome da empresa transportadora  
	NomeFantasia Nvarchar(255) not null,
	--Meio pelo qual a empresa costuma fazer o transporte 
	MeioDeTransporte Nvarchar(255) not null,
	-- preço pelo qual somos cobrados em média pelas transportadoras 
	PrecoMedio Decimal(10,2) not null,
	--observações 
	Observacao Nvarchar(255) 
);
-- Onde serão armazenados os Pedidos 

-- Solução para multiplos produtos em um unico PEDIDO, relação N para N de PRODUTOS com PEDIDOS 
CREATE TABLE ITENS_PEDIDOS(
   --id do itens pedido 
    IdItemPedido INT IDENTITY(1,1) PRIMARY KEY,
	--id do pedido o qual os itens pertencem 
    IdPedido INT references PEDIDOS(IdPedido),
	--id do produto 
    IdMaterial INT references MATERIAL(IdMaterial),
	-- quantidade do produto 
    Quantidade INT NOT NULL,
	--Preço unitário utilizado para a venda ou preço final 
    PrecoUnitarioVenda DECIMAL(10,2) ,
);
GO
