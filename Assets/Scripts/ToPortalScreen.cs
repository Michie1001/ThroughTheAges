using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ToPortalScreen : MonoBehaviour
{
    private int screenToLoad;

    // Start is called before the first frame update
    private void Start()
    {
        screenToLoad = SceneManager.GetActiveScene().buildIndex - 1;
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player")
        {
            SceneManager.LoadScene(screenToLoad);
        }
    }
}
