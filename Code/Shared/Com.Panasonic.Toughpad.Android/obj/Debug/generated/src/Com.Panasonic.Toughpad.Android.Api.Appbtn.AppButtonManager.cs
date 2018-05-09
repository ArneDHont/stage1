using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Appbtn {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/appbtn/AppButtonManager", DoNotGenerateAcw=true)]
	public sealed partial class AppButtonManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='ACTION_APPBUTTON']"
		[Register ("ACTION_APPBUTTON")]
		public const string ActionAppbutton = (string) "com.panasonic.toughpad.android.api.appbutton.intent.APPBUTTON";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='BUTTON_A1']"
		[Register ("BUTTON_A1")]
		public const int ButtonA1 = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='BUTTON_A2']"
		[Register ("BUTTON_A2")]
		public const int ButtonA2 = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='BUTTON_A3']"
		[Register ("BUTTON_A3")]
		public const int ButtonA3 = (int) 3;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='BUTTON_SIDE']"
		[Register ("BUTTON_SIDE")]
		public const int ButtonSide = (int) 5;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='BUTTON_USER']"
		[Register ("BUTTON_USER")]
		public const int ButtonUser = (int) 4;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='EXTRA_APPBUTTON_BUTTON']"
		[Register ("EXTRA_APPBUTTON_BUTTON")]
		public const string ExtraAppbuttonButton = (string) "button";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='EXTRA_APPBUTTON_STATE']"
		[Register ("EXTRA_APPBUTTON_STATE")]
		public const string ExtraAppbuttonState = (string) "state";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='EXTRA_APPBUTTON_STATE_DOWN']"
		[Register ("EXTRA_APPBUTTON_STATE_DOWN")]
		public const int ExtraAppbuttonStateDown = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/field[@name='EXTRA_APPBUTTON_STATE_UP']"
		[Register ("EXTRA_APPBUTTON_STATE_UP")]
		public const int ExtraAppbuttonStateUp = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/appbtn/AppButtonManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (AppButtonManager); }
		}

		internal AppButtonManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_hasButtonControl;
		public static unsafe bool HasButtonControl {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/method[@name='hasButtonControl' and count(parameter)=0]"
			[Register ("hasButtonControl", "()Z", "GetHasButtonControlHandler")]
			get {
				if (id_hasButtonControl == IntPtr.Zero)
					id_hasButtonControl = JNIEnv.GetStaticMethodID (class_ref, "hasButtonControl", "()Z");
				try {
					return JNIEnv.CallStaticBooleanMethod  (class_ref, id_hasButtonControl);
				} finally {
				}
			}
		}

		static IntPtr id_isButtonAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.appbtn']/class[@name='AppButtonManager']/method[@name='isButtonAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isButtonAvailable", "(I)Z", "")]
		public static unsafe bool IsButtonAvailable (int p0)
		{
			if (id_isButtonAvailable_I == IntPtr.Zero)
				id_isButtonAvailable_I = JNIEnv.GetStaticMethodID (class_ref, "isButtonAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isButtonAvailable_I, __args);
			} finally {
			}
		}

	}
}
