using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Common.Detector {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']"
	[global::Android.Runtime.Register ("com/google/zxing/common/detector/MathUtils", DoNotGenerateAcw=true)]
	public sealed partial class MathUtils : global::Java.Lang.Object {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/common/detector/MathUtils", typeof (MathUtils));

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

		internal MathUtils (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='distance' and count(parameter)=4 and parameter[1][@type='float'] and parameter[2][@type='float'] and parameter[3][@type='float'] and parameter[4][@type='float']]"
		[Register ("distance", "(FFFF)F", "")]
		public static unsafe float Distance (float aX, float aY, float bX, float bY)
		{
			const string __id = "distance.(FFFF)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (aX);
				__args [1] = new JniArgumentValue (aY);
				__args [2] = new JniArgumentValue (bX);
				__args [3] = new JniArgumentValue (bY);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='distance' and count(parameter)=4 and parameter[1][@type='int'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
		[Register ("distance", "(IIII)F", "")]
		public static unsafe float Distance (int aX, int aY, int bX, int bY)
		{
			const string __id = "distance.(IIII)F";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [4];
				__args [0] = new JniArgumentValue (aX);
				__args [1] = new JniArgumentValue (aY);
				__args [2] = new JniArgumentValue (bX);
				__args [3] = new JniArgumentValue (bY);
				var __rm = _members.StaticMethods.InvokeSingleMethod (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='round' and count(parameter)=1 and parameter[1][@type='float']]"
		[Register ("round", "(F)I", "")]
		public static unsafe int Round (float d)
		{
			const string __id = "round.(F)I";
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (d);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.common.detector']/class[@name='MathUtils']/method[@name='sum' and count(parameter)=1 and parameter[1][@type='int[]']]"
		[Register ("sum", "([I)I", "")]
		public static unsafe int Sum (int[]? array)
		{
			const string __id = "sum.([I)I";
			IntPtr native_array = JNIEnv.NewArray (array);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [1];
				__args [0] = new JniArgumentValue (native_array);
				var __rm = _members.StaticMethods.InvokeInt32Method (__id, __args);
				return __rm;
			} finally {
				if (array != null) {
					JNIEnv.CopyArray (native_array, array);
					JNIEnv.DeleteLocalRef (native_array);
				}
				global::System.GC.KeepAlive (array);
			}
		}

	}
}
