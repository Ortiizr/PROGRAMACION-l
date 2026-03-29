-- ============================================
-- BASE DE DATOS CENTRALITA TELEFONICA
-- ============================================

-- Crear base de datos
CREATE DATABASE CentralitaDB;
GO

-- Usar la base de datos
USE CentralitaDB;
GO

-- ============================================
-- TABLA: LLAMADAS
-- ============================================

CREATE TABLE Llamadas (
    Id INT IDENTITY(1,1) PRIMARY KEY,
    NumeroOrigen VARCHAR(20) NOT NULL,
    NumeroDestino VARCHAR(20) NOT NULL,
    Duracion FLOAT NOT NULL,
    Costo DECIMAL(10,2) NOT NULL
);
GO

-- ============================================
-- DATOS DE PRUEBA
-- ============================================

INSERT INTO Llamadas (NumeroOrigen, NumeroDestino, Duracion, Costo)
VALUES 
('809-555-1111', '809-555-2222', 60, 9.00),
('829-555-3333', '849-555-4444', 100, 25.00),
('809-555-5555', '829-555-6666', 80, 20.00);
GO

-- ============================================
-- CONSULTA FINAL
-- ============================================

SELECT * FROM Llamadas;
GO