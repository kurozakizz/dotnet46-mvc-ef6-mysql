# .Net 4.6 MVC + Entity Framework 6 + MySQL
CRUD Entity Framework 6 with MySQL

## pre requisited software
- Install [MySQL for Visual Studio](https://dev.mysql.com/downloads/windows/visualstudio/1.2.html)
- Install [MySQL .NET Connector](https://dev.mysql.com/downloads/connector/net/)

## instruction
1. New >> Project >> **ASP.NET Web Application (.NET Framework)**
2. Choose **Empty** and choose **MVC**
3. Add References >> 
	- **EntityFramework**
	- Browse C:\Program Files (x86)\MySQL\MySQL Connector Net 6.9.9\Assemblies\v4.5, choose **MySql.Data.dll**, **MySql.Data.Entity.EF6.dll**, **MySql.Web.dll**
4. edit web.config
```
<entityFramework>
	<defaultConnectionFactory type="MySql.Data.Entity.MySqlConnectionFactory, MySql.Data.Entity.EF6" />
	<providers>
		<provider invariantName="MySql.Data.MySqlClient" type="MySql.Data.MySqlClient.MySqlProviderServices, MySql.Data.Entity.EF6" />
	</providers>
</entityFramework>
```

## references
- [MySQL In Asp.Net MVC CRUD Application Using Entity Framework](https://www.youtube.com/watch?v=Col_2RDI3_4)
- [Enable Entity Framework 6 for MySql (C#)](https://stackoverflow.com/questions/22031269/enable-entity-framework-6-for-mysql-c-in-winforms-of-microsoft-visual-studio)