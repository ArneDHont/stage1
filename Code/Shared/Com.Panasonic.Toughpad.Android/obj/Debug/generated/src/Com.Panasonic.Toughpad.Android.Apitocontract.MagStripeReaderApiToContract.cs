using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Apitocontract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/apitocontract/MagStripeReaderApiToContract", DoNotGenerateAcw=true)]
	public partial class MagStripeReaderApiToContract : global::Com.Panasonic.Toughpad.Android.Contract.MagStripeListenerStub, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeReader {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/apitocontract/MagStripeReaderApiToContract", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagStripeReaderApiToContract); }
		}

		protected MagStripeReaderApiToContract (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/constructor[@name='MagStripeReaderApiToContract' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader']]"
		[Register (".ctor", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;)V", "")]
		public unsafe MagStripeReaderApiToContract (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MagStripeReaderApiToContract)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;)V", __args);
					return;
				}

				if (id_ctor_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_ == IntPtr.Zero)
					id_ctor_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_, __args);
			} finally {
			}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.BatteryCharge;
		}
#pragma warning restore 0169

		static IntPtr id_getBatteryCharge;
		public virtual unsafe int BatteryCharge {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='getBatteryCharge' and count(parameter)=0]"
			[Register ("getBatteryCharge", "()I", "GetGetBatteryChargeHandler")]
			get {
				if (id_getBatteryCharge == IntPtr.Zero)
					id_getBatteryCharge = JNIEnv.GetMethodID (class_ref, "getBatteryCharge", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getBatteryCharge);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getBatteryCharge", "()I"));
				} finally {
				}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceFirmwareVersion);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceFirmwareVersion;
		public virtual unsafe string DeviceFirmwareVersion {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='getDeviceFirmwareVersion' and count(parameter)=0]"
			[Register ("getDeviceFirmwareVersion", "()Ljava/lang/String;", "GetGetDeviceFirmwareVersionHandler")]
			get {
				if (id_getDeviceFirmwareVersion == IntPtr.Zero)
					id_getDeviceFirmwareVersion = JNIEnv.GetMethodID (class_ref, "getDeviceFirmwareVersion", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceFirmwareVersion), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceFirmwareVersion", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceName);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceName;
		public virtual unsafe string DeviceName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='getDeviceName' and count(parameter)=0]"
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.DeviceSerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getDeviceSerialNumber;
		public virtual unsafe string DeviceSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='getDeviceSerialNumber' and count(parameter)=0]"
			[Register ("getDeviceSerialNumber", "()Ljava/lang/String;", "GetGetDeviceSerialNumberHandler")]
			get {
				if (id_getDeviceSerialNumber == IntPtr.Zero)
					id_getDeviceSerialNumber = JNIEnv.GetMethodID (class_ref, "getDeviceSerialNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getDeviceSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getDeviceSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsBatteryCharging;
		}
#pragma warning restore 0169

		static IntPtr id_isBatteryCharging;
		public virtual unsafe bool IsBatteryCharging {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='isBatteryCharging' and count(parameter)=0]"
			[Register ("isBatteryCharging", "()Z", "GetIsBatteryChargingHandler")]
			get {
				if (id_isBatteryCharging == IntPtr.Zero)
					id_isBatteryCharging = JNIEnv.GetMethodID (class_ref, "isBatteryCharging", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isBatteryCharging);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isBatteryCharging", "()Z"));
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsEnabled;
		}
#pragma warning restore 0169

		static IntPtr id_isEnabled;
		public virtual unsafe bool IsEnabled {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='isEnabled' and count(parameter)=0]"
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsExternal;
		}
#pragma warning restore 0169

		static IntPtr id_isExternal;
		public virtual unsafe bool IsExternal {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='isExternal' and count(parameter)=0]"
			[Register ("isExternal", "()Z", "GetIsExternalHandler")]
			get {
				if (id_isExternal == IntPtr.Zero)
					id_isExternal = JNIEnv.GetMethodID (class_ref, "isExternal", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isExternal);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isExternal", "()Z"));
				} finally {
				}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.AddMagStripeListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='addMagStripeListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeListener']]"
		[Register ("addMagStripeListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V", "GetAddMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler")]
		public virtual unsafe void AddMagStripeListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0)
		{
			if (id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == IntPtr.Zero)
				id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNIEnv.GetMethodID (class_ref, "addMagStripeListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_addMagStripeListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "addMagStripeListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V"), __args);
			} finally {
			}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.ClearMagStripeListeners ();
		}
#pragma warning restore 0169

		static IntPtr id_clearMagStripeListeners;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='clearMagStripeListeners' and count(parameter)=0]"
		[Register ("clearMagStripeListeners", "()V", "GetClearMagStripeListenersHandler")]
		public virtual unsafe void ClearMagStripeListeners ()
		{
			if (id_clearMagStripeListeners == IntPtr.Zero)
				id_clearMagStripeListeners = JNIEnv.GetMethodID (class_ref, "clearMagStripeListeners", "()V");
			try {

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_clearMagStripeListeners);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "clearMagStripeListeners", "()V"));
			} finally {
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Disable ();
		}
#pragma warning restore 0169

		static IntPtr id_disable;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='disable' and count(parameter)=0]"
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			__this.Enable (p0);
		}
#pragma warning restore 0169

		static IntPtr id_enable_J;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='enable' and count(parameter)=1 and parameter[1][@type='long']]"
		[Register ("enable", "(J)V", "GetEnable_JHandler")]
		public virtual unsafe void Enable (long p0)
		{
			if (id_enable_J == IntPtr.Zero)
				id_enable_J = JNIEnv.GetMethodID (class_ref, "enable", "(J)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_enable_J, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "enable", "(J)V"), __args);
			} finally {
			}
		}

		static Delegate cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
#pragma warning disable 0169
		static Delegate GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler ()
		{
			if (cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == null)
				cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, IntPtr>) n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_);
			return cb_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		}

		static void n_OnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, IntPtr native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0 = (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1 = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (native_p1, JniHandleOwnership.DoNotTransfer);
			__this.OnRead (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='onRead' and count(parameter)=2 and parameter[1][@type='com.panasonic.toughpad.android.contract.IMagStripeReader'] and parameter[2][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeData']]"
		[Register ("onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V", "GetOnRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_Handler")]
		public override unsafe void OnRead (global::Com.Panasonic.Toughpad.Android.Contract.IMagStripeReader p0, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData p1)
		{
			if (id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ == IntPtr.Zero)
				id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_ = JNIEnv.GetMethodID (class_ref, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_onRead_Lcom_panasonic_toughpad_android_contract_IMagStripeReader_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeData_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "onRead", "(Lcom/panasonic/toughpad/android/contract/IMagStripeReader;Lcom/panasonic/toughpad/android/api/magstripe/MagStripeData;)V"), __args);
			} finally {
			}
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
			global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Apitocontract.MagStripeReaderApiToContract> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0 = (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener)global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.RemoveMagStripeRListener (p0);
		}
#pragma warning restore 0169

		static IntPtr id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.apitocontract']/class[@name='MagStripeReaderApiToContract']/method[@name='removeMagStripeRListener' and count(parameter)=1 and parameter[1][@type='com.panasonic.toughpad.android.api.magstripe.MagStripeListener']]"
		[Register ("removeMagStripeRListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V", "GetRemoveMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_Handler")]
		public virtual unsafe void RemoveMagStripeRListener (global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener p0)
		{
			if (id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ == IntPtr.Zero)
				id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_ = JNIEnv.GetMethodID (class_ref, "removeMagStripeRListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_removeMagStripeRListener_Lcom_panasonic_toughpad_android_api_magstripe_MagStripeListener_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "removeMagStripeRListener", "(Lcom/panasonic/toughpad/android/api/magstripe/MagStripeListener;)V"), __args);
			} finally {
			}
		}

#region "Event implementation for Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener"
		public event EventHandler<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeEventArgs> MagStripe {
			add {
				global::Java.Interop.EventHelper.AddEventHandler<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor>(
						ref weak_implementor_AddMagStripeListener,
						__CreateIMagStripeListenerImplementor,
						AddMagStripeListener,
						__h => __h.Handler += value);
			}
			remove {
				global::Java.Interop.EventHelper.RemoveEventHandler<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener, global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor>(
						ref weak_implementor_AddMagStripeListener,
						global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor.__IsEmpty,
						__v => {throw new NotSupportedException ("Cannot unregister from Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListener.AddMagStripeListener");},
						__h => __h.Handler -= value);
			}
		}

		WeakReference weak_implementor_AddMagStripeListener;

		global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor __CreateIMagStripeListenerImplementor ()
		{
			return new global::Com.Panasonic.Toughpad.Android.Api.Magstripe.IMagStripeListenerImplementor (this);
		}
#endregion
	}
}
