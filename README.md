# Тестовое Owl

## **Содержание**

1. [**Основная информация**](#основная-информация)
2. [**Инструкция**](#инструкция)

## **Основная информация**

Версия Unity: 2020.3.3f1

С момента получения задания получалось уделять в рабочие дни мало времени (хотелось отдохнуть), в субботу удалось закончить. Возник баг который встретите ниже, пытался фиксануть но решил оно того не стоит на данный момент.

## **Инструкция**

Базовая инструкция:
- открываем сцену SampleScene;
- в объекте TileDataManager у нас вся информация по тайлам;
- в объекте HexMapGenerator находится поле seed меняйте как пожелаете (от него полностью зависит генерируемая карта);
- запустите сцену;
- текущий тайл (центральный) - это тот на котором кружок;
- нажимаем на тайл по строго по вертикали или горизонтали от текущего;
- понял только что при нажатии на тайл не находящийся на одной из базовых осей происходит инвертизация.

## **Структура папок проекта**

1. **Prefabs** - префабы проекта
2. **Scenes** - внутриигровые сцены
3. **Scripts** - скрипты


