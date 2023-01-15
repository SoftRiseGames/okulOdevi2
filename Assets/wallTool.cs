using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using TMPro;
public class wallTool : MonoBehaviour
{
    public GameObject[] walllist;
    int b = 0;
    
    bool temas;
    [SerializeField] TextMeshProUGUI replayText;
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (temas)
        {
            if (b == walllist.Length)
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            }
            else
            {
                StartCoroutine(waitAndDeath());
            }
        }
       
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "boulder")
        {
            Debug.Log("temas");
            temas = true;
            foreach (var i in walllist)
            {
                if (i.GetComponent<wallscript>().isOpen)
                {
                    b = b + 1;
                }
                
                Debug.Log(b);
            }

        }
    }
    IEnumerator waitAndDeath()
    {
        replayText.gameObject.SetActive(true);
        yield return new WaitForSeconds(0.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);

    }
}
