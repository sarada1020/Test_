using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PersonagemController : MonoBehaviour

{
    private Rigidbody2D rb;
    private Animator anim;
    private SpriteRenderer sr;

    public float velocidade = 5f;
    public float forcaPulo = 7f;
    private bool noChao;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        anim = GetComponent<Animator>();
        sr = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        // Movimento horizontal
        float movimento = Input.GetAxisRaw("Horizontal");
        rb.velocity = new Vector2(movimento * velocidade, rb.velocity.y);

        // Verifica pulo
        if (Input.GetKeyDown(KeyCode.Space) && noChao)
        {
            rb.velocity = new Vector2(rb.velocity.x, forcaPulo);
            noChao = false;
            anim.Play("Jump"); // Animação de pulo
        }

        // Atualizar animação
        AtualizarAnimacao(movimento);
    }

    void AtualizarAnimacao(float movimento)
    {
        if (!noChao) return; // Se estiver no ar, não troca animação

        if (movimento == 0)
        {
            anim.Play("Idle"); // Parado
        }
        else
        {
            anim.Play("Run"); // Correndo
            sr.flipX = movimento < 0; // Inverte sprite se andar para a esquerda
        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Chao"))
        {
            noChao = true;
        }
    }
}



