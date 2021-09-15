CREATE PROCEDURE AjouterLocation
 @Loc_ID int OUTPUT,
 @Loc_DateDeLocation date,
 @Cust_ID int
AS
 INSERT INTO Location(Loc_DateDeLocation,Cust_ID)
  VALUES(@Loc_DateDeLocation,@Cust_ID)
 SET @Loc_ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierLocation
 @Loc_ID int,
 @Loc_DateDeLocation date,
 @Cust_ID int
AS
 IF(@Loc_ID IS NULL OR @Loc_ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE Location
        SET Loc_DateDeLocation=@Loc_DateDeLocation,Cust_ID=@Cust_ID
        WHERE Loc_ID=@Loc_ID
RETURN
GO
CREATE PROCEDURE SelectionnerLocation
 @Index VARCHAR(10)
AS
 IF(@Index='Loc_DateDeLocation') SELECT * FROM Location ORDER BY Loc_DateDeLocation
 ELSE IF(@Index='Cust_ID') SELECT * FROM Location ORDER BY Cust_ID
 ELSE SELECT * FROM Location ORDER BY Loc_ID
RETURN
GO
CREATE PROCEDURE SelectionnerLocation_ID
 @Loc_ID int
AS
 IF(@Loc_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT Loc_ID,Loc_DateDeLocation,Cust_ID
  FROM Location
  WHERE @Loc_ID=Loc_ID
RETURN
GO
CREATE PROCEDURE SupprimerLocation
 @Loc_ID int
AS
 IF(@Loc_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM Location WHERE @Loc_ID=Loc_ID
RETURN
GO
