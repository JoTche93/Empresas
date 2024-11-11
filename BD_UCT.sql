
USE [BD_UCT]
GO
/****** Object:  Table [dbo].[USUARIO]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE TABLE [dbo].[USUARIO](
	[USU_RUT] [int] NOT NULL,
	[USU_DV] [varchar](1) NOT NULL,
	[USU_NOMBRE] [varchar](100) NOT NULL,
	[USU_APELLIDO] [varchar](100) NOT NULL,
	[USU_DIRECCION] [varchar](100) NOT NULL,
	[USU_PASS] [varchar](50) NOT NULL,
 CONSTRAINT [PK_USUARIO] PRIMARY KEY CLUSTERED 
(
	[USU_RUT] ASC
)WITH (PAD_INDEX = OFF, STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON, OPTIMIZE_FOR_SEQUENTIAL_KEY = OFF) ON [PRIMARY]
) ON [PRIMARY]
GO
/****** Object:  StoredProcedure [dbo].[EditarUsuario]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EditarUsuario]
@P_USU_RUT INT,
@P_USU_DV VARCHAR(1),
@P_USU_NOMBRE VARCHAR(100),
@P_USU_APELLIDO VARCHAR(100),
@P_USU_DIRECCION VARCHAR(100),
@P_USU_PASS VARCHAR(50)
AS
BEGIN
UPDATE dbo.USUARIO SET
USU_RUT = @P_USU_RUT,
USU_DV = @P_USU_DV,
USU_NOMBRE = @P_USU_NOMBRE,
USU_APELLIDO = @P_USU_APELLIDO,
USU_DIRECCION = @P_USU_DIRECCION,
USU_PASS = @P_USU_PASS
WHERE
USU_RUT = @P_USU_RUT
END
GO
/****** Object:  StoredProcedure [dbo].[EliminarUsuario]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[EliminarUsuario]
@P_USU_RUT INT
AS
BEGIN
DELETE FROM dbo.USUARIO
WHERE
USU_RUT = @P_USU_RUT
END
GO
/****** Object:  StoredProcedure [dbo].[ListarUsuario]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[ListarUsuario]
@P_USU_RUT INT
AS
BEGIN
SELECT USU_RUT,
USU_DV,
USU_NOMBRE,
USU_APELLIDO,
USU_DIRECCION,
USU_PASS
FROM DBO.USUARIO
WHERE
(@P_USU_RUT = -1 OR USU_RUT = @P_USU_RUT)
END
GO
/****** Object:  StoredProcedure [dbo].[LoginUsuario]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[LoginUsuario]
@P_USU_RUT INT,
@P_USU_PASS VARCHAR(50)
AS
BEGIN
SELECT USU_RUT,
USU_DV,
USU_NOMBRE,
USU_APELLIDO,
USU_DIRECCION,
USU_PASS
FROM DBO.USUARIO
WHERE
USU_RUT = @P_USU_RUT
AND USU_PASS = @P_USU_PASS
END
GO
/****** Object:  StoredProcedure [dbo].[RegistroUsuario]    Script Date: 07-11-2024 11:54:53 ******/
SET ANSI_NULLS ON
GO
SET QUOTED_IDENTIFIER ON
GO
CREATE procedure [dbo].[RegistroUsuario]
@P_USU_RUT INT,
@P_USU_DV VARCHAR(1),
@P_USU_NOMBRE VARCHAR(100),
@P_USU_APELLIDO VARCHAR(100),
@P_USU_DIRECCION VARCHAR(100),
@P_USU_PASS VARCHAR(50)
AS
BEGIN
INSERT INTO dbo.USUARIO
(USU_RUT,
USU_DV,
USU_NOMBRE,
USU_APELLIDO,
USU_DIRECCION,
USU_PASS)
VALUES
(@P_USU_RUT,
@P_USU_DV,
@P_USU_NOMBRE,
@P_USU_APELLIDO,
@P_USU_DIRECCION,
@P_USU_PASS
)
END
GO
USE [master]
GO
ALTER DATABASE [BD_UCT] SET  READ_WRITE 
GO
