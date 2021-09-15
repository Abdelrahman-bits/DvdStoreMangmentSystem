CREATE PROCEDURE AjouterDVDs
 @Dvd_ID int OUTPUT,
 @Dvd_Nom varchar(20),
 @Dvd_Category varchar(20),
 @Dvd_NumberInStock int,
 @Dvd_Prix float,
 @Dvd_Realisateur varchar(20)
AS
 INSERT INTO DVDs(Dvd_Nom,Dvd_Category,Dvd_NumberInStock,Dvd_Prix,Dvd_Realisateur)
  VALUES(@Dvd_Nom,@Dvd_Category,@Dvd_NumberInStock,@Dvd_Prix,@Dvd_Realisateur)
 SET @Dvd_ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierDVDs
 @Dvd_ID int,
 @Dvd_Nom varchar(20),
 @Dvd_Category varchar(20),
 @Dvd_NumberInStock int,
 @Dvd_Prix float,
 @Dvd_Realisateur varchar(20)
AS
 IF(@Dvd_ID IS NULL OR @Dvd_ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE DVDs
        SET Dvd_Nom=@Dvd_Nom,Dvd_Category=@Dvd_Category,Dvd_NumberInStock=@Dvd_NumberInStock,Dvd_Prix=@Dvd_Prix,Dvd_Realisateur=@Dvd_Realisateur
        WHERE Dvd_ID=@Dvd_ID
RETURN
GO
CREATE PROCEDURE SelectionnerDVDs
 @Index VARCHAR(10)
AS
 IF(@Index='Dvd_Nom') SELECT * FROM DVDs ORDER BY Dvd_Nom
 ELSE IF(@Index='Dvd_Category') SELECT * FROM DVDs ORDER BY Dvd_Category
 ELSE IF(@Index='Dvd_NumberInStock') SELECT * FROM DVDs ORDER BY Dvd_NumberInStock
 ELSE IF(@Index='Dvd_Prix') SELECT * FROM DVDs ORDER BY Dvd_Prix
 ELSE IF(@Index='Dvd_Realisateur') SELECT * FROM DVDs ORDER BY Dvd_Realisateur
 ELSE SELECT * FROM DVDs ORDER BY Dvd_ID
RETURN
GO
CREATE PROCEDURE SelectionnerDVDs_ID
 @Dvd_ID int
AS
 IF(@Dvd_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT Dvd_ID,Dvd_Nom,Dvd_Category,Dvd_NumberInStock,Dvd_Prix,Dvd_Realisateur
  FROM DVDs
  WHERE @Dvd_ID=Dvd_ID
RETURN
GO
CREATE PROCEDURE SupprimerDVDs
 @Dvd_ID int
AS
 IF(@Dvd_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM DVDs WHERE @Dvd_ID=Dvd_ID
RETURN
GO
