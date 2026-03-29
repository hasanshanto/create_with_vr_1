using UnityEngine;
using System;
using Unity.Mathematics;

public class current_time : MonoBehaviour
{
    public Transform hourHand;
    public Transform minuteHand;
    public Transform secondHand;


    // Update is called once per frame
    void Update()
    {
        DateTime currentTime = DateTime.Now;
        // Calculate rotation for each hand based on current time
        // Second hand: 360 degrees in 60 seconds (6 deg per second)
        float secondRotation = (currentTime.Second / 60f) * 360f;

        // 360 degrees in 60 minutes (6 deg per minute), plus offset for current seconds
        float minuteRotation = ((currentTime.Minute + currentTime.Second / 60f) / 60f) * 360f;
        // 360 degrees in 12 hours (30 deg per hour), plus offset for current minutes and seconds
        float hourRotation = ((currentTime.Hour % 12 + currentTime.Minute / 60f + currentTime.Second / 3600f) / 12f) * 360f;

        //  The hands rotate around the X-axis 
        secondHand.localRotation = Quaternion.Euler(secondRotation, 0f, 0f);
        minuteHand.localRotation = Quaternion.Euler(minuteRotation, 0f, 0f);
        hourHand.localRotation = Quaternion.Euler(hourRotation, 0f, 0f);

    }

}