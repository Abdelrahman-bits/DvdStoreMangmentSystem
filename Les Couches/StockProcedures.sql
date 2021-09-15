CREATE PROCEDURE AjouterPersonne
 @ID int OUTPUT,
 @NOM varchar(30),
 @PRE varchar(30),
 @NAI datetime
AS
 INSERT INTO Personne(NOM,PRE,NAI)
  VALUES(@NOM,@PRE,@NAI)
 SET @ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierPersonne
 @ID int,
 @NOM varchar(30),
 @PRE varchar(30),
 @NAI datetime
AS
 IF(@ID IS NULL OR @ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE Personne
        SET NOM=@NOM,PRE=@PRE,NAI=@NAI
        WHERE ID=@ID
RETURN
GO
CREATE PROCEDURE SelectionnerPersonne
 @Index VARCHAR(10)
AS
 IF(@Index='NOM') SELECT * FROM Personne ORDER BY NOM
 ELSE IF(@Index='PRE') SELECT * FROM Personne ORDER BY PRE
 ELSE IF(@Index='NAI') SELECT * FROM Personne ORDER BY NAI
 ELSE SELECT * FROM Personne ORDER BY ID
RETURN
GO
CREATE PROCEDURE SelectionnerPersonne_ID
 @ID int
AS
 IF(@ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT ID,NOM,PRE,NAI
  FROM Personne
  WHERE @ID=ID
RETURN
GO
CREATE PROCEDURE SupprimerPersonne
 @ID int
AS
 IF(@ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM Personne WHERE @ID=ID
RETURN
GO
