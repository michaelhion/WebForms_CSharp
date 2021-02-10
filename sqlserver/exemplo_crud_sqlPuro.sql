select * from dbo.Carro;
insert into dbo.Carro(Codigo,Codigo_Marca,Modelo,Ano,cor) values(125,12367,'onix',2019,'prata');
insert into dbo.Carro(Codigo,Codigo_Marca,Modelo,Ano,cor) values(125,12367,'monza',1998,'verde');
update dbo.Carro set Modelo='corsa',Ano='2000',cor='azul' where id=5;
delete from dbo.Carro where Modelo = 'corsa'; 
select * from dbo.Carro;
