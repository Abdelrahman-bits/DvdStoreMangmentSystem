CREATE PROCEDURE AjouterOrderLine
 @OL_ID int OUTPUT,
 @Loc_ID int,
 @Dvd_ID int,
 @OL_PrixTotal int,
 @OL_DatePourRetourner date
AS
 IF EXISTS(SELECT * FROM OrderLine WHERE Loc_ID=@Loc_ID)
  RAISERROR('Clé primaire existant !',16,1)
 ELSE INSERT INTO OrderLine(Loc_ID,Dvd_ID,OL_PrixTotal,OL_DatePourRetourner)
  VALUES(@Loc_ID,@Dvd_ID,@OL_PrixTotal,@OL_DatePourRetourner)
 SET @OL_ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierOrderLine
 @OL_ID int,
 @Loc_ID int,
 @Dvd_ID int,
 @OL_PrixTotal int,
 @OL_DatePourRetourner date
AS
 IF(@OL_ID IS NULL OR @OL_ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE 
 IF(@Loc_ID IS NULL OR @Loc_ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE OrderLine
        SET Dvd_ID=@Dvd_ID,OL_PrixTotal=@OL_PrixTotal,OL_DatePourRetourner=@OL_DatePourRetourner
        WHERE Loc_ID=@Loc_ID
RETURN
GO
CREATE PROCEDURE SelectionnerOrderLine
 @Index VARCHAR(10)
AS
 IF(@Index='Dvd_ID') SELECT * FROM OrderLine ORDER BY Dvd_ID
 ELSE IF(@Index='OL_PrixTotal') SELECT * FROM OrderLine ORDER BY OL_PrixTotal
 ELSE IF(@Index='OL_DatePourRetourner') SELECT * FROM OrderLine ORDER BY OL_DatePourRetourner
 ELSE SELECT * FROM OrderLine ORDER BY Loc_ID
RETURN
GO
CREATE PROCEDURE SelectionnerOrderLine_ID
 @OL_ID int
AS
 IF(@OL_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT OL_ID,Loc_ID,Dvd_ID,OL_PrixTotal,OL_DatePourRetourner
  FROM OrderLine
  WHERE @OL_ID=OL_ID
RETURN
GO
CREATE PROCEDURE SupprimerOrderLine
 @OL_ID int
AS
 IF(@OL_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM OrderLine WHERE @OL_ID=OL_ID
RETURN
GO
