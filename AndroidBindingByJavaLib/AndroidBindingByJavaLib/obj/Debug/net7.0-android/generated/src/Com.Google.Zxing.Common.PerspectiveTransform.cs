using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']"
	[global::Android.Runtime.Register ("com/google/zxing/common/PerspectiveTransform", DoNotGenerateAcw=true)]
	public sealed partial class PerspectiveTransform : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/PerspectiveTransform", typeof (PerspectiveTransform));

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

		internal PerspectiveTransform (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='quadrilateralToQuadrilateral' and count(parameter)=16 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float'] and parameter[9][@type='float'] and parameter[10][@type='float'] and parameter[11][@type='float'] and parameter[12][@type='float'] and parameter[13][@type='float'] and parameter[14][@type='float'] and parameter[15][@type='float'] and parameter[16][@type='float']]"
		[Register ("quadrilateralToQuadrilateral", "(FFFFFFFFFFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;", "")]
		public static unsafe global::Com.Google.Zxing.Common.PerspectiveTransform? QuadrilateralToQuadrilateral (float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3, float x0p, float y0p, float x1p, float y1p, float x2p, float y2p, float x3p, float y3p)
		{
			const string __id = "quadrilateralToQuadrilateral.(FFFFFFFFFFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [16];
				__args [0] = new JniArgumentValue (x0);
				__args [1] = new JniArgumentValue (y0);
				__args [2] = new JniArgumentValue (x1);
				__args [3] = new JniArgumentValue (y1);
				__args [4] = new JniArgumentValue (x2);
				__args [5] = new JniArgumentValue (y2);
				__args [6] = new JniArgumentValue (x3);
				__args [7] = new JniArgumentValue (y3);
				__args [8] = new JniArgumentValue (x0p);
				__args [9] = new JniArgumentValue (y0p);
				__args [10] = new JniArgumentValue (x1p);
				__args [11] = new JniArgumentValue (y1p);
				__args [12] = new JniArgumentValue (x2p);
				__args [13] = new JniArgumentValue (y2p);
				__args [14] = new JniArgumentValue (x3p);
				__args [15] = new JniArgumentValue (y3p);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='quadrilateralToSquare' and count(parameter)=8 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
		[Register ("quadrilateralToSquare", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;", "")]
		public static unsafe global::Com.Google.Zxing.Common.PerspectiveTransform? QuadrilateralToSquare (float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3)
		{
			const string __id = "quadrilateralToSquare.(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (x0);
				__args [1] = new JniArgumentValue (y0);
				__args [2] = new JniArgumentValue (x1);
				__args [3] = new JniArgumentValue (y1);
				__args [4] = new JniArgumentValue (x2);
				__args [5] = new JniArgumentValue (y2);
				__args [6] = new JniArgumentValue (x3);
				__args [7] = new JniArgumentValue (y3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='squareToQuadrilateral' and count(parameter)=8 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float'] and parameter[5][@type='float'] and parameter[6][@type='float'] and parameter[7][@type='float'] and parameter[8][@type='float']]"
		[Register ("squareToQuadrilateral", "(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;", "")]
		public static unsafe global::Com.Google.Zxing.Common.PerspectiveTransform? SquareToQuadrilateral (float x0, float y0, float x1, float y1, float x2, float y2, float x3, float y3)
		{
			const string __id = "squareToQuadrilateral.(FFFFFFFF)Lcom/google/zxing/common/PerspectiveTransform;";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [8];
				__args [0] = new JniArgumentValue (x0);
				__args [1] = new JniArgumentValue (y0);
				__args [2] = new JniArgumentValue (x1);
				__args [3] = new JniArgumentValue (y1);
				__args [4] = new JniArgumentValue (x2);
				__args [5] = new JniArgumentValue (y2);
				__args [6] = new JniArgumentValue (x3);
				__args [7] = new JniArgumentValue (y3);
				var __rm = _members.StaticMethods.InvokeObjectMethod (__id, __args);
				return global::Java.Lang.Object.GetObject<global::Com.Google.Zxing.Common.PerspectiveTransform> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='transformPoints' and count(parameter)=1 and parameter[1][@type='float[]']]"
		[Register ("transformPoints", "([F)V", "")]
		public unsafe void TransformPoints (float[]? points)
		{
			const string __id = "transformPoints.([F)V";
			IntPtr native_points = JNIEnv.NewArray (points);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_points);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (points != null) {
					JNIEnv.CopyArray (native_points, points);
					JNIEnv.DeleteLocalRef (native_points);
				}
				global::System.GC.KeepAlive (points);
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common']/class[@name='PerspectiveTransform']/method[@name='transformPoints' and count(parameter)=2 and parameter[1][@type='float[]'] and parameter[2][@type='float[]']]"
		[Register ("transformPoints", "([F[F)V", "")]
		public unsafe void TransformPoints (float[]? xValues, float[]? yValues)
		{
			const string __id = "transformPoints.([F[F)V";
			IntPtr native_xValues = JNIEnv.NewArray (xValues);
			IntPtr native_yValues = JNIEnv.NewArray (yValues);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [2];
				__args [0] = new JniArgumentValue (native_xValues);
				__args [1] = new JniArgumentValue (native_yValues);
				_members.InstanceMethods.InvokeAbstractVoidMethod (__id, this, __args);
			} finally {
				if (xValues != null) {
					JNIEnv.CopyArray (native_xValues, xValues);
					JNIEnv.DeleteLocalRef (native_xValues);
				}
				if (yValues != null) {
					JNIEnv.CopyArray (native_yValues, yValues);
					JNIEnv.DeleteLocalRef (native_yValues);
				}
				global::System.GC.KeepAlive (xValues);
				global::System.GC.KeepAlive (yValues);
			}
		}

	}
}
