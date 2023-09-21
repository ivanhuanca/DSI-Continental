create procedure USP_Guardar_ca
@nOpcion int=0,
@nCodigo_Ca int=0,
@Descripcion_Ca varchar(40)=''
as
if @nOpcion=1--Nuevo registro
begin
	insert into Categorias(descripcion_ca, estado) values (@Descripcion_Ca,1);
end;
else--actualiza
begin
	update Categorias set descripcion_ca=@Descripcion_Ca where cod_categ=@nCodigo_Ca;
end;
go