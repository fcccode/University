package com.example.aska.labarator_3;


import android.os.Build;
import android.support.annotation.RequiresApi;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.widget.TextView;

import java.text.DateFormat;
import java.text.SimpleDateFormat;
import java.util.Calendar;

public class Activity_data extends AppCompatActivity {

    TextView txv1;
    DateFormat df;
    @RequiresApi(api = Build.VERSION_CODES.N)
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_data);

        txv1 = (TextView) findViewById(R.id.txv1);

        df = new SimpleDateFormat("dd.MM.yyyy");
        txv1.setText(df.format(Calendar.getInstance().getTime()));
    }
}
