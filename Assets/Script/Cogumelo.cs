using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cogumelo : MonoBehaviour

{
    public GameObject telaPerdeu; // Refer�ncia para a tela de "Perdeu"

    // Este m�todo ser� chamado quando o personagem colidir com o cogumelo
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu � o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Desabilita o cogumelo (ou diamante) ap�s a colis�o
            gameObject.SetActive(false);

            // Exibe a tela de Perdeu
            telaPerdeu.SetActive(true);

            // Reinicia a cena ap�s 2 segundos
            Invoke("ReiniciarJogo", 2f);  // A cena ser� reiniciada ap�s 2 segundos
        }
    }

    void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
}



