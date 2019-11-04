# Lamasti_Botte

![LamastiBotte Logo](https://github.com/tatayoyoo/Lamasti_Botte/blob/lamaDev/Ressources/LamastiBotte_Logo.png)

Développement d'une application donnant l’impression d’un chat avec une IA.
L’application apprendra de nouvelles réponses au fur à mesure des discussions. La base de
questions/réponses devra être persistante, c’est à dire que la dernière session de questions/réponses
doit pouvoir être rechargée à chaque démarrage de l’application.

## Overview
```bash
.
├── LamastiBotte
│   ├── LamastiBotte.Core
│   │   ├── App.config
│   │   ├── LamastiBotte.Core.csproj
│   │   ├── packages.config
│   │   ├── Program.cs
│   │   ├── Properties
│   │   │   ├── AssemblyInfo.cs
│   │   │   ├── Resources.Designer.cs
│   │   │   └── Resources.resx
│   │   ├── Ressources
│   │   │   ├── LamastiBotte_Logo.ico
│   │   │   ├── LamastiBotte_Logo.png
│   │   │   └── Thumbs.db
│   │   ├── Service
│   │   │   ├── DataBaseToolService.cs
│   │   │   ├── LogHelperService.cs
│   │   │   ├── QuestionService.cs
│   │   │   └── ServiceTool.cs
│   │   └── Vue
│   │       ├── Accueil.cs
│   │       ├── Accueil.Designer.cs
│   │       ├── Accueil.resx
│   │       ├── ChatBot.cs
│   │       ├── ChatBot.Designer.cs
│   │       └── ChatBot.resx
│   ├── LamastiBotte.Core.Test
│   │   ├── ControllerTest
│   │   │   ├── QuestionServiceTest.cs
│   │   │   └── ServiceToolTest.cs
│   │   └── LamastiBotte.Core.Test.csproj
│   ├── LamastiBotte.DataBase
│   │   ├── Conversation.sql
│   │   ├── LamastiBotte.DataBase.publish.xml
│   │   ├── LamastiBotte.DataBase.sqlproj
│   │   ├── Question.sql
│   │   ├── Reponse.sql
│   │   └── Script
│   │       └── DefaultData.PreDeployment.sql
│   ├── LamastiBotte.sln
│   └── packages
│       ├── EntityFramework.6.2.0
│       │   ├── Content
│       │   │   └── net40
│       │   │       ├── App.config.transform
│       │   │       └── Web.config.transform
│       │   ├── EntityFramework.6.2.0.nupkg
│       │   ├── lib
│       │   │   ├── net40
│       │   │   │   ├── EntityFramework.dll
│       │   │   │   ├── EntityFramework.SqlServer.dll
│       │   │   │   ├── EntityFramework.SqlServer.xml
│       │   │   │   ├── EntityFramework.xml
│       │   │   │   └── fr
│       │   │   │       ├── EntityFramework.resources.dll
│       │   │   │       ├── EntityFramework.SqlServer.resources.dll
│       │   │   │       ├── EntityFramework.SqlServer.xml
│       │   │   │       └── EntityFramework.xml
│       │   │   └── net45
│       │   │       ├── EntityFramework.dll
│       │   │       ├── EntityFramework.SqlServer.dll
│       │   │       ├── EntityFramework.SqlServer.xml
│       │   │       ├── EntityFramework.xml
│       │   │       └── fr
│       │   │           ├── EntityFramework.resources.dll
│       │   │           ├── EntityFramework.SqlServer.resources.dll
│       │   │           ├── EntityFramework.SqlServer.xml
│       │   │           └── EntityFramework.xml
│       │   └── tools
│       │       ├── about_EntityFramework.help.txt
│       │       ├── EntityFramework.PowerShell.dll
│       │       ├── EntityFramework.PowerShell.Utility.dll
│       │       ├── EntityFramework.psd1
│       │       ├── EntityFramework.psm1
│       │       ├── init.ps1
│       │       ├── install.ps1
│       │       └── migrate.exe
│       ├── EntityFramework.fr.6.2.0
│       │   ├── EntityFramework.fr.6.2.0.nupkg
│       │   └── lib
│       │       ├── net40
│       │       │   └── fr
│       │       │       ├── EntityFramework.resources.dll
│       │       │       └── EntityFramework.xml
│       │       └── net45
│       │           └── fr
│       │               ├── EntityFramework.resources.dll
│       │               └── EntityFramework.xml
│       └── Syn.Speech.1.0.3
│           ├── lib
│           │   └── net45
│           │       └── Syn.Speech.dll
│           └── Syn.Speech.1.0.3.nupkg
├── README.md
└── test
```
