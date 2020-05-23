set identity_insert ventas on
insert into ventas(idventa,idproducto,idusuario,nfv,descripcion,cantidad,precio,subtotal) values(2,1,1,2,'con mani',4,0.25,1.00);
insert into ventas(idventa,idproducto,idusuario,nfv,descripcion,cantidad,precio,subtotal) values(3,1,1,3,'con mani',10,0.25,2.50);

insert into usuarios values(idusuario);
