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
        hourPivot.localRotation = Quaternion.Euler(0, 0, -30 * time.Hour);
        minutesPivot.localRotation = Quaternion.Euler(0, 0, -6 * time.Minute);
        secondsPivot.localRotation = Quaternion.Euler(0, 0, -6 * time.Second);
    }
}
