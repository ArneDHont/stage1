using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Cradle {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/cradle/Cradle", DoNotGenerateAcw=true)]
	public sealed partial class Cradle : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='ACTION_CRADLE_CHANGED']"
		[Register ("ACTION_CRADLE_CHANGED")]
		public const string ActionCradleChanged = (string) "com.panasonic.toughpad.android.api.cradle.intent.CRADLE_CHANGED";

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='CRADLE_TYPE_COMMUNICATION']"
		[Register ("CRADLE_TYPE_COMMUNICATION")]
		public const int CradleTypeCommunication = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='CRADLE_TYPE_ERROR']"
		[Register ("CRADLE_TYPE_ERROR")]
		public const int CradleTypeError = (int) -1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='CRADLE_TYPE_NONE']"
		[Register ("CRADLE_TYPE_NONE")]
		public const int CradleTypeNone = (int) 0;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='CRADLE_TYPE_NORMAL']"
		[Register ("CRADLE_TYPE_NORMAL")]
		public const int CradleTypeNormal = (int) 1;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/field[@name='EXTRA_CRADLE_TYPE']"
		[Register ("EXTRA_CRADLE_TYPE")]
		public const string ExtraCradleType = (string) "cradleType";
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/cradle/Cradle", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (Cradle); }
		}

		internal Cradle (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_getCradleType;
		public static unsafe int CradleType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.cradle']/class[@name='Cradle']/method[@name='getCradleType' and count(parameter)=0]"
			[Register ("getCradleType", "()I", "GetGetCradleTypeHandler")]
			get {
				if (id_getCradleType == IntPtr.Zero)
					id_getCradleType = JNIEnv.GetStaticMethodID (class_ref, "getCradleType", "()I");
				try {
					return JNIEnv.CallStaticIntMethod  (class_ref, id_getCradleType);
				} finally {
				}
			}
		}

	}
}
