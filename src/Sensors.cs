using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem;

public class Sensors : MonoBehaviour
{
    public TMP_Text[] sensorsData;
    public GameObject canvas;
    public GameObject vars;
    public GameObject textPrefab;
    readonly int canvasX = 352;
    int canvasY = -30;
    readonly int offset = -20;
    readonly int varsX = 520;
    int varsY = 880;

    List<InputDevice> devices = new List<InputDevice>{};
    TMP_Text locText;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        //Input.gyro.enabled = true;
        sensorsData = new TMP_Text[InputSystem.devices.ToArray().Length + 1];
        int i = 0;
        foreach (var device in InputSystem.devices)
        {
            devices.Add(device);
            InputSystem.EnableDevice(device);
            GameObject deviceText = Instantiate(textPrefab, canvas.transform, false);
            TMP_Text text = deviceText.GetComponent<TMP_Text>();
            text.text = device.name;      
            RectTransform textTransform = deviceText.GetComponent<RectTransform>();
            textTransform.anchoredPosition = new Vector2(canvasX, canvasY);
            textTransform.anchorMin = new Vector2(0,1);
            textTransform.anchorMax = new Vector2(0,1);
            textTransform.sizeDelta = new Vector2(700, textTransform.sizeDelta.y);
            canvasY += offset;
            GameObject deviceData = Instantiate(textPrefab, vars.transform, false);
            TMP_Text dataText = deviceData.GetComponent<TMP_Text>();
            dataText.text = "";
            RectTransform dataTransform = deviceData.GetComponent<RectTransform>();
            dataTransform.anchoredPosition = new Vector2(varsX, varsY);
            varsY += offset;
            sensorsData[i++] = dataText;
        }
        Input.location.Start(10f, 10f);
        GameObject locationText = Instantiate(textPrefab, canvas.transform, false);
        locText = locationText.GetComponent<TMP_Text>();
        locText.text = Input.location.status == LocationServiceStatus.Initializing ? "GPS " : "NO GPS ";
        RectTransform locTransform = locationText.GetComponent<RectTransform>();
        locTransform.anchorMin = new Vector2(0,1);
        locTransform.anchorMax = new Vector2(0,1);
        locTransform.sizeDelta = new Vector2(700, locTransform.sizeDelta.y);
        locTransform.anchoredPosition = new Vector2(canvasX, canvasY);
        canvasY += offset;
        GameObject locData = Instantiate(textPrefab, vars.transform, false);
        TMP_Text locDataText = locData.GetComponent<TMP_Text>();
        locDataText.text = "";
        RectTransform locDataTransform = locData.GetComponent<RectTransform>();
        locDataTransform.anchoredPosition = new Vector2(varsX, varsY);
        varsY += offset;
        sensorsData[i++] = locText;
        DataUpdate();
    }

    // Update is called once per frame
    void Update()
    {
        DataUpdate();
    }

    public void DataUpdate()
    {
        for (int i = 0; i < devices.Count; ++i)
        {
            foreach (InputControl control in devices[i].allControls)
            {
                sensorsData[i].text = control.ReadValueAsObject().ToString();
            }
        }
        if (Input.location.status == LocationServiceStatus.Running) {
            sensorsData[^1].text = "Location: " + Input.location.lastData.latitude + " " + Input.location.lastData.longitude + " " + Input.location.lastData.altitude + " " + Input.location.lastData.horizontalAccuracy;
        }
    }
}
