using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    public int pontuacaoDoJogador1;
    public int pontuacaoDoJogador2;
    public Text textoDePontuacao;
    public AudioSource somDoGol;
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {
        if (Input.GetKeyDown(KeyCode.R)) {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
            Debug.Log("Saiu do Jogo");
        }
    }

    public void AumentarPontuacaoDoJogador1() {
        pontuacaoDoJogador1 += 1;
        AtualizarTextoDePontuacao();

    }

    public void AumentarPontuacaoDoJogador2() {
        pontuacaoDoJogador2 += 1;
        AtualizarTextoDePontuacao();
    }

    public void AtualizarTextoDePontuacao() {
        textoDePontuacao.text = pontuacaoDoJogador1 + " X " + pontuacaoDoJogador2;
        somDoGol.Play();

    }

}
