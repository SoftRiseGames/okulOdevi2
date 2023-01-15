using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class replayScene : MonoBehaviour
{
    public bool skip, cont;
    // Start is called before the first frame update

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.name == "karakter" && skip)
        {
            Stop();    
        }
        else if (collision.gameObject.name == "karakter" && cont)
        {
            Resume();
        }
    }
    public void Resume()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    public void Stop()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
    
}
