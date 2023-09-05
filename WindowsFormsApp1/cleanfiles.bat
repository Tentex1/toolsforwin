@echo off

del /q %SystemRoot%\Prefetch\*.*
rd /s /q C:\$Recycle.Bin
rmdir /s /q %temp%