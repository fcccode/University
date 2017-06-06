package com.example.aska.labarator_2;

import android.graphics.Color;
import android.net.Uri;
import android.support.v7.app.AppCompatActivity;
import android.os.Bundle;
import android.view.ContextMenu;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.widget.Button;

import com.google.android.gms.appindexing.Action;
import com.google.android.gms.appindexing.AppIndex;
import com.google.android.gms.appindexing.Thing;
import com.google.android.gms.common.api.GoogleApiClient;

public class MainActivity extends AppCompatActivity {

    final int MENU_COLOR_RED = 1;
    final int MENU_COLOR_GREEN = 2;
    final int MENU_COLOR_BLUE = 3;
    final int MENU_COLOR_YELLOW = 4;

    Button btn1, btn2;


    @Override
    protected void onCreate(Bundle savedInstanceState) {
        super.onCreate(savedInstanceState);
        setContentView(R.layout.activity_main);

        btn2 = (Button) findViewById(R.id.btn2);
        registerForContextMenu(btn2);
    }

    @Override
    public boolean onCreateOptionsMenu(Menu menu) {
        getMenuInflater().inflate(R.menu.menu_main,menu);
        return true;
    }

    @Override
    public void onCreateContextMenu(ContextMenu menu, View v,
                                    ContextMenu.ContextMenuInfo menuInfo) {

        menu.add(0, MENU_COLOR_RED, 0, "Red");
        menu.add(0, MENU_COLOR_GREEN, 0, "Green");
        menu.add(0, MENU_COLOR_BLUE, 0, "Blue");
        menu.add(0, MENU_COLOR_BLUE, 0, "Yellow");

    }

    @Override
    public boolean onOptionsItemSelected(MenuItem item) {
        int id = item.getItemId();
        btn1 = (Button) findViewById(R.id.btn1);
        switch(id) {
            case R.id.hidding:
                btn1.setVisibility(View.INVISIBLE);
                return true;
            case R.id.nohidding:
                btn1.setVisibility(View.VISIBLE);
                return true;
            default:
            return super.onOptionsItemSelected(item);
        }
    }

    @Override
    public boolean onContextItemSelected(MenuItem item) {

        switch (item.getItemId()) {
            // пункты меню для tvColor
            case MENU_COLOR_RED:
                btn2.setTextColor(Color.RED);
                break;
            case MENU_COLOR_GREEN:
                btn2.setTextColor(Color.GREEN);
                break;
            case MENU_COLOR_BLUE:
                btn2.setTextColor(Color.BLUE);
                break;
            case MENU_COLOR_YELLOW:
                btn2.setTextColor(Color.YELLOW);
                break;
        }
        return super.onContextItemSelected(item);
    }


}
