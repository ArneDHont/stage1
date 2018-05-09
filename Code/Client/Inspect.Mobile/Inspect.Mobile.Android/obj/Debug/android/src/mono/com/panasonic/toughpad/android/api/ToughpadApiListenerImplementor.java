package mono.com.panasonic.toughpad.android.api;


public class ToughpadApiListenerImplementor
	extends java.lang.Object
	implements
		mono.android.IGCUserPeer,
		com.panasonic.toughpad.android.api.ToughpadApiListener
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onApiConnected:(I)V:GetOnApiConnected_IHandler:Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerInvoker, Com.Panasonic.Toughpad.Android\n" +
			"n_onApiDisconnected:()V:GetOnApiDisconnectedHandler:Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerInvoker, Com.Panasonic.Toughpad.Android\n" +
			"";
		mono.android.Runtime.register ("Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", ToughpadApiListenerImplementor.class, __md_methods);
	}


	public ToughpadApiListenerImplementor ()
	{
		super ();
		if (getClass () == ToughpadApiListenerImplementor.class)
			mono.android.TypeManager.Activate ("Com.Panasonic.Toughpad.Android.Api.IToughpadApiListenerImplementor, Com.Panasonic.Toughpad.Android, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onApiConnected (int p0)
	{
		n_onApiConnected (p0);
	}

	private native void n_onApiConnected (int p0);


	public void onApiDisconnected ()
	{
		n_onApiDisconnected ();
	}

	private native void n_onApiDisconnected ();

	private java.util.ArrayList refList;
	public void monodroidAddReference (java.lang.Object obj)
	{
		if (refList == null)
			refList = new java.util.ArrayList ();
		refList.add (obj);
	}

	public void monodroidClearReferences ()
	{
		if (refList != null)
			refList.clear ();
	}
}
