using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class intro2fade : MonoBehaviour
{
    public Image intro;
    public Text txt;

    float time = 0f;
    float F_time = 1f;

    void Start()
    {
        StartCoroutine(Fade());
    }

    IEnumerator Fade()
    {
        intro.gameObject.SetActive(true);
        txt.gameObject.SetActive(true);
        time = 0f;

        Color alpha = intro.color;
        Color alpha2 = txt.color;

        while (alpha.a < 1f)
        {
            time += Time.deltaTime / F_time;
            intro.color = alpha;
            txt.color = alpha2;
            alpha2.a = Mathf.Lerp(0, 1, time);
            alpha.a = Mathf.Lerp(0, 1, time);
            yield return null;
        }
    }
}
