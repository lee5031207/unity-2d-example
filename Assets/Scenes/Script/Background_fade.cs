using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Background_fade : MonoBehaviour
{

    public Image background;
    float time = 0f;
    float F_time = 1f;

    void Start()
    {
        StartCoroutine(FadeFlow());
    }

    IEnumerator FadeFlow()
    {
        time = 0f;

        Color alpha = background.color;

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            background.color = alpha;
            yield return null;
        }

        time = 0f;

        yield return new WaitForSeconds(1.5f);

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            background.color = alpha;
            alpha.a = Mathf.Lerp(0, 1, time);
            yield return null;
        }

        yield return null;
    }
}

