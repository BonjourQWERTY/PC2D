using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuWastedRestart : MonoBehaviour
{
    public int n_scene = 4;  // индекс загружаемой сцены по умолчанию, который в редакторе можно изменить

    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "Player")
        {
            SceneManager.LoadScene(n_scene);
        }
    }
}
