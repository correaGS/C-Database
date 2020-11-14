-- phpMyAdmin SQL Dump
-- version 4.8.4
-- https://www.phpmyadmin.net/
--
-- Host: 127.0.0.1
-- Generation Time: 05-Out-2019 às 21:02
-- Versão do servidor: 10.1.37-MariaDB
-- versão do PHP: 7.3.0

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET AUTOCOMMIT = 0;
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- Database: `dbconcessionaria`
--

DELIMITER $$
--
-- Procedures
--
CREATE DEFINER=`root`@`localhost` PROCEDURE `pAlterarFuncionario` (IN `idFun` INT(11), IN `nomeFun` VARCHAR(100), IN `cargoFun` INT(11), IN `emailFun` VARCHAR(100), IN `senhaFun` CHAR(8))  NO SQL
update tbfuncionario set 
Nome = nomeFun,
fk_cargo = cargoFun,
Email = emailFun,
Senha = senhaFun
where idFuncionario = idFun$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pAlterarVeiculo` (IN `PlacaId` CHAR(7), IN `modeloV` INT(11), IN `corV` INT(11), IN `Ano` INT(11), IN `AnoModelo` INT(11), IN `cambioV` INT(11), IN `combustivelV` INT(11), IN `KmRodado` INT(11), IN `categoriaV` INT(11), IN `segmentoV` INT(11), IN `QtdPorta` INT(11), IN `ObsVeiculo` TEXT)  NO SQL
update tbveiculo set 
		
fk_modelo = modeloV,		
fk_cor = corV,		
ano = Ano,		
anoModelo = AnoModelo,		
fk_cambio = cambioV,		
fk_combustivel = combustivelV,		
kmRodado = KmRodado,		
fk_categoria = categoriaV,			
fk_segmento = segmentoV,			
qtdPorta = QtdPorta,		
obsVeiculo = ObsVeiculo	
where placa = PlacaId$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pDeletarFuncionario` (IN `idFun` INT(11))  NO SQL
Delete from tbfuncionario  
where idFuncionario = idFun$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pDeletarVeiculo` (IN `PlacaId` CHAR(7))  NO SQL
Delete from tbveiculo  
where placa = PlacaId$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirCambio` (IN `Cambio` VARCHAR(50))  NO SQL
insert into tbcambio 
(cambio)
values
(Cambio)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirCargo` (IN `cargo` VARCHAR(100))  NO SQL
insert into tbcargo
(Cargo)
values
(cargo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirCategoria` (IN `Categoria` VARCHAR(50))  NO SQL
insert into tbcategoria
(categoria)
values
(Categoria)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirCombustivel` (IN `Combustivel` VARCHAR(50))  NO SQL
insert into tbcombustivel 
(combustivel)
values
(Combustivel)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirCor` (IN `Cor` INT(50))  NO SQL
insert into tbcor
(cor)
values
(Cor)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirFuncionario` (IN `nomeFun` VARCHAR(100), IN `cargoFun` INT(11), IN `emailFun` VARCHAR(100), IN `senhaFun` CHAR(8))  NO SQL
insert into tbfuncionario 
(Nome, fk_cargo, Email, Senha)
values
(nomeFun, cargoFun, emailFun, senhaFun)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirMarca` (IN `Marca` INT(50))  NO SQL
insert into tbmarca 
(marca)
values
(Marca)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirModelo` (IN `Modelo` VARCHAR(50), IN `marcaM` INT(11))  NO SQL
insert into tbmodelo
(modelo, fk_marca)
values
(Modelo, marcaM)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirSegmento` (IN `Segmento` INT(50))  NO SQL
insert into tbsegmento 
(segmento)
values
(Segmento)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pInserirVeiculo` (IN `Placa` CHAR(7), IN `modeloV` INT(11), IN `corV` INT(11), IN `Ano` INT(11), IN `AnoModelo` INT(11), IN `cambioV` INT(11), IN `combustivelV` INT(11), IN `KmRodado` INT(11), IN `categoriaV` INT(11), IN `segmentoV` INT(11), IN `QtdPorta` INT(11), IN `ObsVeiculo` TEXT)  NO SQL
insert into tbveiculo
(placa,	fk_modelo,	fk_cor,	ano,	anoModelo,	fk_cambio,	fk_combustivel,	kmRodado,	fk_categoria,	fk_segmento,	qtdPorta,	obsVeiculo
)
values
(Placa, modeloV, corV, Ano, AnoModelo, cambioV, combustivelV, KmRodado, categoriaV, segmentoV, QtdPorta, ObsVeiculo)$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pLogin` (IN `emailFun` VARCHAR(100), IN `senhaFun` CHAR(8))  NO SQL
SELECT count(*) from tbfuncionario where Email = emailFun AND Senha = senhaFun$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pVisualizarFuncionario` (INOUT `idFun` INT(11))  NO SQL
SELECT 
idFuncionario as IdFun,
Nome as NomeFun,
fk_cargo as CargoFun,
Email as EmailFun,
Senha as SenhaFun

from tbfuncionario where idFuncionario = idFun$$

CREATE DEFINER=`root`@`localhost` PROCEDURE `pVisualizarVeiculo` (IN `Placa` CHAR(7))  NO SQL
SELECT 
fk_modelo as modeloV,		
fk_cor as corV,		
ano as Ano,		
anoModelo as AnoModelo,		
fk_cambio as cambioV,		
fk_combustivel as combustivelV,		
kmRodado as KmRodado,		
fk_categoria as categoriaV,			
fk_segmento as segmentoV,			
qtdPorta as QtdPorta,		
obsVeiculo as ObsVeiculo	

from tbveiculo where placa = Placa$$

DELIMITER ;

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbcambio`
--

CREATE TABLE `tbcambio` (
  `codCambio` int(11) NOT NULL,
  `cambio` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbcambio`
--

INSERT INTO `tbcambio` (`codCambio`, `cambio`) VALUES
(1, 'Manual'),
(2, 'Automático'),
(3, 'Semi-automático');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbcargo`
--

CREATE TABLE `tbcargo` (
  `idCargo` int(11) NOT NULL,
  `Cargo` varchar(100) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbcargo`
--

INSERT INTO `tbcargo` (`idCargo`, `Cargo`) VALUES
(1, 'Programador'),
(2, 'Jardineiro');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbcategoria`
--

CREATE TABLE `tbcategoria` (
  `codCategoria` int(11) NOT NULL,
  `categoria` varchar(50) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbcategoria`
--

INSERT INTO `tbcategoria` (`codCategoria`, `categoria`) VALUES
(1, 'Hatch'),
(2, 'Sedan');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbcombustivel`
--

CREATE TABLE `tbcombustivel` (
  `codCombustivel` int(11) NOT NULL,
  `combustivel` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbcombustivel`
--

INSERT INTO `tbcombustivel` (`codCombustivel`, `combustivel`) VALUES
(1, 'Gasolina'),
(2, 'Álcool'),
(3, 'Gás'),
(4, 'Diesel'),
(5, 'Flex');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbcor`
--

CREATE TABLE `tbcor` (
  `codCor` int(11) NOT NULL,
  `cor` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbcor`
--

INSERT INTO `tbcor` (`codCor`, `cor`) VALUES
(1, 'Branco'),
(2, 'Preto'),
(3, 'Vermelho'),
(4, 'Azul'),
(5, 'Prata'),
(6, 'Cinza');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbfuncionario`
--

CREATE TABLE `tbfuncionario` (
  `idFuncionario` int(11) NOT NULL,
  `Nome` varchar(100) DEFAULT NULL,
  `fk_cargo` int(11) DEFAULT NULL,
  `Email` varchar(100) DEFAULT NULL,
  `Senha` char(8) DEFAULT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbfuncionario`
--

INSERT INTO `tbfuncionario` (`idFuncionario`, `Nome`, `fk_cargo`, `Email`, `Senha`) VALUES
(1, 'Gabriel', 1, 'correa.gabrielsilva@outlook.com', 'kluy1304'),
(2, 'giovani', 1, 'giovani@senac.com', '1234'),
(4, 'Pedro', 2, 'pedro@senac.com', '0001');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbmarca`
--

CREATE TABLE `tbmarca` (
  `codMarca` int(11) NOT NULL,
  `marca` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbmarca`
--

INSERT INTO `tbmarca` (`codMarca`, `marca`) VALUES
(1, 'VolksWagen'),
(2, 'Fiat'),
(3, 'Chevrolet'),
(4, 'Hyundai'),
(5, 'BMW'),
(6, 'Mercedes');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbmodelo`
--

CREATE TABLE `tbmodelo` (
  `codModelo` int(11) NOT NULL,
  `modelo` varchar(50) NOT NULL,
  `fk_marca` int(11) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbmodelo`
--

INSERT INTO `tbmodelo` (`codModelo`, `modelo`, `fk_marca`) VALUES
(1, 'Gol', 1),
(2, 'Uno', 2),
(3, 'HB20', 4),
(4, 'Onix', 3),
(5, 'Siena', 2),
(6, 'Meriva', 3),
(7, 'Celta', 3),
(8, 'Corsa', 3),
(9, 'Fox', 1);

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbsegmento`
--

CREATE TABLE `tbsegmento` (
  `codSegmento` int(11) NOT NULL,
  `segmento` varchar(50) NOT NULL
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbsegmento`
--

INSERT INTO `tbsegmento` (`codSegmento`, `segmento`) VALUES
(1, 'Novo'),
(2, 'Semi-novo');

-- --------------------------------------------------------

--
-- Estrutura da tabela `tbveiculo`
--

CREATE TABLE `tbveiculo` (
  `placa` char(7) NOT NULL,
  `fk_modelo` int(11) NOT NULL,
  `fk_cor` int(11) NOT NULL,
  `ano` int(11) DEFAULT NULL,
  `anoModelo` int(11) DEFAULT NULL,
  `fk_cambio` int(11) DEFAULT NULL,
  `fk_combustivel` int(11) DEFAULT NULL,
  `kmRodado` int(11) DEFAULT NULL,
  `fk_categoria` int(11) DEFAULT NULL,
  `fk_segmento` int(11) DEFAULT NULL,
  `qtdPorta` int(11) NOT NULL,
  `obsVeiculo` text
) ENGINE=InnoDB DEFAULT CHARSET=latin1;

--
-- Extraindo dados da tabela `tbveiculo`
--

INSERT INTO `tbveiculo` (`placa`, `fk_modelo`, `fk_cor`, `ano`, `anoModelo`, `fk_cambio`, `fk_combustivel`, `kmRodado`, `fk_categoria`, `fk_segmento`, `qtdPorta`, `obsVeiculo`) VALUES
('poi5859', 1, 1, 200, 2000, 1, 1, 22222, 1, 1, 2, '212121'),
('STC9437', 5, 2, 2009, 2008, 2, 5, 7521, 1, 1, 4, 'hrsf');

--
-- Indexes for dumped tables
--

--
-- Indexes for table `tbcambio`
--
ALTER TABLE `tbcambio`
  ADD PRIMARY KEY (`codCambio`);

--
-- Indexes for table `tbcargo`
--
ALTER TABLE `tbcargo`
  ADD PRIMARY KEY (`idCargo`);

--
-- Indexes for table `tbcategoria`
--
ALTER TABLE `tbcategoria`
  ADD PRIMARY KEY (`codCategoria`);

--
-- Indexes for table `tbcombustivel`
--
ALTER TABLE `tbcombustivel`
  ADD PRIMARY KEY (`codCombustivel`);

--
-- Indexes for table `tbcor`
--
ALTER TABLE `tbcor`
  ADD PRIMARY KEY (`codCor`);

--
-- Indexes for table `tbfuncionario`
--
ALTER TABLE `tbfuncionario`
  ADD PRIMARY KEY (`idFuncionario`),
  ADD KEY `fk_cargoFuncionario` (`fk_cargo`);

--
-- Indexes for table `tbmarca`
--
ALTER TABLE `tbmarca`
  ADD PRIMARY KEY (`codMarca`);

--
-- Indexes for table `tbmodelo`
--
ALTER TABLE `tbmodelo`
  ADD PRIMARY KEY (`codModelo`),
  ADD KEY `fk_marcaModelo` (`fk_marca`);

--
-- Indexes for table `tbsegmento`
--
ALTER TABLE `tbsegmento`
  ADD PRIMARY KEY (`codSegmento`);

--
-- Indexes for table `tbveiculo`
--
ALTER TABLE `tbveiculo`
  ADD PRIMARY KEY (`placa`),
  ADD KEY `fk_modeloVeiculo` (`fk_modelo`),
  ADD KEY `fk_segmentoVeiculo` (`fk_segmento`),
  ADD KEY `fk_corVeiculo` (`fk_cor`),
  ADD KEY `fk_cambioVeiculo` (`fk_cambio`),
  ADD KEY `fk_categoriaVeiculo` (`fk_categoria`),
  ADD KEY `fk_combustuvelVeiculo` (`fk_combustivel`);

--
-- AUTO_INCREMENT for dumped tables
--

--
-- AUTO_INCREMENT for table `tbcambio`
--
ALTER TABLE `tbcambio`
  MODIFY `codCambio` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=4;

--
-- AUTO_INCREMENT for table `tbcargo`
--
ALTER TABLE `tbcargo`
  MODIFY `idCargo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbcategoria`
--
ALTER TABLE `tbcategoria`
  MODIFY `codCategoria` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- AUTO_INCREMENT for table `tbcombustivel`
--
ALTER TABLE `tbcombustivel`
  MODIFY `codCombustivel` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=6;

--
-- AUTO_INCREMENT for table `tbcor`
--
ALTER TABLE `tbcor`
  MODIFY `codCor` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbfuncionario`
--
ALTER TABLE `tbfuncionario`
  MODIFY `idFuncionario` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbmarca`
--
ALTER TABLE `tbmarca`
  MODIFY `codMarca` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=7;

--
-- AUTO_INCREMENT for table `tbmodelo`
--
ALTER TABLE `tbmodelo`
  MODIFY `codModelo` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=10;

--
-- AUTO_INCREMENT for table `tbsegmento`
--
ALTER TABLE `tbsegmento`
  MODIFY `codSegmento` int(11) NOT NULL AUTO_INCREMENT, AUTO_INCREMENT=3;

--
-- Constraints for dumped tables
--

--
-- Limitadores para a tabela `tbfuncionario`
--
ALTER TABLE `tbfuncionario`
  ADD CONSTRAINT `fk_cargoFuncionario` FOREIGN KEY (`fk_cargo`) REFERENCES `tbcargo` (`idCargo`);

--
-- Limitadores para a tabela `tbmodelo`
--
ALTER TABLE `tbmodelo`
  ADD CONSTRAINT `fk_marcaModelo` FOREIGN KEY (`fk_marca`) REFERENCES `tbmarca` (`codMarca`);

--
-- Limitadores para a tabela `tbveiculo`
--
ALTER TABLE `tbveiculo`
  ADD CONSTRAINT `fk_cambioVeiculo` FOREIGN KEY (`fk_cambio`) REFERENCES `tbcambio` (`codCambio`),
  ADD CONSTRAINT `fk_categoriaVeiculo` FOREIGN KEY (`fk_categoria`) REFERENCES `tbcategoria` (`codCategoria`),
  ADD CONSTRAINT `fk_combustivelVeiculo` FOREIGN KEY (`fk_combustivel`) REFERENCES `tbcombustivel` (`codCombustivel`),
  ADD CONSTRAINT `fk_corVeiculo` FOREIGN KEY (`fk_cor`) REFERENCES `tbcor` (`codCor`),
  ADD CONSTRAINT `fk_modeloVeiculo` FOREIGN KEY (`fk_modelo`) REFERENCES `tbmodelo` (`codModelo`),
  ADD CONSTRAINT `fk_segmentoVeiculo` FOREIGN KEY (`fk_segmento`) REFERENCES `tbsegmento` (`codSegmento`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
