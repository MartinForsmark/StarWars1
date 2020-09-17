﻿using UnityEngine;

public class Thruster : MonoBehaviour {
    // Start is called before the first frame update
    void Start() {
    }

    // Update is called once per frame
    void Update() {
    }

    void OnEnable() {
        GetComponent<ParticleSystem>().Play();
    }

    void OnDisable() {
        GetComponent<ParticleSystem>().Stop();
    }
}