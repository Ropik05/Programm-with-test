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
-- Структура таблицы `math`
--

CREATE TABLE `math` (
  `number` int(10) NOT NULL,
  `text` text NOT NULL,
  `1var` varchar(20) NOT NULL,
  `2var` varchar(20) NOT NULL,
  `3var` varchar(20) NOT NULL,
  `correct` int(2) NOT NULL
) ENGINE=MyISAM DEFAULT CHARSET=utf8;

--
-- Дамп данных таблицы `math`
--

INSERT INTO `math` (`number`, `text`, `1var`, `2var`, `3var`, `correct`) VALUES
(1, 'Как записывают цифрами число «три миллиона тридцать тысяч триста', '3 030 300', '3 300 300', '3 003 300', 1),
(2, 'Укажите верное утверждение', 'Двухзначное натураль', 'Сумма двух натуральн', 'Луч не имеет конца', 3),
(3, 'Какое пятизначное число, запись которого оканчивается цифрой 2, больше числа 99 982?', '9992', '99 092', '99 992', 3),
(4, 'Велосипедист каждый день преодолевал по 45 км. Сколько километров в день нужно преодолевать велосипедисту, чтобы вернуться обратно за 9 дней, если все путешествие у него заняло 10 дней?', '45', '50', '61', 2),
(5, ' х : 23 = 11.', '253', '223', '323', 1),
(6, '\r\nНайдите периметр и площадь прямоугольника со сторонами 6 см и 8 см.', '14 и 32', '28 и 48', '28 и 24', 2),
(7, 'Делителем натурального числа a называют натуральное число, на которое а делится', 'и получается единица', 'без остатка', 'и получается число 5', 2),
(8, 'Периметр прямоугольника: Р =', ' 2ab', ' vt', '2·(a + b)', 3),
(9, 'Используя переместительное и сочетательное свойства сложения, упростить: (х + 58) + 12.', 'x + 70', '58x + 12', ' 70x', 1),
(10, 'означает найти все его корни или убедиться, что корней нет.', 'решить пример', 'решить неравенство', 'решить уравнение', 3);
COMMIT;

/*!40101 SET CHARACTER_SET_CLIENT=@OLD_CHARACTER_SET_CLIENT */;
/*!40101 SET CHARACTER_SET_RESULTS=@OLD_CHARACTER_SET_RESULTS */;
/*!40101 SET COLLATION_CONNECTION=@OLD_COLLATION_CONNECTION */;