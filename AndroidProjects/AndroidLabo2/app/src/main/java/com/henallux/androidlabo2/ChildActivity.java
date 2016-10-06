package com.henallux.androidlabo2;

import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

/**
 * Created by yves on 05-10-16.
 */

public class ChildActivity extends AppCompatActivity {

    private int result;
    private Button button;

    @Override
    protected void onCreate(Bundle savedInstance){
        super.onCreate(savedInstance);
        setContentView(R.layout.activity_child);
        Bundle bundle = this.getIntent().getExtras();
        final String parentMes = bundle.getString("infoId");
        Toast.makeText(ChildActivity.this,parentMes, Toast.LENGTH_LONG).show();

        button= (Button) findViewById(R.id.buttonChild);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View arg0){
                setResult(1);
                finish();
            }
        });
    }
}
