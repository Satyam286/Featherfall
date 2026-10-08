using UnityEngine;

public class KillPlayer2D : MonoBehaviour
{
    public LogicScript logic;

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            logic.gameOver();
        }
    }
}