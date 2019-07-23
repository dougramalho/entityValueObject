USE [BD_REFACTORING]
GO

/****** Object:  Table [dbo].[TB_PESSOA]    Script Date: 23/07/2019 20:24:35 ******/
SET ANSI_NULLS ON
GO

SET QUOTED_IDENTIFIER ON
GO

CREATE TABLE [dbo].[TB_PESSOA](
	[PessoaId_Value] [uniqueidentifier] NOT NULL,
	[Nome] [varchar](100) NOT NULL,
	[Cpf_Value] [varchar](11) NOT NULL,
	[DadosComplementares_Rg] [varchar](20) NOT NULL,
	[DadosComplementares_DataNascimento] [datetime] NOT NULL,
	[DadosComplementares_NomeMae] [varchar](100) NOT NULL,
	[DadosComplementares_Endereco_Logradouro] [varchar](150) NOT NULL,
	[DadosComplementares_Endereco_EstadoLogradouro] [varchar](20) NOT NULL,
	[DadosComplementares_Endereco_CidadeLogradouro] [varchar](50) NOT NULL,
	[DadosComplementares_Contato_Telefones] [varchar](300) NOT NULL,
	[DadosComplementares_Contato_Email] [varchar](150) NOT NULL,
 CONSTRAINT [PK_TB_PESSOA] PRIMARY KEY CLUSTERED 
(
	[PessoaId_Value] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]
) ON [PRIMARY]
GO


