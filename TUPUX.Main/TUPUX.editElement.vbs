Dim oShell


Set oShell = CreateObject ("WSCript.shell")
'WScript.Echo (oShell.CurrentDirectory)

strPath = oShell.CurrentDirectory

strPath =  """" & strPath & "\TUPUX.Main.exe"" 5"

'WScript.Echo (strPath)

oShell.run(strPath)
Set oShell = Nothing
