
using UnityEngine;
using Zork;
using TMPro;
using System;

public class UnityInputService : MonoBehaviour, IInputService
{
    event EventHandler<string> InputReceived;


    [SerializeField]
    private TMP_InputField InputField;



    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Return))
        {
            string inputString = InputField.text;

            if (string.IsNullOrWhiteSpace(inputString) == false)
            {
                InputReceived?.Invoke(this, inputString);
            }

            InputField.text = string.Empty;
        }
    }

}
