using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class winMenu : MonoBehaviour
{
    public Animator transitionAnim;
    public void GoBacke()
    {

        StartCoroutine(LoadScene(4));
    }
    public void KeepGoing()
    {
        StartCoroutine(LoadScene(0));
    }
    IEnumerator LoadScene(int scene)
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(scene);
    }
}
