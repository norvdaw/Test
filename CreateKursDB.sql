use KursDB
CREATE TABLE norm ( -- Пооперационные нормы затрат труда на изготовление
id_detail INT NOT NULL,
id_oper INT NOT NULL,
id_prof INT,
razryad INT,
id_work INT,
time_all VARCHAR(10) default ('30 мин.'),
time_one INT,
PRIMARY KEY (id_detail, id_oper)
)
CREATE TABLE sostav( -- Личный состав 
id_worker INT NOT NULL PRIMARY KEY,
id_ceh INT,
id_uch INT,
id_prof INT,
razryad INT,
family VARCHAR(20) default ('Свободен(на)'),
FIO VARCHAR(20)
)
CREATE TABLE uchet( -- Учет выработки рабочих 
id_worker INT NOT NULL,
date_work DATE NOT NULL,
id_detail INT NOT NULL,
id_oper INT NOT NULL,
kolvo_good INT,
kolvo_bad INT,
proc_brak VARCHAR(20) default ('3%'),
PRIMARY KEY (id_worker,date_work,id_detail, id_oper),
FOREIGN KEY (id_worker) REFERENCES sostav(id_worker),
FOREIGN KEY(id_detail, id_oper) REFERENCES norm(id_detail, id_oper)
)
GO 
CREATE TRIGGER A_trigger -- Триггер 1
ON norm
INSTEAD OF DELETE AS
BEGIN
	DELETE FROM uchet
			WHERE id_detail IN (SELECT id_detail FROM DELETED) AND id_oper IN (SELECT id_oper FROM DELETED)
			DELETE FROM norm
				WHERE id_detail IN (SELECT id_detail FROM DELETED) AND id_oper IN (SELECT id_oper FROM DELETED)
			END
GO 
CREATE TRIGGER B_trigger -- Триггер 2
ON norm
AFTER INSERT AS 
BEGIN
    UPDATE uchet
    SET kolvo_good=kolvo_good+1
    WHERE exists ( select * from inserted i where i.id_detail=uchet.id_detail and i.id_oper=uchet.id_oper)
END
go
CREATE PROCEDURE A_proc( --	Найти количество небракованных деталей, сделанных рабочим
@id_worker int,
@kolvo_good int output
)
as
begin
set @kolvo_good= (select SUM(uchet.kolvo_good) FROM uchet
where uchet.id_worker = @id_worker)
end
go
-- Загрузка данных в таблицы
INSERT INTO norm(id_detail,id_oper,id_prof,razryad,id_work, time_one)
VALUES 
(1, 1, 1, 1,1,5),
(1, 2, 3, 1,1,11),
(2, 2, 10, 3,2,10),
(3, 3, 2, 4,5,20),
(4, 1, 10, 3,4,15);
INSERT INTO sostav(id_worker,id_ceh,id_uch,id_prof,razryad,FIO)
VALUES
(1,1,3,1,1,'Иванов И.И.'),
(2,1,2,10,3,'Петров П.П.'),
(3,2,1,2,4,'Усманова М.А.'),
(4,3,5,1,1,'Сидорова У.П.');
INSERT INTO uchet(id_worker,date_work,id_detail, id_oper,kolvo_good,kolvo_bad)
VALUES
(1,'2019-05-09',1,1,100,1),
(1,'2016-11-08',1,2,1000,2),
(2,'2020-03-09',4,1,1,20),
(2,'2020-02-12',2,2,250,25),
(3,'2021-05-08',3,3,5, 0),
(4,'2019-12-01',1,1,100, 0);

