CREATE TABLE IF NOT EXISTS produtos (
    id               TEXT    DEFAULT (0) 
                             PRIMARY KEY
                             UNIQUE,
    descricao        TEXT    DEFAULT ('PRODUTO SEM CADASTRO'),
    quantidadeMinima REAL    DEFAULT (0),
    quantidadeMaxima REAL    DEFAULT (0),
    quantidadeTotal  REAL    DEFAULT (0),
    leadTime         INTEGER DEFAULT (0),
    tipo             TEXT    DEFAULT ('TBD'),
    unidade          TEXT    DEFAULT ('TBD'),
    localizacao      TEXT    DEFAULT ('ALMOXARIFADO'),
    caixa            TEXT    DEFAULT ('TBD'),
    obs              TEXT    DEFAULT ('') 
);