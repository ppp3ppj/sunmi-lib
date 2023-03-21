using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']"
	[global::Android.Runtime.Register ("com/google/zxing/BinaryBitmap", DoNotGenerateAcw=true)]
	public sealed partial class BinaryBitmap : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/BinaryBitmap", typeof (BinaryBitmap));

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

		internal BinaryBitmap (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/constructor[@name='BinaryBitmap' and count(parameter)=1 and parameter[1][@type='com.google.zxing.Binarizer']]"
		[Register (".ctor", "(Lcom/google/zxing/Binarizer;)V", "")]
		public unsafe BinaryBitmap (global::Com.Google.Zxing.Binarizer? binarizer) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Lcom/google/zxing/Binarizer;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue ((binarizer == null) ? IntPtr.Zero : ((global::Java.Lang.Object) binarizer).Handle);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				global::System.GC.KeepAlive (binarizer);
			}
		}

		public unsafe global::Com.Google.Zxing.Common.BitMatrix? BlackMatrix {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getBlackMatrix' and count(parameter)=0]"
			[Register ("getBlackMatrix", "()Lcom/google/zxing/common/BitMatrix;", "")]
			get {
				const string __id = "getBlackMatrix.()Lcom/google/zxing/common/BitMatrix;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitMatrix> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe int Height {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getHeight' and count(parameter)=0]"
			[Register ("getHeight", "()I", "")]
			get {
				const string __id = "getHeight.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsCropSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='isCropSupported' and count(parameter)=0]"
			[Register ("isCropSupported", "()Z", "")]
			get {
				const string __id = "isCropSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsRotateSupported {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='isRotateSupported' and count(parameter)=0]"
			[Register ("isRotateSupported", "()Z", "")]
			get {
				const string __id = "isRotateSupported.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe int Width {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getWidth' and count(parameter)=0]"
			[Register ("getWidth", "()I", "")]
			get {
				const string __id = "getWidth.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='crop' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("crop", "(IIII)Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap? Crop (int left, int top, int width, int height)
		{
			const string __id = "crop.(IIII)Lcom/google/zxing/BinaryBitmap;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (left);
				__args [1] = new JniArgumentValue (top);
				__args [2] = new JniArgumentValue (width);
				__args [3] = new JniArgumentValue (height);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='getBlackRow' and count(parameter)=2 and parameter[1][@type='int'] and parameter[2][@type='com.google.zxing.common.BitArray']]"
		[Register ("getBlackRow", "(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;", "")]
		public unsafe global::Com.Google.Zxing.Common.BitArray? GetBlackRow (int y, global::Com.Google.Zxing.Common.BitArray? row)
		{
			const string __id = "getBlackRow.(ILcom/google/zxing/common/BitArray;)Lcom/google/zxing/common/BitArray;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (y);
				__args [1] = new JniArgumentValue ((row == null) ? IntPtr.Zero : ((global::Java.Lang.Object) row).Handle);
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.BitArray> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
				global::System.GC.KeepAlive (row);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='rotateCounterClockwise' and count(parameter)=0]"
		[Register ("rotateCounterClockwise", "()Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap? RotateCounterClockwise ()
		{
			const string __id = "rotateCounterClockwise.()Lcom/google/zxing/BinaryBitmap;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing']/class[@name='BinaryBitmap']/method[@name='rotateCounterClockwise45' and count(parameter)=0]"
		[Register ("rotateCounterClockwise45", "()Lcom/google/zxing/BinaryBitmap;", "")]
		public unsafe global::Com.Google.Zxing.BinaryBitmap? RotateCounterClockwise45 ()
		{
			const string __id = "rotateCounterClockwise45.()Lcom/google/zxing/BinaryBitmap;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.BinaryBitmap> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

	}
}
