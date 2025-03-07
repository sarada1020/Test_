using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    // Este m�todo ser� chamado quando o personagem colidir com o diamante
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu � o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Aqui voc� pode adicionar algum efeito, como aumentar pontua��o, antes de destruir o diamante
            Debug.Log("Diamante Coletado!");

            // Destr�i o diamante ap�s a coleta
            Destroy(gameObject);  // Isso remove o diamante do jogo
        }
    }
}

