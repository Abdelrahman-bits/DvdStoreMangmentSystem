CREATE PROCEDURE AjouterCustomer
 @Cust_ID int OUTPUT,
 @Cust_Nom varchar(20),
 @Cust_PreNom varchar(20),
 @Cust_Tele varchar(50),
 @Cust_Email varchar(50),
 @Cust_CodePostal int,
 @Cust_Adresse varchar(50),
 @Cust_PassWord varchar(50)
AS
 INSERT INTO Customer(Cust_Nom,Cust_PreNom,Cust_Tele,Cust_Email,Cust_CodePostal,Cust_Adresse,Cust_PassWord)
  VALUES(@Cust_Nom,@Cust_PreNom,@Cust_Tele,@Cust_Email,@Cust_CodePostal,@Cust_Adresse,@Cust_PassWord)
 SET @Cust_ID=@@IDENTITY
RETURN
GO
CREATE PROCEDURE ModifierCustomer
 @Cust_ID int,
 @Cust_Nom varchar(20),
 @Cust_PreNom varchar(20),
 @Cust_Tele varchar(50),
 @Cust_Email varchar(50),
 @Cust_CodePostal int,
 @Cust_Adresse varchar(50),
 @Cust_PassWord varchar(50)
AS
 IF(@Cust_ID IS NULL OR @Cust_ID=0)
  RAISERROR('Identifiant requis !',16,1)
 ELSE  UPDATE Customer
        SET Cust_Nom=@Cust_Nom,Cust_PreNom=@Cust_PreNom,Cust_Tele=@Cust_Tele,Cust_Email=@Cust_Email,Cust_CodePostal=@Cust_CodePostal,Cust_Adresse=@Cust_Adresse,Cust_PassWord=@Cust_PassWord
        WHERE Cust_ID=@Cust_ID
RETURN
GO
CREATE PROCEDURE SelectionnerCustomer
 @Index VARCHAR(10)
AS
 IF(@Index='Cust_Nom') SELECT * FROM Customer ORDER BY Cust_Nom
 ELSE IF(@Index='Cust_PreNom') SELECT * FROM Customer ORDER BY Cust_PreNom
 ELSE IF(@Index='Cust_Tele') SELECT * FROM Customer ORDER BY Cust_Tele
 ELSE IF(@Index='Cust_Email') SELECT * FROM Customer ORDER BY Cust_Email
 ELSE IF(@Index='Cust_CodePostal') SELECT * FROM Customer ORDER BY Cust_CodePostal
 ELSE IF(@Index='Cust_Adresse') SELECT * FROM Customer ORDER BY Cust_Adresse
 ELSE IF(@Index='Cust_PassWord') SELECT * FROM Customer ORDER BY Cust_PassWord
 ELSE SELECT * FROM Customer ORDER BY Cust_ID
RETURN
GO
CREATE PROCEDURE SelectionnerCustomer_ID
 @Cust_ID int
AS
 IF(@Cust_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  SELECT Cust_ID,Cust_Nom,Cust_PreNom,Cust_Tele,Cust_Email,Cust_CodePostal,Cust_Adresse,Cust_PassWord
  FROM Customer
  WHERE @Cust_ID=Cust_ID
RETURN
GO
CREATE PROCEDURE SupprimerCustomer
 @Cust_ID int
AS
 IF(@Cust_ID IS NULL)
  RAISERROR('Identifiant requis !',16,1)
 ELSE
  DELETE FROM Customer WHERE @Cust_ID=Cust_ID
RETURN
GO
