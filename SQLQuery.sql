CREATE TABLE [dbo].[Clientes] (
    [Cpf]     VARCHAR (11) NOT NULL,
    [Nome]    VARCHAR (50) NULL,
    [Email]   VARCHAR (50) NULL,
    [Celular] VARCHAR (11) NULL,
    PRIMARY KEY CLUSTERED ([Cpf] ASC)
);

CREATE TABLE [dbo].[Funcionarios] (
    [cpf]            VARCHAR (11)  NOT NULL,
    [nome]           VARCHAR (50)  NULL,
    [endereco]       VARCHAR (100) NULL,
    [dataNascimento] DATE          NULL,
    [celular]        VARCHAR (11)  NULL,
    [cep]            VARCHAR (8)   NULL,
    [cargo]          INT           NULL,
    [numero]         VARCHAR (10)  NULL,
    PRIMARY KEY CLUSTERED ([cpf] ASC)
);

CREATE TABLE [dbo].[Logins] (
    [usuario] VARCHAR (50) NOT NULL,
    [senha]   VARCHAR (50) NULL,
    [cpf]     VARCHAR (11) NULL,
    PRIMARY KEY CLUSTERED ([usuario] ASC),
    CONSTRAINT [FK_Logins_ToTable] FOREIGN KEY ([cpf]) REFERENCES [dbo].[Funcionarios] ([cpf])
);

CREATE TABLE [dbo].[Estoque]
(
	[CodProduto] INT NOT NULL IDENTITY(1,1)PRIMARY KEY , 
    [Descricao] VARCHAR(100) NOT NULL, 
    [Quantidade] INT NOT NULL, 
    [TipoProduto] VARCHAR(50) NULL
)
