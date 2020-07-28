using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadBattleScene : MonoBehaviour
{
    // Update is called once per frame
    public void OnMouseButton()
    {
        SceneManager.LoadScene("GameScene");
    }
}
