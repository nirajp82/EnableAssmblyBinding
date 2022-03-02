# EnableAssmblyBinding


*. Path: Computer\HKEY_LOCAL_MACHINE\SOFTWARE\Microsoft\Fusion

*. EnableLog: 1

*. ForceLog: 1

*. LogFailures: 1

*. LogPath: C:\FusionLog\  Can be any valid path for ex. (Make sure you include the **backslash** after the folder name and that the **Folder exists.**)

*. LogResourceBinds: 1

![image](https://user-images.githubusercontent.com/61636643/156439372-ef1f9a63-cda0-4ec3-8c5b-9ec4fb716858.png)


Binding Redirect to Specific Location in config file.
```
 <dependentAssembly>
  <assemblyIdentity name="ServiceStack.Interfaces" culture="neutral" />
  <bindingRedirect oldVersion="5.9.0.0-5.9.0.0" newVersion="5.9.0.0" />
  <codeBase version="5.9.0.0" href="bin\ServiceStack.Standard.5.9.0\ServiceStack.Interfaces.dll" />
</dependentAssembly>
```
