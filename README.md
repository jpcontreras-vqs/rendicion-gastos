# Sistema de Rendición de Gastos

Sistema web desarrollado con .NET Core, Entity Framework Core y SQL Server para gestionar rendiciones de gastos con flujo de aprobación multinivel.

## Características

- ✅ Registro de información personal del rendidor
- ✅ Gestión detallada de gastos por categorías
- ✅ Flujo de aprobación multinivel (Gerente, Auditor, Administrador)
- ✅ Carga de comprobantes y documentación
- ✅ Reportes y auditoría de cambios
- ✅ Notificaciones por correo electrónico
- ✅ Autenticación y autorización por roles

## Stack Tecnológico

- **Backend**: .NET Core 7.0+
- **ORM**: Entity Framework Core
- **Base de Datos**: SQL Server
- **Frontend**: ASP.NET MVC / Razor Pages
- **Autenticación**: ASP.NET Core Identity

## Estructura del Proyecto

```
rendicion-gastos/
├── src/
│   ├── ExpenseManagement.Domain/
│   ├── ExpenseManagement.Application/
│   ├── ExpenseManagement.Infrastructure/
│   ├── ExpenseManagement.Web/
├── tests/
├── docs/
└── README.md
```

## Requisitos Previos

- .NET Core 7.0 o superior
- SQL Server 2019+
- Visual Studio 2022

## Instalación

1. Clonar el repositorio
2. Restaurar dependencias: `dotnet restore`
3. Actualizar base de datos: `dotnet ef database update`
4. Ejecutar: `dotnet run`

## Licencia

© 2024 Ventisqueros TIC
