using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CambioNiveles3 : MonoBehaviour
{

    [SerializeField] private AudioSource Coin_SFX;

    private void OnTriggerEnter2D(Collider2D collision){ 
        Debug.Log("Meta");
        Coin_SFX.Play(); //Sonido para la moneda antes de cambiar de escena 

        StartCoroutine(goNextLevel(Coin_SFX.clip.length));
        gameObject.GetComponent<Renderer>().enabled = false;
        

    }   
     
        private IEnumerator goNextLevel(float delay){
        yield return new WaitForSeconds(delay); 
        Destroy(gameObject);

        if(SceneManager.GetActiveScene().name=="LV3"){
            SceneManager.LoadScene("Fin_Juego");
        }
        else{
            SceneManager.LoadScene("LV3");
        } 
    }

}