using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Peripheral.Printer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']"
	[global::Android.Runtime.Register ("com/sunmi/peripheral/printer/InnerPrinterCallback", DoNotGenerateAcw=true)]
	public abstract partial class InnerPrinterCallback : global::Java.Lang.Object, global::Android.Content.IServiceConnection {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/peripheral/printer/InnerPrinterCallback", typeof (InnerPrinterCallback));

		internal static IntPtr class_ref {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override IntPtr ThresholdClass {
			get { return _members.JniPeerType.PeerReference.Handle; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		protected InnerPrinterCallback (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']/constructor[@name='InnerPrinterCallback' and count(parameter)=0]"
		[Register (".ctor", "()V", "")]
		public unsafe InnerPrinterCallback () : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "()V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), null);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, null);
			} finally {
			}
		}

		static Delegate? cb_onDisconnected;
#pragma warning disable 0169
		static Delegate GetOnDisconnectedHandler ()
		{
			if (cb_onDisconnected == null)
				cb_onDisconnected = JNINativeWrapper.CreateDelegate ((_JniMarshal_PP_V) n_OnDisconnected);
			return cb_onDisconnected;
		}

		static void n_OnDisconnected (IntPtr jnienv, IntPtr native__this)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			__this.OnDisconnected ();
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']/method[@name='onDisconnected' and count(parameter)=0]"
		[Register ("onDisconnected", "()V", "GetOnDisconnectedHandler")]
		protected abstract void OnDisconnected ();

		static Delegate? cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
#pragma warning disable 0169
		static Delegate GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler ()
		{
			if (cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ == null)
				cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_);
			return cb_onServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_;
		}

		static void n_OnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name, IntPtr native_service)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var name = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_name, JniHandleOwnership.DoNotTransfer);
			var service = (global::Android.OS.IBinder?)global::Java.Lang.Object.GetObject<global::Android.OS.IBinder> (native_service, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceConnected (name, service);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']/method[@name='onServiceConnected' and count(parameter)=2 and parameter[1][@type='android.content.ComponentName'] and parameter[2][@type='android.os.IBinder']]"
		[Register ("onServiceConnected", "(Landroid/content/ComponentName;Landroid/os/IBinder;)V", "GetOnServiceConnected_Landroid_content_ComponentName_Landroid_os_IBinder_Handler")]
		public virtual unsafe void OnServiceConnected (global::Android.Content.ComponentName? name, global::Android.OS.IBinder? service)
		{
			const string __id = "onServiceConnected.(Landroid/content/ComponentName;Landroid/os/IBinder;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				__args [1] = new JniArgumentValue ((service == null) ? IntPtr.Zero : ((global::Java.Lang.Object) service).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (name);
				global::System.GC.KeepAlive (service);
			}
		}

		static Delegate? cb_onServiceDisconnected_Landroid_content_ComponentName_;
#pragma warning disable 0169
		static Delegate GetOnServiceDisconnected_Landroid_content_ComponentName_Handler ()
		{
			if (cb_onServiceDisconnected_Landroid_content_ComponentName_ == null)
				cb_onServiceDisconnected_Landroid_content_ComponentName_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPL_V) n_OnServiceDisconnected_Landroid_content_ComponentName_);
			return cb_onServiceDisconnected_Landroid_content_ComponentName_;
		}

		static void n_OnServiceDisconnected_Landroid_content_ComponentName_ (IntPtr jnienv, IntPtr native__this, IntPtr native_name)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var name = global::Java.Lang.Object.GetObject<global::Android.Content.ComponentName> (native_name, JniHandleOwnership.DoNotTransfer);
			__this.OnServiceDisconnected (name);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']/method[@name='onServiceDisconnected' and count(parameter)=1 and parameter[1][@type='android.content.ComponentName']]"
		[Register ("onServiceDisconnected", "(Landroid/content/ComponentName;)V", "GetOnServiceDisconnected_Landroid_content_ComponentName_Handler")]
		public virtual unsafe void OnServiceDisconnected (global::Android.Content.ComponentName? name)
		{
			const string __id = "onServiceDisconnected.(Landroid/content/ComponentName;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((name == null) ? IntPtr.Zero : ((global::Java.Lang.Object) name).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (name);
			}
		}

	}

	[global::Android.Runtime.Register ("com/sunmi/peripheral/printer/InnerPrinterCallback", DoNotGenerateAcw=true)]
	internal partial class InnerPrinterCallbackInvoker : InnerPrinterCallback {
		public InnerPrinterCallbackInvoker (IntPtr handle, JniHandleOwnership transfer) : base (handle, transfer)
		{
		}

		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/peripheral/printer/InnerPrinterCallback", typeof (InnerPrinterCallbackInvoker));

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		public override global::Java.Interop.JniPeerMembers JniPeerMembers {
			get { return _members; }
		}

		[global::System.Diagnostics.DebuggerBrowsable (global::System.Diagnostics.DebuggerBrowsableState.Never)]
		[global::System.ComponentModel.EditorBrowsable (global::System.ComponentModel.EditorBrowsableState.Never)]
		protected override global::System.Type ThresholdType {
			get { return _members.ManagedPeerType; }
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterCallback']/method[@name='onDisconnected' and count(parameter)=0]"
		[Register ("onDisconnected", "()V", "GetOnDisconnectedHandler")]
		protected override unsafe void OnDisconnected ()
		{
			const string __id = "onDisconnected.()V";
			try {
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, null);
			} finally {
			}
		}

	}
}
