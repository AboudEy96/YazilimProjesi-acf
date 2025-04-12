using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.InputSystem.LowLevel;

public class TypeAnimatino : MonoBehaviour
{
    public TextMeshPro textMeshPro;
    public static bool noTextLeft = false;
    private float speed = 0.07f;
    public List<string> currentText = new List<string>();
    public bool read = true;

    //private int i = Doctor.currentStep;
    
    void Start()
    {
        StartCoroutine(PrintText());
    }

    IEnumerator PrintText()
    {
        textMeshPro.text = "";
        for (int i = 0; i < currentText.Count; i++, textMeshPro.text = ""){
            
            foreach(char letter in currentText[i])
            {
                
              //  read = false;
                textMeshPro.text += letter;
                yield return new WaitForSeconds(speed);
                
            }
            yield return new WaitUntil(() => Input.GetKeyDown(KeyCode.E) || Input.GetMouseButtonDown(0));
            Doctor.currentStep = i;
            Doctor.noTextLeft = i == currentText.Count-1;

        }
    }


    
}
