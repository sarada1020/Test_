using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Diamante : MonoBehaviour
{
    // Este método será chamado quando o personagem colidir com o diamante
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu é o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Aqui você pode adicionar algum efeito, como aumentar pontuação, antes de destruir o diamante
            Debug.Log("Diamante Coletado!");

            // Destrói o diamante após a coleta
            Destroy(gameObject);  // Isso remove o diamante do jogo
        }
    }
}

