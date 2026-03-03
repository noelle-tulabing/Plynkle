using UnityEngine;

public class Slot : MonoBehaviour
{
   public UI UI;
   public int Points = 10;
   public GameObject FireworksParticlePrefab;
   public Sounds Sounds;

   public void OnTriggerEnter2D(Collider2D other)
   {
      if (other.CompareTag("Ball"))
      {
         OnBallEntered(other);
      }
   }

   private void OnBallEntered(Collider2D ball)
   {
      ScorePoint();
      SpawnParticles(ball);
      PlayFireworksSound();
   }

   private void PlayFireworksSound()
   {
      Sounds.PlayFireworkSound();
   }

   private void SpawnParticles(Collider2D ball)
   {
      Vector3 particlePosition = GetParticlePosition(ball);
      Instantiate(FireworksParticlePrefab, particlePosition, Quaternion.identity);
   }

   private Vector3 GetParticlePosition(Collider2D ball)
   {
      Vector3 ballPosition = ball.transform.position;
      ballPosition.y += 0.25f;
      return ballPosition;
   }

   private void ScorePoint()
   {
      ScoreKeeper.Add(Points);
      UI.ShowScore(ScoreKeeper.GetScore());
   }
}
