package md55f05e49d00efa064fdaa630909a37531;


public class Nutricion
	extends android.app.Activity
	implements
		mono.android.IGCUserPeer
{
/** @hide */
	public static final String __md_methods;
	static {
		__md_methods = 
			"n_onCreate:(Landroid/os/Bundle;)V:GetOnCreate_Landroid_os_Bundle_Handler\n" +
			"";
		mono.android.Runtime.register ("ConsultorioUH.Nutricion, ConsultorioUH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", Nutricion.class, __md_methods);
	}


	public Nutricion () throws java.lang.Throwable
	{
		super ();
		if (getClass () == Nutricion.class)
			mono.android.TypeManager.Activate ("ConsultorioUH.Nutricion, ConsultorioUH, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null", "", this, new java.lang.Object[] {  });
	}


	public void onCreate (android.os.Bundle p0)
	{
		n_onCreate (p0);
	}

	private native void n_onCreate (android.os.Bundle p0);

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
