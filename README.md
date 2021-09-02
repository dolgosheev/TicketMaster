# TicketMaster (web api req,req)
<p style="color:red;font-weight:bold;padding:10px;">app is .net5 dependent</p>

```text
dotnet build TicketMaster/TicketMaster.csproj -c Release

cd TicketMaster/bin/Release/net5.0/publish/
```
call exe File or exec with dotnet support

```text
dotnet TicketMaster.dll
```

If you device is MacOs, you should build like this

```text
dotnet build TicketMaster/TicketMaster.csproj -c Release --arch osx-x64
```

then just allow file execute and call it

```text
cd TicketMaster/bin/Release/net5.0/publish/

chmod +x TicketMaster.dll

./TicketMaster
```

* (Minimum OS version is macOS 10.12 Sierra)

ALL SETTING Into file Settings.cs
    
```text
public static string ApiKey { get; } = "<YOU API KEY>";

// example request
public static string Additionalfilters { get; set; } = "keyword=football";
```