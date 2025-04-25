# 🖱️ Mouse Jiggler GUI

Uma aplicação em Windows Forms desenvolvida em C# para manter seu computador ativo de forma discreta e configurável. Ideal para evitar bloqueio de tela, suspensão automática e status de inatividade em aplicativos como Teams ou Slack.

---

## 🎯 Objetivo

Simula movimentações do mouse de forma real ou virtual para evitar que o sistema entre em repouso ou bloqueie a tela por inatividade, sem interferir no uso do usuário. Agora também permite agendar o desligamento automático do sistema.

---

## 🛠️ Recursos

- ✅ Modo **Real**: movimenta fisicamente o ponteiro do mouse.
- ✅ Modo **Fantasma (Virtual)**: simula movimentação sem alterar a posição do ponteiro.
- ⏱️ Intervalo configurável entre movimentações.
- 🖥️ Minimiza automaticamente para a **System Tray**.
- 🔁 Inicia automaticamente com o Windows (opcional).
- 💾 Salva configurações automaticamente.
- 🧠 Só começa a agir após um período de **inatividade do mouse**.
- ☑️ Ícone na bandeja com menu: Mostrar, Iniciar/Parar, Alternar Modo, Sair.
- 🔌 **Novo**: Agendamento de desligamento automático do Windows
  - Defina em quantos minutos o sistema será desligado
  - Cancelamento com um clique
  - Verificação automática se há desligamento agendado
  - Feedback claro com hora programada e status

---

## 📦 Instalação

✅ **Download rápido:**  
Baixe a última versão compilada em [Releases](https://github.com/QuelitonSouza/MouseJigglerGUI/releases/tag/Latest)

[![Download](https://img.shields.io/github/v/release/QuelitonSouza/MouseJigglerGUI?label=Baixar%20Última%20Versão)](https://github.com/QuelitonSouza/MouseJigglerGUI/releases/latest)

### Instalação manual (compilando o projeto)

1. Clone ou baixe o repositório:
   ```bash
   git clone https://github.com/QuelitonSouza/MouseJigglerGUI.git
   ```
2. Abra o projeto no **Visual Studio**.
3. Compile em modo **Release**.
4. (Opcional) Gere um instalador usando [Inno Setup](https://jrsoftware.org/isinfo.php).

---

Se quiser, posso atualizar todo o `README.md` com esse botão e te devolver o arquivo final. Quer que eu gere isso?

---

## 🚀 Uso

1. Execute o `MouseJigglerGUI.exe`.
2. Configure o **tempo de inatividade** e selecione o modo desejado (real ou fantasma).
3. (Opcional) Programe o desligamento do sistema após um tempo definido.
4. Clique em **Iniciar**.
5. O app rodará em segundo plano, com controle via ícone da bandeja.

---

## 📂 Configurações Salvas

As seguintes preferências são armazenadas automaticamente:
- Intervalo (segundos)
- Modo Fantasma ativado ou não
- Início automático com o Windows
- Tempo de inatividade
- Último modo selecionado
- Status do agendamento de desligamento (em breve)

---

## 🧱 Tecnologias utilizadas

- C#
- .NET Framework (Windows Forms)
- API Win32: `SetCursorPos`, `SendInput`, `SetThreadExecutionState`, `shutdown.exe`

---

## 🖼️ Screenshot

![Mouse Jiggler UI](/MouseJigglerGUI/screenshot.png)

---

## 📄 Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## ✨ Créditos

Desenvolvido por Queliton — baseado na necessidade real de manter o sistema ativo sem interações manuais 😄

---