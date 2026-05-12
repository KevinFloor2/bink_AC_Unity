using UnityEngine;

namespace BinkVideo
{
    /// <summary>
    /// Configuration settings for the Bink Video plugin
    /// </summary>
    [CreateAssetMenu(fileName = "BinkVideoConfig", menuName = "BinkVideo/Configuration")]
    public class BinkVideoConfig : ScriptableObject
    {
        [Header("Default Playback Settings")]
        [SerializeField]
        public bool defaultLoop = false;

        [SerializeField]
        [Range(0f, 1f)]
        public float defaultVolume = 1f;

        [SerializeField]
        public bool defaultShowSubtitles = false;

        [Header("Performance Settings")]
        [SerializeField]
        public bool useHardwareDecoding = true;

        [SerializeField]
        [Range(0, 3)]
        public int decodingThreads = 1;

        [Header("Video 2 Specific")]
        [SerializeField]
        public int defaultWidth = 1920;

        [SerializeField]
        public int defaultHeight = 1080;

        [Header("Subtitle Settings")]
        [SerializeField]
        public Font subtitleFont;

        [SerializeField]
        public int subtitleFontSize = 32;

        [SerializeField]
        public Color subtitleColor = Color.white;
    }
}
