package com.ppp.sunmit2vicescreen;

import android.content.Context;

import com.ppp.sunmit2vicescreen.utils.ScreenManager;
import com.ppp.sunmit2vicescreen.utils.UPacketFactory;

import org.json.JSONArray;
import org.json.JSONException;
import org.json.JSONObject;

import sunmi.ds.DSKernel;
import sunmi.ds.callback.IConnectionCallback;
import sunmi.ds.callback.IReceiveCallback;
import sunmi.ds.callback.ISendCallback;
import sunmi.ds.data.DSData;
import sunmi.ds.data.DSFile;
import sunmi.ds.data.DSFiles;
import sunmi.ds.data.DataPacket;

public class ViceScreenUtils {
    public DSKernel mDSKernel;
    public static String msgConnect = null;

    public static ViceScreenUtils viceStatus = new ViceScreenUtils();
    private ViceScreenUtils() { }

    public static ViceScreenUtils getInstance() {
        return viceStatus;
    }

    private IConnectionCallback mIConnectionCallback = new IConnectionCallback() {
        @Override
        public void onDisConnect() {
            msgConnect = "Disconnect";
        }

        @Override
        public void onConnected(ConnState state) {
            switch (state) {
                case AIDL_CONN:
                    msgConnect = "AIDL";
                    break;
                case VICE_SERVICE_CONN:
                    msgConnect = "VICE_SERVICE";
                    break;
                case VICE_APP_CONN:
                    msgConnect = "VICE_APP";
                    break;
                default:
                    msgConnect = "UNKNOWN";
                    break;
            }
        }
    };

    private IReceiveCallback mIReceiveCallback = new IReceiveCallback() {
        @Override
        public void onReceiveData(DSData data) {

        }

        @Override
        public void onReceiveFile(DSFile file) {

        }

        @Override
        public void onReceiveFiles(DSFiles files) {

        }

        @Override
        public void onReceiveCMD(DSData cmd) {

        }
    };

    public void initSdk(Context context, DSKernel dataDS) {
        mDSKernel = dataDS;
        //mDSKernel = DSKernel.newInstance();
        mDSKernel.init(context, mIConnectionCallback);
        mDSKernel.addReceiveCallback(mIReceiveCallback);
        // mDSKernel.addReceiveCallback(mIReceiveCallback2);
        mDSKernel.removeReceiveCallback(mIReceiveCallback);
        // mDSKernel.removeReceiveCallback(mIReceiveCallback2);
    }

    public void simpleShowText() {
        try {
            JSONObject json = new JSONObject();
            json.put("title", "title");    //title is the content of the line above
            json.put("content", "content");    //content is the content of the following line
            String jsonStr = json.toString();    //Build the DataPacket class
            DataPacket packet = UPacketFactory.buildShowText(DSKernel.getDSDPackageName(), jsonStr, new ISendCallback() {
                @Override
                public void onSendSuccess(long taskId) {

                }

                @Override
                public void onSendFail(int errorId, String errorInfo) {

                }

                @Override
                public void onSendProcess(long totle, long sended) {

                }
            });

            mDSKernel.sendData(packet);    //Call SendData to send text
        } catch (JSONException e) {
            e.printStackTrace();
        }
    }

}
