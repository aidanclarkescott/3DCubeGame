using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour {

    bool gameHasEnded = false;
    public float restartDelay = 1f;
    public GameObject completeLevelUI;
    public PlayerMovement movement;

    public void CompleteLevel() {
        completeLevelUI.SetActive(true);
        movement.enabled = false;
    }

    public void EndGame() {

        if (!gameHasEnded) {
            gameHasEnded = true;
            Debug.Log("Game Over");
            Invoke("Restart", restartDelay);
        }

    }

    private void Restart() {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }
}
