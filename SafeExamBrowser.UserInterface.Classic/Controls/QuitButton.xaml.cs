﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using SafeExamBrowser.Contracts.UserInterface.Taskbar.Events;
using SafeExamBrowser.UserInterface.Classic.Utilities;

namespace SafeExamBrowser.UserInterface.Classic.Controls
{
	public partial class QuitButton : UserControl
	{
		public event QuitButtonClickedEventHandler Clicked;

		public QuitButton()
		{
			InitializeComponent();
			LoadIcon();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			Clicked?.Invoke(new CancelEventArgs());
		}

		private void LoadIcon()
		{
			var uri = new Uri("pack://application:,,,/SafeExamBrowser.UserInterface.Classic;component/Images/ShutDown.xaml");
			var resource = new XamlIconResource(uri);

			Button.Content = IconResourceLoader.Load(resource);
		}
	}
}
