----Aufgabe 1)

select Name from Table_Bar


-----Aufgabe 2)

 
 select bar.Name, keeper.NachName
 from Table_Bar bar join Table_BarKeeper  keeper on bar.ID = keeper.BarId


------Aufgabe 3)


select bar.Name, product.ProductName, lage.Anzahl, product.MessGröße as Meneneinheit
   from Table_Bar bar join Table_Lage lage on bar.ID= lage.BarId 
       join Table_Product product on product.ID=lage.ProductId
         
         


-------Aufgabe 4)

select B.Name as BarName, R.Name as RezeptName
       from Table_Bar B join Table_BarRezept BR on  
	        B.ID=BR.BarId join Table_Rezept R on 
			R.ID=BR.RezeptId
        
     


-------Aufgabe 5)
select B.ID, B.Name from Table_Bar B where B.ID not in(
select L.BarId from Table_Product P join Table_Lage L on p.ID=l.ProductId
where p.ProductName='Gin')

-------Aufgabe 6)
select B.ID,B.VorName,B.NachName from Table_BarKeeper B where B.ID not in(
select Br.BarKeeperId from Table_BarKeeperRezept BR join Table_Rezept R on BR.RezeptId=R.ID
where R.Name='Old-Fashioned')




-------Aufgabe 7)


select R.Name as RezeptName,RZ.RezeptId ,P.ProductName,RZ.Menge,L.Anzahl,L.BarId from Table_Lage L join Table_Product P on L.ProductId=P.ID
join Table_RezeptZutat RZ on p.ID=RZ.ProductId JOIN  Table_Rezept R on R.ID=RZ.RezeptId
where L.BarId= 100 and  RZ.RezeptId= all (Select rz.ProductId from  Table_RezeptZutat rz ,Table_Rezept r where RZ.Menge > L.Anzahl );

	  


select distinct B.Name BarName, R.Name as RezeptName from Table_RezeptZutat REZU join Table_BarRezept BZ on REZU.RezeptId = BZ.RezeptId join Table_Bar B on B.ID = BZ.BarId 
join Table_Rezept R on R.ID = REZU.RezeptId  where (select count(*)  as c from Table_RezeptZutat t where t.RezeptId = REZU.RezeptId) = (
select count(RZ.RezeptId) from Table_Lage L join Table_Product P on L.ProductId=P.ID join Table_RezeptZutat RZ on RZ.ProductId = P.ID 
where RZ.Menge < L.Anzahl and BarId = BZ.BarId and RZ.RezeptId = REZU.RezeptId group by Rz.RezeptId)
