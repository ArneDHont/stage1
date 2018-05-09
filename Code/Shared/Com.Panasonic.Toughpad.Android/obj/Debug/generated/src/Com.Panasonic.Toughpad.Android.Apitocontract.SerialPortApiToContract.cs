using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Apitocontract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/apitocontract/SerialPortApiToContract", DoNotGenerateAcw=true)]
	public partial class SerialPortApiToContract : global::Java.Lang.Object, global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort {


		public static class InterfaceConsts {

			// The following are fields from: com.panasonic.toughpad.android.api.serial.SerialPort

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_115200']"
			[Register ("BAUDRATE_115200")]
			public const int Baudrate115200 = (int) 17;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_1200']"
			[Register ("BAUDRATE_1200")]
			public const int Baudrate1200 = (int) 9;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_1800']"
			[Register ("BAUDRATE_1800")]
			public const int Baudrate1800 = (int) 10;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_19200']"
			[Register ("BAUDRATE_19200")]
			public const int Baudrate19200 = (int) 14;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_2400']"
			[Register ("BAUDRATE_2400")]
			public const int Baudrate2400 = (int) 11;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_300']"
			[Register ("BAUDRATE_300")]
			public const int Baudrate300 = (int) 7;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_38400']"
			[Register ("BAUDRATE_38400")]
			public const int Baudrate38400 = (int) 15;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_4800']"
			[Register ("BAUDRATE_4800")]
			public const int Baudrate4800 = (int) 12;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_57600']"
			[Register ("BAUDRATE_57600")]
			public const int Baudrate57600 = (int) 16;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_600']"
			[Register ("BAUDRATE_600")]
			public const int Baudrate600 = (int) 8;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='BAUDRATE_9600']"
			[Register ("BAUDRATE_9600")]
			public const int Baudrate9600 = (int) 13;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='DATASIZE_5']"
			[Register ("DATASIZE_5")]
			public const int Datasize5 = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='DATASIZE_6']"
			[Register ("DATASIZE_6")]
			public const int Datasize6 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='DATASIZE_7']"
			[Register ("DATASIZE_7")]
			public const int Datasize7 = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='DATASIZE_8']"
			[Register ("DATASIZE_8")]
			public const int Datasize8 = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='FLOWCONTROL_NONE']"
			[Register ("FLOWCONTROL_NONE")]
			public const int FlowcontrolNone = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='FLOWCONTROL_RTS_CTS']"
			[Register ("FLOWCONTROL_RTS_CTS")]
			public const int FlowcontrolRtsCts = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='FLOWCONTROL_XON_XOFF']"
			[Register ("FLOWCONTROL_XON_XOFF")]
			public const int FlowcontrolXonXoff = (int) 3;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='PARITY_EVEN']"
			[Register ("PARITY_EVEN")]
			public const int ParityEven = (int) 2;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='PARITY_NONE']"
			[Register ("PARITY_NONE")]
			public const int ParityNone = (int) 0;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='PARITY_ODD']"
			[Register ("PARITY_ODD")]
			public const int ParityOdd = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='STOPBITS_1']"
			[Register ("STOPBITS_1")]
			public const int Stopbits1 = (int) 1;

			// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/field[@name='STOPBITS_2']"
			[Register ("STOPBITS_2")]
			public const int Stopbits2 = (int) 2;
		}

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/apitocontract/SerialPortApiToContract", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (SerialPortApiToContract); }
		}

		protected SerialPortApiToContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_panasonic_toughpad_android_contract_ISerialPort_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/constructor[@name='SerialPortApiToContract' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.ISerialPort']]"
		[Register (".ctor", "(Lcom/panasonic/toughpad/android/contract/ISerialPort;)V", "")]
		public unsafe SerialPortApiToContract (global::Com.Panasonic.Toughpad.Android.Contract.ISerialPort p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (SerialPortApiToContract)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/panasonic/toughpad/android/contract/ISerialPort;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/panasonic/toughpad/android/contract/ISerialPort;)V", __args);
					return;
				}

				if (id_ctor_Lcom_panasonic_toughpad_android_contract_ISerialPort_ == IntPtr.Zero)
					id_ctor_Lcom_panasonic_toughpad_android_contract_ISerialPort_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/panasonic/toughpad/android/contract/ISerialPort;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_ISerialPort_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_ISerialPort_, __args);
			} finally {
			}
		}

		static Delegate cb_getDeviceName;
#pragma warning disable 0169
		static Delegate GetGetDeviceNameHandler ()
		{
			if (cb_getDeviceName == null)
				cb_getDeviceName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceName);
			return cb_getDeviceName;
		}

		static IntPtr n_GetDeviceName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceName;
		public virtual unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler")]
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getInputStream;
#pragma warning disable 0169
		static Delegate GetGetInputStreamHandler ()
		{
			if (cb_getInputStream == null)
				cb_getInputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetInputStream);
			return cb_getInputStream;
		}

		static IntPtr n_GetInputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getInputStream;
		public virtual unsafe global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler")]
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getInputStream", "()Ljava/io/InputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_isEnabled;
#pragma warning disable 0169
		static Delegate GetIsEnabledHandler ()
		{
			if (cb_isEnabled == null)
				cb_isEnabled = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsEnabled);
			return cb_isEnabled;
		}

		static bool n_IsEnabled (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler")]
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isEnabled", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_getOutputStream;
#pragma warning disable 0169
		static Delegate GetGetOutputStreamHandler ()
		{
			if (cb_getOutputStream == null)
				cb_getOutputStream = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetOutputStream);
			return cb_getOutputStream;
		}

		static IntPtr n_GetOutputStream (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		static IntPtr id_getOutputStream;
		public virtual unsafe global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler")]
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
					else
						return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getOutputStream", "()Ljava/io/OutputStream;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_disable;
#pragma warning disable 0169
		static Delegate GetDisableHandler ()
		{
			if (cb_disable == null)
				cb_disable = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_Disable);
			return cb_disable;
		}

		static void n_Disable (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler")]
		public virtual unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "disable", "()V"));
			} finally {
			}
		}

		static Delegate cb_enable_IIIII;
#pragma warning disable 0169
		static Delegate GetEnable_IIIIIHandler ()
		{
			if (cb_enable_IIIII == null)
				cb_enable_IIIII = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, int, int, int, int, int>) n_Enable_IIIII);
			return cb_enable_IIIII;
		}

		static void n_Enable_IIIII (IntPtr jnienv, IntPtr native__this, int p0, int p1, int p2, int p3, int p4)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.SerialPortApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		static IntPtr id_enable_IIIII;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='SerialPortApiToContract']/method[@name='enable' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("enable", "(IIIII)V", "GetEnable_IIIIIHandler")]
		public virtual unsafe void Enable (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_enable_IIIII == IntPtr.Zero)
				id_enable_IIIII = JNIEnv.GetMethodID (class_ref, "enable", "(IIIII)V");
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				__args [2] = new JValue (p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_IIIII, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(IIIII)V"), __args);
			} finally {
			}
		}

	}
}
