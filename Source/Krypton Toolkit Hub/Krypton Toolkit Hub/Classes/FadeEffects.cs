#region BSD License
/*
 *  New BSD 3-Clause License (https://github.com/Krypton-Suite/Standard-Toolkit/blob/master/LICENSE)
 *  Modifications by Peter Wagner(aka Wagnerp) & Simon Coghlan(aka Smurf-IV), et al. 2017 - 2021. All rights reserved. 
 *  
 */
#endregion

using System;
using System.Threading;
using System.Windows.Forms;

using Krypton.Toolkit;

namespace KryptonToolkitHub.Classes
{
    /// <summary>
    ///     Fades the selected <see cref="KryptonForm" /> or <see cref="Form" /> in and out.
    /// </summary>
    public class FadeEffects
    {
        #region Variables

        #endregion

        #region Constructor

        #endregion

        #region De constructor

        /// <summary>
        ///     Finalises an instance of the <see cref="FadeEffects" /> class.
        /// </summary>
        ~FadeEffects()
        {
            GC.SuppressFinalize(this);
        }

        #endregion

        #region Properties

        /// <summary>
        ///     Gets or sets the fade in value.
        /// </summary>
        /// <value>
        ///     The fade in value.
        /// </value>
        private double FadeIn { get; set; }

        /// <summary>
        ///     Gets or sets the fade out value.
        /// </summary>
        /// <value>
        ///     The fade out value.
        /// </value>
        private double FadeOut { get; set; }

        #endregion

        #region Methods

        #region Fade In

        /// <summary>
        ///     Fades the form in.
        ///     Use this in your 'Form_Load' event.
        /// </summary>
        /// <param name="kryptonWindow">The krypton window.</param>
        /// <param name="window">The window.</param>
        /// <param name="fadeInSleepTimer">The fade in sleep timer.</param>
        public void FadeInWindow(KryptonForm kryptonWindow, Form window = null, int fadeInSleepTimer = 50)
        {
            for (FadeIn = 0.0; FadeIn <= 1.1; FadeIn += 0.1)
            {
                if (window != null)
                {
                    window.Opacity = FadeIn;

                    window.Refresh();
                }
                else
                {
                    kryptonWindow.Opacity = FadeIn;

                    kryptonWindow.Refresh();
                }

                Thread.Sleep(fadeInSleepTimer);
            }
        }

        #endregion

        #region Fade Out

        /// <summary>
        ///     Fades the out window.
        /// </summary>
        /// <param name="currentKryptonWindow">The current krypton window.</param>
        /// <param name="nextKryptonWindow">The next krypton window.</param>
        /// <param name="currentWindow">The current window.</param>
        /// <param name="nextWindow">The next window.</param>
        /// <param name="fadeOutSleepTimer">The fade out sleep timer.</param>
        public void FadeOutWindow(KryptonForm currentKryptonWindow, KryptonForm nextKryptonWindow,
            Form currentWindow = null, Form nextWindow = null, int fadeOutSleepTimer = 50)
        {
            for (FadeOut = 90; FadeOut >= 10; FadeOut += -10)
            {
                if (nextWindow != null)
                {
                    nextWindow.Opacity = FadeOut / 100;

                    nextWindow.Refresh();
                }
                else
                {
                    currentKryptonWindow.Opacity = FadeOut / 100;

                    currentKryptonWindow.Refresh();
                }

                Thread.Sleep(fadeOutSleepTimer);
            }

            if (nextWindow != null)
                nextWindow.Show();
            else
                nextKryptonWindow.Show();
        }

        #endregion

        #endregion
    }
}