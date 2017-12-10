package rpanel.a2_lab.com.lab2;

import android.graphics.Color;
import android.os.Bundle;
import android.support.v7.app.AppCompatActivity;
import android.support.v7.widget.Toolbar;
import android.view.ContextMenu;
import android.view.ContextMenu.ContextMenuInfo;
import android.view.Menu;
import android.view.MenuItem;
import android.view.View;
import android.view.View.OnClickListener;
import android.view.View.OnLongClickListener;
import android.widget.Button;

public class MainActivity extends AppCompatActivity {

  Button btn1;
  Button btn2;
  Toolbar toolbar;

  @Override
  protected void onCreate(Bundle savedInstanceState) {
    super.onCreate(savedInstanceState);
    setContentView(R.layout.activity_main);
    btn1 = (Button) findViewById(R.id.button1);
    btn2 = (Button) findViewById(R.id.button2);
    toolbar = (Toolbar) findViewById(R.id.toolbar);
    setSupportActionBar(toolbar);
    registerForContextMenu(findViewById(R.id.button1));

    btn1.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {
        MainActivity.this.openOptionsMenu();
      }
    });

    btn2.setOnClickListener(new OnClickListener() {
      @Override
      public void onClick(View view) {

      }
    });

    btn1.setOnLongClickListener(new OnLongClickListener() {
      @Override
      public boolean onLongClick(View view) {
        view.showContextMenu();
        return false;
      }
    });

  }

  @Override
  public boolean onCreateOptionsMenu(Menu menu) {
    super.onCreateOptionsMenu(menu);
    getMenuInflater().inflate(R.menu.menu, menu);
    return true;
  }

  @Override
  public boolean onContextItemSelected(MenuItem item) {
    switch (item.getItemId()) {
      case 1:
        btn1.setBackgroundColor(Color.RED);
        break;
      case 2:
        btn1.setBackgroundColor(Color.GREEN);
        break;
      case 3:
        btn1.setBackgroundColor(Color.BLUE);
        break;
      case 4:
        btn1.setBackgroundColor(Color.YELLOW);
        break;
    }
    return super.onContextItemSelected(item);
  }

  @Override
  public void onCreateContextMenu(ContextMenu menu, View v, ContextMenuInfo menuInfo) {
    switch (v.getId()) {
      case R.id.button1:
        menu.add(0, 1, 0, "Red");
        menu.add(0, 2, 0, "Green");
        menu.add(0, 3, 0, "Blue");
        menu.add(0, 4, 0, "Yellow");
    }
    super.onCreateContextMenu(menu, v, menuInfo);
  }

  @Override
  public boolean onOptionsItemSelected(MenuItem item) {
    int id = item.getItemId();
    switch (id) {
      case R.id.action_en:
        btn2.setVisibility(View.VISIBLE);
        return true;
      case R.id.action_ds:
        btn2.setVisibility(View.INVISIBLE);
        return true;
      default:
        return super.onOptionsItemSelected(item);
    }
  }

//  @Override
//  public void openOptionsMenu() {
//    Configuration config = getResources().getConfiguration();
//    if((config.screenLayout & Configuration.SCREENLAYOUT_SIZE_MASK)
//        > Configuration.SCREENLAYOUT_SIZE_LARGE) {
//
//      int originalScreenLayout = config.screenLayout;
//      config.screenLayout = Configuration.SCREENLAYOUT_SIZE_LARGE;
//      super.openOptionsMenu();
//      config.screenLayout = originalScreenLayout;
//
//    } else {
//      super.openOptionsMenu();
//    }
//  }

}
