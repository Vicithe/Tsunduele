using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class TextVanish : MonoBehaviour
{
    private void Update()
    {
        if(SceneManager.GetActiveScene().name == "GameScene")
        {
            Destroy(gameObject);
        }
    }
}
