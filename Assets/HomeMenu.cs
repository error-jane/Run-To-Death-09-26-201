using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class HomeMenu : MonoBehaviour
{
    public Animator transitionAnim;
    public void PlayGame()
    {
        StartCoroutine(LoadScene());
    }
    public void exitThisGame()
    {
        UnityEngine.Debug.LogError("Exit Game");
        Application.Quit();
    }
    IEnumerator LoadScene()
    {
        transitionAnim.SetTrigger("end");
        yield return new WaitForSeconds(1.5f);
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
    }

}
