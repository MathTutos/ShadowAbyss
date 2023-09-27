using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNiveles : MonoBehaviour
{

    [SerializeField] private AudioSource Coin_SFX;

    private void OnTriggerEnter2D(Collider2D collision){ 
        Debug.Log("Meta");
        Coin_SFX.Play();

        StartCoroutine(goNextLevel(Coin_SFX.clip.length));
        gameObject.GetComponent<Renderer>().enabled = false;
        

    }   
     
        private IEnumerator goNextLevel(float delay){
        yield return new WaitForSeconds(delay); 
        Destroy(gameObject);

        if(SceneManager.GetActiveScene().name=="LV1"){
            SceneManager.LoadScene("LV2");
        }
        else{
            SceneManager.LoadScene("LV1");
        } 
    }

}