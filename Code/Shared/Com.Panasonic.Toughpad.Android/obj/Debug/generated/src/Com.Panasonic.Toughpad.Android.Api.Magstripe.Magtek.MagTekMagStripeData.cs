using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/magstripe/magtek/MagTekMagStripeData", DoNotGenerateAcw=true)]
	public partial class MagTekMagStripeData : global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/field[@name='CREATOR']"
		[Register ("CREATOR")]
		public static global::Android.OS.IParcelableCreator Creator {
			get {
				if (CREATOR_jfieldId == IntPtr.Zero)
					CREATOR_jfieldId = JNIEnv.GetStaticFieldID (class_ref, "CREATOR", "Landroid/os/Parcelable$Creator;");
				IntPtr __ret = JNIEnv.GetStaticObjectField (class_ref, CREATOR_jfieldId);
				return global::Java.Lang.Object.GetObject<global::Android.OS.IParcelableCreator> (__ret, JniHandleOwnership.TransferLocalRef);
			}
		}
		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/magstripe/magtek/MagTekMagStripeData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagTekMagStripeData); }
		}

		protected MagTekMagStripeData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/constructor[@name='MagTekMagStripeData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		public unsafe MagTekMagStripeData (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MagTekMagStripeData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Landroid/os/Parcel;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "(Landroid/os/Parcel;)V", __args);
					return;
				}

				if (id_ctor_Landroid_os_Parcel_ == IntPtr.Zero)
					id_ctor_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Landroid/os/Parcel;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Landroid_os_Parcel_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_Landroid_os_Parcel_, __args);
			} finally {
			}
		}

		static Delegate cb_getCardName;
#pragma warning disable 0169
		static Delegate GetGetCardNameHandler ()
		{
			if (cb_getCardName == null)
				cb_getCardName = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardName);
			return cb_getCardName;
		}

		static IntPtr n_GetCardName (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardName);
		}
#pragma warning restore 0169

		static IntPtr id_getCardName;
		public virtual unsafe string CardName {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getCardName' and count(parameter)=0]"
			[Register ("getCardName", "()Ljava/lang/String;", "GetGetCardNameHandler")]
			get {
				if (id_getCardName == IntPtr.Zero)
					id_getCardName = JNIEnv.GetMethodID (class_ref, "getCardName", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardName), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardName", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCardServiceCode;
#pragma warning disable 0169
		static Delegate GetGetCardServiceCodeHandler ()
		{
			if (cb_getCardServiceCode == null)
				cb_getCardServiceCode = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardServiceCode);
			return cb_getCardServiceCode;
		}

		static IntPtr n_GetCardServiceCode (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardServiceCode);
		}
#pragma warning restore 0169

		static IntPtr id_getCardServiceCode;
		public virtual unsafe string CardServiceCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getCardServiceCode' and count(parameter)=0]"
			[Register ("getCardServiceCode", "()Ljava/lang/String;", "GetGetCardServiceCodeHandler")]
			get {
				if (id_getCardServiceCode == IntPtr.Zero)
					id_getCardServiceCode = JNIEnv.GetMethodID (class_ref, "getCardServiceCode", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardServiceCode), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardServiceCode", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getCardStatus;
#pragma warning disable 0169
		static Delegate GetGetCardStatusHandler ()
		{
			if (cb_getCardStatus == null)
				cb_getCardStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetCardStatus);
			return cb_getCardStatus;
		}

		static IntPtr n_GetCardStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.CardStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getCardStatus;
		public virtual unsafe string CardStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getCardStatus' and count(parameter)=0]"
			[Register ("getCardStatus", "()Ljava/lang/String;", "GetGetCardStatusHandler")]
			get {
				if (id_getCardStatus == IntPtr.Zero)
					id_getCardStatus = JNIEnv.GetMethodID (class_ref, "getCardStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getCardStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getCardStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEncodeType;
#pragma warning disable 0169
		static Delegate GetGetEncodeTypeHandler ()
		{
			if (cb_getEncodeType == null)
				cb_getEncodeType = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, sbyte>) n_GetEncodeType);
			return cb_getEncodeType;
		}

		static sbyte n_GetEncodeType (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.EncodeType;
		}
#pragma warning restore 0169

		static IntPtr id_getEncodeType;
		public virtual unsafe sbyte EncodeType {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getEncodeType' and count(parameter)=0]"
			[Register ("getEncodeType", "()B", "GetGetEncodeTypeHandler")]
			get {
				if (id_getEncodeType == IntPtr.Zero)
					id_getEncodeType = JNIEnv.GetMethodID (class_ref, "getEncodeType", "()B");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallByteMethod (((global::Java.Lang.Object) this).Handle, id_getEncodeType);
					else
						return JNIEnv.CallNonvirtualByteMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncodeType", "()B"));
				} finally {
				}
			}
		}

		static Delegate cb_getEncryptedCount;
#pragma warning disable 0169
		static Delegate GetGetEncryptedCountHandler ()
		{
			if (cb_getEncryptedCount == null)
				cb_getEncryptedCount = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptedCount);
			return cb_getEncryptedCount;
		}

		static IntPtr n_GetEncryptedCount (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptedCount);
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptedCount;
		public virtual unsafe string EncryptedCount {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getEncryptedCount' and count(parameter)=0]"
			[Register ("getEncryptedCount", "()Ljava/lang/String;", "GetGetEncryptedCountHandler")]
			get {
				if (id_getEncryptedCount == IntPtr.Zero)
					id_getEncryptedCount = JNIEnv.GetMethodID (class_ref, "getEncryptedCount", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptedCount), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptedCount", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getEncryptionStatus;
#pragma warning disable 0169
		static Delegate GetGetEncryptionStatusHandler ()
		{
			if (cb_getEncryptionStatus == null)
				cb_getEncryptionStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetEncryptionStatus);
			return cb_getEncryptionStatus;
		}

		static IntPtr n_GetEncryptionStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.EncryptionStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getEncryptionStatus;
		public virtual unsafe string EncryptionStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getEncryptionStatus' and count(parameter)=0]"
			[Register ("getEncryptionStatus", "()Ljava/lang/String;", "GetGetEncryptionStatusHandler")]
			get {
				if (id_getEncryptionStatus == IntPtr.Zero)
					id_getEncryptionStatus = JNIEnv.GetMethodID (class_ref, "getEncryptionStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getEncryptionStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getEncryptionStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getExperationDate;
#pragma warning disable 0169
		static Delegate GetGetExperationDateHandler ()
		{
			if (cb_getExperationDate == null)
				cb_getExperationDate = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetExperationDate);
			return cb_getExperationDate;
		}

		static IntPtr n_GetExperationDate (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.ExperationDate);
		}
#pragma warning restore 0169

		static IntPtr id_getExperationDate;
		public virtual unsafe string ExperationDate {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getExperationDate' and count(parameter)=0]"
			[Register ("getExperationDate", "()Ljava/lang/String;", "GetGetExperationDateHandler")]
			get {
				if (id_getExperationDate == IntPtr.Zero)
					id_getExperationDate = JNIEnv.GetMethodID (class_ref, "getExperationDate", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getExperationDate), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getExperationDate", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getFirmware;
#pragma warning disable 0169
		static Delegate GetGetFirmwareHandler ()
		{
			if (cb_getFirmware == null)
				cb_getFirmware = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetFirmware);
			return cb_getFirmware;
		}

		static IntPtr n_GetFirmware (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Firmware);
		}
#pragma warning restore 0169

		static IntPtr id_getFirmware;
		public virtual unsafe string Firmware {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getFirmware' and count(parameter)=0]"
			[Register ("getFirmware", "()Ljava/lang/String;", "GetGetFirmwareHandler")]
			get {
				if (id_getFirmware == IntPtr.Zero)
					id_getFirmware = JNIEnv.GetMethodID (class_ref, "getFirmware", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getFirmware), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getFirmware", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getIIN;
#pragma warning disable 0169
		static Delegate GetGetIINHandler ()
		{
			if (cb_getIIN == null)
				cb_getIIN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetIIN);
			return cb_getIIN;
		}

		static IntPtr n_GetIIN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.IIN);
		}
#pragma warning restore 0169

		static IntPtr id_getIIN;
		public virtual unsafe string IIN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getIIN' and count(parameter)=0]"
			[Register ("getIIN", "()Ljava/lang/String;", "GetGetIINHandler")]
			get {
				if (id_getIIN == IntPtr.Zero)
					id_getIIN = JNIEnv.GetMethodID (class_ref, "getIIN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getIIN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getIIN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getKSN;
#pragma warning disable 0169
		static Delegate GetGetKSNHandler ()
		{
			if (cb_getKSN == null)
				cb_getKSN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetKSN);
			return cb_getKSN;
		}

		static IntPtr n_GetKSN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.KSN);
		}
#pragma warning restore 0169

		static IntPtr id_getKSN;
		public virtual unsafe string KSN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getKSN' and count(parameter)=0]"
			[Register ("getKSN", "()Ljava/lang/String;", "GetGetKSNHandler")]
			get {
				if (id_getKSN == IntPtr.Zero)
					id_getKSN = JNIEnv.GetMethodID (class_ref, "getKSN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getKSN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getKSN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getLast4Digits;
#pragma warning disable 0169
		static Delegate GetGetLast4DigitsHandler ()
		{
			if (cb_getLast4Digits == null)
				cb_getLast4Digits = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetLast4Digits);
			return cb_getLast4Digits;
		}

		static IntPtr n_GetLast4Digits (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.Last4Digits);
		}
#pragma warning restore 0169

		static IntPtr id_getLast4Digits;
		public virtual unsafe string Last4Digits {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getLast4Digits' and count(parameter)=0]"
			[Register ("getLast4Digits", "()Ljava/lang/String;", "GetGetLast4DigitsHandler")]
			get {
				if (id_getLast4Digits == IntPtr.Zero)
					id_getLast4Digits = JNIEnv.GetMethodID (class_ref, "getLast4Digits", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getLast4Digits), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getLast4Digits", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMSRSerialNumber;
#pragma warning disable 0169
		static Delegate GetGetMSRSerialNumberHandler ()
		{
			if (cb_getMSRSerialNumber == null)
				cb_getMSRSerialNumber = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMSRSerialNumber);
			return cb_getMSRSerialNumber;
		}

		static IntPtr n_GetMSRSerialNumber (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MSRSerialNumber);
		}
#pragma warning restore 0169

		static IntPtr id_getMSRSerialNumber;
		public virtual unsafe string MSRSerialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getMSRSerialNumber' and count(parameter)=0]"
			[Register ("getMSRSerialNumber", "()Ljava/lang/String;", "GetGetMSRSerialNumberHandler")]
			get {
				if (id_getMSRSerialNumber == IntPtr.Zero)
					id_getMSRSerialNumber = JNIEnv.GetMethodID (class_ref, "getMSRSerialNumber", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMSRSerialNumber), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMSRSerialNumber", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMagnePrint;
#pragma warning disable 0169
		static Delegate GetGetMagnePrintHandler ()
		{
			if (cb_getMagnePrint == null)
				cb_getMagnePrint = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagnePrint);
			return cb_getMagnePrint;
		}

		static IntPtr n_GetMagnePrint (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagnePrint);
		}
#pragma warning restore 0169

		static IntPtr id_getMagnePrint;
		public virtual unsafe string MagnePrint {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getMagnePrint' and count(parameter)=0]"
			[Register ("getMagnePrint", "()Ljava/lang/String;", "GetGetMagnePrintHandler")]
			get {
				if (id_getMagnePrint == IntPtr.Zero)
					id_getMagnePrint = JNIEnv.GetMethodID (class_ref, "getMagnePrint", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagnePrint), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagnePrint", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMagnePrintStatus;
#pragma warning disable 0169
		static Delegate GetGetMagnePrintStatusHandler ()
		{
			if (cb_getMagnePrintStatus == null)
				cb_getMagnePrintStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMagnePrintStatus);
			return cb_getMagnePrintStatus;
		}

		static IntPtr n_GetMagnePrintStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MagnePrintStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getMagnePrintStatus;
		public virtual unsafe string MagnePrintStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getMagnePrintStatus' and count(parameter)=0]"
			[Register ("getMagnePrintStatus", "()Ljava/lang/String;", "GetGetMagnePrintStatusHandler")]
			get {
				if (id_getMagnePrintStatus == IntPtr.Zero)
					id_getMagnePrintStatus = JNIEnv.GetMethodID (class_ref, "getMagnePrintStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMagnePrintStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMagnePrintStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getMaskedPAN;
#pragma warning disable 0169
		static Delegate GetGetMaskedPANHandler ()
		{
			if (cb_getMaskedPAN == null)
				cb_getMaskedPAN = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetMaskedPAN);
			return cb_getMaskedPAN;
		}

		static IntPtr n_GetMaskedPAN (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.MaskedPAN);
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedPAN;
		public virtual unsafe string MaskedPAN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getMaskedPAN' and count(parameter)=0]"
			[Register ("getMaskedPAN", "()Ljava/lang/String;", "GetGetMaskedPANHandler")]
			get {
				if (id_getMaskedPAN == IntPtr.Zero)
					id_getMaskedPAN = JNIEnv.GetMethodID (class_ref, "getMaskedPAN", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedPAN), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedPAN", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getPANLength;
#pragma warning disable 0169
		static Delegate GetGetPANLengthHandler ()
		{
			if (cb_getPANLength == null)
				cb_getPANLength = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_GetPANLength);
			return cb_getPANLength;
		}

		static int n_GetPANLength (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.PANLength;
		}
#pragma warning restore 0169

		static IntPtr id_getPANLength;
		public virtual unsafe int PANLength {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getPANLength' and count(parameter)=0]"
			[Register ("getPANLength", "()I", "GetGetPANLengthHandler")]
			get {
				if (id_getPANLength == IntPtr.Zero)
					id_getPANLength = JNIEnv.GetMethodID (class_ref, "getPANLength", "()I");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_getPANLength);
					else
						return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getPANLength", "()I"));
				} finally {
				}
			}
		}

		static Delegate cb_getSessionId;
#pragma warning disable 0169
		static Delegate GetGetSessionIdHandler ()
		{
			if (cb_getSessionId == null)
				cb_getSessionId = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetSessionId);
			return cb_getSessionId;
		}

		static IntPtr n_GetSessionId (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.SessionId);
		}
#pragma warning restore 0169

		static IntPtr id_getSessionId;
		public virtual unsafe string SessionId {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getSessionId' and count(parameter)=0]"
			[Register ("getSessionId", "()Ljava/lang/String;", "GetGetSessionIdHandler")]
			get {
				if (id_getSessionId == IntPtr.Zero)
					id_getSessionId = JNIEnv.GetMethodID (class_ref, "getSessionId", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getSessionId), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getSessionId", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate cb_getTrackDecodeStatus;
#pragma warning disable 0169
		static Delegate GetGetTrackDecodeStatusHandler ()
		{
			if (cb_getTrackDecodeStatus == null)
				cb_getTrackDecodeStatus = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetTrackDecodeStatus);
			return cb_getTrackDecodeStatus;
		}

		static IntPtr n_GetTrackDecodeStatus (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.Magtek.MagTekMagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.TrackDecodeStatus);
		}
#pragma warning restore 0169

		static IntPtr id_getTrackDecodeStatus;
		public virtual unsafe string TrackDecodeStatus {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe.magtek']/class[@name='MagTekMagStripeData']/method[@name='getTrackDecodeStatus' and count(parameter)=0]"
			[Register ("getTrackDecodeStatus", "()Ljava/lang/String;", "GetGetTrackDecodeStatusHandler")]
			get {
				if (id_getTrackDecodeStatus == IntPtr.Zero)
					id_getTrackDecodeStatus = JNIEnv.GetMethodID (class_ref, "getTrackDecodeStatus", "()Ljava/lang/String;");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackDecodeStatus), JniHandleOwnership.TransferLocalRef);
					else
						return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackDecodeStatus", "()Ljava/lang/String;")), JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
