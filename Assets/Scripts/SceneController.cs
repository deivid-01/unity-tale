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
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                if (Uicontroller.Instance.fresaJoven.activeInHierarchy) {
                    Uicontroller.Instance.EnableDisable();
                   
                }
                return;
                        
            }
            


            if (anim == null) return;

            anim.SetBool("desaparecer", true);
            StartCoroutine(NextScene());
        }
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            if (SceneManager.GetActiveScene().buildIndex == 10)
            {
                if (!Uicontroller.Instance.fresaJoven.activeInHierarchy)
                {
                    Uicontroller.Instance.DisableEnabled();
                    return;
                }        
            }


            if (SceneManager.GetActiveScene().buildIndex == 0) return;
               
            anim.SetBool("desaparecer", true);
            StartCoroutine(PreviusScene());
            
        }

        if (Input.GetKeyDown(KeyCode.Escape)) {
            Application.Quit();
        }
    }
    
    IEnumerator NextScene() {


        yield return new WaitForSeconds(2.0f);
       
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }
    IEnumerator PreviusScene()
    {
        yield return new WaitForSeconds(2.0f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex - 1);
    }
}

