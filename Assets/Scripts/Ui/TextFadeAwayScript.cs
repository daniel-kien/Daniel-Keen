using UnityEngine;
using TMPro;

public class TextFadeAwayScript : MonoBehaviour
{
    public float fadeTime;
    private TextMeshProUGUI fadeAwayTime;
    public float alphaValue;
    public float fadeAwayPerSecond;

    void Start()
    {
        fadeAwayTime = GetComponent<TextMeshProUGUI>();
        fadeAwayPerSecond = 1 / fadeTime;
        alphaValue = fadeAwayTime.color.a;
    }

    void Update()
    {
        if (fadeTime > 0)
        {
            alphaValue -= fadeAwayPerSecond * Time.deltaTime;
            fadeAwayTime.color = new Color(fadeAwayTime.color.r, fadeAwayTime.color.g, fadeAwayTime.color.b, alphaValue);
            fadeTime -= Time.deltaTime;
        }
    }
}