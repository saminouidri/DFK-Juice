@echo off

gcc -o run M:\helloworld\main.c

run.exe

set /p DUMMY=Hit ENTER to continue...

del run.exe