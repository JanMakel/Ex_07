using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;


public class Ex_02 : MonoBehaviour
{

    public TextMeshProUGUI nums;
    private int counter = 10;

    private IEnumerator CountDown()
    {
       
        for (var i = 0; i < 10; i++)
        {
            yield return new WaitForSeconds(1);
            nums.text = $"{counter}";
            counter--;
        }
    }
    private void Start()
    {

        StartCoroutine(CountDown());
    }
    


}
