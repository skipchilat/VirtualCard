﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;
using System.Data.Linq;
using System.Data.Linq.Mapping;
using System.ComponentModel;
using System.Collections.ObjectModel;

namespace VirtualCard

{
    
    public partial class AddCard : PhoneApplicationPage
    {
        public AddCard()
        {
            InitializeComponent();
        }

       

        private void lstCardType_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
           
            
        }
    }
}