using ChatAppTutorial.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Data;
using System.Windows.Input;

namespace ChatAppTutorial.ViewModel
{
    class WindowViewModel : BaseViewModel
    {
        #region Private Member
        private Window window;
        private int mOuterMarginSize = 10;
        private int mWindowRadius = 10;
        private WindowDockPosition mWindowDockPosition=WindowDockPosition.Undocked;
        
        #endregion
        #region Commands
        public ICommand MinimizeCommand { get; }
        public ICommand MaximizeCommand { get; }
        public ICommand CloseCommand { get; }
        public ICommand MenuCommand { get; }
        #endregion
        #region Public Members
        public int ResizeBorder { get { return Borderless ? 0 : 6; } }
        public int TitleHeight { get; set; } = 42;
        public double WindowMinWidth { get; set; } = 400;
        public double WindowMinHeight { get; set; } = 400;
        public Thickness ResizeBorderThickness { get { return new Thickness(ResizeBorder + OuterMarginSize); } }

        public Thickness InnerContentPadding { get; }=new Thickness(0);
        public bool Borderless { get { return (window.WindowState == WindowState.Maximized || mWindowDockPosition != WindowDockPosition.Undocked); } }
        public int OuterMarginSize
        {
            get
            {
                // If it is maximized or docked, no border
                return Borderless ? 0 : mOuterMarginSize;
            }
            set
            {
                mOuterMarginSize = value;
            }
        }
        public GridLength TitleHeightGridLenght
        {
            get
            {
                return new GridLength(TitleHeight+ResizeBorder);
            }
            
        }

        public Thickness OuterMarginThickness { get { return new Thickness(OuterMarginSize); } }
        public CornerRadius WindowCornerRadius
        {
            get { return new CornerRadius(WindowRadius); }
        }
        public int WindowRadius
        {
            get
            {
                // If it is maximized or docked, no border
                return Borderless ? 0 : mWindowRadius;
            }
            set
            {
                mWindowRadius = value;
            }
        }

        public ApplicationPage CurrentPage { get; set; }=ApplicationPage.Login;
        #endregion
        #region Constructor
        public WindowViewModel( Window window)
        {
            this.window = window;

            window.StateChanged += (sender, e) =>
            {
                WindowResized();
            };
            MinimizeCommand = new RellayCommand(()=>window.WindowState=WindowState.Minimized);
            MaximizeCommand = new RellayCommand(()=>window.WindowState^=WindowState.Maximized);
            CloseCommand = new RellayCommand(() => window.Close());
            MenuCommand = new RellayCommand(()=> SystemCommands.ShowSystemMenu(window,GetMousePosition()));

            var resizer=new WindowResizer(window);
            resizer.WindowDockChanged += (dock) =>
            {
                // Store last position
                mWindowDockPosition = dock;

                // Fire off resize events
                WindowResized();
            };
        }
        #endregion

        #region Private Helpers
        /// <summary>
        /// Gets the current mouse position on the screen
        /// </summary>
        /// <returns></returns>
        private Point GetMousePosition()
        {
            // Position of the mouse relative to the window
            var position = Mouse.GetPosition(window);

            // Add the window position so its a "ToScreen"
            return new Point(position.X + window.Left, position.Y + window.Top);
        }
        private void WindowResized()
        {
            // Fire off events for all properties that are affected by a resize
            OnPropertyChanged(nameof(Borderless));
            OnPropertyChanged(nameof(ResizeBorderThickness));
            OnPropertyChanged(nameof(OuterMarginSize));
            OnPropertyChanged(nameof(OuterMarginThickness));
            OnPropertyChanged(nameof(WindowRadius));
            OnPropertyChanged(nameof(WindowCornerRadius));
        }

        #endregion
    }
}
