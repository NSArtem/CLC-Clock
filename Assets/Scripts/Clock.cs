using System;
using UnityEngine;

public class Clock: MonoBehaviour
{
    [SerializeField]
    Transform hourPivot, secondsPivot, minutesPivot;

    void Update() {
        SetTime();
    }

    void SetTime() {
        var time = DateTime.Now;
        hourPivot.localRotation = Quaternion.Euler(0f, 0f, -30f * time.Hour + (-30f / 60 * time.Minute));
        minutesPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0f, 0f, -6f * time.Second);
    }
}
