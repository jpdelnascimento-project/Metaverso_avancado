using UnityEngine;
using UnityEngine.InputSystem;

public class InteracaoTV : MonoBehaviour
{
    private Renderer rendererTV;
    private bool ligada = false;

    void Start()
    {
        rendererTV = GetComponent<Renderer>();
    }

    // Esta função roda a cada frame em que a seta do mouse estiver em cima da TV
    void OnMouseOver()
    {
        // Checa se o botão esquerdo do mouse foi clicado neste frame
        if (Mouse.current != null && Mouse.current.leftButton.wasPressedThisFrame)
        {
            AlternarEstado();
        }
    }

    void AlternarEstado()
    {
        if (rendererTV != null)
        {
            if (!ligada)
            {
                // Liga a TV: Altera tanto a cor padrão quanto a propriedade de cor do pipeline URP
                rendererTV.material.SetColor("_BaseColor", Color.white);
                rendererTV.material.color = Color.white;
                ligada = true;
                Debug.Log("TV Ligada com Sucesso!");
            }
            else
            {
                // Desliga a TV: Retorna ao preto padrão
                rendererTV.material.SetColor("_BaseColor", Color.black);
                rendererTV.material.color = Color.black;
                ligada = false;
                Debug.Log("TV Desligada!");
            }
        }
    }
}