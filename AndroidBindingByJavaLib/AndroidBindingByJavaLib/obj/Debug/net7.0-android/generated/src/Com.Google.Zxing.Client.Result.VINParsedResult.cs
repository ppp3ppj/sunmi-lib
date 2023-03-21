using System;
using System.Collections.Generic;
using Android.Runtime;
using Java.Interop;

namespace Com.Google.Zxing.Client.Result {

	// Metadata.xml XPath class reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']"
	[global::Android.Runtime.Register ("com/google/zxing/client/result/VINParsedResult", DoNotGenerateAcw=true)]
	public sealed partial class VINParsedResult : global::Com.Google.Zxing.Client.Result.ParsedResult {
		static readonly JniPeerMembers _members = new XAPeerMembers ("com/google/zxing/client/result/VINParsedResult", typeof (VINParsedResult));

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

		internal VINParsedResult (IntPtr javaReference, JniHandleOwnership transfer) : base (javaReference, transfer)
		{
		}

		// Metadata.xml XPath constructor reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/constructor[@name='VINParsedResult' and count(parameter)=9 and parameter[1][@type='java.lang.String'] and parameter[2][@type='java.lang.String'] and parameter[3][@type='java.lang.String'] and parameter[4][@type='java.lang.String'] and parameter[5][@type='java.lang.String'] and parameter[6][@type='java.lang.String'] and parameter[7][@type='int'] and parameter[8][@type='char'] and parameter[9][@type='java.lang.String']]"
		[Register (".ctor", "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V", "")]
		public unsafe VINParsedResult (string? vin, string? worldManufacturerID, string? vehicleDescriptorSection, string? vehicleIdentifierSection, string? countryCode, string? vehicleAttributes, int modelYear, char plantCode, string? sequentialNumber) : base (IntPtr.Zero, JniHandleOwnership.DoNotTransfer)
		{
			const string __id = "(Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;Ljava/lang/String;ICLjava/lang/String;)V";

			if (((global::Java.Lang.Object) this).Handle != IntPtr.Zero)
				return;

			IntPtr native_vin = JNIEnv.NewString ((string?)vin);
			IntPtr native_worldManufacturerID = JNIEnv.NewString ((string?)worldManufacturerID);
			IntPtr native_vehicleDescriptorSection = JNIEnv.NewString ((string?)vehicleDescriptorSection);
			IntPtr native_vehicleIdentifierSection = JNIEnv.NewString ((string?)vehicleIdentifierSection);
			IntPtr native_countryCode = JNIEnv.NewString ((string?)countryCode);
			IntPtr native_vehicleAttributes = JNIEnv.NewString ((string?)vehicleAttributes);
			IntPtr native_sequentialNumber = JNIEnv.NewString ((string?)sequentialNumber);
			try {
				JniArgumentValue* __args = stackalloc JniArgumentValue [9];
				__args [0] = new JniArgumentValue (native_vin);
				__args [1] = new JniArgumentValue (native_worldManufacturerID);
				__args [2] = new JniArgumentValue (native_vehicleDescriptorSection);
				__args [3] = new JniArgumentValue (native_vehicleIdentifierSection);
				__args [4] = new JniArgumentValue (native_countryCode);
				__args [5] = new JniArgumentValue (native_vehicleAttributes);
				__args [6] = new JniArgumentValue (modelYear);
				__args [7] = new JniArgumentValue (plantCode);
				__args [8] = new JniArgumentValue (native_sequentialNumber);
				var __r = _members.InstanceMethods.StartCreateInstance (__id, ((object) this).GetType (), __args);
				SetHandle (__r.Handle, JniHandleOwnership.TransferLocalRef);
				_members.InstanceMethods.FinishCreateInstance (__id, this, __args);
			} finally {
				JNIEnv.DeleteLocalRef (native_vin);
				JNIEnv.DeleteLocalRef (native_worldManufacturerID);
				JNIEnv.DeleteLocalRef (native_vehicleDescriptorSection);
				JNIEnv.DeleteLocalRef (native_vehicleIdentifierSection);
				JNIEnv.DeleteLocalRef (native_countryCode);
				JNIEnv.DeleteLocalRef (native_vehicleAttributes);
				JNIEnv.DeleteLocalRef (native_sequentialNumber);
			}
		}

		public unsafe string? CountryCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getCountryCode' and count(parameter)=0]"
			[Register ("getCountryCode", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getCountryCode.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public override unsafe string? DisplayResult {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getDisplayResult' and count(parameter)=0]"
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

		public unsafe int ModelYear {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getModelYear' and count(parameter)=0]"
			[Register ("getModelYear", "()I", "")]
			get {
				const string __id = "getModelYear.()I";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractInt32Method (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe char PlantCode {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getPlantCode' and count(parameter)=0]"
			[Register ("getPlantCode", "()C", "")]
			get {
				const string __id = "getPlantCode.()C";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractCharMethod (__id, this, null);
					return __rm;
				} finally {
				}
			}
		}

		public unsafe string? SequentialNumber {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getSequentialNumber' and count(parameter)=0]"
			[Register ("getSequentialNumber", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getSequentialNumber.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? VIN {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVIN' and count(parameter)=0]"
			[Register ("getVIN", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVIN.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? VehicleAttributes {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleAttributes' and count(parameter)=0]"
			[Register ("getVehicleAttributes", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVehicleAttributes.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? VehicleDescriptorSection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleDescriptorSection' and count(parameter)=0]"
			[Register ("getVehicleDescriptorSection", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVehicleDescriptorSection.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? VehicleIdentifierSection {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getVehicleIdentifierSection' and count(parameter)=0]"
			[Register ("getVehicleIdentifierSection", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getVehicleIdentifierSection.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

		public unsafe string? WorldManufacturerID {
			// Metadata.xml XPath method reference: path="/api/package[@name='com.google.zxing.client.result']/class[@name='VINParsedResult']/method[@name='getWorldManufacturerID' and count(parameter)=0]"
			[Register ("getWorldManufacturerID", "()Ljava/lang/String;", "")]
			get {
				const string __id = "getWorldManufacturerID.()Ljava/lang/String;";
				try {
					var __rm = _members.InstanceMethods.InvokeAbstractObjectMethod (__id, this, null);
					return JNIEnv.GetString (__rm.Handle, JniHandleOwnership.TransferLocalRef);
				} finally {
				}
			}
		}

	}
}
