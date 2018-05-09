using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Com.Panasonic.Toughpad.Android.Contract {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']"
	[global::Android.Runtime.Register ("com/panasonic/toughpad/android/contract/CheckedExceptionWrapper", DoNotGenerateAcw=true)]
	public partial class CheckedExceptionWrapper : global::Java.Lang.IllegalStateException {

		internal static new IntPtr java_class_handle;
		internal static new IntPtr class_ref {
			get {
				return JNIEnv.FindClass ("com/panasonic/toughpad/android/contract/CheckedExceptionWrapper", ref java_class_handle);
			}
		}

		protected override IntPtr ThresholdClass {
			get { return class_ref; }
		}

		protected override global::System.Type ThresholdType {
			get { return typeof (CheckedExceptionWrapper); }
		}

		protected CheckedExceptionWrapper (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer) {}

		static IntPtr id_ctor_Ljava_lang_Exception_;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']/constructor[@name='CheckedExceptionWrapper' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register (".ctor", "(Ljava/lang/Exception;)V", "")]
		public unsafe CheckedExceptionWrapper (global::Java.Lang.Exception p0)
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				if (((object) this).GetType () != typeof (CheckedExceptionWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "(Ljava/lang/Exception;)V", __args),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "(Ljava/lang/Exception;)V", __args);
					return;
				}

				if (id_ctor_Ljava_lang_Exception_ == IntPtr.Zero)
					id_ctor_Ljava_lang_Exception_ = JNIEnv.GetMethodID (class_ref, "<init>", "(Ljava/lang/Exception;)V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor_Ljava_lang_Exception_, __args),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor_Ljava_lang_Exception_, __args);
			} finally {
			}
		}

		static IntPtr id_ctor;
		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']/constructor[@name='CheckedExceptionWrapper' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe CheckedExceptionWrapper ()
			: base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			if (((global::Java.Lang.Throwable) this).Handle != IntPtr.Zero)
				return;

			try {
				if (((object) this).GetType () != typeof (CheckedExceptionWrapper)) {
					SetHandle (
							global::Android.Runtime.JNIEnv.StartCreateInstance (((object) this).GetType (), "()V"),
							JniHandleOwnership.TransferLocalRef);
					global::Android.Runtime.JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, "()V");
					return;
				}

				if (id_ctor == IntPtr.Zero)
					id_ctor = JNIEnv.GetMethodID (class_ref, "<init>", "()V");
				SetHandle (
						global::Android.Runtime.JNIEnv.StartCreateInstance (class_ref, id_ctor),
						JniHandleOwnership.TransferLocalRef);
				JNIEnv.FinishCreateInstance (((global::Java.Lang.Throwable) this).Handle, class_ref, id_ctor);
			} finally {
			}
		}

		static IntPtr id_resolveException_Ljava_lang_IllegalStateException_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']/method[@name='resolveException' and count(parameter)=2 and parameter[1][@type='java.lang.IllegalStateException'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("resolveException", "(Ljava/lang/IllegalStateException;Ljava/lang/Class;)Z", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"T extends java.lang.Exception"})]
		public static unsafe bool ResolveException (global::Java.Lang.IllegalStateException p0, global::Java.Lang.Class p1)
		{
			if (id_resolveException_Ljava_lang_IllegalStateException_Ljava_lang_Class_ == IntPtr.Zero)
				id_resolveException_Ljava_lang_IllegalStateException_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "resolveException", "(Ljava/lang/IllegalStateException;Ljava/lang/Class;)Z");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				bool __ret = JNIEnv.CallStaticBooleanMethod  (class_ref, id_resolveException_Ljava_lang_IllegalStateException_Ljava_lang_Class_, __args);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_resolveExceptionAlways_Ljava_lang_IllegalStateException_Ljava_lang_Class_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']/method[@name='resolveExceptionAlways' and count(parameter)=2 and parameter[1][@type='java.lang.IllegalStateException'] and parameter[2][@type='java.lang.Class&lt;T&gt;']]"
		[Register ("resolveExceptionAlways", "(Ljava/lang/IllegalStateException;Ljava/lang/Class;)Ljava/lang/Object;", "")]
		[global::Java.Interop.JavaTypeParameters (new string [] {"U", "T extends java.lang.Exception"})]
		public static unsafe global::Java.Lang.Object ResolveExceptionAlways (global::Java.Lang.IllegalStateException p0, global::Java.Lang.Class p1)
		{
			if (id_resolveExceptionAlways_Ljava_lang_IllegalStateException_Ljava_lang_Class_ == IntPtr.Zero)
				id_resolveExceptionAlways_Ljava_lang_IllegalStateException_Ljava_lang_Class_ = JNIEnv.GetStaticMethodID (class_ref, "resolveExceptionAlways", "(Ljava/lang/IllegalStateException;Ljava/lang/Class;)Ljava/lang/Object;");
			try {
				JValue* __args = stackalloc JValue [2];
				__args [0] = new JValue (p0);
				__args [1] = new JValue (p1);
				global::Java.Lang.Object __ret = (Java.Lang.Object) global::Java.Lang.Object.GetObject<global::Java.Lang.Object> (JNIEnv.CallStaticObjectMethod  (class_ref, id_resolveExceptionAlways_Ljava_lang_IllegalStateException_Ljava_lang_Class_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

		static IntPtr id_serializeException_Ljava_lang_Exception_;
		// Metadata.xml XPath method reference: path="/api/package[@name='com.panasonic.toughpad.android.contract']/class[@name='CheckedExceptionWrapper']/method[@name='serializeException' and count(parameter)=1 and parameter[1][@type='java.lang.Exception']]"
		[Register ("serializeException", "(Ljava/lang/Exception;)Ljava/lang/String;", "")]
		protected static unsafe string SerializeException (global::Java.Lang.Exception p0)
		{
			if (id_serializeException_Ljava_lang_Exception_ == IntPtr.Zero)
				id_serializeException_Ljava_lang_Exception_ = JNIEnv.GetStaticMethodID (class_ref, "serializeException", "(Ljava/lang/Exception;)Ljava/lang/String;");
			try {
				JValue* __args = stackalloc JValue [1];
				__args [0] = new JValue (p0);
				string __ret = JNIEnv.GetString (JNIEnv.CallStaticObjectMethod  (class_ref, id_serializeException_Ljava_lang_Exception_, __args), JniHandleOwnership.TransferLocalRef);
				return __ret;
			} finally {
			}
		}

	}
}
