using System;
using OmniPlayZone.MiniGames.Data;
using TMPro;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

namespace OmniPlayZone.MiniGames.UI.Elements
{
    [RequireComponent(typeof(Button))]
    public class GameButton : MonoBehaviour
    {
        [SerializeField] private MiniGame _game;
        [SerializeField] private Image _gameIcon;
        [SerializeField] private TMP_Text _gameTitle;
        private Button _button;
        public event Action<MiniGame> Clicked;

        private void Awake()
        {
            _button = GetComponent<Button>();
            UpdateUI();
        }

        private void UpdateUI()
        {
            if (_game)
            {
                _gameTitle.text = _game.MiniGameName;
                _gameIcon.sprite = _game.GameIcon;
            }
        }

        private void OnEnable()
        {
            _button.onClick.AddListener(OnButtonClicked);
        }

        private void OnDisable()
        {
            _button.onClick.RemoveListener(OnButtonClicked);
        }

        private void OnButtonClicked()
        {
            Clicked?.Invoke(_game);
        }
    }
}