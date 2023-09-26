using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CoinController3 : MonoBehaviour
{

    [SerializeField] private AudioSource Coin_SFX;

    private void OnTriggerEnter2D(Collider2D collision){ 
        Debug.Log("Moneda");
        Coin_SFX.Play(); //Sonido para la moneda antes de cambiar de escena 

        StartCoroutine(goNextLevel(Coin_SFX.clip.length));
        gameObject.GetComponent<Renderer>().enabled = false;
        

    }   
     
        private IEnumerator goNextLevel(float delay){
        yield return new WaitForSeconds(delay); 
        Destroy(gameObject);

        if(SceneManager.GetActiveScene().name=="Nivel3"){
            SceneManager.LoadScene("Win");
        }
        else{
            SceneManager.LoadScene("Nivel3");
        } 
    }

}