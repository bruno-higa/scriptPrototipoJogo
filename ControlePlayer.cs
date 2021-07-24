using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlePlayer : MonoBehaviour
{
    private Rigidbody2D rb;
    [ SerializeField ] private float vel = 5f;
    [ SerializeField ] private GameObject tiroJogador;
    [ SerializeField ] private int vidaJogador = 1;
    
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        //Input horizontal e vertical
        float horizontal = Input.GetAxis ("Horizontal");
        float vertical = Input.GetAxis ("Vertical");
        Vector2 velocidade = new Vector2 (horizontal, vertical);
        //Normalizando a velocidade
        velocidade.Normalize();
        //Passando para a velocidade o Rigidbody
        rb.velocity = velocidade*vel;
        //Tiro do jogador
        if(Input.GetButtonDown("Fire1")) {
            Instantiate(tiroJogador, transform.position, transform.rotation);
        }
    }
    public void SofreDano(int perda) {
        //perdendo vida 
        vidaJogador -= perda; 
        if(vidaJogador <=0) {
            Destroy(gameObject);
        }
    }
}
