using UnityEngine;
using UnityEngine.UI;

namespace CT.UI
{
    public class MainMenuView : MonoBehaviour
    {
        public Image background;

        [SerializeField] private Button buttonSetRed;
        [SerializeField] private Button buttonSetGreen;
        [SerializeField] private Button buttonSetBlue;

        private MainMenuPresenter _presenter;

        private void Awake()
        {
            _presenter = new MainMenuPresenter(this);
        }

        private void OnEnable()
        {
            buttonSetRed.onClick.AddListener(_presenter.SetRedColor);
            buttonSetGreen.onClick.AddListener(_presenter.SetGreenColor);
            buttonSetBlue.onClick.AddListener(_presenter.SetBlueColor);
        }

        private void OnDisable()
        {
            buttonSetRed.onClick.RemoveListener(_presenter.SetRedColor);
            buttonSetGreen.onClick.RemoveListener(_presenter.SetGreenColor);
            buttonSetBlue.onClick.RemoveListener(_presenter.SetBlueColor);
        }
    }
}