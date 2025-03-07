using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cogumelo : MonoBehaviour

{
    public GameObject telaPerdeu; // Referência para a tela de "Perdeu"

    // Este método será chamado quando o personagem colidir com o cogumelo
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu é o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Desabilita o cogumelo (ou diamante) após a colisão
            gameObject.SetActive(false);

            // Exibe a tela de Perdeu
            telaPerdeu.SetActive(true);

            // Reinicia a cena após 2 segundos
            Invoke("ReiniciarJogo", 2f);  // A cena será reiniciada após 2 segundos
        }
    }

    void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
}



