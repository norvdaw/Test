use KursDB
CREATE VIEW NormSosUch AS -- Объединение данных из трех таблиц в одну
	select u.id_worker as [Номер рабочего],
	u.id_detail as [Номер детали],
			u.id_oper as [Номер операции],
			u.date_work as [Дата выполнения работ],
			n.id_prof as [Номер профессии],
			n.razryad as [Разряд рабочего],
			n.time_all as [Время выполнения работы],
			s.id_ceh as [Номер цеха],
			s.id_uch as [Номер участка],
			u.kolvo_bad as [Количество брака],
			u.kolvo_good as [Количество годных деталей],
			s.FIO as [ФИО]
from uchet u
join norm n on u.id_detail = n.id_detail and u.id_oper = n.id_oper
join sostav s on s.id_worker = u.id_worker
