using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Api.Magstripe {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/api/magstripe/MagStripeData", DoNotGenerateAcw=true)]
	public partial class MagStripeData : global::Java.Lang.Object, global::Android.OS.IParcelable {


		static IntPtr CREATOR_jfieldId;

		// Metadata.xml XPath field reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/field[@name='CREATOR']"
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
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/api/magstripe/MagStripeData", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (MagStripeData); }
		}

		protected MagStripeData (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Landroid_os_Parcel_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/constructor[@name='MagStripeData' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register (".ctor", "(Landroid/os/Parcel;)V", "")]
		protected unsafe MagStripeData (global::Android.OS.Parcel p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (MagStripeData)) {
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

		static IntPtr id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayBZZ;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/constructor[@name='MagStripeData' and count(parameter)=5 and parameter[1][@type='java.lang.String[]'] and parameter[2][@type='java.lang.String[]'] and parameter[3][@type='byte[]'] and parameter[4][@type='boolean'] and parameter[5][@type='boolean']]"
		[Register (".ctor", "([Ljava/lang/String;[Ljava/lang/String;[BZZ)V", "")]
		public unsafe MagStripeData (string[] p0, string[] p1, byte[] p2, bool p3, bool p4)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_p0 = JNIEnv.NewArray (p0);
			IntPtr native_p1 = JNIEnv.NewArray (p1);
			IntPtr native_p2 = JNIEnv.NewArray (p2);
			try {
				JValue* __args = stackalloc JValue [5];
				__args [0] = new JValue (native_p0);
				__args [1] = new JValue (native_p1);
				__args [2] = new JValue (native_p2);
				__args [3] = new JValue (p3);
				__args [4] = new JValue (p4);
				if (((object) this).GetType () != typeof (MagStripeData)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "([Ljava/lang/String;[Ljava/lang/String;[BZZ)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, "([Ljava/lang/String;[Ljava/lang/String;[BZZ)V", __args);
					return;
				}

				if (id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayBZZ == IntPtr.Zero)
					id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayBZZ = JNIEnv.GetMethodID (class_ref, "<init>", "([Ljava/lang/String;[Ljava/lang/String;[BZZ)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayBZZ, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Object) this).Handle, class_ref, id_ctor_arrayLjava_lang_String_arrayLjava_lang_String_arrayBZZ, __args);
			} finally {
				if (p0 != null) {
					JNIEnv.CopyArray (native_p0, p0);
					JNIEnv.DeleteLocalRef (native_p0);
				}
				if (p1 != null) {
					JNIEnv.CopyArray (native_p1, p1);
					JNIEnv.DeleteLocalRef (native_p1);
				}
				if (p2 != null) {
					JNIEnv.CopyArray (native_p2, p2);
					JNIEnv.DeleteLocalRef (native_p2);
				}
			}
		}

		static Delegate cb_isGoodSwipe;
#pragma warning disable 0169
		static Delegate GetIsGoodSwipeHandler ()
		{
			if (cb_isGoodSwipe == null)
				cb_isGoodSwipe = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsGoodSwipe);
			return cb_isGoodSwipe;
		}

		static bool n_IsGoodSwipe (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsGoodSwipe;
		}
#pragma warning restore 0169

		static IntPtr id_isGoodSwipe;
		public virtual unsafe bool IsGoodSwipe {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='isGoodSwipe' and count(parameter)=0]"
			[Register ("isGoodSwipe", "()Z", "GetIsGoodSwipeHandler")]
			get {
				if (id_isGoodSwipe == IntPtr.Zero)
					id_isGoodSwipe = JNIEnv.GetMethodID (class_ref, "isGoodSwipe", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isGoodSwipe);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isGoodSwipe", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_isTrackDataEncrypted;
#pragma warning disable 0169
		static Delegate GetIsTrackDataEncryptedHandler ()
		{
			if (cb_isTrackDataEncrypted == null)
				cb_isTrackDataEncrypted = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, bool>) n_IsTrackDataEncrypted);
			return cb_isTrackDataEncrypted;
		}

		static bool n_IsTrackDataEncrypted (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.IsTrackDataEncrypted;
		}
#pragma warning restore 0169

		static IntPtr id_isTrackDataEncrypted;
		public virtual unsafe bool IsTrackDataEncrypted {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='isTrackDataEncrypted' and count(parameter)=0]"
			[Register ("isTrackDataEncrypted", "()Z", "GetIsTrackDataEncryptedHandler")]
			get {
				if (id_isTrackDataEncrypted == IntPtr.Zero)
					id_isTrackDataEncrypted = JNIEnv.GetMethodID (class_ref, "isTrackDataEncrypted", "()Z");
				try {

					if (((object) this).GetType () == ThresholdType)
						return JNIEnv.CallBooleanMethod (((global::Java.Lang.Object) this).Handle, id_isTrackDataEncrypted);
					else
						return JNIEnv.CallNonvirtualBooleanMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "isTrackDataEncrypted", "()Z"));
				} finally {
				}
			}
		}

		static Delegate cb_describeContents;
#pragma warning disable 0169
		static Delegate GetDescribeContentsHandler ()
		{
			if (cb_describeContents == null)
				cb_describeContents = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int>) n_DescribeContents);
			return cb_describeContents;
		}

		static int n_DescribeContents (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return __this.DescribeContents ();
		}
#pragma warning restore 0169

		static IntPtr id_describeContents;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='describeContents' and count(parameter)=0]"
		[Register ("describeContents", "()I", "GetDescribeContentsHandler")]
		public virtual unsafe int DescribeContents ()
		{
			if (id_describeContents == IntPtr.Zero)
				id_describeContents = JNIEnv.GetMethodID (class_ref, "describeContents", "()I");
			try {

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.CallIntMethod (((global::Java.Lang.Object) this).Handle, id_describeContents);
				else
					return JNIEnv.CallNonvirtualIntMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "describeContents", "()I"));
			} finally {
			}
		}

		static Delegate cb_getMaskedTrackData_I;
#pragma warning disable 0169
		static Delegate GetGetMaskedTrackData_IHandler ()
		{
			if (cb_getMaskedTrackData_I == null)
				cb_getMaskedTrackData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetMaskedTrackData_I);
			return cb_getMaskedTrackData_I;
		}

		static IntPtr n_GetMaskedTrackData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetMaskedTrackData (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getMaskedTrackData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='getMaskedTrackData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getMaskedTrackData", "(I)Ljava/lang/String;", "GetGetMaskedTrackData_IHandler")]
		public virtual unsafe string GetMaskedTrackData (int p0)
		{
			if (id_getMaskedTrackData_I == IntPtr.Zero)
				id_getMaskedTrackData_I = JNIEnv.GetMethodID (class_ref, "getMaskedTrackData", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getMaskedTrackData_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getMaskedTrackData", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_getRawData;
#pragma warning disable 0169
		static Delegate GetGetRawDataHandler ()
		{
			if (cb_getRawData == null)
				cb_getRawData = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, IntPtr>) n_GetRawData);
			return cb_getRawData;
		}

		static IntPtr n_GetRawData (IntPtr jnienv, IntPtr native__this)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewArray (__this.GetRawData ());
		}
#pragma warning restore 0169

		static IntPtr id_getRawData;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='getRawData' and count(parameter)=0]"
		[Register ("getRawData", "()[B", "GetGetRawDataHandler")]
		public virtual unsafe byte[] GetRawData ()
		{
			if (id_getRawData == IntPtr.Zero)
				id_getRawData = JNIEnv.GetMethodID (class_ref, "getRawData", "()[B");
			try {

				if (((object) this).GetType () == ThresholdType)
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getRawData), JniHandleOwnership.TransferLocalRef, typeof (byte));
				else
					return (byte[]) JNIEnv.GetArray (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getRawData", "()[B")), JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		static Delegate cb_getTrackData_I;
#pragma warning disable 0169
		static Delegate GetGetTrackData_IHandler ()
		{
			if (cb_getTrackData_I == null)
				cb_getTrackData_I = JNINativeWrapper.CreateDelegate ((Func<IntPtr, IntPtr, int, IntPtr>) n_GetTrackData_I);
			return cb_getTrackData_I;
		}

		static IntPtr n_GetTrackData_I (IntPtr jnienv, IntPtr native__this, int p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			return JNIEnv.NewString (__this.GetTrackData (p0));
		}
#pragma warning restore 0169

		static IntPtr id_getTrackData_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='getTrackData' and count(parameter)=1 and parameter[1][@type='int']]"
		[Register ("getTrackData", "(I)Ljava/lang/String;", "GetGetTrackData_IHandler")]
		public virtual unsafe string GetTrackData (int p0)
		{
			if (id_getTrackData_I == IntPtr.Zero)
				id_getTrackData_I = JNIEnv.GetMethodID (class_ref, "getTrackData", "(I)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					return JNIEnv.GetString (JNIEnv.CallObjectMethod (((global::Java.Lang.Object) this).Handle, id_getTrackData_I, __args), JniHandleOwnership.TransferLocalRef);
				else
					return JNIEnv.GetString (JNIEnv.CallNonvirtualObjectMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "getTrackData", "(I)Ljava/lang/String;"), __args), JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		static Delegate cb_readFromParcel_Landroid_os_Parcel_;
#pragma warning disable 0169
		static Delegate GetReadFromParcel_Landroid_os_Parcel_Handler ()
		{
			if (cb_readFromParcel_Landroid_os_Parcel_ == null)
				cb_readFromParcel_Landroid_os_Parcel_ = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr>) n_ReadFromParcel_Landroid_os_Parcel_);
			return cb_readFromParcel_Landroid_os_Parcel_;
		}

		static void n_ReadFromParcel_Landroid_os_Parcel_ (IntPtr jnienv, IntPtr native__this, IntPtr native_p0)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			__this.ReadFromParcel (p0);
		}
#pragma warning restore 0169

		static IntPtr id_readFromParcel_Landroid_os_Parcel_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='readFromParcel' and count(parameter)=1 and parameter[1][@type='android.os.Parcel']]"
		[Register ("readFromParcel", "(Landroid/os/Parcel;)V", "GetReadFromParcel_Landroid_os_Parcel_Handler")]
		public virtual unsafe void ReadFromParcel (global::Android.OS.Parcel p0)
		{
			if (id_readFromParcel_Landroid_os_Parcel_ == IntPtr.Zero)
				id_readFromParcel_Landroid_os_Parcel_ = JNIEnv.GetMethodID (class_ref, "readFromParcel", "(Landroid/os/Parcel;)V");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_readFromParcel_Landroid_os_Parcel_, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "readFromParcel", "(Landroid/os/Parcel;)V"), __args);
			} finally {
			}
		}

		static Delegate cb_writeToParcel_Landroid_os_Parcel_I;
#pragma warning disable 0169
		static Delegate GetWriteToParcel_Landroid_os_Parcel_IHandler ()
		{
			if (cb_writeToParcel_Landroid_os_Parcel_I == null)
				cb_writeToParcel_Landroid_os_Parcel_I = JNINativeWrapper.CreateDelegate ((Action<IntPtr, IntPtr, IntPtr, int>) n_WriteToParcel_Landroid_os_Parcel_I);
			return cb_writeToParcel_Landroid_os_Parcel_I;
		}

		static void n_WriteToParcel_Landroid_os_Parcel_I (IntPtr jnienv, IntPtr native__this, IntPtr native_p0, int native_p1)
		{
			global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData __this = global::Java.Lang.Object.GetObject<global::Com.Panasonic.Toughpad.Android.Api.Magstripe.MagStripeData> (jnienv, native__this, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.Parcel p0 = global::Java.Lang.Object.GetObject<global::Android.OS.Parcel> (native_p0, JniHandleOwnership.DoNotTransfer);
			global::Android.OS.ParcelableWriteFlags p1 = (global::Android.OS.ParcelableWriteFlags) native_p1;
			__this.WriteToParcel (p0, p1);
		}
#pragma warning restore 0169

		static IntPtr id_writeToParcel_Landroid_os_Parcel_I;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.api.magstripe']/class[@name='MagStripeData']/method[@name='writeToParcel' and count(parameter)=2 and parameter[1][@type='android.os.Parcel'] and parameter[2][@type='int']]"
		[Register ("writeToParcel", "(Landroid/os/Parcel;I)V", "GetWriteToParcel_Landroid_os_Parcel_IHandler")]
		public virtual unsafe void WriteToParcel (global::Android.OS.Parcel p0, [global::Android.Runtime.GeneratedEnum] global::Android.OS.ParcelableWriteFlags p1)
		{
			if (id_writeToParcel_Landroid_os_Parcel_I == IntPtr.Zero)
				id_writeToParcel_Landroid_os_Parcel_I = JNIEnv.GetMethodID (class_ref, "writeToParcel", "(Landroid/os/Parcel;I)V");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue ((int) p1);

				if (((object) this).GetType () == ThresholdType)
					JNIEnv.CallVoidMethod (((global::Java.Lang.Object) this).Handle, id_writeToParcel_Landroid_os_Parcel_I, __args);
				else
					JNIEnv.CallNonvirtualVoidMethod (((global::Java.Lang.Object) this).Handle, ThresholdClass, JNIEnv.GetMethodID (ThresholdClass, "writeToParcel", "(Landroid/os/Parcel;I)V"), __args);
			} finally {
			}
		}

	}
}
