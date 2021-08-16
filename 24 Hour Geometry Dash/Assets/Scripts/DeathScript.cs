using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DeathScript : MonoBehaviour {

    private void OnCollisionEnter2D(Collision2D DeathCollider)
    {
        if (DeathCollider.gameObject.CompareTag("Player"))
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }

    void Start()
    {
        
    }

    void Update()
    {
        
    }
}
