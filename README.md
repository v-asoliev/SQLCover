# SQLCover

To the newly created db project add a database reference to  tSQLt.dacpack which is based on the V1.0.5873.27393 version of tSQLt framework.

https://github.com/GoEddie/SQLCover

https://the.agilesql.club/2016/04/sqlcover-code-coverage-for-sql-server-t-sql/

SQLCover can be integrated with the [ReportGenerator](https://github.com/danielpalme/ReportGenerator) tool which provides a great coverage visualization.

## SOME_DB_TESTS.PostDeployment.sql
```
EXEC sp_configure 'clr enabled', 1;
RECONFIGURE;
GO
 
ALTER DATABASE [$(DatabaseName)] SET TRUSTWORTHY ON;
GO
 
EXEC tSQLt.Ebsco_NewTestClass N'ZTest_Some_Stored_Procedure_To_Test';
GO
 
EXEC tSQLt.Ebsco_NewTestClass N'ZTest_Another_Stored_Procedure_To_Test';
GO
```