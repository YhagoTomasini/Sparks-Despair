using UnityEngine;

public class HideCanvasOnEnter : MonoBehaviour
{
    // Referência para a Canvas que será escondida
    public Canvas canvasToHide;

    // Flag para verificar se o enter foi pressionado
    private bool enterPressed = false;

    void Update()
    {
        // Verifica se a tecla Enter foi pressionada e se ainda não foi processada
        if (Input.GetKeyDown(KeyCode.Return) && !enterPressed)
        {
            // Esconde a Canvas desativando seu GameObject
            canvasToHide.gameObject.SetActive(false);

            // Marca o enter como pressionado para não processar novamente
            enterPressed = true;
        }
    }
}
