using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Cogumelo : MonoBehaviour

{
    // Este método será chamado quando o personagem colidir com o cogumelo
    private void OnTriggerEnter2D(Collider2D other)
    {
        // Verifica se o objeto que colidiu é o personagem (com base na Tag)
        if (other.CompareTag("Personagem"))
        {
            // Aqui você pode adicionar algum efeito visual ou sonoro antes de perder o jogo
            Debug.Log("Você perdeu o jogo!");

            // Pode tocar um som ou mostrar uma animação de perda antes de reiniciar a cena
            // Exemplo: AudioManager.Instance.Play("perda_som");

            // Reinicia a cena atual, fazendo o jogo "perder"
            SceneManager.LoadScene(SceneManager.GetActiveScene().name); // Reinicia a cena
        }
    }
}

