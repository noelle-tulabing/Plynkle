using System;
using System.Collections.Generic;
using UnityEngine;

public class Peg : MonoBehaviour
{
   public List<Sprite> Sprites;
   public Sounds Sounds;
   
   private int currentSpriteNumber = 0;
   private SpriteRenderer spriteRenderer;

   public void Start()
   {
      spriteRenderer = GetComponent<SpriteRenderer>();
      spriteRenderer.sprite = Sprites[currentSpriteNumber];
   }
   public void OnCollisionEnter2D(Collision2D other)
   {
      if (other.gameObject.CompareTag("Ball"))
      {
         OnBallHit();
      }
   }

   private void OnBallHit()
   {
      if (NoMoreSprites())
      {
         Sounds.PlayPegDestroySound();
         Destroy(gameObject);
      }
      else
      {
         Sounds.PlayPegHitSound();
         ShowNextSprite();
      }
   }

   public void ShowNextSprite()
   {
      currentSpriteNumber++;
      spriteRenderer.sprite = Sprites[currentSpriteNumber];
   }

   private bool NoMoreSprites()
   {
      if (currentSpriteNumber == 2)
      {
         return true;
      }
      return false;
   }
}
