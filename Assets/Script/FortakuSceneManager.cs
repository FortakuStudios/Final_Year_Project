using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class FortakuSceneManager : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(waitToChange());
    }
    IEnumerator waitToChange()
    {
        yield return new WaitForSeconds(3);
        SceneManager.LoadScene("Loading");
    }
}
