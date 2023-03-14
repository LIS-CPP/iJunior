# ЯЮниор

Для сдачи задач требуется сдать код, который вы можете загрузить\
на https://gist.github.com или https://pastebin.com \
Сдавать нужно весь код, а не только Main.


## Задача №1: `Установка Visual Studio`
Просмотрев лекцию по установке Visual Studio попробуйте повторить установку.\
Для сдачи задачи требуется сделать скриншот кода консольной программы,\
который генерируется при запуске, но вместо `Hello, world` запишите строку `ЯЮниор`.

## Задача №2: `Переменные`
Попрактикуйтесь в создании переменных, объявить `10` переменных разных типов.

_Напоминание: переменные именуются с маленькой буквы,\
если название состоит из нескольких слов,\
то комбинируем их следующим образом - `названиеПеременной`._

Также имя всегда должно отражать суть того, что хранит переменная.

## Задача №3: `Что выведется в консоль и почему?`
```csharp
int a = 10;
int b = 38;
int c = (31 – 5 * a) / b;
Console.WriteLine(c);
```
_ВАЖНО!!! Не запускать код и попытаться подумать головой. Также надо написать ответ `Почему?`_

## Задача №4: `Работа со строками`
Вы задаете вопросы пользователю, по типу `как вас зовут`, `какой ваш знак зодиака` и т.д.,\
после чего, по данным, которые он ввел, формируете небольшой текст о пользователе.

К примеру: `Вас зовут Алексей, вам 21 год, вы водолей и работаете на заводе.`

## Задача №5: `Перестановка местами значений`
Даны две переменные.\
Поменять местами значения двух переменных.\
Вывести на экран значения переменных до перестановки и после.\
К примеру, есть две переменные имя и фамилия, они сразу инициализированные,\
но данные не верные, перепутанные.\
Вот эти данные и надо поменять местами через код. 

## Задача №6: `Картинки`
На экране, в специальной зоне, выводятся картинки, по `3` в ряд.\
Всего у пользователя в альбоме 52 картинки.\
Код должен вывести, сколько полностью заполненных рядов можно будет вывести,\
и сколько картинок будет сверх меры.

В качестве решения ожидаются объявленные переменные с необходимыми значениями и,\
основываясь на значениях переменных, вывод необходимых данных.


## Задача №7: `Магазин`
**Легенда**:
Вы приходите в магазин и хотите купить за своё золото кристаллы.\
В вашем кошельке есть какое-то количество золота, продавец спрашивает у вас,\
сколько кристаллов вы хотите купить?\
После сделки у вас остаётся какое-то количество золота и появляется какое-то количество кристаллов.

**Формально**:
При старте программы пользователь вводит начальное количество золота.\
Потом ему предлагается купить какое-то количество кристаллов по цене N(задать в программе самому).\
Пользователь вводит число и его золото конвертируется в кристаллы.\
Остаток золота и кристаллов выводится на экран.\
Проверять на то, что у игрока достаточно денег не нужно.

## Задача №8: `Поликлиника`
Вы заходите в поликлинику и видите огромную очередь из старушек,\
вам нужно рассчитать время ожидания в очереди.

**Формально**:
Пользователь вводит кол-во людей в очереди.\
Фиксированное время приема одного человека всегда равно 10 минутам.\
Пример ввода: `Введите кол-во старушек: 14`\
Пример вывода: `Вы должны отстоять в очереди 2 часа и 20 минут.`

