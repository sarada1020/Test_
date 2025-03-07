using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Diamante : MonoBehaviour

{
    public GameObject telaGanhou; // Referência para a tela de "Ganhou"

    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu é o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Desabilita o diamante (ou cogumelo) após a coleta
            gameObject.SetActive(false);

            // Exibe a tela de Ganhou
            telaGanhou.SetActive(true);

            // Reinicia a cena após 2 segundos
            Invoke("ReiniciarJogo", 2f);  // A cena será reiniciada após 2 segundos
        }
    }

    void ReiniciarJogo()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
    }
}



