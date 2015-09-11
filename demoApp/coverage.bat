.\packages\OpenCover.4.6.166\tools\OpenCover.Console.exe -register:user "-filter:+[UnitTestProject1]* -[*Test]*" "-target:.\packages\NUnit.Runners.2.6.4\tools\nunit-console-x86.exe" "-targetargs:/noshadow .\UnitTestProject1\bin\Debug\UnitTestProject1.dll"

.\packages\ReportGenerator.2.3.1.0\tools\ReportGenerator.exe "-reports:results.xml" "-targetdir:.\coverage"

pause