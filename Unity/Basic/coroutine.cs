using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coroutine : MonoBehaviour
{
    public void Start(){
        StartCoroutine(Fade(new GameObject()));
    }
    
    IEnumerator Fade(GameObject target) {
        yield return new WaitForSeconds(0.1f);
        yield return null;
    }
}
