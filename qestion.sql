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
-- Структура таблицы `qestion`
--

CREATE TABLE `qestion` (
  `number` int(10) NOT NULL,
  `text` text NOT NULL,
  `1var` varchar(20) NOT NULL,
  `2var` varchar(20) NOT NULL,
  `3var` varchar(20) NOT NULL,
  `correct` int(2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `qestion`
--

INSERT INTO `qestion` (`number`, `text`, `1var`, `2var`, `3var`, `correct`) VALUES
(1, '7X*4=28', '2', '2,4', '1', 3),
(2, '234-456=?', '-123', '-222', '78', 2),
(3, 'В каком числе столько же цифр, сколько букв в его названии?', '100', '800', '100000000', 1),
(4, '3648 : 8 =?', '465', '867', '456', 3),
(5, ' 3 485 660 ? 3 458 660', '>', '<', '=', 1);

--
-- Индексы сохранённых таблиц
--

--
-- Индексы таблицы `qestion`
--
ALTER TABLE `qestion`
  ADD PRIMARY KEY (`number`);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;
