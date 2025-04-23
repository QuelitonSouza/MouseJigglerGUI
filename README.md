# 🖱️ Mouse Jiggler GUI

Uma aplicação em Windows Forms desenvolvida em C# para manter seu computador ativo de forma discreta e configurável. Ideal para evitar bloqueio de tela, suspensão automática e status de inatividade em aplicativos como Teams ou Slack.

---

## 🎯 Objetivo

Simula movimentações do mouse de forma real ou virtual para evitar que o sistema entre em repouso ou bloqueie a tela por inatividade, sem interferir no uso do usuário.

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

---

## 📦 Instalação

1. Clone ou baixe o repositório:
   ```bash
   git clone https://github.com/QuelitonSouza/MouseJigglerGUI.git
   ```
2. Abra o projeto no **Visual Studio**.
3. Compile em modo **Release**.
4. Opcional: gere um instalador usando [Inno Setup](https://jrsoftware.org/isinfo.php).

---

## 🚀 Uso

1. Execute o `MouseJigglerGUI.exe`.
2. Configure o **tempo de inatividade** e selecione o modo desejado (real ou fantasma).
3. Clique em **Iniciar**.
4. O app rodará em segundo plano, com controle via ícone da bandeja.

---

## 📂 Configurações Salvas

As seguintes preferências são armazenadas automaticamente:
- Intervalo (segundos)
- Modo Fantasma ativado ou não
- Início automático com o Windows

---

## 🧱 Tecnologias utilizadas

- C#
- .NET Framework (Windows Forms)
- API Win32: `SetCursorPos`, `SendInput`, `SetThreadExecutionState`

---

## 🖼️ Screenshot

![Mouse Jiggler UI](./screenshot.png)

---

## 📄 Licença

Este projeto está licenciado sob a licença MIT. Veja o arquivo [LICENSE](LICENSE) para mais detalhes.

---

## ✨ Créditos

Desenvolvido por Queliton — baseado na necessidade real de manter o sistema ativo sem interações manuais 😄

---

Se quiser, posso gerar esse arquivo `.md` como parte do projeto e criar uma versão com estrutura de pastas para GitHub (`src`, `assets`, `installer`, etc). Deseja que eu gere isso também?