﻿using Xamarin.UITest;

namespace TestUtils.Appium.UITests
{
	public interface IApp2 : IApp, IDisposable
	{
		bool IsKeyboardShown();
		void ActivateApp();
		void CloseApp();
		string ElementTree { get; }
		ApplicationState AppState { get; }
		bool WaitForTextToBePresentInElement(string automationId, string text);
		public byte[] Screenshot();
	}
}
