﻿#pragma checksum "C:\Users\Andy\SkyDrive\WP8 JumpStart LIVE\S12 NFC and Bluetooth Demos\2 - NFCMessageExchange\NFCMessageExchange\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "429F5641C3ADCCFDDBDD98ED2E7432D0"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18010
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace NFCMessageExchange {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.Button PublishMessageButton;
        
        internal System.Windows.Controls.Button StopPublishingMessageButton;
        
        internal System.Windows.Controls.TextBox MessageTextBox;
        
        internal System.Windows.Controls.Button PublishUriButton;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/NFCMessageExchange;component/MainPage.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.PublishMessageButton = ((System.Windows.Controls.Button)(this.FindName("PublishMessageButton")));
            this.StopPublishingMessageButton = ((System.Windows.Controls.Button)(this.FindName("StopPublishingMessageButton")));
            this.MessageTextBox = ((System.Windows.Controls.TextBox)(this.FindName("MessageTextBox")));
            this.PublishUriButton = ((System.Windows.Controls.Button)(this.FindName("PublishUriButton")));
        }
    }
}

