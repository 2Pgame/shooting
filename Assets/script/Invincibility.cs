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
        public float duration2 = 10.0f;
        public float duration3 = 6.0f;
        public float fadeDuration = 0.1f;

        [field: SerializeField]
        public bool IsInvincible { get; private set; } = false;

        private Collider2D collider2D; // 2D �R���C�_�[�R���|�[�l���g

        void Awake()
        {
            collider2D = GetComponent<Collider2D>(); // �R���C�_�[�R���|�[�l���g�̎擾
        }


        public void SetInvincibility()
        {
            if (spriteRenderer != null && collider2D != null)
            {
                StartCoroutine(BecomeInvincible(duration, fadeDuration));
            }
            else
            {
                Debug.LogError("Invincibility: SpriteRenderer��Collider2D���K�v�ł��B");
            }
        }

        private IEnumerator BecomeInvincible(float duration, float fadeDuration)
        {
            IsInvincible = true;
            collider2D.enabled = false; // �R���C�_�[�𖳌��ɂ���

            float endTime = Time.time + duration;
            while (Time.time < endTime)
            {
                spriteRenderer.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                spriteRenderer2.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                yield return new WaitForSeconds(fadeDuration * 2);
            }
            spriteRenderer.DOFade(1, 0);
            spriteRenderer2.DOFade(1, 0);

            collider2D.enabled = true; // �R���C�_�[���ĂїL���ɂ���
            IsInvincible = false;
        }
        public void SetInvincibility2()
        {
            if (spriteRenderer != null && collider2D != null)
            {
                StartCoroutine(BecomeInvincible2(duration, fadeDuration));
            }
            else
            {
                Debug.LogError("Invincibility: SpriteRenderer��Collider2D���K�v�ł��B");
            }
        }

        private IEnumerator BecomeInvincible2(float duration2, float fadeDuration)
        {
            IsInvincible = true;
            collider2D.enabled = false; // �R���C�_�[�𖳌��ɂ���

            float endTime = Time.time + duration;
            while (Time.time < endTime)
            {
                spriteRenderer.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                spriteRenderer2.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                yield return new WaitForSeconds(fadeDuration * 2);
            }
            spriteRenderer.DOFade(1, 0);
            spriteRenderer2.DOFade(1, 0);


            IsInvincible = false;
        }
        public void SetInvincibility3()
        {
            if (spriteRenderer != null && collider2D != null)
            {
                StartCoroutine(BecomeInvincible3(duration, fadeDuration));
            }
            else
            {
                Debug.LogError("Invincibility: SpriteRenderer��Collider2D���K�v�ł��B");
            }
        }

        private IEnumerator BecomeInvincible3(float duration3, float fadeDuration)
        {
            IsInvincible = true;
            collider2D.enabled = false; // �R���C�_�[�𖳌��ɂ���

            float endTime = Time.time + duration;
            while (Time.time < endTime)
            {
                spriteRenderer.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                spriteRenderer2.DOFade(0, fadeDuration).SetLoops(2, LoopType.Yoyo);
                yield return new WaitForSeconds(fadeDuration * 2);
            }
            spriteRenderer.DOFade(1, 0);
            spriteRenderer2.DOFade(1, 0);

            collider2D.enabled = true; // �R���C�_�[���ĂїL���ɂ���
            IsInvincible = false;
        }
    }
}