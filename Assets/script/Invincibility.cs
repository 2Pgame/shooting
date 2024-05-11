using System.Collections;
using UnityEngine;
using DG.Tweening;

namespace YourCompany.Utilities
{
    public class Invincibility : MonoBehaviour
    {
        public SpriteRenderer spriteRenderer;
        public SpriteRenderer spriteRenderer2;
        public float duration = 3.0f;
        public float fadeDuration = 0.1f;

        [field: SerializeField]
        public bool IsInvincible { get; private set; } = false;

        private Collider2D collider2D; // 2D コライダーコンポーネント

        void Awake()
        {
            collider2D = GetComponent<Collider2D>(); // コライダーコンポーネントの取得
        }


        public void SetInvincibility()
        {
            if (spriteRenderer != null && collider2D != null)
            {
                StartCoroutine(BecomeInvincible(duration, fadeDuration));
            }
            else
            {
                Debug.LogError("Invincibility: SpriteRendererとCollider2Dが必要です。");
            }
        }

        private IEnumerator BecomeInvincible(float duration, float fadeDuration)
        {
            IsInvincible = true;
            collider2D.enabled = false; // コライダーを無効にする

            float endTime = Time.time + duration;
            while (Time.time < endTime)
            {
                Debug.Log("test");
                spriteRenderer.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                spriteRenderer2.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                yield return new WaitForSeconds(fadeDuration * 2);
            }
            spriteRenderer.DOFade(1, 0);
            spriteRenderer2.DOFade(1, 0);

            collider2D.enabled = true; // コライダーを再び有効にする
            IsInvincible = false;
        }
    }
}