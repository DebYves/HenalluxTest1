package com.henallux.androidlabo3;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;

/**
 * Created by yves on 19/10/2016.
 */

public class ChildActivity extends AppCompatActivity {

    @Override
    protected void onCreate(Bundle savedInstance) {
        super.onCreate(savedInstance);
        setContentView(R.layout.activity_child);
    }
}
