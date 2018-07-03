using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Particle_Remover : MonoBehaviour {

	
	void Start () {
        Destroy(gameObject, 5);
    }
	
	
	void Update () {
    }
}
