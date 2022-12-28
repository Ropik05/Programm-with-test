-- phpMyAdmin SQL Dump
-- version 5.1.2
-- https://www.phpmyadmin.net/
--
-- Хост: localhost:3306
-- Время создания: Дек 15 2022 г., 06:33
-- Версия сервера: 5.7.24
-- Версия PHP: 8.0.1

SET SQL_MODE = "NO_AUTO_VALUE_ON_ZERO";
START TRANSACTION;
SET time_zone = "+00:00";


/*!40101 SET @OLD_CHARACTER_SET_CLIENT=@@CHARACTER_SET_CLIENT */;
/*!40101 SET @OLD_CHARACTER_SET_RESULTS=@@CHARACTER_SET_RESULTS */;
/*!40101 SET @OLD_COLLATION_CONNECTION=@@COLLATION_CONNECTION */;
/*!40101 SET NAMES utf8mb4 */;

--
-- База данных: `chisla`
--

-- --------------------------------------------------------

--
-- Структура таблицы `chooses`
--

CREATE TABLE `chooses` (
  `TestName` varchar(30) NOT NULL,
  `questions` varchar(5) NOT NULL,
  `RNumer` int(5) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `chooses`
--

INSERT INTO `chooses` (`TestName`, `questions`, `RNumer`) VALUES
('qestion', '6', 1),
('math', '10', 2),
('math1', '10', 3),
('math2', '10', 4),
('math3', '10', 5),
('math4', '10', 6);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
