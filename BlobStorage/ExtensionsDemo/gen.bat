@echo off
del /S /F /Q %1\generated-client
C:\work\autorest\src\core\AutoRest\bin\Debug\net451\win7-x64\AutoRest.exe -Input %1\blob-storage.yaml -CodeGenerator Azure.CSharp -SkipValidation -OutputDirectory %1\generated-client