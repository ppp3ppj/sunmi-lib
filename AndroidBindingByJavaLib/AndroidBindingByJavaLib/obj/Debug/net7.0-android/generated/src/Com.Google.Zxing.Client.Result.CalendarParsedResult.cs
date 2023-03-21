using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/CalendarParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class CalendarParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/CalendarParsedResult", typeof (CalendarParsedResult));

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

		internal CalendarParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/constructor[@name='CalendarParsedResult' and count(parameter)=10 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='java.lang.String[]'] and parameter[8][@type='java.lang.String'] and parameter[9][@type='double'] and parameter[10][@type='double']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V", "")]
		public unsafe CalendarParsedResult (string? summary, string? startString, string? endString, string? durationString, string? location, string? organizer, string[]? attendees, string? description, double latitude, double longitude) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;[Ljava/lang/String;Ljava/lang/String;DD)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_summary = JNIEnv.NewString ((string?)summary);
			IntPtr native_startString = JNIEnv.NewString ((string?)startString);
			IntPtr native_endString = JNIEnv.NewString ((string?)endString);
			IntPtr native_durationString = JNIEnv.NewString ((string?)durationString);
			IntPtr native_location = JNIEnv.NewString ((string?)location);
			IntPtr native_organizer = JNIEnv.NewString ((string?)organizer);
			IntPtr native_attendees = JNIEnv.NewArray (attendees);
			IntPtr native_description = JNIEnv.NewString ((string?)description);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [10];
				__args [0] = new JniArgumentValue (native_summary);
				__args [1] = new JniArgumentValue (native_startString);
				__args [2] = new JniArgumentValue (native_endString);
				__args [3] = new JniArgumentValue (native_durationString);
				__args [4] = new JniArgumentValue (native_location);
				__args [5] = new JniArgumentValue (native_organizer);
				__args [6] = new JniArgumentValue (native_attendees);
				__args [7] = new JniArgumentValue (native_description);
				__args [8] = new JniArgumentValue (latitude);
				__args [9] = new JniArgumentValue (longitude);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_summary);
				JNIEnv.DeleteLocalRef (native_startString);
				JNIEnv.DeleteLocalRef (native_endString);
				JNIEnv.DeleteLocalRef (native_durationString);
				JNIEnv.DeleteLocalRef (native_location);
				JNIEnv.DeleteLocalRef (native_organizer);
				if (attendees != null) {
					JNIEnv.CopyArray (native_attendees, attendees);
					JNIEnv.DeleteLocalRef (native_attendees);
				}
				JNIEnv.DeleteLocalRef (native_description);
				global::System.GC.KeepAlive (attendees);
			}
		}

		public unsafe string? Description {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getDescription' and count(parameter)=0]"
			[Register ("getDescription", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDescription.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
			[Register ("getDisplayResult", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getDisplayResult.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Date? End {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getEnd' and count(parameter)=0]"
			[Register ("getEnd", "()Ljava/util/Date;", "")]
			get {
				const string __id = "getEnd.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe bool IsEndAllDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='isEndAllDay' and count(parameter)=0]"
			[Register ("isEndAllDay", "()Z", "")]
			get {
				const string __id = "isEndAllDay.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe bool IsStartAllDay {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='isStartAllDay' and count(parameter)=0]"
			[Register ("isStartAllDay", "()Z", "")]
			get {
				const string __id = "isStartAllDay.()Z";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractBooleanMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe double Latitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLatitude' and count(parameter)=0]"
			[Register ("getLatitude", "()D", "")]
			get {
				const string __id = "getLatitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string? Location {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLocation' and count(parameter)=0]"
			[Register ("getLocation", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getLocation.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe double Longitude {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getLongitude' and count(parameter)=0]"
			[Register ("getLongitude", "()D", "")]
			get {
				const string __id = "getLongitude.()D";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractDoubleMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string? Organizer {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getOrganizer' and count(parameter)=0]"
			[Register ("getOrganizer", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getOrganizer.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe global::Java.Util.Date? Start {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getStart' and count(parameter)=0]"
			[Register ("getStart", "()Ljava/util/Date;", "")]
			get {
				const string __id = "getStart.()Ljava/util/Date;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return global::Java.Lang.Object.GetObject<global::Java.Util.Date> (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? Summary {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getSummary' and count(parameter)=0]"
			[Register ("getSummary", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSummary.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='CalendarParsedResult']/method[@name='getAttendees' and count(parameter)=0]"
		[Register ("getAttendees", "()[Ljava/lang/String;", "")]
		public unsafe string[]? GetAttendees ()
		{
			const string __id = "getAttendees.()[Ljava/lang/String;";
			try {
				var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
				return (string[]?) JNIEnv.GetArray (__rm.Handle, JniHandleOwnership.TransferLocalRef, typeof (string));
			} finally {
			}
		}

	}
}
