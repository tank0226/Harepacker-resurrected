﻿/* Copyright (C) 2020 LastBattle
* https://github.com/lastbattle/Harepacker-resurrected
* 
* This Source Code Form is subject to the terms of the Mozilla Public
* License, v. 2.0. If a copy of the MPL was not distributed with this
* file, You can obtain one at http://mozilla.org/MPL/2.0/. */


using HaRepacker.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace HaRepacker.Converter
{
	/// <summary>
	/// Converts the image (x, y) width or height to the correct size according to the screen's DPI scaling factor
	/// </summary>
    public class ImageWidthOrHeightToScreenDPIConverter : IValueConverter
	{
		public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
			int widthOrHeight = (int)value;
			int realWidthOrHeightToDisplay = (int) ((double) widthOrHeight * ScreenDPIUtil.GetScreenScaleFactor());

			return realWidthOrHeightToDisplay;
		}

		public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
		{
            int value_ = (int)value;
            int imageWidthOrHeight = (int) ((double)value_ / ScreenDPIUtil.GetScreenScaleFactor());

			return imageWidthOrHeight;
		}
	}
}
