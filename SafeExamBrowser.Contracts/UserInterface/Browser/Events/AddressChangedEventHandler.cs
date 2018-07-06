﻿/*
 * Copyright (c) 2018 ETH Zürich, Educational Development and Technology (LET)
 * 
 * This Source Code Form is subject to the terms of the Mozilla Public
 * License, v. 2.0. If a copy of the MPL was not distributed with this
 * file, You can obtain one at http://mozilla.org/MPL/2.0/.
 */

namespace SafeExamBrowser.Contracts.UserInterface.Browser.Events
{
	/// <summary>
	/// Indicates that the address has changed to the specified value.
	/// </summary>
	public delegate void AddressChangedEventHandler(string address);
}
