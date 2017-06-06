package com.example.aska.labarator_4;

import android.content.Intent;
import android.content.SharedPreferences;
import android.content.SharedPreferences.Editor;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.View;
import android.widget.Button;
import android.widget.EditText;
import android.widget.Toast;

public class Activity_data extends AppCompatActivity {

    Button button3;
    EditText editText;
    SharedPreferences sh;
    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_data);
        button3 = (Button) findViewById(R.id.button3);
        editText = (EditText) findViewById(R.id.editText);

        button3.setOnClickListener(new View.OnClickListener() {
            @Override
            public void onClick(View v) {
                if (!editText.getText().toString().equals("")){
                    Editor ed = getSharedPreferences("pref", MODE_PRIVATE).edit();
                    ed.putString("abcdefgh", editText.getText().toString());
                    ed.apply();
                    startActivity(new Intent(getApplicationContext(), MainActivity.class));
                    finish();
                } else{
                    Toast.makeText(Activity_data.this, "TextEditor is Empty", Toast.LENGTH_SHORT).show();
                }
            }
        });
    }
}
