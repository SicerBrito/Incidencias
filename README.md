# Configuracion NetCore

## Documentacion

Proyecto NetCore
 - Core : Esta carpeta contendrá todas las clases entidades e interfaces del
project.
 - Infrastructure : esa carpeta va a contener todo lo relacionado con el acceso de
datos, los repositorios y las unidades de trabajo.
 - Api: esta carpeta guardará el proyecto donde crearemos las diferentes apis o
Endpoints para ser consumidos por las aplicaciones externas.



**Comandos utilizados para la creacion de mi proyecto (La estructura o Base del proyecto)**

```Terminal
1. dotnet tool install --global dotnet-ef                                                               ---> instala la herramienta "dotnet-ef" globalmente para trabajar con Entity Framework Core.

2. dotnet tool list -g                                                                                  ---> Lista las herramientas globales instaladas en .NET.

3. dotnet new sln                                                                                       ---> Crea una nueva solución de .NET.
---(Una solución (.sln) se refiere a un archivo que actúa como un contenedor para organizar y administrar proyectos relacionados en un entorno de desarrollo de .NET)


4. dotnet new webapi -o API                                                                             ---> Crea un nuevo proyecto de API web en la carpeta "API".

5. dotnet sln add API/                                                                                  ---> Agrega el proyecto "API" a la solución.

6. dotnet new classlib -o Core                                                                          ---> Crea un nuevo proyecto de biblioteca de clases en la carpeta "Core".

7. dotnet new classlib -o Infrastructure                                                                ---> Crea un nuevo proyecto de biblioteca de clases en la carpeta "Infrastructure".

8. dotnet sln add Core/                                                                                 ---> Agrega el proyecto "Core" a la solución.

9. dotnet sln add Infrastructure/                                                                       ---> Agrega el proyecto "Infrastructure" a la solución.


10. cd Infrastructure/
    - dotnet add reference ../Core/                                                                     ---> Agrega una referencia al proyecto "Core" desde el proyecto "Infrastructure".


12. cd API/
    - dotnet add reference ../Infrastructure/                                                           ---> Agrega una referencia al proyecto "Infrastructure" desde el proyecto "API".


13. cd Infrastructure/
    - dotnet add package Microsoft.EntityFrameworkCore --version 7.0.9                                  ---> Agrega el paquete de Entity Framework Core versión 7.0.9 al proyecto "Infrastructure".
    - dotnet add package Pomelo.EntityFrameworkCore.MySql --version 7.0.0                               ---> Agrega el paquete de Entity Framework Core para MySQL versión 7.0.0 al proyecto "Infrastructure".


14. cd API/
    - dotnet add package Microsoft.EntityFrameworkCore.Design --version 7.0.8                           ---> Agrega el paquete de diseño de Entity Framework Core versión 7.0.8 al proyecto "API".
    - dotnet add package AutoMapper.Extensions.Microsoft.DependencyInjection --version 12.0.1           ---> Se utiliza para agregar el paquete de AutoMapper.Extensions.Microsoft.DependencyInjection en su versión 12.0.1 a un proyecto de .NET.



```

---
>ESTO ES IMPORTANTE
> - **Migrations** (Se deben utilizar estos comandos para poder aplicar las migraciones y que los cambios se guarden en la base de datos)
>   - dotnet ef migrations add InitialCreate --project ./Infrastructure/ --startup-project ./API/ --output-dir ./Data/Migrations
>   - dotnet ef database update --project ./Infrastructure/ --startup-project ./API/
> - **Errores** (Ambos comandos se utilizan para construir (compilar) los proyectos "Infrastructure" y "API" en sus respectivos directorios y tambien los podemos utilizar para ver que posibles errores podemos tener.)
>   - dotnet build ./Infrastructure/
>   - dotnet build ./API/




