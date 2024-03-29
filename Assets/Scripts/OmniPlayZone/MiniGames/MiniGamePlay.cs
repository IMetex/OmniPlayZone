using System;
using OmniPlayZone.MiniGames.Data;
using UnityEngine;

namespace OmniPlayZone.MiniGames
{
    public class MiniGamePlay : MonoBehaviour
    {
        private MiniGame _miniGame;

        public MiniGame MiniGames
        {
            get => _miniGame;
            set
            {
                EndGame();
                _miniGame = value;
            }
        }

        public void StartGame()
        {
            if (_miniGame)
            {
                _miniGame.Begin();
            }
        }

        public void EndGame()
        {
            if (_miniGame)
            {
                _miniGame.End();
            }
        }

        private void Update()
        {
            if (_miniGame)
            {
                _miniGame.Tick();
            }
        }

        private void OnDisable()
        {
            EndGame();
        }
    }
}