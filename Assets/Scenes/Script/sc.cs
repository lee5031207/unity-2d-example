using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
public class sc : MonoBehaviour
{
    public Image img;
    public Text txt;
    float time = 0f;
    float F_time = 1f;

    public void ChangeStageScene()
    {
        txt.gameObject.SetActive(false);

        time = 0f;

        Color alpha = img.color;

        while (alpha.a > 0f)
        {
            time += Time.deltaTime / F_time;
            alpha.a = Mathf.Lerp(1, 0, time);
            img.color = alpha;
        }
        img.gameObject.SetActive(false);
        SceneManager.LoadScene("Stage");
    }
}
