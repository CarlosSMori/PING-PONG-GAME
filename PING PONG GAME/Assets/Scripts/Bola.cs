using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bola : MonoBehaviour {
    public float velocidadeDaBola;
    public Rigidbody2D Rb2d;
    public AudioSource somDaBola;

    // Start is called before the first frame update
    void Start() {
        Rb2d.velocity = new Vector2(velocidadeDaBola, velocidadeDaBola) * Time.deltaTime;
    }

    // Update is called once per frame
    void Update() {

    }

    void OnCollisionEnter2D(Collision2D collisionInfo) {
        somDaBola.Play();
    }
}
