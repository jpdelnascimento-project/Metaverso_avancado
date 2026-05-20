# Projeto: Metaverso Avançado - Sala de Treinamento Interativa
**Aluno:** João Paulo do Nascimento
## Curso de Web 3.0 - Residência em TIC

### 📋 Conceito do Projeto
O repositório **"Metaverso avançado"** contém uma experiência imersiva voltada para o ambiente corporativo: uma **Sala de Treinamento Virtual de Integração e RH**. O espaço foi projetado para simular um hub educacional dentro do Metaverso, contendo os seguintes elementos 3D:
* **Aparelho de TV Interativo:** Ponto central da experiência, simulando a tela onde o colaborador pode assistir aos treinamentos da empresa.
* **Sofá** e **Poltrona** (configurados como Prefabs): Áreas de acomodação para os avatares dos funcionários.
* **Mesa de Centro** e **Vaso de Planta** decorativo para ambientação do espaço.

---

### 🕹️ Controles e Interação (Simulação PC)
* **Teclas WASD / Setas:** Movimentam o avatar livremente pela sala de treinamento.
* **Movimento do Mouse:** Gira a câmera para olhar ao redor do ambiente.
* **Clique do Mouse (Botão Esquerdo) na TV:** O usuário pode clicar diretamente na tela da TV para interagir, ligando-a (mudança de cor em tempo real para branco, simulando o início do vídeo de treinamento do RH) e desligando-a (retornando ao preto).

---

### 🛠️ Configurações Técnicas Implementadas
* **Plataforma VR:** Projeto ativo e configurado para a plataforma **Android (Meta Quest)** nas Build Settings.
* **Hierarquia:** Organizada rigorosamente com grupos lógicos (`_CENARIO` e `_OBJETOS_INTERATIVOS`) para manter uma nomenclatura clara.
* **Ambientação:** Uso de Skybox procedural para iluminação natural e renderização do céu.
* **Código C#:** Implementação dos controles de movimentação pelo New Input System e desenvolvimento do script `InteracaoTV.cs` para computar a mecânica de clique e alteração de material.

---

### 🧠 Processo de Criação e Dificuldades
O maior desafio deste módulo avançado foi a transição de um cenário estático para um ambiente corporativo funcional com interações em C#. Durante os testes de clique em primeira pessoa, a função de seleção apresentou falhas de alcance devido à distância inicial do avatar.

**Solução:** O problema foi resolvido fisicamente no Unity Editor através do redimensionamento do componente `Box Collider` da TV (eixo Z). O aumento desse volume de colisão permitiu que o colaborador consiga clicar e ativar o treinamento de RH mesmo estando a uma distância confortável na sala, garantindo uma experiência de usuário fluida e sem bugs de navegação.
