using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Ex_03 : MonoBehaviour
{
    public int value;
    public TextMeshProUGUI val;

    private IEnumerator UpDown()
    {
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            value++;
            val.text = $"{value}";
        }
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            value--;
            val.text = $"{value}";
         }
        yield return new WaitForSeconds(0);
    }

    private void Update()
    {
        StartCoroutine(UpDown());
    }
}
