use KursDB
CREATE VIEW NormSosUch AS -- ����������� ������ �� ���� ������ � ����
	select u.id_worker as [����� ��������],
	u.id_detail as [����� ������],
			u.id_oper as [����� ��������],
			u.date_work as [���� ���������� �����],
			n.id_prof as [����� ���������],
			n.razryad as [������ ��������],
			n.time_all as [����� ���������� ������],
			s.id_ceh as [����� ����],
			s.id_uch as [����� �������],
			u.kolvo_bad as [���������� �����],
			u.kolvo_good as [���������� ������ �������],
			s.FIO as [���]
from uchet u
join norm n on u.id_detail = n.id_detail and u.id_oper = n.id_oper
join sostav s on s.id_worker = u.id_worker
