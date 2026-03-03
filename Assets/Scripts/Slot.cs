using UnityEngine;

public class Slot : MonoBehaviour
{
   public UI UI;
   public int Points = 10;
   public void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Ball"))
      {
         OnBallEntered(other);
      }
      
   }

   private void OnBallEntered(Collider2D other)
   {
      ScorePoint();
   }

   private void ScorePoint()
   {
      ScoreKeeper.Add(Points);
      UI.ShowScore(ScoreKeeper.GetScore());
   }
}
