using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animation : MonoBehaviour
{
    public GameObject[] layers; // Array de renderizadores de sprite para as camadas do personagem
    public float[] movementRange; // Distância máxima de movimento para cima e para baixo
    public float[] movementSpeed; // Velocidade de movimento

    private Vector3[] originalPositions; // Posições originais das camadas do personagem

    private void Start()
    {
        // Salva as posições originais das camadas
        originalPositions = new Vector3[layers.Length];
        for (int i = 0; i < layers.Length; i++)
        {
            originalPositions[i] = layers[i].transform.localPosition;
        }
    }

    private void Update()
    {
        // Movimenta as camadas para cima e para baixo ao longo do tempo

        for (int i = 0; i < layers.Length; i++)
        {
            float offsetY = Mathf.Sin(Time.time * movementSpeed[i]) * movementRange[i];
            Vector3 newPosition = originalPositions[i] + Vector3.up * offsetY;
            layers[i].transform.localPosition = newPosition;
        }
    }
}
