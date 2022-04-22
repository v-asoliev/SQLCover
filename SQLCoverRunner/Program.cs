using System;
using System.Collections.Generic;
using System.IO;
using SQLCover;

namespace SQLCoverRunner
{
    class Program
    {
        static void Main(string[] args)
        {
            //var connStr = "Server=admindevsql.dqa.ebscopub.com;pwd=Amaz0n!2;uid=sa;database=EAMASTER_TESTS;Connection Lifetime=1200;";
            //var connStr = "server=192.168.0.104;pwd=MPar9chqICpxdmOfdLE9;uid=sa;database=EAMASTER_TESTS";
            var connStr = "server=localhost;pwd=soliev@ebsco.12;uid=sa;database=EAMASTER_TESTS";
            var dbName = "EAMASTER_TESTS";
            var query = "EXEC tsqlt.RunAll;";

            var codeCoverage = new CodeCoverage(connStr, dbName, new string[] {"Z(?i)test", "\\[Test .*" });  // regex
            
            var result = codeCoverage.Cover(query, 120);
            //var result = codeCoverage.Cover(query);  // for SQLCover.dll v0.0.2.0
            var report = result.Html();
            var xmlReport = result.OpenCoverXml();

            File.WriteAllText(".\\Coverage.html", report);
            File.WriteAllText(".\\XMLCoverage.xml", xmlReport);
        }
    }
}
