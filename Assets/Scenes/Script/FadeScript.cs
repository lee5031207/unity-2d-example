using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class FadeScript : MonoBehaviour
{
    public Image intro;
    public Canvas obj;

    float time = 0f;
    float F_time = 1f;

    void Start()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        intro.gameObject.SetActive(true);
        time = 0f;

        Color alpha = intro.color;

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            intro.color = alpha;
            alpha.a = Mathf.Lerp(0, 1, time);
            yield return null;
        }

        time = 0f;

        yield return new WaitForSeconds(1.5f);
        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            intro.color = alpha;
            yield return null;
        }
        intro.gameObject.SetActive(false);

        yield return new WaitForSeconds(0.5f);

        SceneManager.LoadScene("intro2");
        yield return null;
    }
}
