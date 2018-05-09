using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Magstripe {

	// Metadata.xml XPath interface reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']"
	[Register ("com/panasonic/toughpad/android/api/magstripe/MagStripeReader", "", "Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker")]
	public partial interface IMagStripeReader : IJavaObject {

		int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='getDeviceName' and count(parameter)=0]"
			[Register ("getDeviceName", "()Ljava/lang/String;", "GetGetDeviceNameHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='isEnabled' and count(parameter)=0]"
			[Register ("isEnabled", "()Z", "GetIsEnabledHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")] get;
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='addMagStripeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeListener']]"
		[Register ("addMagStripeListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V", "GetAddMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void AddMagStripeListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='clearMagStripeListeners' and count(parameter)=0]"
		[Register ("clearMagStripeListeners", "()V", "GetClearMagStripeListenersHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void ClearMagStripeListeners ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='disable' and count(parameter)=0]"
		[Register ("disable", "()V", "GetDisableHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Disable ();

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void Enable (long p0);

		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/interface[@name='MagStripeReader']/method[@name='removeMagStripeRListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeListener']]"
		[Register ("removeMagStripeRListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V", "GetRemoveMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler:Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReaderInvoker, Com.Panasonic.Toughpad.Android")]
		void RemoveMagStripeRListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0);

	}

	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/magstripe/MagStripeReader", DoNotGenerateAcw=true)]
	internal class IMagStripeReaderInvoker : global::Java.Lang.Object, IMagStripeReader {

		static IntPtr java_class_ref = JNIEnv.FindClass ("com/panasonic/toughpad/android/api/magstripe/MagStripeReader");

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (IMagStripeReaderInvoker); }
		}

		IntPtr class_ref;

		public static IMagStripeReader GetObject (IntPtr handle, JniHandleOwnership transfer)
		{
			return global::Java.Lang.Object.GetObject<IMagStripeReader> (handle, transfer);
		}

		static IntPtr Validate (IntPtr handle)
		{
			if (!JNIEnv.IsInstanceOf (handle, java_class_ref))
				throw new InvalidCastException (string.Format ("Unable to convert instance of type '{0}' to type '{1}'.",
							JNIEnv.GetClassNameFromInstance (handle), "com.panasonic.toughpad.android.api.magstripe.MagStripeReader"));
			return handle;
		}

		protected override void Dispose (bool disposing)
		{
			if (this.class_ref != IntPtr.Zero)
				JNIEnv.DeleteGlobalRef (this.class_ref);
			this.class_ref = IntPtr.Zero;
			base.Dispose (disposing);
		}

		public IMagStripeReaderInvoker (IntPtr handle, JniHandleOwnership transfer) : base (Validate (handle), transfer)
		{
			IntPtr local_ref = JNIEnv.GetObjectClass (((global::Java.Lang.Object) this).Handle);
			this.class_ref = JNIEnv.NewGlobalRef (local_ref);
			JNIEnv.DeleteLocalRef (local_ref);
		}

		static Delegate cb_getBatteryCharge;
#pragma warning disable 0169
		static Delegate GetGetBatteryChargeHandler ()
		{
			if (cb_getBatteryCharge == null)
				cb_getBatteryCharge = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetBatteryCharge);
			return cb_getBatteryCharge;
		}

		static int n_GetBatteryCharge (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatteryCharge;
		}
#pragma warning restore 0169

		IntPtr id_getBatteryCharge;
		public unsafe int BatteryCharge {
			get {
				if (id_getBatteryCharge == IntPtr.Zero)
					id_getBatteryCharge = JNIEnv.GetMethodID (class_ref, "getBatteryCharge", "()I");
				return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryCharge);
			}
		}

		static Delegate cb_getDeviceFirmwareVersion;
#pragma warning disable 0169
		static Delegate GetGetDeviceFirmwareVersionHandler ()
		{
			if (cb_getDeviceFirmwareVersion == null)
				cb_getDeviceFirmwareVersion = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceFirmwareVersion);
			return cb_getDeviceFirmwareVersion;
		}

		static IntPtr n_GetDeviceFirmwareVersion (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFirmwareVersion);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceFirmwareVersion;
		public unsafe string DeviceFirmwareVersion {
			get {
				if (id_getDeviceFirmwareVersion == IntPtr.Zero)
					id_getDeviceFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFirmwareVersion", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFirmwareVersion), JniHandleOwnership.TransferLocalRef);
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
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_getDeviceSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetDeviceSerialNumberHandler ()
		{
			if (cb_getDeviceSerialNumber == null)
				cb_getDeviceSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetDeviceSerialNumber);
			return cb_getDeviceSerialNumber;
		}

		static IntPtr n_GetDeviceSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSerialNumber);
		}
#pragma warning restore 0169

		IntPtr id_getDeviceSerialNumber;
		public unsafe string DeviceSerialNumber {
			get {
				if (id_getDeviceSerialNumber == IntPtr.Zero)
					id_getDeviceSerialNumber = JNIEnv.GetMethodID (class_ref, "getDeviceSerialNumber", "()Ljava/lang/String;");
				return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSerialNumber), JniHandleOwnership.TransferLocalRef);
			}
		}

		static Delegate cb_isBatteryCharging;
#pragma warning disable 0169
		static Delegate GetIsBatteryChargingHandler ()
		{
			if (cb_isBatteryCharging == null)
				cb_isBatteryCharging = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsBatteryCharging);
			return cb_isBatteryCharging;
		}

		static bool n_IsBatteryCharging (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBatteryCharging;
		}
#pragma warning restore 0169

		IntPtr id_isBatteryCharging;
		public unsafe bool IsBatteryCharging {
			get {
				if (id_isBatteryCharging == IntPtr.Zero)
					id_isBatteryCharging = JNIEnv.GetMethodID (class_ref, "isBatteryCharging", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatteryCharging);
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
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_isExternal;
#pragma warning disable 0169
		static Delegate GetIsExternalHandler ()
		{
			if (cb_isExternal == null)
				cb_isExternal = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsExternal);
			return cb_isExternal;
		}

		static bool n_IsExternal (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExternal;
		}
#pragma warning restore 0169

		IntPtr id_isExternal;
		public unsafe bool IsExternal {
			get {
				if (id_isExternal == IntPtr.Zero)
					id_isExternal = JNIEnv.GetMethodID (class_ref, "isExternal", "()Z");
				return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExternal);
			}
		}

		static Delegate cb_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
#pragma warning disable 0169
		static Delegate GetAddMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler ()
		{
			if (cb_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == null)
				cb_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_AddMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_);
			return cb_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		}

		static void n_AddMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMagStripeListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		public unsafe void AddMagStripeListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0)
		{
			if (id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == IntPtr.Zero)
				id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNIEnv.GetMethodID (class_ref, "addMagStripeListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_, __args);
		}

		static Delegate cb_clearMagStripeListeners;
#pragma warning disable 0169
		static Delegate GetClearMagStripeListenersHandler ()
		{
			if (cb_clearMagStripeListeners == null)
				cb_clearMagStripeListeners = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr>) n_ClearMagStripeListeners);
			return cb_clearMagStripeListeners;
		}

		static void n_ClearMagStripeListeners (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMagStripeListeners ();
		}
#pragma warning restore 0169

		IntPtr id_clearMagStripeListeners;
		public unsafe void ClearMagStripeListeners ()
		{
			if (id_clearMagStripeListeners == IntPtr.Zero)
				id_clearMagStripeListeners = JNIEnv.GetMethodID (class_ref, "clearMagStripeListeners", "()V");
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearMagStripeListeners);
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
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
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

		static Delegate cb_enable_J;
#pragma warning disable 0169
		static Delegate GetEnable_JHandler ()
		{
			if (cb_enable_J == null)
				cb_enable_J = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, long>) n_Enable_J);
			return cb_enable_J;
		}

		static void n_Enable_J (IntPtr jnienv, IntPtr native__this, long p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		IntPtr id_enable_J;
		public unsafe void Enable (long p0)
		{
			if (id_enable_J == IntPtr.Zero)
				id_enable_J = JNIEnv.GetMethodID (class_ref, "enable", "(J)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_J, __args);
		}

		static Delegate cb_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
#pragma warning disable 0169
		static Delegate GetRemoveMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler ()
		{
			if (cb_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == null)
				cb_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_RemoveMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_);
			return cb_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		}

		static void n_RemoveMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMagStripeRListener (p0);
		}
#pragma warning restore 0169

		IntPtr id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		public unsafe void RemoveMagStripeRListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0)
		{
			if (id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == IntPtr.Zero)
				id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNIEnv.GetMethodID (class_ref, "removeMagStripeRListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V");
			JValue* __args = stackalloc JValue [1];
			__args [0] = new JValue (p0);
			JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_, __args);
		}

	}

}
