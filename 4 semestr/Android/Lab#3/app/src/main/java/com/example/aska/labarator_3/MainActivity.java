package com.example.aska.labarator_3;

import android.content.Intent;
import android.icu.text.SimpleDateFormat;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.Menu;
import android.view.View;
import android.widget.Button;
import android.widget.TextView;

import java.sql.Date;

public class MainActivity extends AppCompatActivity implements View.OnClickListener {

    Button button, button2, button3;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);
        button = (Button) findViewById(R.id.button);
        button2 = (Button) findViewById(R.id.button2);
        button3 = (Button) findViewById(R.id.button3);

        button.setOnClickListener(this);
        button2.setOnClickListener(this);
        button3.setOnClickListener(this);

    }
    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main,menu);
        return true;
    }



    @Override
    public void onClick (View v) {
        switch (v.getId()){
            case R.id.button:
                Intent intent = new Intent(this, Activity_data.class);
                startActivity(intent);
                break;
            case R.id.button2:
                Intent intent2 = new Intent(this, Activity_time.class);
                startActivity(intent2);
                break;
            case R.id.button3:
                finish();
                break;
            default:break;
        }
    }

}
