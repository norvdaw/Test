<h1 align="center">Coursework</h1>

## Исходные данные

<h4 align="center">05:Нормы затрат труда <–>> 11:Учет выработки <<–> 10:Личный состав</h4>

<h3 align="center"><img src="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/images/norm.PNG" height="140"/>
<img src="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/images/uchet.PNG" height="140"/>
<img src="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/images/sostav.PNG" height="140"/></h3>

<h6 align="center">SQL-script для создания и загрузки данных в таблицы можно посмотреть 
<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/proektCreateBD.sql" target="_blank">тут</a>.

## Главная экранная форма (<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/Coursework/DataDispley.cs" target="_blank">DataDisplay.cs</a>)

- Визуализация таблиц ранее созданной базы данных.
- Отображение результата выполнения хранимой процедуры 
(количество небракованных деталей, сделанных рабочим).

## Альтернативное заполнение таблиц (<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/Coursework/DataDispleyAlternative.cs" target="_blank">DataDisplayAlternative.cs</a>)

- Реализация альтернативной формы с динамическим отображением всех таблиц в одном DataGridView.

## Представление данных через VIEW (<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/Coursework/VIEW.cs" target="_blank">VIEW.cs</a>)

Создание представления (VIEW), которое показывает в виде одной таблицы данные из трех таблиц, соединенных в соответствии с межтабличными связями межу ними. 

## Task 1 (<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/Coursework/Task1.cs" target="_blank">Task1.cs</a>)

> Сведения об учете выработки с допускаемым браком (>0): номер цеха и участка; фамилия; дата; количество бракованных изделий.  

#### Решение задачи разными способами

1. Воспользуемся Set-ориентированными средствами SQL для работы с таблицами и объектом типа TableAdapter для связи с SQL-сервером.
2. Воспользуемся Record-ориентированными средствами Visual Studio для работы с таблицами, наиболее близкими к традиционным процедурным средствам обработки файлов
3. Воспользуемся первичным ключами для поиска в таблице с интересующим нас допускаемым браком. Поиск строки в таблице по её ключу выполним
с помощью метода Find объекта DataRowCollection.
4. Воспользуемся операционной связью DataRelation для таблиц в наборе данных.
5. Воспользуемся присоединенным режимом работы с базой данных,
т.е. откроем соединение с БД, выполним SQL-команду и закроем соединение. Основной объект получения данных SqlDataReader. 

## Task 3 (<a href="https://github.com/norvdaw/Coursework-WinForms-SQL/blob/main/Coursework/Task3.cs" target="_blank">Task3.cs</a>)

> #### Все рабочие, такие что:
> - Имеется операция по сборке некоторой детали с временем изготовления одной детали > 10, 
которую должен выполнять рабочий соответствующей профессии и квалификации.
> - Этот рабочий при выполнении этой операции никогда не допускал брак.

К Task 3 написать две программы: решение с помощью кванторного SQL-запроса с подзапросами и решение с помощью record-ориентированных средств
