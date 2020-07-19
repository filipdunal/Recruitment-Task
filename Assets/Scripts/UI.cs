using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI : MonoBehaviour
{
    public GameObject text;
    public void ShowText(float time)
    {
        StopAllCoroutines();
        StartCoroutine(ShowTextCoroutine(time));
    }
    IEnumerator ShowTextCoroutine(float time)
    {
        text.SetActive(true);
        yield return new WaitForSecondsRealtime(time);
        text.SetActive(false);

    }
}
