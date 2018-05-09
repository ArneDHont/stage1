using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Pwrmgmt {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/pwrmgmt/PortPowerManager", DoNotGenerateAcw=true)]
	public sealed partial class PortPowerManager : global::Java.Lang.Object {


		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/field[@name='PORT_GADGET']"
		[Register ("PORT_GADGET")]
		public const int PortGadget = (int) 2;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/field[@name='PORT_MICRO_USB']"
		[Register ("PORT_MICRO_USB")]
		public const int PortMicroUsb = (int) 1;
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/pwrmgmt/PortPowerManager", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (PortPowerManager); }
		}

		internal PortPowerManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_isPortAvailable_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/method[@name='isPortAvailable' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isPortAvailable", "(I)Z", "")]
		public static unsafe bool IsPortAvailable (int p0)
		{
			if (id_isPortAvailable_I == IntPtr.Zero)
				id_isPortAvailable_I = JNIEnv.GetStaticMethodID (class_ref, "isPortAvailable", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isPortAvailable_I, __args);
			} finally {
			}
		}

		static IntPtr id_isSelectiveSuspend_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/method[@name='isSelectiveSuspend' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isSelectiveSuspend", "(I)Z", "")]
		public static unsafe bool IsSelectiveSuspend (int p0)
		{
			if (id_isSelectiveSuspend_I == IntPtr.Zero)
				id_isSelectiveSuspend_I = JNIEnv.GetStaticMethodID (class_ref, "isSelectiveSuspend", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isSelectiveSuspend_I, __args);
			} finally {
			}
		}

		static IntPtr id_isVBUSSupply_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/method[@name='isVBUSSupply' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("isVBUSSupply", "(I)Z", "")]
		public static unsafe bool IsVBUSSupply (int p0)
		{
			if (id_isVBUSSupply_I == IntPtr.Zero)
				id_isVBUSSupply_I = JNIEnv.GetStaticMethodID (class_ref, "isVBUSSupply", "(I)Z");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				return JNIEnv.CallStaticBooleanMethod  (class_ref, id_isVBUSSupply_I, __args);
			} finally {
			}
		}

		static IntPtr id_setSelectiveSuspend_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/method[@name='setSelectiveSuspend' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setSelectiveSuspend", "(IZ)V", "")]
		public static unsafe void SetSelectiveSuspend (int p0, bool p1)
		{
			if (id_setSelectiveSuspend_IZ == IntPtr.Zero)
				id_setSelectiveSuspend_IZ = JNIEnv.GetStaticMethodID (class_ref, "setSelectiveSuspend", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setSelectiveSuspend_IZ, __args);
			} finally {
			}
		}

		static IntPtr id_setVBUSSupply_IZ;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.pwrmgmt']/class[@name='PortPowerManager']/method[@name='setVBUSSupply' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='boolean']]"
		[Register ("setVBUSSupply", "(IZ)V", "")]
		public static unsafe void SetVBUSSupply (int p0, bool p1)
		{
			if (id_setVBUSSupply_IZ == IntPtr.Zero)
				id_setVBUSSupply_IZ = JNIEnv.GetStaticMethodID (class_ref, "setVBUSSupply", "(IZ)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				JNIEnv.CallStaticVoidMethod  (class_ref, id_setVBUSSupply_IZ, __args);
			} finally {
			}
		}

	}
}
