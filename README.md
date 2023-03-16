Tecnologías utilizadas:

Backend: ASP.NET CORE (C#)
Frontend: REACT JS
Base de datos: SQL SERVER

PASO N° 1:
Creamos la base datos llamada "ChallengeBotones"

PASO N° 2:
Creamos la tabla 'Botones', aquí la instrucción:

create table Botones
(
idBoton int primary key identity (1,1),
contador int
)

PASO N° 3:
Introducir la cadena de conexión correspondiente a su conexión, en mi caso es la siguiente:
"Server=.\SQLEXPRESS;Database=ChallengeBotones;Trusted_Connection=True;TrustServerCertificate=True;" Microsoft.EntityFrameworkCore.SqlServer -OutputDir Models

// Modificar la parte de ".\SQLEXPRESS" según corresponda y el nombre de la base de datos 
// Esta cadena se encuentra en la carpeta "Models" --> "ChallengeBotonesContext.cs", línea 22.

Por último, instalar las dependencias (npm install)
- Clic secundario en "ClientApp" y presionar en "Abrir en terminal"
- Ejecutar npm install

*Ahora ya se puede compilar sin problemas*


