/*
 * Created by Vincent Diquélou (vincent.diquelou.pro@gmail.com)
 */

using UnityEngine;

namespace Utils
{
    [RequireComponent(typeof(ParticleSystem))]
    public class ParticleSystemAutoDestroy : MonoBehaviour
    {
        private ParticleSystem _particleSystem;


        public void Awake()
        {
            _particleSystem = GetComponent<ParticleSystem>();
        }

        public void FixedUpdate()
        {
            if (_particleSystem == null) return;
            if (_particleSystem.IsAlive()) return;
            Destroy(gameObject);
        }
    }
}