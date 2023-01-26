using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    public TMP_Text timerText;
    private float time;

    void Update()
    {
        time += Time.deltaTime;
        timerText.text = Mathf.FloorToInt(time).ToString();
    }
}
