IF OBJECT_ID(N'[__EFMigrationsHistory]') IS NULL
BEGIN
    CREATE TABLE [__EFMigrationsHistory] (
        [MigrationId] nvarchar(150) NOT NULL,
        [ProductVersion] nvarchar(32) NOT NULL,
        CONSTRAINT [PK___EFMigrationsHistory] PRIMARY KEY ([MigrationId])
    );
END;

GO

CREATE TABLE [Responsavel] (
    [ID] uniqueidentifier NOT NULL,
    [codResponsavel] int NOT NULL,
    [Nome] nvarchar(max) NULL,
    CONSTRAINT [PK_Responsavel] PRIMARY KEY ([ID])
);

GO

CREATE TABLE [Acampante] (
    [ID] uniqueidentifier NOT NULL,
    [codPessoa] int NOT NULL,
    [codAcampante] nvarchar(max) NULL,
    [ResponsavelID] uniqueidentifier NULL,
    [codPacote] int NULL,
    [Nome] nvarchar(max) NULL,
    [FichaRespondida] bit NOT NULL,
    CONSTRAINT [PK_Acampante] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Acampante_Responsavel_ResponsavelID] FOREIGN KEY ([ResponsavelID]) REFERENCES [Responsavel] ([ID]) ON DELETE NO ACTION
);

GO

CREATE TABLE [Ficha] (
    [ID] uniqueidentifier NOT NULL,
    [ResponsavelID] uniqueidentifier NULL,
    [AcampanteID] uniqueidentifier NULL,
    [Peso] float NOT NULL,
    [Altura] float NOT NULL,
    [Tip_Sanguineo] nvarchar(max) NULL,
    [Convenio] nvarchar(max) NULL,
    [Nome_Pediatra_Contato] nvarchar(max) NULL,
    [Nadar] bit NOT NULL,
    [Boia] bit NOT NULL,
    [Acomp_Psicologico] bit NOT NULL,
    [Motivo_Acomp_Psicologico] nvarchar(max) NULL,
    [Vacinas_Validas] bit NOT NULL,
    [Alopatia] bit NOT NULL,
    [Homeopatia] bit NOT NULL,
    [H1N1] bit NOT NULL,
    [Dat_H1N1] datetime2 NOT NULL,
    [MenigiteC] bit NOT NULL,
    [Covid] bit NOT NULL,
    [Dat_Covid] datetime2 NOT NULL,
    [Dat_MenigiteC] datetime2 NOT NULL,
    [BelicheInferior] bit NOT NULL,
    [Aparelho_Dental] bit NOT NULL,
    [Dramin] bit NOT NULL,
    [Vonal] bit NOT NULL,
    [Orientacao_Febre] nvarchar(max) NULL,
    [Orientacao_Barriga] nvarchar(max) NULL,
    [Orientacao_Cabeca] nvarchar(max) NULL,
    [Orientacao_Ouvido] nvarchar(max) NULL,
    [Orientacao_Colica] nvarchar(max) NULL,
    [Orientacao_Garganta] nvarchar(max) NULL,
    [Diabetes] bit NOT NULL,
    [Tratamento_Diabetes] nvarchar(max) NULL,
    [Convulsao] bit NOT NULL,
    [Tratamento_Convulsao] nvarchar(max) NULL,
    [Asma] bit NOT NULL,
    [Tratamento_Asma] nvarchar(max) NULL,
    [Bronquite] bit NOT NULL,
    [Tratamento_Bronquite] nvarchar(max) NULL,
    [Infeccao_Recente] bit NOT NULL,
    [Enurese_Noturna] bit NOT NULL,
    [Sonambulismo] bit NOT NULL,
    [RestricaoAttFisica] bit NOT NULL,
    [Obs_RestricaoAttFisica] nvarchar(max) NULL,
    [Alergia_Medicamento] nvarchar(max) NOT NULL,
    [Obs_Alergia_Medicamento] nvarchar(max) NULL,
    [Necessidade_Especial] nvarchar(max) NOT NULL,
    [Obs_Necessidade_Especial] nvarchar(max) NULL,
    [Restricao_Alimentar] bit NOT NULL,
    [Obs_Restricao_Alimentar] nvarchar(max) NULL,
    [Medo_Fobia] bit NOT NULL,
    [Obs_Medo_Fobia] nvarchar(max) NULL,
    [OcorrenciaMedica] nvarchar(max) NULL,
    [Obs_Geral] nvarchar(max) NULL,
    [DatAtt] datetime2 NOT NULL,
    [Autorizacao_Atividades] bit NOT NULL,
    [Obs_Autorizacao_Atividades] nvarchar(max) NULL,
    CONSTRAINT [PK_Ficha] PRIMARY KEY ([ID]),
    CONSTRAINT [FK_Ficha_Acampante_AcampanteID] FOREIGN KEY ([AcampanteID]) REFERENCES [Acampante] ([ID]) ON DELETE NO ACTION,
    CONSTRAINT [FK_Ficha_Responsavel_ResponsavelID] FOREIGN KEY ([ResponsavelID]) REFERENCES [Responsavel] ([ID]) ON DELETE NO ACTION
);

GO

CREATE INDEX [IX_Acampante_ResponsavelID] ON [Acampante] ([ResponsavelID]);

GO

CREATE INDEX [IX_Ficha_AcampanteID] ON [Ficha] ([AcampanteID]);

GO

CREATE INDEX [IX_Ficha_ResponsavelID] ON [Ficha] ([ResponsavelID]);

GO

INSERT INTO [__EFMigrationsHistory] ([MigrationId], [ProductVersion])
VALUES (N'20210226174630_InitialCreate', N'3.1.9');

GO

