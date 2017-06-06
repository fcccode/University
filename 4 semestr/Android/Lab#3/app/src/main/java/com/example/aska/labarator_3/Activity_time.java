package com.example.aska.labarator_3;

import android.os.StrictMode;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class Activity_time extends AppCompatActivity {

    DateFormat ds;
    TextView txv2;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_time);
        txv2 = (TextView) findViewById(R.id.txv2);
        ds = new SimpleDateFormat("HH:mm:ss");

        Thread t = new Thread() {
            @Override
            public void run() {
                try{
                while(!isInterrupted()){
                    runOnUiThread(new Runnable() {
                        @Override
                        public void run() {
                            txv2.setText(ds.format(Calendar.getInstance().getTime()));
                        }
                    });
                    Thread.sleep(1000);

                }
            } catch (InterruptedException e){

                }
            }


        };
        t.start();
    }

}
