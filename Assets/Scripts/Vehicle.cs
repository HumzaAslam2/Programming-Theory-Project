using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Vehicle : MonoBehaviour
{
    protected float speed;
    [SerializeField] protected bool engineIsOn = false;
    [SerializeField] protected int year;

    public int Year
    {
        get
        {
            return year;
        }
        protected set
        {
            if (year < 1769)
            {
                year = 1769;
            }
            else
            {
                year = value;
            }
        }
    }

    [SerializeField] protected float minSpeed = 5;
    [SerializeField] protected float maxSpeed = 200;
    [SerializeField] protected float rotationSpeed = 10;
    [SerializeField] protected Button turnOnButton;
    [SerializeField] protected Button turnOffButton;
    [SerializeField] protected Slider speedSlider;
    [SerializeField] protected TextMeshProUGUI currentSpeedText;
    
    private void Awake()
    {
        speedSlider.minValue = minSpeed;
        speedSlider.maxValue = maxSpeed;
        speed = minSpeed;
        currentSpeedText.text = "Current Speed: 0";
    }

    private void Start()
    {
        turnOnButton.onClick.AddListener(TurnOn);
        turnOffButton.onClick.AddListener(TurnOff);
        speedSlider.onValueChanged.AddListener(delegate { ChangeSpeed(); });
    }

    // Update is called once per frame
    void Update()
    {
        if (engineIsOn)
        {
            Move();
        }
    }

    protected void TurnOn()
    {
        engineIsOn = true;
        speed = speedSlider.value;
        currentSpeedText.text = $"Current Speed: {speed}";
    }

    protected virtual void Move()
    {
        float forwardInput = Input.GetAxis("Vertical");

        transform.Translate(Vector3.forward * speed * forwardInput * Time.deltaTime);
    }

    protected void TurnOff()
    {
        engineIsOn = false;
        speed = 0;
        currentSpeedText.text = "Current Speed: 0";
    }

    protected void ChangeSpeed()
    {
        speed = speedSlider.value;
        currentSpeedText.text = $"Current Speed: {speed}";
    }
}
