using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class geradorInimigos : MonoBehaviour
{
    [ SerializeField ] private GameObject inimigo1;
    [ SerializeField ] private float espera = 5f;
    private float tempoInimigo = 0f;
    private int pontuacao = 0;
    [ SerializeField ] private int level = 1;
    private GameObject maisInimigo;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GerandoInimigos();
    }

    private void GerandoInimigos() {
        //diminuindo o tempo de espera do inimigo
        if(tempoInimigo > 0) {
            tempoInimigo -= Time.deltaTime;
        }
        //verificando se a espera zerou
        if(tempoInimigo <= 0f) {
            int numeroDeInimigos = level * 5;
            int numInimigos = 0;
            do
            {
            //criando mais inimigo de acordo com o level
            float nivel = Random.Range(0f, level);
            if(nivel > 4f) {
                maisInimigo = inimigo1;
            } else {
                maisInimigo = inimigo1;
            }
            //posição inicial do inimigo
            Vector3 posicaoInimigo = new Vector3(Random.Range(-9f, 9f), Random.Range(6f, 8f), 0f);
            //fazendo surgir inimigo
            Instantiate(maisInimigo, posicaoInimigo, transform.rotation);
            //aumentando o numero de inimigos
            numInimigos++;
            //fazendo a espera pelo inimigo de novo
            tempoInimigo = espera;
            }while(numInimigos < numeroDeInimigos);
        }
    }
}
