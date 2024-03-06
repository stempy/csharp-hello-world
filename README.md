# csharp-hello-world
To demonstrate .NET8 hello world native aot

## Build

```sh
# build only
dotnet build
# OR run
dotnet run

```

## Build AOT exe

```sh
dotnet publish
dir bin\Release\net8.0\win-x64\publish

Mode                 LastWriteTime         Length Name
----                 -------------         ------ ----
-a----         6/03/2024  11:04 PM        1244160 csharp-helloworld-native-aot.exe
-a----         6/03/2024  11:04 PM        7057408 csharp-helloworld-native-aot.pdb

# 1.2mb EXE native binary (win11) with no runtime dependencies
```