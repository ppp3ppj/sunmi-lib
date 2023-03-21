using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Sunmi.Peripheral.Printer {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterManager']"
	[global::Android.Runtime.Register ("com/sunmi/peripheral/printer/InnerPrinterManager", DoNotGenerateAcw=true)]
	public partial class InnerPrinterManager : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/sunmi/peripheral/printer/InnerPrinterManager", typeof (InnerPrinterManager));

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

		protected InnerPrinterManager (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		public static unsafe global::Com.Sunmi.Peripheral.Printer.InnerPrinterManager? Instance {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterManager']/method[@name='getInstance' and count(parameter)=0]"
			[Register ("getInstance", "()Lcom/sunmi/peripheral/printer/InnerPrinterManager;", "")]
			get {
				const string __id = "getInstance.()Lcom/sunmi/peripheral/printer/InnerPrinterManager;";
				try {
					var __rm = _members.StaticMethods.InvokeObjectMethod (__id, null);
					return global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterManager> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		static Delegate? cb_bindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_Handler ()
		{
			if (cb_bindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ == null)
				cb_bindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_Z) n_BindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_);
			return cb_bindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_;
		}

		static bool n_BindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mContext, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var mContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_mContext, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			bool __ret = __this.BindService (mContext, @callback);
			return __ret;
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterManager']/method[@name='bindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.sunmi.peripheral.printer.InnerPrinterCallback']]"
		[Register ("bindService", "(Landroid/content/Context;Lcom/sunmi/peripheral/printer/InnerPrinterCallback;)Z", "GetBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_Handler")]
		public virtual unsafe bool BindService (global::Android.Content.Context? mContext, global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback? @callback)
		{
			const string __id = "bindService.(Landroid/content/Context;Lcom/sunmi/peripheral/printer/InnerPrinterCallback;)Z";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mContext).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				var __rm = _members.InstanceMethods.InvokeVirtualBooleanMethod (__id, this, __args);
				return __rm;
			} finally {
				global::System.GC.KeepAlive (mContext);
				global::System.GC.KeepAlive (@callback);
			}
		}

		static Delegate? cb_unBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_;
#pragma warning disable 0169
		static Delegate GetUnBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_Handler ()
		{
			if (cb_unBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ == null)
				cb_unBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ = JNINativeWrapper.CreateDelegate ((_JniMarshal_PPLL_V) n_UnBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_);
			return cb_unBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_;
		}

		static void n_UnBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_ (IntPtr jnienv, IntPtr native__this, IntPtr native_mContext, IntPtr native__callback)
		{
			var __this = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterManager> (jnienv, native__this, JniHandleOwnership.DoNotTransfer)!;
			var mContext = global::Java.Lang.Object.GetObject<global::Android.Content.Context> (native_mContext, JniHandleOwnership.DoNotTransfer);
			var @callback = global::Java.Lang.Object.GetObject<global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback> (native__callback, JniHandleOwnership.DoNotTransfer);
			__this.UnBindService (mContext, @callback);
		}
#pragma warning restore 0169

		// Metadata.xml XPath method reference: path="/api/package[@name='com.sunmi.peripheral.printer']/class[@name='InnerPrinterManager']/method[@name='unBindService' and count(parameter)=2 and parameter[1][@type='android.content.Context'] and parameter[2][@type='com.sunmi.peripheral.printer.InnerPrinterCallback']]"
		[Register ("unBindService", "(Landroid/content/Context;Lcom/sunmi/peripheral/printer/InnerPrinterCallback;)V", "GetUnBindService_Landroid_content_Context_Lcom_sunmi_peripheral_printer_InnerPrinterCallback_Handler")]
		public virtual unsafe void UnBindService (global::Android.Content.Context? mContext, global::Com.Sunmi.Peripheral.Printer.InnerPrinterCallback? @callback)
		{
			const string __id = "unBindService.(Landroid/content/Context;Lcom/sunmi/peripheral/printer/InnerPrinterCallback;)V";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue ((mContext == null) ? IntPtr.Zero : ((global::Java.Lang.Object) mContext).Handle);
				__args [1] = new JniArgumentValue ((@callback == null) ? IntPtr.Zero : ((global::Java.Lang.Object) @callback).Handle);
				_members.InstanceMethods.InvokeVirtualVoidMethod (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (mContext);
				global::System.GC.KeepAlive (@callback);
			}
		}

	}
}
