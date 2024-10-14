using System.Collections;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;

public class TimerController : MonoBehaviour
{
    [SerializeField] public float time;
    [SerializeField] public TextMeshProUGUI timeView;
    IEnumerator Timer()
    {
        TimerSave(time);
        for (float second = time; second >= 0; second -= 1f)
        {
            TimerSave(second);
            yield return new WaitForSeconds(1f);
        }
    }
    private void TimerSave(float time)
    {
        timeView.text = time.ToString();
    }
    public void StartTimer()
    {
        StartCoroutine(Timer());
    }
}
