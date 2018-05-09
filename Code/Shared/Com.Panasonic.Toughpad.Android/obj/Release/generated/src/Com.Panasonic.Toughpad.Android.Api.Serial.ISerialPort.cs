using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Serial {

	[Register ("com/panasonic/toughpad/android/api/serial/SerialPort", DoNotGenerateAcw=true)]
	public abstract class SerialPort : Java.Lang.Object {

		internal SerialPort ()
		{
		}

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

	[Register ("com/panasonic/toughpad/android/api/serial/SerialPort", DoNotGenerateAcw=true)]
	[global::System.Obsolete ("Use the 'SerialPort' type. This type will be removed in a future release.")]
	public abstract class SerialPortConsts : SerialPort {

		private SerialPortConsts ()
		{
		}
	}

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']"
	[Register ("com/panasonic/toughpad/android/api/serial/SerialPort", "", "Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker")]
	public partial interface ISerialPort : IJavaObject {

		string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::System.IO.Stream InputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='getInputStream' and count(parameter)=0]"
			[Register ("getInputStream", "()Ljava/io/InputStream;", "GetGetInputStreamHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		global::System.IO.Stream OutputStream {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='getOutputStream' and count(parameter)=0]"
			[Register ("getOutputStream", "()Ljava/io/OutputStream;", "GetGetOutputStreamHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.serial']/interface[@name='SerialPort']/method[@name='enable' and count(parameter)=5 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int']]"
		[Register ("enable", "(IIIII)V", "GetEnable_IIIIIHandler:Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPortInvoker, Com.Panasonic.Toughpad.Android")]
		void Enable (int p0, int p1, int p2, int p3, int p4);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/serial/SerialPort", DoNotGenerateAcw=true)]
	internal class ISerialPortInvoker : global::Java.Lang.Object, ISerialPort {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/serial/SerialPort");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (ISerialPortInvoker); }
		}

		IntPtr class_ref;

		public static ISerialPort GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<ISerialPort> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.serial.SerialPort"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public ISerialPortInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceName;
		public unsafe string DeviceName {
			get {
				if (id_getDeviceName == IntPtr.Zero)
					id_getDeviceName = JNIEnv.GetMethodID (class_ref, "getDeviceName", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceName), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.InputStreamAdapter.ToLocalJniHandle (__this.InputStream);
		}
#pragma warning restore 0169

		IntPtr id_getInputStream;
		public unsafe global::System.IO.Stream InputStream {
			get {
				if (id_getInputStream == IntPtr.Zero)
					id_getInputStream = JNIEnv.GetMethodID (class_ref, "getInputStream", "()Ljava/io/InputStream;");
				return global::Android.Runtime.InputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getInputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		IntPtr id_isEnabled;
		public unsafe bool IsEnabled {
			get {
				if (id_isEnabled == IntPtr.Zero)
					id_isEnabled = JNIEnv.GetMethodID (class_ref, "isEnabled", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isEnabled);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return global::Android.Runtime.OutputStreamAdapter.ToLocalJniHandle (__this.OutputStream);
		}
#pragma warning restore 0169

		IntPtr id_getOutputStream;
		public unsafe global::System.IO.Stream OutputStream {
			get {
				if (id_getOutputStream == IntPtr.Zero)
					id_getOutputStream = JNIEnv.GetMethodID (class_ref, "getOutputStream", "()Ljava/io/OutputStream;");
				return global::Android.Runtime.OutputStreamInvoker.FromJniHandle (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getOutputStream), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		IntPtr id_disable;
		public unsafe void Disable ()
		{
			if (id_disable == IntPtr.Zero)
				id_disable = JNIEnv.GetMethodID (class_ref, "disable", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_disable);
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
			global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Serial.ISerialPort> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0, p1, p2, p3, p4);
		}
#pragma warning restore 0169

		IntPtr id_enable_IIIII;
		public unsafe void Enable (int p0, int p1, int p2, int p3, int p4)
		{
			if (id_enable_IIIII == IntPtr.Zero)
				id_enable_IIIII = JNIEnv.GetMethodID (class_ref, "enable", "(IIIII)V");
			JValue* __args = stackalloc JValue [5];
			__args [0] = new JValue (p0);
			__args [1] = new JValue (p1);
			__args [2] = new JValue (p2);
			__args [3] = new JValue (p3);
			__args [4] = new JValue (p4);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_IIIII, __args);
		}

	}

}
