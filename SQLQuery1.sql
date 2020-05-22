alter table ventas add constraint idventa  foreign key(nfv) references facturav (nfv) on delete cascade;
select * from ventas