# Servicio gRPC de ASP.NET Core CRUD con MSSQL y EF

Este proyecto demuestra cómo construir un servicio gRPC utilizando ASP.NET Core, Entity Framework (EF) y MSSQL para operaciones CRUD.

## Requisitos

- .NET 6.0 SDK o superior
- SQL Server

## Configuración

1. **Clonar el repositorio:**

    ```bash
    git clone https://github.com/InfoToolsSV/Servicio-gRPC-de-ASP.NET-Core-CRUD-MSSQL-EF.git
    cd Servicio-gRPC-de-ASP.NET-Core-CRUD-MSSQL-EF
    ```

2. **Configurar la base de datos:**

    Actualiza la cadena de conexión en `appsettings.json`:

    ```json
    "ConnectionStrings": {
        "DefaultConnection": "Server=your_server;Database=your_database;User Id=your_user;Password=your_password;"
    }
    ```

3. **Aplicar migraciones:**

    ```bash
    dotnet ef database update
    ```

## Ejecución del proyecto

1. **Construir el proyecto:**

    ```bash
    dotnet build
    ```

2. **Ejecutar el proyecto:**

    ```bash
    dotnet run
    ```

## Estructura del proyecto

- **Data:** Contiene el contexto de EF y las configuraciones de la base de datos.
- **Migrations:** Archivos generados por EF para las migraciones de la base de datos.
- **Models:** Las clases de modelo de datos.
- **Protos:** Archivos .proto para definir los servicios gRPC.
- **Services:** Implementaciones de los servicios gRPC.

## Uso

Una vez que el servicio esté en ejecución, puedes interactuar con él utilizando un cliente gRPC para realizar operaciones CRUD.

## Contribuciones

¡Las contribuciones son bienvenidas! Por favor, abre un issue o envía un pull request.

## Licencia

Este proyecto está licenciado bajo la Licencia MIT.
