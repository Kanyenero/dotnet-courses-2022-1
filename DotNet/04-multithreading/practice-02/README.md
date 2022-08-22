## Задание

Реализуйте 'синхронное' свойство SharedRes типа string, то есть свойство, самостоятельно заботящиеся о том, чтобы одновременно обращающиеся к нему потоки работали с ним корректно.

Правила такого обращения следующие:
1. Записывать в одно время может только один поток, любой следующий 'писатель' должен ждать (блокироваться).
2. Если один поток выполняет запись, то любой читатель должен ждать завершения этой записи.
3. Пока происходит чтение свойства, запись невозможна.
4. Однако требуется избежать такой ситуации, когда запись невозможна из-за сменяющих друг друга операций чтения.
5. Любое количество читающих потоков могут читать одновременно.

В главном классе программы:
- создайте экземпляр класса, который содержит "синхронное" свойство;
- создайте 10 потоков читателей, пытающихся прочитать это свойство;
- создайте 2 потока писателей, пытающихся изменить это свойство.

Вначале запускайте часть читателей, потом писателя, потом снова читателей, второго писателя и оставшихся читателей.

Важно:
1. Для реализации "свойства" используйте специально предназначенный для этого класс ReaderWriterLockSlim из пространства имен System.Threading.
2. Для эмуляции долгих операций чтения и записи - воспользуйтесь случайными задержками.
    - При этом у операций записи задержки больше, чем у операции чтения.
3. Добавьте запись отладочной информации с помощью стандартных средств, чтобы можно было получить файл с полным логом выполнения приложения.
    - Подробности смотрите в задании Learning Tracing and Instrumenting Applications
    - Создайте сущность Logger.
    - Сообщения в лог должны быть о каждом "чихе":
        - Запуск приложения.
        - Завершение приложения.
        - Запуск потока.
        - Старт метода потока.
        - Завершение метода потока.
        - Старт метода чтения.
        - Ожидание блокировки на чтение.
        - Успешное получение блокировки на чтение.
        - Завершение метода чтения.
        - И т.д. и т.п.
    - Формат сообщения "[yy/MM/dd HH:mm:ss.fff] [Thread name or ID] Message Text"
    
    ## Результаты

...\MultithreadingBasicsApp\logs\trace-2022-08-22_15.12.22-client.txt
```
[2022.08.22 15:12:22.666256] [App Thread] Started
[2022.08.22 15:12:22.672647] [Reader 2] Started
[2022.08.22 15:12:22.672872] [Reader 3] Started
[2022.08.22 15:12:22.673030] [Reader 1] Started
[2022.08.22 15:12:22.673266] [Reader 2] Method Started
[2022.08.22 15:12:22.673393] [Reader 3] Method Started
[2022.08.22 15:12:22.673536] [Reader 1] Method Started
[2022.08.22 15:12:22.673897] [Reader 2] Acquired a read lock
[2022.08.22 15:12:22.674028] [Reader 3] Acquired a read lock
[2022.08.22 15:12:22.674150] [Reader 1] Acquired a read lock
[2022.08.22 15:12:23.674446] [Writer 1] Started
[2022.08.22 15:12:23.674769] [Writer 1] Method Started
[2022.08.22 15:12:23.675133] [Writer 1] Waiting for a write lock...
[2022.08.22 15:12:24.686585] [Reader 1] Released a read lock
[2022.08.22 15:12:24.686749] [Reader 1] Method Completed(result: 'SharedResContent')
[2022.08.22 15:12:24.686819] [Reader 3] Released a read lock
[2022.08.22 15:12:24.686873] [Reader 3] Method Completed(result: 'SharedResContent')
[2022.08.22 15:12:24.686922] [Reader 3] Terminated
[2022.08.22 15:12:24.686988] [Reader 2] Released a read lock
[2022.08.22 15:12:24.687147] [Reader 2] Method Completed(result: 'SharedResContent')
[2022.08.22 15:12:24.687282] [Reader 2] Terminated
[2022.08.22 15:12:24.687352] [Writer 1] Acquired a write lock
[2022.08.22 15:12:24.687436] [Reader 1] Terminated
[2022.08.22 15:12:24.687685] [Reader 4] Started
[2022.08.22 15:12:24.687773] [Reader 4] Method Started
[2022.08.22 15:12:24.687865] [Reader 4] Waiting for a read lock...
[2022.08.22 15:12:24.687959] [Reader 5] Started
[2022.08.22 15:12:24.688045] [Reader 5] Method Started
[2022.08.22 15:12:24.688110] [Reader 5] Waiting for a read lock...
[2022.08.22 15:12:24.688190] [Reader 6] Started
[2022.08.22 15:12:24.688270] [Reader 6] Method Started
[2022.08.22 15:12:24.688321] [Reader 6] Waiting for a read lock...
[2022.08.22 15:12:25.701308] [Writer 2] Started
[2022.08.22 15:12:25.701530] [Writer 2] Method Started
[2022.08.22 15:12:25.701591] [Writer 2] Waiting for a write lock...
[2022.08.22 15:12:26.714590] [Reader 7] Started
[2022.08.22 15:12:26.714736] [Reader 7] Method Started
[2022.08.22 15:12:26.714806] [Reader 7] Waiting for a read lock...
[2022.08.22 15:12:26.714861] [Reader 8] Started
[2022.08.22 15:12:26.714941] [Reader 8] Method Started
[2022.08.22 15:12:26.715098] [Reader 8] Waiting for a read lock...
[2022.08.22 15:12:26.715158] [Reader 9] Started
[2022.08.22 15:12:26.715288] [Reader 9] Method Started
[2022.08.22 15:12:26.715350] [Reader 9] Waiting for a read lock...
[2022.08.22 15:12:26.715437] [Reader 10] Started
[2022.08.22 15:12:26.715547] [Reader 10] Method Started
[2022.08.22 15:12:26.715600] [Reader 10] Waiting for a read lock...
[2022.08.22 15:12:29.700628] [Writer 1] Released a write lock
[2022.08.22 15:12:29.700803] [Writer 1] Method Completed
[2022.08.22 15:12:29.700887] [Writer 1] Terminated
[2022.08.22 15:12:29.700966] [Writer 2] Acquired a write lock
[2022.08.22 15:12:34.712860] [Writer 2] Released a write lock
[2022.08.22 15:12:34.712989] [Reader 8] Acquired a read lock
[2022.08.22 15:12:34.713044] [Reader 9] Acquired a read lock
[2022.08.22 15:12:34.713132] [Reader 10] Acquired a read lock
[2022.08.22 15:12:34.713210] [Reader 7] Acquired a read lock
[2022.08.22 15:12:34.713287] [Reader 6] Acquired a read lock
[2022.08.22 15:12:34.713351] [Reader 5] Acquired a read lock
[2022.08.22 15:12:34.713412] [Reader 4] Acquired a read lock
[2022.08.22 15:12:34.713511] [Writer 2] Method Completed
[2022.08.22 15:12:34.713559] [Writer 2] Terminated
[2022.08.22 15:12:36.724843] [Reader 5] Released a read lock
[2022.08.22 15:12:36.724958] [Reader 5] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725005] [Reader 5] Terminated
[2022.08.22 15:12:36.725088] [Reader 7] Released a read lock
[2022.08.22 15:12:36.725166] [Reader 9] Released a read lock
[2022.08.22 15:12:36.725222] [Reader 9] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725256] [Reader 9] Terminated
[2022.08.22 15:12:36.725367] [Reader 6] Released a read lock
[2022.08.22 15:12:36.725431] [Reader 6] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725490] [Reader 6] Terminated
[2022.08.22 15:12:36.725552] [Reader 10] Released a read lock
[2022.08.22 15:12:36.725616] [Reader 10] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725658] [Reader 10] Terminated
[2022.08.22 15:12:36.725699] [Reader 4] Released a read lock
[2022.08.22 15:12:36.725764] [Reader 4] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725829] [Reader 4] Terminated
[2022.08.22 15:12:36.725873] [Reader 7] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.725935] [Reader 7] Terminated
[2022.08.22 15:12:36.725999] [Reader 8] Released a read lock
[2022.08.22 15:12:36.726061] [Reader 8] Method Completed(result: 'SharedResContent (after 'Writer 2' changes)')
[2022.08.22 15:12:36.726105] [Reader 8] Terminated
[2022.08.22 15:12:36.726229] [App Thread] Terminated

```