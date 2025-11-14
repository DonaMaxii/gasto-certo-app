-- phpMyAdmin SQL Dump
-- version 4.0.4.2
-- http://www.phpmyadmin.net
--
-- Máquina: localhost
-- Data de Criação: 14-Nov-2025 às 01:48
-- Versão do servidor: 5.6.13
-- versão do PHP: 5.4.17

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8 */;

--
-- Base de Dados: `gasto_certo`
--
CREATE DATABASE IF NOT EXISTS `gasto_certo` DEFAULT CHARACTER SET latin1 COLLATE latin1_swedish_ci;
USE `gasto_certo`;

-- --------------------------------------------------------

--
-- Estrutura da tabela `orcamentos`
--

CREATE TABLE IF NOT EXISTS `orcamentos` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `mes` varchar(20) NOT NULL,
  `ano` int(11) NOT NULL,
  `sub_tipo` varchar(40) NOT NULL,
  `tipo` varchar(30) NOT NULL,
  `descricao` text NOT NULL,
  `valor` float NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=29 ;

--
-- Extraindo dados da tabela `orcamentos`
--

INSERT INTO `orcamentos` (`id`, `usuario`, `mes`, `ano`, `sub_tipo`, `tipo`, `descricao`, `valor`) VALUES
(9, 'RAFAEL', 'Abril', 2025, 'Alimentação', 'Gasto', 'Mercado', 200),
(10, 'RAFAEL', 'Novembro', 2030, 'Salário', 'Receita', 'Crime', 10000),
(11, 'RAFAEL', 'Dezembro', 2025, 'Alimentação', 'Gasto', 'Insalubre', 500),
(12, 'RAFAEL', 'Dezembro', 2025, 'Salário', 'Receita', 'Estágio', 1500),
(13, 'RAFAEL', 'Dezembro', 2025, 'Educação', 'Gasto', 'Cinema', 100),
(14, 'RAFAEL', 'Dezembro', 2025, 'Lazer', 'Gasto', 'Cinema', 100),
(15, 'RAFAEL', 'Dezembro', 2025, 'Salário', 'Receita', 'Emprego', 90000),
(16, 'RAFAEL', 'Dezembro', 2025, 'Alimentação', 'Gasto', 'Point Salgados', 1000),
(17, 'Samuel', 'Março', 2025, 'Alimentação', 'Gasto', '', 120),
(18, 'Samuel', 'Março', 2025, 'Salário', 'Receita', '', 0),
(19, 'RAFAEL', 'Janeiro', 2025, 'Salário', 'Receita', '', 10),
(20, 'RAFAEL', 'Janeiro', 2025, 'Salário', 'Receita', '', 0),
(21, 'RAFAEL', 'Fevereiro', 2025, 'Salário', 'Receita', '', 10),
(22, 'RAFAEL', 'Fevereiro', 2025, 'Alimentação', 'Gasto', 'Insalubre', 200099),
(23, 'RAFAEL', 'Março', 2025, 'Freelance', 'Receita', '', 1221),
(24, 'RAFAEL', 'Fevereiro', 2025, 'Salário', 'Receita', 'estágio', 15001),
(25, 'RAFAEL', 'Janeiro', 2025, 'Freelance', 'Receita', 'Site', 100.99),
(26, 'RAFAEL', 'Janeiro', 2024, 'Salário', 'Receita', '', 12.12),
(27, 'RAFAEL', 'Janeiro', 2015, 'Freelance', 'Receita', '', 1999.99),
(28, 'RAFAEL', 'Fevereiro', 2023, 'Alimentação', 'Gasto', '', 1200.99);

-- --------------------------------------------------------

--
-- Estrutura da tabela `usuarios`
--

CREATE TABLE IF NOT EXISTS `usuarios` (
  `id` int(100) NOT NULL AUTO_INCREMENT,
  `usuario` varchar(50) NOT NULL,
  `senha` varchar(50) NOT NULL,
  PRIMARY KEY (`id`)
) ENGINE=InnoDB  DEFAULT CHARSET=latin1 AUTO_INCREMENT=9 ;

--
-- Extraindo dados da tabela `usuarios`
--

INSERT INTO `usuarios` (`id`, `usuario`, `senha`) VALUES
(3, 'RAFAEL', '123'),
(4, 'Maxine', '12345'),
(5, 'teste', '123'),
(6, 'Teste2', '123'),
(7, 'Joeliton', '123'),
(8, 'Samuel', '123');

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
