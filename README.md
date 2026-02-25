<p align="center">
  <img src="[SynqPlataform
/Properties/LOGO.png](https://raw.githubusercontent.com/SabriMelo/SynqPlataform/refs/heads/main/SynqPlataform/Properties/LOGO.png)" alt="Logo" width="250"/>
</p>

<h1 align="center">Synq Platform</h1>

O **Synq Platform** é um sistema de gestão e produtividade desenvolvido especificamente para escritórios de arquitetura. Ele centraliza o controle de clientes, projetos e equipes, e traz como grande diferencial um **Rastreador Automático de Horas (Background Tracker)** que monitora e contabiliza o tempo de trabalho da equipe nos softwares de arquitetura (CAD, SketchUp, Revit, etc.) de forma totalmente transparente e invisível.

---

## ✨ Principais Funcionalidades

### 1. Rastreador de Produtividade Invisível (O "Espião")
* **Captura Automática:** O sistema roda na bandeja do sistema (System Tray) e lê o título da janela ativa do Windows para identificar em qual projeto e etapa o colaborador está trabalhando.
* **Filtro Inteligente:** Ignora janelas irrelevantes (navegadores, WhatsApp, pastas) e foca apenas nos softwares de projeto. Remove automaticamente diretórios extensos gerados pelo ZWCAD/AutoCAD.
* **Detector de Ociosidade:** Se o usuário ficar mais de 5 minutos (300 segundos) sem mexer o mouse ou o teclado, o rastreador pausa a contagem automaticamente para garantir a precisão das horas reais trabalhadas.

### 2. Gestão de Projetos e Clientes
* **Cadastro Completo:** Gerenciamento de Clientes (PF/PJ, contatos, endereços) e Projetos (Metragem, Valor de Contrato, Status).
* **Códigos Elásticos Automáticos:** Geração automática e inteligente de códigos de projeto no banco de dados (ex: `001`, `045`, `1050`).
* **Equipes e Obras:** Vinculação de projetos a equipes responsáveis e registro de acompanhamento de obras.

### 3. Dashboard Interativo (LiveCharts)
* Visão em tempo real da saúde do escritório.
* Gráficos de barra com o TOP 5 projetos que mais consomem horas.
* Gráfico de evolução anual e mensal de horas trabalhadas da equipe.
* Gráfico de pizza com o funil de status dos projetos (Estudo Preliminar, Finalizado, etc.).

### 4. Segurança e Controle de Acesso
* Níveis de permissão rigorosos: Cargos de "Sócio" ou "Administrador" têm visão global, enquanto colaboradores veem apenas os projetos de suas respectivas equipes.
* Login inteligente com integração ao Registro do Windows para a função "Lembrar de mim".
* Inicialização automática junto com o Windows.

---

## 🛠️ Tecnologias Utilizadas

* **Linguagem:** C# (.NET Framework / WinForms)
* **Banco de Dados:** Microsoft SQL Server (Mapeamento de tabelas via `Microsoft.Data.SqlClient`)
* **Gráficos:** LiveCharts2 (SkiaSharp)
* **Integração com SO:** Windows API (`user32.dll` para hooks de janelas ativas e tempo ocioso, `Microsoft.Win32` para manipulação de registros).

---

## ⚠️ Regra de Ouro: Nomenclatura de Arquivos

Para que o **Rastreador Automático** consiga computar as horas corretamente no banco de dados, é **obrigatório** que a equipe de arquitetura salve os arquivos (DWG, SKP, RVT) seguindo o padrão oficial do escritório. 

O sistema procura o **Código do Projeto** antes do primeiro traço (`-`) e busca uma **Categoria Válida** no restante do nome.

**✅ Padrão Aceito:**
`[CÓDIGO] - [SIGLA] - [NOME DO CLIENTE] - [CATEGORIA] - [REVISÃO]`

**Exemplos Corretos:**
* `001 - RD - CLINICA BETA - MARCENARIA - R00.dwg`
* `042 - RES - FAMILIA SILVA - LAYOUT - R02.skp`
* `105 - COM - LOJA SHOPPING - 3D.rvt`

**Categorias Válidas no Sistema:**
`MARCENARIA`, `OBRA`, `LAYOUT`, `3D`, `DETALHES`, `PROJETO LEGAL`, `DOCUMENTOS`, `LEVANTAMENTO`, `APRESENTAÇÃO`.

---

## 🚀 Como Executar o Projeto

1. Clone este repositório.
2. Restaure os pacotes NuGet (especialmente o `LiveChartsCore.SkiaSharpView.WinForms` e `Microsoft.Data.SqlClient`).
3. Configure a sua String de Conexão no arquivo `BancoConfig.cs` apontando para o seu servidor SQL Server.
4. O banco de dados exige a criação de tabelas e a rotina da coluna computada para os Códigos de Projeto.
5. Compile o projeto em modo **Release**.

---

Este ERP foi desenhado para eliminar o microgerenciamento. A equipe foca em projetar, e o Synq foca em gerenciar o tempo.
