using UnityEngine;

namespace OmniPlayZone.MiniGames.Data
{
    [CreateAssetMenu(fileName = "FILENAME", menuName = "MiniGame", order = 0)]
    public abstract class MiniGame : ScriptableObject
    {
        [SerializeField] private string _miniGameName;
        public string MiniGameName => _miniGameName;
        [SerializeField] private Sprite _icon;
        public Sprite GameIcon => _icon;
        private bool _isStarted;

        public void Begin()
        {
            if (_isStarted) return;
            _isStarted = true;
            OnBegin();
        }

        public void Tick()
        {
            if (_isStarted)
                OnTick();
        }

        public void End()
        {
            if (_isStarted)
                OnEnd();
        }

        protected abstract void OnBegin();
        protected abstract void OnTick();
        protected abstract void OnEnd();
    }
}