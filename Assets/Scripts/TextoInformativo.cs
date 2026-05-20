using UnityEngine;

public class TextoInformativo : MonoBehaviour
{
    void OnGUI()
    {
        GUIStyle estiloTexto = new GUIStyle();
        estiloTexto.fontSize = 22;
        estiloTexto.normal.textColor = Color.white;
        estiloTexto.alignment = TextAnchor.MiddleCenter;

        // Desenha o texto centralizado na parte inferior da tela
        Rect posicao = new Rect(Screen.width / 2 - 250, Screen.height - 80, 500, 40);
        GUI.Label(posicao, "Passe o mouse e clique na TV para interagir", estiloTexto);
    }
}