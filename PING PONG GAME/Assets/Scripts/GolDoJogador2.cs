using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GolDoJogador2 : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {

    }

    // Update is called once per frame
    void Update() {

    }

    void OnTriggerEnter2D(Collider2D other) {
        if (other.gameObject.CompareTag("Bolinha")) {
            FindObjectOfType<GameManager>().AumentarPontuacaoDoJogador1();

            other.gameObject.transform.position = Vector2.zero;
        }
    }
}