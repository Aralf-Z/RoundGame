using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;
using ZToolKit;

namespace RoundGame.UI
{
    public class MainMenuUI : UIScreen
    {
        [Header("MainMenu")] public Button startBtn;
        public Button optionsBtn;
        public Button exitBtn;

        protected override void OnInit()
        {
            startBtn.onClick.AddListener(OnClickStartBtn);
            optionsBtn.onClick.AddListener(OnClickSettingBtn);
            exitBtn.onClick.AddListener(OnClickExitBtn);
        }

        protected override void OnOpen(object data)
        {
            AudTool.PlayMusic(CfgTool.Audio.MainMenuBgm);
        }

        protected override void OnHide()
        {

        }

        private void OnClickStartBtn()
        {
            HideSelf();
            UITool.OpenUI<GameHudUI>(UIPanel.Normal);
            SceneManager.LoadScene("_Scenes/BattleField");
        }

        private void OnClickSettingBtn()
        {
            UITool.OpenUI<OptionsUI>(UIPanel.Tip);
        }

        private void OnClickExitBtn()
        {
#if UNITY_EDITOR
            UnityEditor.EditorApplication.isPlaying = false;
#else
        Application.Quit();
#endif
        }
    }
}
