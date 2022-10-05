using System;
using UnityEngine;

namespace CT.UI
{
    public class MainMenuPresenter
    {
        private MainMenuView _view;
        
        public MainMenuPresenter(MainMenuView view)
        {
            _view = view;
        }

        public void SetRedColor()
        {
            Debug.Log("Red");
            throw new NotImplementedException();
        }
        
        public void SetGreenColor()
        {
            throw new NotImplementedException();
        }
        
        public void SetBlueColor()
        {
            throw new NotImplementedException();
        }
    }
}