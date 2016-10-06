package com.henallux.androidlabo2;

import android.content.Intent;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.Toast;

public class MainActivity extends AppCompatActivity {

    private Intent intent;
    private Button button;

    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        intent = new Intent(MainActivity.this,ChildActivity.class);
        intent.putExtra("infoId","Yolooooooooooooooo");
        button= (Button) findViewById(R.id.button);
        button.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                //startActivity(intent);
                startActivityForResult(intent,1);
            }
        });
    }


    public void onActivityResult(int req,int res,Intent intent){
        super.onActivityResult(req,res,intent);
        if(req==1){
            switch(res){
                case 0 :
                    Toast.makeText(MainActivity.this,"Result code = 0", Toast.LENGTH_LONG).show();
                    break;
                case 1 :
                    Toast.makeText(MainActivity.this,"Result code = 1", Toast.LENGTH_LONG).show();
                    break;

            }
        }
    }

}
