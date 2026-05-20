using UnityEngine;
using UnityEngine.InputSystem;

public class ControleJogador : MonoBehaviour
{
    public float velocidade = 5.0f;
    public float sensibilidadeMouse = 0.05f;
    
    private Transform cameraTransform;
    private float rotationX = 0;

    void Start()
    {
        // ATENÇÃO: Mudamos aqui para o cursor ficar visível e livre na tela!
        Cursor.lockState = CursorLockMode.None;
        Cursor.visible = true;
        
        cameraTransform = GetComponentInChildren<Camera>().transform;
    }

    void Update()
    {
        // Movimentação Teclado (WASD)
        var teclado = Keyboard.current;
        if (teclado != null)
        {
            Vector3 movimento = Vector3.zero;
            if (teclado.wKey.isPressed || teclado.upArrowKey.isPressed) movimento += transform.forward;
            if (teclado.sKey.isPressed || teclado.downArrowKey.isPressed) movimento -= transform.forward;
            if (teclado.aKey.isPressed || teclado.leftArrowKey.isPressed) movimento -= transform.right;
            if (teclado.dKey.isPressed || teclado.rightArrowKey.isPressed) movimento += transform.right;

            transform.position += movimento.normalized * velocidade * Time.deltaTime;
        }

        // Rotação da Câmera com o Mouse (Apenas quando você arrasta ou move)
        var mouse = Mouse.current;
        if (mouse != null)
        {
            Vector2 deltaMouse = mouse.delta.ReadValue();
            float mouseX = deltaMouse.x * sensibilidadeMouse;
            float mouseY = deltaMouse.y * sensibilidadeMouse;

            transform.Rotate(0, mouseX, 0);
            rotationX -= mouseY;
            rotationX = Mathf.Clamp(rotationX, -90f, 90f);
            
            if (cameraTransform != null)
            {
                cameraTransform.localRotation = Quaternion.Euler(rotationX, 0, 0);
            }
        }
    }
}