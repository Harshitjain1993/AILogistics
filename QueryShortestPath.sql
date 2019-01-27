 Origin     Destination        Distance 
   A             B                 10
   B             C                 20
   C             E                 30
   B             F                 5
   F             E                 6





Jaipur	Alwar	160
Jaipur	Neemrana	150
Rewari	Alwar	90
Rewari	  Neemrana	50
Neemrana	Alwar	80
Udaipur	Neemrana	540
Udaipur	Jaipur	400
Udaipur	Alwar	540


 CREATE TABLE troute(origin varchar(25),destination varchar(25),distance int , Supply int)
 
SELECT * FROM troute
DROP TABLE troute

	INSERT INTO troute VALUES ( 'A','B',10)
	INSERT INTO troute VALUES(  'B' ,'C', 20)
	INSERT INTO troute VALUES(  'C','E',30)
	INSERT INTO troute VALUES(  'B','F', 5)
    INSERT INTO troute VALUES(  'F','E',6)


	  INSERT INTO troute VALUES(  'J','A',160)
	  INSERT INTO troute VALUES(  'A','R',90)
	  INSERT INTO troute VALUES(  'R','N',50)
	  INSERT INTO troute VALUES(  'A','N',80)
	  INSERT INTO troute VALUES(  'N','U',540)

	  INSERT INTO troute VALUES(  'J','N',150)
	  INSERT INTO troute VALUES(  'R','A',90)
	  INSERT INTO troute VALUES(  'U','J',400)
	  INSERT INTO troute VALUES(  'U','A',540)
	  
 INSERT INTO troute VALUES('Jaipur'	,'Alwar'	,160 , 8)
 INSERT INTO troute VALUES('Jaipur'	,'Udaipur'	,400 ,10)
 INSERT INTO troute VALUES('Jaipur'	,'Neemrana'	,150 ,12)
 INSERT INTO troute VALUES('Jaipur'	,'Rewari'	,190, 5)
 INSERT INTO troute VALUES('Rewari'	,'Jaipur'	,190,6)
 INSERT INTO troute VALUES('Rewari'	,'Alwar'	,90 ,7)
 INSERT INTO troute VALUES('Rewari'	,'Udaipur'	,580 ,4)
 INSERT INTO troute VALUES('Rewari'	,'Neemrana'	,50,5)
 INSERT INTO troute VALUES('Neemrana','Rewari'	,50,3)
 INSERT INTO troute VALUES('Neemrana','Jaipur'	,150,10)
 INSERT INTO troute VALUES('Neemrana','Alwar'	,80,4)
 INSERT INTO troute VALUES('Neemrana','Udaipur'	,540,12)
 INSERT INTO troute VALUES('Udaipur','Neemrana' ,540,10)
 INSERT INTO troute VALUES('Udaipur','Rewari'	,580,3)
 INSERT INTO troute VALUES('Udaipur','Jaipur'	,400,4)
 INSERT INTO troute VALUES('Udaipur','Alwar'	,540,12)
 INSERT INTO troute VALUES('Alwar'	,'Udaipur'	,540,8)
 INSERT INTO troute VALUES('Alwar'	,'Neemrana' ,80,9)
 INSERT INTO troute VALUES('Alwar'	,'Rewari'	,90,5)
 INSERT INTO troute VALUES('Alwar'	,'Jaipur'	,160,8)




DECLARE @x varCHAR(25)= 'Jaipur';
DECLARE @y varCHAR(25)= 'Neemrana';

WITH cte
     AS (
     SELECT CASE
                WHEN origin = @x
                THEN destination
                ELSE origin
            END destination,
            distance,
            CAST(RTRIM(CASE
                           WHEN origin = @x
                           THEN origin
                           ELSE destination
                       END) AS VARCHAR) AS rt
     FROM troute
     WHERE(origin = @x
           OR destination = @x)
     UNION ALL
     SELECT a.destination,
            a.distance + b.distance distance,
            CAST(RTRIM(b.rt)+'-'+a.origin AS VARCHAR) rt
     FROM troute a
          JOIN cte b ON a.origin = b.destination)
     SELECT id,
            destination,
            distance,
            RTRIM(rt)+'-'+RTRIM(@y)
     FROM
(
    SELECT ROW_NUMBER() OVER(ORDER BY distance) ID,
           *
    FROM cte
    WHERE destination = @y
) a
     WHERE a.ID = 1;

	  SELECT * FROM troute

-----------------------------------------------------------------------------------------------------------

	  with RoutesCTE as
(
    select CAST([origin] + '->' + [destination]  as nvarchar(max) ) as [Route]
          ,0 as TransfersCount
          ,[origin]
          ,[destination]
		  ,distance

    from troute

    union all

    select r.[Route] + '->' + r1.[destination] 
          ,TransfersCount + 1
          ,r.[origin]
          ,r1.[destination]
		  ,r.[distance]+r1.[distance] 
    from RoutesCTE r
        join troute r1
            on r.[destination] = r1.[origin]
                and r1.[destination] <> r.[origin] 
                  and PATINDEX('%'+r1.[destination]+'%', r.[Route]) = 0
)
select [Route],distance
from RoutesCTE 
where [origin] = 'Neemrana'
    and [destination] = 'Udaipur'

  --  and TransfersCount <= 2
ORDER BY 2 DESC

---------------------------------------------------------------------------------------

	  with RoutesCTE as
(
    select CAST([origin] + '->' + [destination]  as nvarchar(max) ) as [Route]
          ,0 as TransfersCount
          ,[origin]
          ,[destination]
		  ,distance
		  ,distance*supply as rev
		,supply 

    from troute

    union all

    select r.[Route] + '->' + r1.[destination]  
          ,TransfersCount + 1
          ,r.[origin]
          ,r1.[destination]
		  ,r.[distance]+r1.[distance] 
		  ,((rev)+(r1.[distance]*r1.supply) ) as rev
		  ,r.supply+ r1.supply
		  

    from RoutesCTE r
        join troute r1
            on r.[destination] = r1.[origin]
             and r1.[destination] <> r.[origin] 
                 and PATINDEX('%'+r1.[destination]+'%', r.[Route]) = 0



)
select [Route],distance,supply,(distance*5) as  cost,rev*10 as Revenue , (rev*10-distance*5) as profit
from RoutesCTE 
where [origin] = 'Udaipur'
    and [destination] = 'Neemrana'

  --  and TransfersCount <= 2
ORDER BY 2 ,6 DESC 

select * from troute
--------------------------------------------------------------

WITH CTE_SD
AS
(   SELECT  [origin],[destination] FROM troute WHERE [destination] = 'Jaipur'
    UNION ALL
    SELECT  troute.[origin],troute.[destination]
    FROM    troute
    INNER JOIN CTE_SD   ON  troute.[Destination]    =   CTE_SD.[origin]

)
SELECT * FROM CTE_SD ORDER BY [origin]








CREATE TABLE Graph (
   PA VARCHAR (25), 
   PB VARCHAR (25), 
   Distance INT,
   Supply INT
   ) 
GO
DROP TABLE Graph
SELECT * FROM Graph

 INSERT INTO Graph VALUES('Jaipur'	,'Alwar'	,160 , 8)
 INSERT INTO Graph VALUES('Jaipur'	,'Udaipur'	,400 ,10)
 INSERT INTO Graph VALUES('Jaipur'	,'Neemrana'	,150 ,12)
 INSERT INTO Graph VALUES('Jaipur'	,'Rewari'	,190, 5)
 INSERT INTO Graph VALUES('Rewari'	,'Jaipur'	,190,6)
 INSERT INTO Graph VALUES('Rewari'	,'Alwar'	,90 ,7)
 INSERT INTO Graph VALUES('Rewari'	,'Udaipur'	,580 ,4)
 INSERT INTO Graph VALUES('Rewari'	,'Neemrana'	,50,5)
 INSERT INTO Graph VALUES('Neemrana','Rewari'	,50,3)
 INSERT INTO Graph VALUES('Neemrana','Jaipur'	,150,10)
 INSERT INTO Graph VALUES('Neemrana','Alwar'	,80,4)
 INSERT INTO Graph VALUES('Neemrana','Udaipur'	,540,12)
 INSERT INTO Graph VALUES('Udaipur','Neemrana' ,540,10)
 INSERT INTO Graph VALUES('Udaipur','Rewari'	,580,3)
 INSERT INTO Graph VALUES('Udaipur','Jaipur'	,400,4)
 INSERT INTO Graph VALUES('Udaipur','Alwar'	,540,12)
 INSERT INTO Graph VALUES('Alwar'	,'Udaipur'	,540,8)
 INSERT INTO Graph VALUES('Alwar'	,'Neemrana' ,80,9)
 INSERT INTO Graph VALUES('Alwar'	,'Rewari'	,90,5)
 INSERT INTO Graph VALUES('Alwar'	,'Jaipur'	,160,8)

ALTER PROCEDURE dbo.usp_FindShortestGraphPath (@strt VARCHAR (25), @end VARCHAR (25))
AS
BEGIN
   SET NOCOUNT ON;
   WITH CommonTableExp1
   AS (SELECT PB,
         CASE 
            WHEN PA IS NULL
               THEN CAST ('-' + ISNULL (PA, PB) + '-' AS VARCHAR (MAX))
            WHEN PA IS NOT NULL
               THEN CAST ('-' + PA + '-' + PB + '-' AS VARCHAR (MAX))
            END FullPath,
         Distance TotalDistance
      FROM Graph
      WHERE (PA = @strt)
      UNION ALL
      SELECT a.PB,
         c.FullPath + '-' + a.PB + '-' FullPath,
         TotalDistance + a.Distance TotDistance
      FROM Graph a, CommonTableExp1 c
      WHERE a.PA = c.PB
      ),
   CommonTableExp2
   AS (SELECT *, RANK () OVER (ORDER BY TotalDistance) TheRank
      FROM CommonTableExp1
      WHERE PB = @end AND PATINDEX ('%' + @end + '%', FullPath) > 0)
   SELECT FullPath, TotalDistance
   FROM CommonTableExp2
   WHERE TheRank = 1;
   SET NOCOUNT OFF
END
GO			

usp_FindShortestGraphPath 'Jaipur','Neemrana'