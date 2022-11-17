using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class PlayerController : MonoBehaviour
{
    private TMP_Text uiText;

    void Start()
    {
        uiText = GameObject.Find("uiText").GetComponent<TMP_Text>();
    }

    void Update()
    {
        // ABSTRACTION
        CheckForMouseInput();
    }

    void CheckForMouseInput()
    {
        if (Input.GetMouseButtonDown(0))
        {
            CastRayFromScreenMousePosition();
        }
    }

    void CastRayFromScreenMousePosition()
    {
        if (Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition), out RaycastHit hitInfo))
        {

            Shape shapeHit = hitInfo.transform.gameObject.GetComponent<Shape>();

            if (shapeHit)
            {
                uiText.text = shapeHit.GetDescription();
            }
        }
    }
}
