using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class CharacterDeath : MonoBehaviour {

    // Dovrebbe andare riscritto in futuro, per renderlo più "pulito". Caricare tutta la scena di nuovo ricarica anche BGM e tutto il resto.

    // Respawn = Numero di scena corrente
    public int currentScene;
    //timeToDeath indica dopo quanto il giocatore rispawnerà
    public float timeToRespawn;

    void Start() {
        currentScene = SceneManager.GetActiveScene().buildIndex;
    }
    // Se il giocatore tocca il nemico, parte la coroutine
    private void OnTriggerEnter(Collider other) {
        if (other.CompareTag("Player")) {
            StartCoroutine(DeadPlayer());
            Debug.Log("Dentro");
        }
    }

    // Disattiva il game object del giocatore, e dopo due secondi ricarica la scena.
    // Probabilmente andrà cambiato.
    IEnumerator DeadPlayer() {

        //La riga seguente servirà per quando verrà migliorato il sistema di respawn in futuro
        // GameObject.Find("Player").GetComponent<PlayerMovement>().Death();
        yield return new WaitForSeconds(timeToRespawn);
        SceneManager.LoadScene(currentScene);
    }
}
