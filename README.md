# EcoCardio
Aplicação para relatórios de Ecocardiogramas

![icon](/EcoCardio/EcoCardio.WinApp/Resources/ImgCustom/ecoCardio.ico)

## Application

Login Form

![Login](/Docs/App/01-Login.png)

Main Form

![MainForm](/Docs/App/02-MainForm.png)

Exame Form

![ExameForm](/Docs/App/03-ExameForm.png)

Report Form

![ReportForm](/Docs/App/04-ReportForm.png)

Templates Form

![TemplateForm](/Docs/App/05-TemplatesForm.png)

## Run with docker

1. Create a SQLServer database

```
> docker pull microsoft/mssql-server-linux:latest
> docker run -e ''ACCEPT_EULA=Y'' -e ''SA_PASSWORD=Adm1nP@ssw0rd'' --name mssql2 -p 1433:1433 -d microsoft/mssql-server-linux:latest
// server:   localhost
// user:     sa
// password: Adm1nP@ssw0rd
```

2. Add sample data

```sql
USE [EcoCardio]
INSERT [dbo].[Exame] ([CavidadesCardiacas], [Conclusao], [Data], [DiametroAorta], [DiametroAuriculaEsquerda], [DiametroParedePosterior], [DiametroSepto], [DiametroVETeleadiastole], [DiametroVETelessistole], [EspessuraParedesVentriculares], [EstruturasValvulares], [FracaoEjecao], [FracaoEncurtamento], [FuncaoVentricular], [Idade], [MassasIntracavitarias], [Nome], [Numero], [NumeroProcesso], [Observacao], [DataNascimento], [Email], [FirstName], [LastName], [Morada], [NumeroSNS], [Telefone], [Telemovel], [Genre], [InfoClinica], [Medico1], [Medico2], [Pericardio], [RequisitadoPor], [TransmissaoAcustica], [DiametroAortaAscendente], [DiametroAuriculaEsquerda1], [DiametroAuriculaEsquerda2], [DiametroFuncaoVd], [MassaVE]) VALUES (N'Texto00', N'Texto6', CAST(N'2020-07-09T22:39:56.760' AS DateTime), 12, 12, 12, 12, 12, 12, N'Texto111', N'Texto2', 12, NULL, N'Texto3', 30, N'Texto5', N'Miguel Pinto da Costa', 1, NULL, NULL, CAST(N'1990-07-09T22:48:23.000' AS DateTime), NULL, NULL, NULL, NULL, NULL, NULL, NULL, 1, N'asdasdasd123', N'Servico1', N'Servico2', N'Texto4', N'Servico3', N'TA1', 12, 12, 12, 12, 37.4)
INSERT [dbo].[Responsavel] ([Nome]) VALUES (N'Responsavel1')
INSERT [dbo].[Responsavel] ([Nome]) VALUES (N'Responsavel2')
INSERT [dbo].[Responsavel] ([Nome]) VALUES (N'Responsavel3')
INSERT [dbo].[Servico] ([Nome], [Tipo]) VALUES (N'Servico0', 0)
INSERT [dbo].[Servico] ([Nome], [Tipo]) VALUES (N'Servico1', 1)
INSERT [dbo].[Servico] ([Nome], [Tipo]) VALUES (N'Servico2', 2)
INSERT [dbo].[Servico] ([Nome], [Tipo]) VALUES (N'Servico3', 3)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome0', N'Texto0', 0)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome00', N'Texto00', 0)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome000', N'Texto000', 0)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome1', N'Texto1', 1)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome11', N'Texto11', 1)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome111', N'Texto111', 1)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome2', N'Texto2', 2)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome3', N'Texto3', 3)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome4', N'Texto4', 4)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nome5', N'Texto5', 5)
INSERT [dbo].[Template] ([Nome], [Texto], [Type]) VALUES (N'Nom36', N'Texto6', 6)
INSERT [dbo].[TransmissaoAcustica] ([Nome]) VALUES (N'TA1')
INSERT [dbo].[TransmissaoAcustica] ([Nome]) VALUES (N'TA2')
INSERT [dbo].[TransmissaoAcustica] ([Nome]) VALUES (N'TA3')
INSERT [dbo].[Utilizador] ([Nome], [Password], [Username], [Profile]) VALUES (N'ecocardio', N'ecocardio', N'ecocardio', 1)
```

3. Default login:

```
username: ecocardio
password: ecocardio
```

## CrsytalReports

```
SAP Crystal Reports, version for Visual Studio
    https://www.sap.com/cmp/td/sap-crystal-reports-visual-studio-trial.html

Crystal Reports, Developer for Visual Studio Downloads
    https://wiki.scn.sap.com/wiki/display/BOBJ/Crystal+Reports%2C+Developer+for+Visual+Studio+Downloads

CRforVS13SP27_0-10010309
    SAP Crystal Reports for Visual Studio (SP27) installation package for Microsoft Visual Studio IDE
    https://origin.softwaredownloads.sap.com/public/file/0020000000543482020

CR13SP27Redist32_0-10010309
    SAP Crystal Reports for Visual Studio (SP27) runtime (32-bit)
    https://origin.softwaredownloads.sap.com/public/file/0020000000543602020

CR13SP27Redist64_0-10010309
    SAP Crystal Reports for Visual Studio (SP27) runtime (64-bit)
    https://origin.softwaredownloads.sap.com/public/file/0020000000543632020

CR13SP27MSI32_0-10010309
    SAP Crystal Reports for Visual Studio (SP27) runtime engine for .NET framework MSI (32-bit)
    https://origin.softwaredownloads.sap.com/public/file/0020000000543412020

CR13SP27MSI64_0-10010309
    SAP Crystal Reports for Visual Studio (SP27) runtime engine for .NET framework MSI (64-bit)
    https://origin.softwaredownloads.sap.com/public/file/0020000000543422020

```
