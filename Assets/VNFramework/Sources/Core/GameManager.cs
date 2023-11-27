using UnityEngine;

namespace VNFramework
{
    public class GameManager : MonoBehaviour
    {
        public GameState GameState { get; private set; }
        public DialogueState DialogueState { get; private set; }
        public CheckpointManager CheckpointManager { get; private set; }
        public ConfigManager ConfigManager { get; private set; }
        public InputManager InputManager { get; private set; }
        public CheckpointHelper CheckpointHelper { get; private set; }

        public NovaAnimation PerDialogueAnimation { get; private set; }
        public NovaAnimation HoldingAnimation { get; private set; }
        public NovaAnimation UIAnimation { get; private set; }
        public NovaAnimation TextAnimation { get; private set; }

        private void Awake()
        {
            GameState = GetComponent<GameState>();
            DialogueState = GetComponent<DialogueState>();
            CheckpointManager = GetComponent<CheckpointManager>();
            ConfigManager = GetComponent<ConfigManager>();
            InputManager = GetComponent<InputManager>();
            CheckpointHelper = GetComponent<CheckpointHelper>();
        }
    }
}