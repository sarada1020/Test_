using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamante : MonoBehaviour

{
    public GameObject telaGanhou; // Refer�ncia para a tela de "Ganhou"

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu � o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Desabilita o diamante (ou cogumelo) ap�s a coleta
            gameObject.SetActive(false);

            // Exibe a tela de Ganhou
            telaGanhou.SetActive(true);

            // Reinicia a cena ap�s 2 segundos
            Invoke("ReiniciarJogo", 2f);  // A cena ser� reiniciada ap�s 2 segundos
        }
    }

    void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
}



