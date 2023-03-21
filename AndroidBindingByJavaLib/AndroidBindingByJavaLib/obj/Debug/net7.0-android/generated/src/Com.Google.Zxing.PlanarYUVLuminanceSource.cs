using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']"
	[global::Android.Runtime.Register ("com/google/zxing/PlanarYUVLuminanceSource", DoNotGenerateAcw=true)]
	public sealed partial class PlanarYUVLuminanceSource : global::Com.Google.Zxing.LuminanceSource {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/PlanarYUVLuminanceSource", typeof (PlanarYUVLuminanceSource));

		internal static new IntPtr class_ref {
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

		internal PlanarYUVLuminanceSource (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/constructor[@name='PlanarYUVLuminanceSource' and count(parameter)=8 and parameter[1][@type='byte[]'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='int'] and parameter[6][@type='int'] and parameter[7][@type='int'] and parameter[8][@type='boolean']]"
		[Register (".ctor", "([BIIIIIIZ)V", "")]
		public unsafe PlanarYUVLuminanceSource (byte[]? yuvData, int dataWidth, int dataHeight, int left, int top, int width, int height, bool reverseHorizontal) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "([BIIIIIIZ)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_yuvData = JNIEnv.NewArray (yuvData);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (native_yuvData);
				__args [1] = new JniArgumentValue (dataWidth);
				__args [2] = new JniArgumentValue (dataHeight);
				__args [3] = new JniArgumentValue (left);
				__args [4] = new JniArgumentValue (top);
				__args [5] = new JniArgumentValue (width);
				__args [6] = new JniArgumentValue (height);
				__args [7] = new JniArgumentValue (reverseHorizontal);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				if (yuvData != null) {
					JNIEnv.CopyArray (native_yuvData, yuvData);
					JNIEnv.DeleteLocalRef (native_yuvData);
				}
				global::System.GC.KeepAlive (yuvData);
			}
		}

		public unsafe int ThumbnailHeight {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getThumbnailHeight' and count(parameter)=0]"
			[Register ("getThumbnailHeight", "()I", "")]
			get {
				const string __id = "getThumbnailHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int ThumbnailWidth {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getThumbnailWidth' and count(parameter)=0]"
			[Register ("getThumbnailWidth", "()I", "")]
			get {
				const string __id = "getThumbnailWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getMatrix' and count(parameter)=0]"
		[Register ("getMatrix", "()[B", "")]
		public override unsafe byte[]? GetMatrix ()
		{
			const string __id = "getMatrix.()[B";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='getRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='byte[]']]"
		[Register ("getRow", "(I[B)[B", "")]
		public override unsafe byte[]? GetRow (int y, byte[]? row)
		{
			const string __id = "getRow.(I[B)[B";
			IntPtr native_row = JNIEnv.NewArray (row);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue (native_row);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return (byte[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (byte));
			} finally {
				if (row != null) {
					JNIEnv.CopyArray (native_row, row);
					JNIEnv.DeleteLocalRef (native_row);
				}
				global::System.GC.KeepAlive (row);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='PlanarYUVLuminanceSource']/method[@name='renderThumbnail' and count(parameter)=0]"
		[Register ("renderThumbnail", "()[I", "")]
		public unsafe int[]? RenderThumbnail ()
		{
			const string __id = "renderThumbnail.()[I";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (int[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (int));
			} finally {
			}
		}

	}
}
