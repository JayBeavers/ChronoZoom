﻿using Framework.Interfaces;

namespace Framework.BrowserImpl
{
    public class FirefoxControls : DefaultControls, IControls
    {
        public override void ClickCloseButton()
        {
            ExecuteJavaScript("closeWelcomeScreen()");
        }
    }
}