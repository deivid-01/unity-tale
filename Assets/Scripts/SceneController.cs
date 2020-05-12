using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneController : MonoBehaviour
{

    public Animator anim;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            anim.SetBool("desaparecer", true);
            StartCoroutine(NextScene());
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (SceneManager.GetActiveScene().buildIndex == 0)
                return;
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
            
        }
    }
    
    IEnumerator NextScene() {
        yield return new WaitForSeconds(2.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
}

