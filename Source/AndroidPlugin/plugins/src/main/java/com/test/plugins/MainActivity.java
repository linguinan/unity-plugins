package com.test.plugins;

import android.content.Context;
import android.os.Bundle;
import android.util.Log;

import com.unity3d.player.UnityPlayerActivity;

/**
 * Created by Administrator on 2018/5/23.
 */

public class MainActivity extends UnityPlayerActivity {

    public static String unityGameObjectName = "PluginListener";
    public static final String TAG = "Unity_Android";

    Context mContext = null;

    @Override
    protected void onCreate(Bundle bundle) {
        super.onCreate(bundle);
        Log.i(TAG, "onCreate");

        mContext = this;
    }

    public void Hello()
    {
        Log.i(TAG, "Hello from android!");
    }

    //TODO
    //实现把不同功能接口在不同类中处理，并可被unity直接调用
    //测试各种接口调用耗时



}
