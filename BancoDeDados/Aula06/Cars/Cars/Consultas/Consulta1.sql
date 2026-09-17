-- Script para preencher a coluna Foto na tabela Estoque
-- Regras:
-- Tipo = 1 -> Motos (Moto1.jpg, Moto2.jpg, ...)
-- Tipo = 2 -> Carros (Carro1.jpg, Carro2.jpg, ...)
-- Ajuste os caminhos base abaixo conforme necessário

SET XACT_ABORT ON;
BEGIN TRANSACTION;

DECLARE @basePathMoto NVARCHAR(400) = N'C:\Users\Back\Documents\DEVBACKEND\BancoDeDados\Aula06\Cars\Cars\Fotos\Motos\';
DECLARE @basePathCarro NVARCHAR(400) = N'C:\Users\Back\Documents\DEVBACKEND\BancoDeDados\Aula06\Cars\Cars\Fotos\Carros\';

;WITH Sequencia AS (
	SELECT
		Id, -- chave primária da tabela Estoque (ajuste se for outro nome)
		Tipo,
		ROW_NUMBER() OVER (PARTITION BY Tipo ORDER BY Id) AS SeqNum
	FROM Estoque
	WHERE Tipo IN (1, 2)
)
UPDATE e
SET Foto = CASE 
		WHEN s.Tipo = 1 THEN @basePathMoto + N'Moto' + CAST(s.SeqNum AS NVARCHAR(10)) + N'.jpg'
		WHEN s.Tipo = 2 THEN @basePathCarro + N'Carro' + CAST(s.SeqNum AS NVARCHAR(10)) + N'.jpg'
	END
FROM Estoque e
INNER JOIN Sequencia s ON e.Id = s.Id;

COMMIT TRANSACTION;

GO

-- Observações:
-- 1) Se a chave primária não se chama Id, substitua a coluna Id no CTE e no JOIN pelo nome correto.
-- 2) Ajuste os caminhos @basePathMoto e @basePathCarro para apontarem para as pastas corretas em sua máquina.
-- 3) Execute em ambiente de teste antes de aplicar em produção.
