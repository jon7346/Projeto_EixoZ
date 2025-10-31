CREATE DATABASE EixoZ;
GO
USE EixoZ;
GO

CREATE TABLE CLIENTE(
	IdCliente int identity(1,1) primary key,
	Nome Nvarchar(255) not null,
	Idade int not null,
	Email Nvarchar(255) not null UNIQUE, 
	Senha Nvarchar(255) not null,
	Endereco Nvarchar(255) not null
);

CREATE TABLE PRODUTO(
	IdProduto int identity(1,1) primary key,
	NomeProduto Nvarchar(255) not null,
	Material Nvarchar(50) not null,
	Peso decimal(10,2) not null,
	Tamanho decimal(10,2) not null,
	Preco Decimal(10,2) not null
);

CREATE TABLE FORNECEDOR(
	IdFornecedor int identity(1,1) primary key,
	MateriaPrima Nvarchar(255) not null,
	NomeFantasia Nvarchar(255) not null,
	PesoProduto Decimal(4,2) not null,
	Tipo Nvarchar(50) not null,
	Marca Nvarchar(50) not null
);

CREATE TABLE TRANSPORTADORA(
	IdTransportadora int identity(1,1) primary key,
	NomeFantasia Nvarchar(255) not null,
	MeioDeTransporte Nvarchar(255) not null,
	PrecoMedio Decimal(10,2) not null,
	Observacao Nvarchar(255) 
);

CREATE TABLE PEDIDOS(
	IdPedido int IDENTITY(1,1) PRIMARY KEY,
    IdCliente int NOT NULL,
	IdTransportadora int not null,
    EnderecoEntrega Nvarchar(255) NOT NULL,
    DataPedido DATETIME DEFAULT GETDATE(),
    StatusPedido NVARCHAR(50) NOT NULL DEFAULT 'Aguardando Pagamento',
	Observacao Nvarchar(255) not null,
	FOREIGN KEY (IdCliente) REFERENCES CLIENTE(IdCliente),
	FOREIGN KEY (IdTransportadora) REFERENCES TRANSPORTADORA(IdTransportadora)
);

CREATE TABLE ITENS_PEDIDOS(
    IdItemPedido INT IDENTITY(1,1) PRIMARY KEY,
    IdPedido INT NOT NULL,
    IdProduto INT NOT NULL,
    Quantidade INT NOT NULL,
    PrecoUnitarioVenda DECIMAL(10,2) ,
    FOREIGN KEY (IdPedido) REFERENCES PEDIDOS(IdPedido),
    FOREIGN KEY (IdProduto) REFERENCES PRODUTO(IdProduto)
);
GO
