diskpart /s ./XPDeployDiskpartScript.txt
imagex.exe /apply E:\Acct_XP.wim 1 W:
bootsect.exe /nt52 W: /mbr /force